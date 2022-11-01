﻿#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.7.1 Revision 5
// last Edit: 11/1/22 V2.0
#endregion

using HardwareInformation;
using Newtonsoft.Json.Linq;
using SteamAPI;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse
{
    public partial class Main : Form
    {
        //----------------------Variables----------------------//
        private bool DataLoaded = false;
        //string FormulaCaption = "";
        private readonly string AppHash = Hasher("SteamPulse");
        public static string SearchID;
        private bool isowned = false;
        private bool giveawayisactive = false;
        private long GiveawayBegin, GiveawayEnd;
        private DateTime GiveawayBeginTime;
        private string EditionName;
        public static double EditionPrice;
        private double price;
        public static int EditionDiscount;
        public static bool SettingisUpdated = false;
        public static bool DarkMode;
        private bool IsLoading = true;
        public static bool noGiveAwayLimit = false;

        //----------------------Moving Form----------------------//
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        //----------------------Loading Region From Settings----------------------//
        public void LoadRegion()
        {
            if (Settings.Currency.Name == "Real")
            {
                DropDownRegion.SelectedIndex = 7;
            }
            else if (Settings.Currency.Name == "Ruble")
            {
                DropDownRegion.SelectedIndex = 6;
            }
            else if (Settings.Currency.Name == "Yuan")
            {
                DropDownRegion.SelectedIndex = 3;
            }
            else if (Settings.Currency.Name == "Euro")
            {
                DropDownRegion.SelectedIndex = 2;
            }
            else if (Settings.Currency.Name == "Pound")
            {
                DropDownRegion.SelectedIndex = 1;
            }
            else if (Settings.Currency.Name == "USD")
            {
                DropDownRegion.SelectedIndex = 0;
            }
            else if (Settings.Currency.Name == "Lira")
            {
                DropDownRegion.SelectedIndex = 5;
            }
            else if (Settings.Currency.Name == "ARS")
            {
                DropDownRegion.SelectedIndex = 4;
            }
            else { }

        }

        //----------------------Run on Form Load----------------------//
        private void Main_Load(object sender, EventArgs e)
        {
            bool MaintenanceMode = Maintenance.MaintenanceMode;
            if (MaintenanceMode == true)
            {
                Label_AppName.Text = "SteamPulse - Maintenance Mode";
            }
            else
            {
                Label_AppName.Text = "SteamPulse";
            }

            PanelStatus.Location = new Point(0, 0);
            PanelStatus.Size = new Size(568, 468);
            TextBox_URL.SelectAll();
            MainUpdateChecker();
            LoadRegion();
            DarkMode = Settings.DarkMode;


            PanelGiveaway.Visible = giveawayisactive;
            Timer.Enabled = giveawayisactive;
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(GiveawayBegin);
            GiveawayBeginTime = dateTimeOffset.DateTime;
            if (giveawayisactive)
            {
                this.Size = new Size(878, 690);

            }
            else
            {
                this.Size = new Size(878, 552);
            }

            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            if (Settings.DeveloperMode == true)
            {
                this.ContextMenuStrip = MenuDev;
                NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            }
            else { }

            IsLoading = false;

        }
        //----------------------Moving Form----------------------//
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //----------------------Exit Button----------------------//
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            if (BackgroundWorker.IsBusy)
            {
                BackgroundWorker.CancelAsync();
            }

            this.Close();
        }
        //----------------------Send Text to Method----------------------//
        private void TextBox_URL_TextChanged(object sender, EventArgs e)
        {
            TextBox_URL.Text = URLtoAppID(TextBox_URL.Text);
            TextBox_URL.ForeColor = Color.Black;
        }
        //----------------------Editions of Product----------------------//
        private void ComboBox_Editions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelStatus.Visible = true;
            LabelStatus.Text = "Loading Edition...";
            if (!ComboBox_Editions.Text.Contains("Not Available") && !ComboBox_Editions.Text.Contains("Free"))
            {
                ComboBox_Editions.Focus();
                if (!ComboBox_Editions.Text.Contains("Free"))
                {

                    EditionPrice = 0;
                    GetData.PackageID = LoadData.Store.Packages.GetPackageIDbyIndex(ComboBox_Editions.SelectedIndex);
                    GetData.ConnectToSteam.Package();

                    if (ComboBox_Editions.SelectedIndex != 0)
                    {
                        try
                        {
                            PictureBox_Image.Load(LoadData.Store.Packages.HeaderImage);
                        }
                        catch
                        {
                            PictureBox_Image.Load(LoadData.Store.HeaderImage);
                        }
                    }
                    else
                    {
                        PictureBox_Image.Load(LoadData.Store.HeaderImage);
                    }

                    EditionPrice = LoadData.Store.Packages.Price.Final;
                    EditionName = LoadData.Store.Packages.TrimmedName;
                }
                else { }

                EditionDiscount = LoadData.Store.Packages.Price.Discount_Percent;
                if (EditionPrice == 0)
                {
                    if (LoadData.Store.IsFree == true)
                    {
                        Label_Price.Text = "Price: Free";
                        Label_KeyCount.Text = "Item Count: 0";
                    }
                    else
                    {
                        if (LoadData.Store.Price.AvailabletoPurchase != true)
                        {
                            Label_Price.Text = "Price: Not Available to Purchase";
                            Label_KeyCount.Text = "Item Count: 0";
                        }
                        else { }
                    }
                }
                else
                {
                    if (EditionDiscount == 0)
                    {
                        Label_Price.Text = string.Format("Price: {0} {1}", EditionPrice.ToString("N"), Settings.Currency.Unit);
                    }
                    else
                    {
                        if (ComboBox_Editions.SelectedIndex == 0)
                        {
                            Label_Price.Text = "Price: " + string.Format("{0} {1} - {2}%", EditionPrice.ToString("N"), Settings.Currency.Unit, LoadData.Store.Price.Discount_Percent.ToString());
                        }
                        else
                        {
                            Label_Price.Text = "Price: " + string.Format("{0} {1} - {2}%", EditionPrice.ToString("N"), Settings.Currency.Unit, EditionDiscount.ToString());
                        }
                    }
                    GetData.ConnectToSteam.Market.TF2Ticket();
                    if (EditionPrice < LoadData.Market.Ticket.LowestSellOrderNoFee && Settings.ItemCalculationMode != "Key Only")
                    {
                        double Ticket_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Ticket.LowestSellOrderNoFee;
                        double Ticket_rounded = (int)Math.Ceiling(Math.Round(Ticket_count, 1));
                        double Remaining = (Ticket_rounded * LoadData.Market.Ticket.LowestSellOrderNoFee) - EditionPrice;
                        /*if (Settings.DeveloperMode == true)
                        {
                            if (Settings.KeyCalcMode == "Rounded to Up") { }
                            else
                            {
                                Ticket_rounded = Math.Round(Ticket_count, 2);
                            }
                        }
                        else { }*/

                        if (Convert.ToBoolean(Settings.CheckIRT) == true)
                        {
                            GetData.GamingClub.Ticket();
                            if (LoadData.GamingClub.Ticket.Price != 0)
                            {
                                if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Text = string.Format("Ticket Count: {0} - {1} IRT ~ {2} {3}", Ticket_rounded.ToString(), string.Format("{0:n0} ", (int)Math.Ceiling(Ticket_count) * LoadData.GamingClub.Ticket.Price), (int)Remaining, Settings.Currency.Unit);
                                }
                                else
                                {
                                    Label_KeyCount.Text = string.Format("Ticket Count: {0} - {1} IRT ", Ticket_rounded.ToString(), string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(Ticket_count, 1)) * LoadData.GamingClub.Ticket.Price));
                                }
                            }
                            else
                            {
                                if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Text = string.Format("Ticket Count: {0} ~ {1} {2}", Ticket_rounded, (int)Remaining, Settings.Currency.Unit);
                                }
                                else
                                {
                                    Label_KeyCount.Text = "Ticket Count: " + Ticket_rounded;
                                }
                            }
                        }
                        else
                        {
                            if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                            {
                                Label_KeyCount.Text = string.Format("Ticket Count: {0} ~ {1} {2}", Ticket_rounded, (int)Remaining, Settings.Currency.Unit);
                            }
                            else
                            {
                                Label_KeyCount.Text = "Ticket Count: " + Ticket_rounded;
                            }
                        }
                    }
                    else
                    {
                        GetData.ConnectToSteam.Market.TF2Key();
                        double key_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Key.LowestSellOrderNoFee;
                        double KeyRoundedUp = (int)Math.Ceiling(key_count);
                        double Remaining = (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee) - EditionPrice;
                        int KeyRoundedDown = (int)Math.Floor(key_count);
                        double DownRemaining = EditionPrice - (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee);
                        double Remaining2 = ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee) - EditionPrice;


                        if (Settings.DeveloperMode == true)
                        {
                            if (Settings.KeyCalcMode != "Rounded to Up" && Settings.ItemCalculationMode != "Smart")
                            {
                                KeyRoundedUp = Math.Round(key_count, 2);
                            }
                        }
                        else { }
                        if (Convert.ToBoolean(Settings.CheckIRT) == true)
                        {
                            GetData.GamingClub.Key();
                            if (LoadData.GamingClub.Key.Price != 0)
                            {
                                if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                                {
                                    if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.GamingClub.Ticket.Stock !=0)
                                        {
                                            Label_KeyCount.Text = string.Format("Item Count: {0} Key + 1 Ticket - {1} IRT ~ {2} {3} ", KeyRoundedDown, string.Format("{0:n0} ", (KeyRoundedDown * LoadData.GamingClub.Key.Price) + LoadData.GamingClub.Ticket.Price), (int)Remaining2, Settings.Currency.Unit);
                                            //FormulaCaption = string.Format("Key = {0} - {1}IRT | Ticket = {2} - {3}IRT => {4} Key({5}) + 1 Ticket({6}) = {7} {10} - {8} IRT ~ Remains {9} {10}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.GamingClub.Key.Price), LoadData.Market.Ticket.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.GamingClub.Ticket.Price), KeyRoundedDown, (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee), LoadData.Market.Ticket.LowestSellOrderNoFee, ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee), String.Format("{0:n0}", ((KeyRoundedDown * LoadData.GamingClub.Key.Price) + LoadData.GamingClub.Ticket.Price)), (int)Remaining2, Settings.Currency.Unit);
                                        }
                                        else
                                        {
                                            Label_KeyCount.Text = string.Format("Key Count: {0} - {1} IRT ~ {2} {3}", KeyRoundedUp, string.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.GamingClub.Key.Price), (int)Remaining, Settings.Currency.Unit);
                                            //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.GamingClub.Key.Price), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee), String.Format("{0:n0}", (KeyRoundedUp * LoadData.GamingClub.Key.Price)), (int)Remaining, Settings.Currency.Unit);
                                        }

                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = string.Format("Key Count: {0} - {1} IRT ~ {2} {3}", KeyRoundedUp, string.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.GamingClub.Key.Price), (int)Remaining, Settings.Currency.Unit);
                                        //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.GamingClub.Key.Price), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee), String.Format("{0:n0}", (KeyRoundedUp * LoadData.GamingClub.Key.Price)), (int)Remaining, Settings.Currency.Unit);
                                    }
                                }
                                else
                                {
                                    if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.GamingClub.Ticket.Stock != 0)
                                        {
                                            Label_KeyCount.Text = string.Format("Item Count: {0} Key + 1 Ticket - {1} IRT", KeyRoundedDown, string.Format("{0:n0} ", (KeyRoundedDown * LoadData.GamingClub.Key.Price) + LoadData.GamingClub.Ticket.Price));
                                        }
                                        else
                                        {
                                            Label_KeyCount.Text = string.Format("Key Count: {0} - {1} IRT", KeyRoundedUp, string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.GamingClub.Key.Price));
                                        }
                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = string.Format("Key Count: {0} - {1} IRT", KeyRoundedUp, string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.GamingClub.Key.Price));
                                    }
                                    //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.GamingClub.Key.Price), KeyRoundedUp, KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee, KeyRoundedUp * LoadData.GamingClub.Key.Price);
                                }

                            }
                            else
                            {
                                if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                                {
                                    if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.GamingClub.Ticket.Stock != 0)
                                    {
                                        Label_KeyCount.Text = string.Format("Item Count: {0} Key + 1 Ticket ~ {1} {2} ", KeyRoundedDown, (int)Remaining2, Settings.Currency.Unit);
                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = string.Format("Key Count: {0} - {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
                                    }
                                }
                                else
                                {
                                    Label_KeyCount.Text = "Key Count: " + KeyRoundedUp;
                                }
                            }
                        }
                        else
                        {
                            if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                            {
                                Label_KeyCount.Text = string.Format("Key Count: {0} - {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
                            }
                            else
                            {
                                Label_KeyCount.Text = "Key Count: " + KeyRoundedUp;
                            }
                        }
                    }
                }
            }
            else
            {
                if (LoadData.Store.IsFree == true)
                {
                    Label_Price.Text = "Price: Free";
                    Label_KeyCount.Text = "Item Count: 0";
                }
                else
                {
                    if (LoadData.Store.Price.AvailabletoPurchase != true)
                    {
                        Label_Price.Text = "Price: Not Available to Purchase";
                        Label_KeyCount.Text = "Item Count: 0";
                    }
                    else { }
                }
            }
            PanelStatus.Visible = false;
        }
        //----------------------Check for Update----------------------//
        private void MainUpdateChecker()
        {
            try
            {
                var AppVersion = new Version(Application.ProductVersion);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument data2 = new XmlDocument();
                data2.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                XmlElement root2 = data2.DocumentElement;
                XmlNodeList nodes2 = root2.SelectNodes("/Data/Application");
                foreach (XmlNode node in nodes2)
                {
                    string app_id_xml2 = node["AppID"].InnerText;
                    var ServerVersion = new Version(node["CurrentVersion"].InnerText);
                    string UpdateType = node["UpdateType"].InnerText;
                    var result = AppVersion.CompareTo(ServerVersion);
                    giveawayisactive = Convert.ToBoolean(node["Giveaway"].InnerText);
                    GiveawayBegin = Convert.ToInt32(node["GiveawayBegin"].InnerText);
                    GiveawayEnd = Convert.ToInt32(node["GiveawayEnd"].InnerText);
                    if (AppHash == app_id_xml2)
                    {
                        if (Convert.ToBoolean(Settings.CheckUpdate) == true)
                        {
                            if (Convert.ToBoolean(Settings.InstallBeta) == true)
                            {
                                var BetaVersion = new Version(node["BetaVersion"].InnerText);
                                string BetaDate_XML = node["BetaDate"].InnerText;
                                string BetaURL_XML = node["BetaURL"].InnerText;
                                bool Beta = Convert.ToBoolean(node["Beta"].InnerText);
                                var BetaResult = AppVersion.CompareTo(BetaVersion);
                                if (Beta == true)
                                {
                                    if (BetaResult < 0)
                                    {
                                        Label_Update.Text = string.Format("Update {1} Beta Available.", UpdateType, BetaVersion);
                                        Logger.LogUpdate("Update", BetaVersion, "Beta");
                                        Label_Update.Visible = true;
                                    }
                                    else if (BetaResult > 0)
                                    {
                                        bool MaintenanceMode = Maintenance.MaintenanceMode;
                                        if (MaintenanceMode == true)
                                        {
                                            Label_AppName.Text = "SteamPulse Beta - Maintenance Mode";
                                        }
                                        else
                                        {
                                            Label_AppName.Text = "SteamPulse - Beta";
                                        }
                                    }
                                }
                                else
                                {
                                    if (result < 0)
                                    {
                                        Label_Update.Text = string.Format("{0} {1} Available.", UpdateType, ServerVersion);
                                        Logger.LogUpdate(UpdateType, ServerVersion);
                                        Label_Update.Visible = true;
                                    }
                                    else if (result > 0)
                                    {
                                        bool MaintenanceMode = Maintenance.MaintenanceMode;
                                        if (MaintenanceMode == true)
                                        {
                                            Label_AppName.Text = "SteamPulse Beta - Maintenance Mode";
                                        }
                                        else
                                        {
                                            Label_AppName.Text = "SteamPulse - Beta";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (result < 0)
                                {
                                    Label_Update.Text = string.Format("{0} {1} Available.", UpdateType, ServerVersion);
                                    Logger.LogUpdate(UpdateType, ServerVersion);
                                    Label_Update.Visible = true;
                                }
                                else if (result > 0)
                                {
                                    bool MaintenanceMode = Maintenance.MaintenanceMode;
                                    if (MaintenanceMode == true)
                                    {
                                        Label_AppName.Text = "SteamPulse Beta - Maintenance Mode";
                                    }
                                    else
                                    {
                                        Label_AppName.Text = "SteamPulse - Beta";
                                    }
                                }
                            }
                        }
                        else { }
                    }
                    else { }
                }
            }
            catch { }
        }
        //----------------------Get AppID from Steam URL----------------------//
        private string URLtoAppID(string value)
        {
            if (TextBox_URL.Text.Length > 8)
            {
                try
                {
                    if (value.Contains("agecheck"))
                    {
                        Uri address = new Uri(TextBox_URL.Text);
                        string appid = address.Segments[3].Replace("/", "");
                        return appid;
                    }
                    else
                    {
                        Uri address = new Uri(TextBox_URL.Text);
                        string appid = address.Segments[2].Replace("/", "");
                        return appid;
                    }
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return TextBox_URL.Text;
            }
        }
        //----------------------Main Worker----------------------//
        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
            if (!string.IsNullOrEmpty(TextBox_URL.Text))
            {
                // Pre-Load
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Font = new Font("Poppins Black", 40)));
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Connecting..."));
                GetData.Appid = Convert.ToInt32(TextBox_URL.Text);
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Clear()));
                EditionPrice = 0;
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Loading..."));
                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Loading..."));
                //Initial Load
                try
                {
                    if (GetData.ConnectToSteam.Store() == true)
                    {
                        // if Loaded product is dlc
                        LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading Data..."));
                        if (LoadData.Store.Type == "dlc")
                        {
                            if (LoadData.Store.Name.Contains("-"))
                            {
                                string[] name = LoadData.Store.Name.Split(new[] { " - " }, StringSplitOptions.None);
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + name[1]));
                            }
                            else if (LoadData.Store.Name.Contains(":"))
                            {
                                string[] name = LoadData.Store.Name.Split(new[] { ":" }, StringSplitOptions.None);
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + name[1]));
                            }
                            else
                            {
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + LoadData.Store.Name));
                            }

                            PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.HeaderImage)));

                        }
                        else
                        {
                            //msfs easter-egg
                            if (GetData.Appid == 1250410)
                            {
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + GlobalVariables.Names.MSFS));
                                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(GlobalVariables.Images.Header.MSFS)));
                            }
                            else
                            {
                                if (LoadData.Store.IsComingSoon == true && LoadData.Store.Price.AvailabletoPurchase == true)
                                {
                                    Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = string.Format("Name: {0} (Pre-Order)", LoadData.Store.Name)));
                                }
                                else
                                {
                                    Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + LoadData.Store.Name));
                                }

                                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.HeaderImage)));
                            }
                        }

                        // if loaded game is free
                        if (LoadData.Store.IsFree == true)
                        {
                            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: Free"));
                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "Item Count: 0"));

                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading DLC..."));
                            Thread.Sleep(500);

                            if (LoadData.Store.DLC.Count != 0)
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Hand));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = string.Format("{0} DLC Found,Click to Open", LoadData.Store.DLC.Count)));
                            }
                            else
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "No DLC Found."));
                            }
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading Editions..."));
                            Thread.Sleep(500);


                            string package = LoadData.Store.Packages.ProductPackages;
                            JObject JsonObject = JObject.Parse(GetData.Data);
                            MatchCollection matches = Regex.Matches(package, @"\d+");

                            string[] result = matches.Cast<Match>()
                                                     .Take(10)
                                                     .Select(match => match.Value)
                                                     .ToArray();
                            int edition_count = result.Length - 1;
                            if (result.Length == 1 && result.Length != 0)
                            {
                                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                EditionDiscount = LoadData.Store.Price.Discount_Percent;
                            }
                            else
                            {
                                price = LoadData.Store.Price.Final;
                                string PriceString;
                                if (price == 0.00)
                                {
                                    if (LoadData.Store.IsFree == true)
                                    {
                                        Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: Free"));
                                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "Item Count: 0"));
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                    }
                                    else
                                    {
                                        if (LoadData.Store.Price.AvailabletoPurchase != true)
                                        {
                                            ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Not Available")));
                                        }
                                        else { }
                                    }
                                }
                                else
                                {
                                    PriceString = LoadData.Store.Price.Final.ToString("N");
                                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                    EditionDiscount = LoadData.Store.Price.Discount_Percent;
                                }
                                for (int i = 1; i < edition_count; i++)
                                {
                                    GetData.PackageID = Convert.ToInt32(result[i]);
                                    GetData.ConnectToSteam.Package();
                                    EditionPrice = LoadData.Store.Packages.Price.Final;
                                    string EditionName = LoadData.Store.Packages.TrimmedName;
                                    if (EditionPrice == 0)
                                    {

                                        
                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");
                                        char first = EditionName[0];
                                        if (char.IsWhiteSpace(first))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - Free", EditionName))));
                                    }
                                    else
                                    {
                                        
                                        
                                        if (GetData.Appid == 1250410)
                                        {
                                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                            EditionName = EditionName.Replace("Game of the Year", "");
                                        }

                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");
                                        
                                        if (EditionName.StartsWith(" "))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                                    }
                                }
                            }
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Finalizing..."));
                            if (Settings.CheckOwned == true)
                            {
                                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
                                isowned = LoadData.Community.Isowned(GetData.Appid);
                            }
                        }
                        else
                        {
                            // check for discount
                            if (LoadData.Store.Price.Discount_Percent == 0)
                            {
                                Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: " + string.Format("{0} {1}", Convert.ToDouble(LoadData.Store.Price.Final).ToString("N"), Settings.Currency.Unit)));
                            }
                            else
                            {
                                Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: " + string.Format("{0} {1} - {2}%", Convert.ToDouble(LoadData.Store.Price.Final).ToString("N"), Settings.Currency.Unit, LoadData.Store.Price.Discount_Percent.ToString())));
                            }

                            GetData.ConnectToSteam.Market.TF2Ticket();
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading DLC..."));
                            Thread.Sleep(500);

                            //check for dlc
                            if (LoadData.Store.DLC.Count != 0)
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Hand));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = string.Format("{0} DLC Found,Click to Open", LoadData.Store.DLC.Count)));
                            }
                            else
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "No DLC Found."));
                            }

                            //check for editions
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading Editions..."));
                            Thread.Sleep(500);
                            string package = LoadData.Store.Packages.ProductPackages;
                            JObject JsonObject = JObject.Parse(GetData.Data);
                            MatchCollection matches = Regex.Matches(package, @"\d+");

                            string[] result = matches.Cast<Match>()
                                                     .Take(10)
                                                     .Select(match => match.Value)
                                                     .ToArray();
                            int edition_count;
                            if (GetData.Appid == 271590)
                            {
                                edition_count = result.Length - 2;
                            }
                            else
                            {
                                edition_count = result.Length - 1;
                            }

                            if (result.Length == 1 && result.Length != 0)
                            {
                                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                EditionDiscount = LoadData.Store.Price.Discount_Percent;
                            }
                            else
                            {
                                if (LoadData.Store.Price.AvailabletoPurchase != true)
                                {
                                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Not Available")));
                                }
                                else { }
                                EditionDiscount = LoadData.Store.Price.Discount_Percent;
                                for (int i = 0; i <= edition_count; i++)
                                {
                                    GetData.PackageID = Convert.ToInt32(result[i]);
                                    GetData.ConnectToSteam.Package();

                                    //MessageBox.Show(LoadData.Store.Packages.GetPackageIDbyIndex(i).ToString());

                                    if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].packageid") != null)
                                    {
                                        string EditionName = LoadData.Store.Packages.TrimmedName;
                                        if (GetData.Appid == 1250410)
                                        {
                                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                            EditionName = EditionName.Replace("Game of the Year", "");
                                        }

                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");

                                        //char first = EditionName[0];
                                        if (EditionName.StartsWith(" "))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }

                                        if (EditionName == "" || EditionName == " ")
                                        {
                                            EditionName = "Standard";
                                        }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));

                                    }
                                    else
                                    {
                                        break;
                                    }


                                    //old edition method
                                    /*if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text") != null)
                                    {
                                        string dataRemover = JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text").ToString();
                                        string Temp = dataRemover.Replace("<span class=\"discount_original_price\">", "");
                                        string output = Temp.Replace("</span>", "");
                                        double EditionPrice = Convert.ToDouble(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                                        EditionPrice /= 100;
                                        output = output.Replace(LoadData.Store.Name.ToString(), "");
                                        output = output.Replace(":", "");

                                        string EditionName = Regex.Replace(output, @"[\d]", string.Empty);
                                        EditionName = EditionName.Replace(".,", "");
                                        EditionName = EditionName.Replace(",.", "");
                                        EditionName = EditionName.Replace("ARS$", "");
                                        EditionName = EditionName.Replace(".", "");
                                        EditionName = EditionName.Replace("$", "");
                                        EditionName = EditionName.Replace("-", "");
                                        EditionName = EditionName.Replace(",", "");
                                        EditionName = EditionName.Replace("Edition ", "");
                                        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                                        EditionName = rgx.Replace(EditionName.ToString(), "");
                                        if (Settings.Currency.Name == "Ruble")
                                        {
                                            EditionName = EditionName.Replace("p", "");
                                        }

                                        if (Settings.Currency.Name == "Lira")
                                        {
                                            EditionName = EditionName.Replace("TL", "");
                                        }

                                        if (GetData.Appid == 1250410)
                                        {
                                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                            EditionName = EditionName.Replace("Game of the Year", "");
                                        }
                                        else if (GetData.Appid == 292030)
                                        {
                                            EditionName = EditionName.Remove(0, 22);
                                        }

                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");
                                        char first = EditionName[0];
                                        if (char.IsWhiteSpace(first))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }

                                        if (EditionName == "" || EditionName == " ")
                                        {
                                            EditionName = "Standard";
                                        }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - {1} {2}", EditionName, EditionPrice.ToString("N"), Settings.Currency.Unit))));

                                    }
                                    else
                                    {
                                        break;
                                    }*/
                                }
                            }
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Finalizing..."));
                            if (Settings.CheckOwned == true)
                            {
                                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default.UserSteamID);
                                isowned = LoadData.Community.Isowned(GetData.Appid);
                            }
                        }
                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.SelectedIndex = 0));
                        //false
                        PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));
                        DataLoaded = true;
                        LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Data Loaded Successfully"));
                    }
                    else
                    {
                        if (GetData.ErrorCode == 3)
                        {
                            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Font = new Font("Poppins Black", 25)));
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Can't Connect to Steam"));
                            ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Can't Load"));
                        }
                        if (GetData.ErrorCode == 2)
                        {
                            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Can't Load Data"));
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Font = new Font("Poppins Black", 25)));
                            ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Can't Load"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Error!"));
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                    LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                    LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Can't Load"));
                    MessageBox.Show(ex.Message + "\n\nDescription:\n" + ex.InnerException + "\n\nTrace:\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Logger.LogRequest(LabelStatus.Text);
        }

        private void TextBox_URL_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox_URL.SelectAll();
        }
        private void Label_About_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }
        private void OpenMarket_Click(object sender, EventArgs e)
        {
            if (Settings.DeveloperMode == true && Settings.HistogramData == false)
            {
                Form OldMarket = new OldLiveMarketPrice();
                OldMarket.ShowDialog(this);

            }
            else
            {
                Form Market = new LiveMarketPrice();
                Market.ShowDialog(this);
            }
        }
        private void OpenDetails_Click(object sender, EventArgs e)
        {
            if (LoadData.Store.Type == "game")
            {
                Form GameDetails = new GameDetails();
                GameDetails.ShowDialog();
            }
            else
            {
                Form DlcDetails = new DlcDetails();
                DlcDetails.ShowDialog();
            }
        }
        private void TextBox_URL_Click(object sender, EventArgs e)
        {
            TextBox_URL.SelectAll();
        }
        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show(this);
        }
        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Calculator = new Calculator();
            Calculator.ShowDialog(this);
        }
        private void Main_Resize(object sender, EventArgs e)
        {
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LiveMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.DeveloperMode == true && Settings.HistogramData == false)
            {
                Form OldMarket = new OldLiveMarketPrice();
                OldMarket.ShowDialog(this);

            }
            else
            {
                Form Market = new LiveMarketPrice();
                Market.ShowDialog(this);
            }
        }

        private static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setings = new Setting();
            Setting.FormParent = "Main";
            setings.ShowDialog(this);
        }
        private void Main_Activated(object sender, EventArgs e)
        {

            if (SettingisUpdated == true)
            {
                LoadRegion();
                if (GetData.Appid != 0)
                {
                    PanelStatus.Visible = true;
                    ButtonLoad.PerformClick();
                    SettingisUpdated = false;
                }
                SettingisUpdated = false;
            }
            else { }
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            if (Settings.DeveloperMode == true)
            {
                this.ContextMenuStrip = MenuDev;
                NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            }
            else
            {
                this.ContextMenuStrip = MenuMain;
                NotifyIcon.ContextMenuStrip = this.ContextMenuStrip;
            }

            if (SearchID != null)
            {
                TextBox_URL.Text = SearchID;
                SearchID = null;
                ButtonLoad.PerformClick();
            }
        }
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                this.BackColor = GlobalVariables.Colors.Dark.Cello;
                ButtonLoad.Image = Properties.Resources.BTNLoadLight;
                OpenDetailsIcon.Image = Properties.Resources.OpenExternal;
                OpenDiscountCalculatorIcon.Image = Properties.Resources.OpenExternal;
                OpenMarketIcon.Image = Properties.Resources.OpenExternal;
                ButtonSetting.Image = Properties.Resources.Settings;
                ButtonStatus.Image = Properties.Resources.StatusWhite;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
                ButtonLoad.Image = Properties.Resources.BTNLoadDark;
                OpenDetailsIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenDiscountCalculatorIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenMarketIcon.Image = Properties.Resources.OpenExternalBlack;
                ButtonSetting.Image = Properties.Resources.SettingsBlack;
                ButtonStatus.Image = Properties.Resources.StatusBlack;
            }
            ButtonLoad.BackColor = BackGround;
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelAbout.BackgroundColor = BackGround;
            Label_About.ForeColor = ForeGround;
            PanelStatus.BackgroundColor = BackGround;
            LabelStatus.ForeColor = ForeGround;
            PanelRegion.BackgroundColor = BackGround;
            Label_Regions.ForeColor = ForeGround;
            PanelURL.BackgroundColor = BackGround;
            Label_URL.ForeColor = ForeGround;
            TextBox_URL.BorderColorIdle = ForeGround;
            TextBox_URL.BorderColorHover = ForeGround;
            TextBox_URL.BorderColorActive = ForeGround;
            PanelEdition.BackgroundColor = BackGround;
            Label_Edition.ForeColor = ForeGround;
            PanelData.BackgroundColor = BackGround;
            Label_Details.ForeColor = ForeGround;
            Label_KeyCount.ForeColor = ForeGround;
            Label_Name.ForeColor = ForeGround;
            Label_Price.ForeColor = ForeGround;
            Label_KeyCount.BackColor = BackGround;
            Label_Name.BackColor = BackGround;
            Label_Price.BackColor = BackGround;
            Label_Update.ForeColor = ForeGround;
            LabelSearch.ForeColor = ForeGround;

            PanelDLC.BackgroundColor = BackGround;
            PanelDLC.ForeColor = ForeGround;
            LabelDLC.ForeColor = ForeGround;
            LabelDLCCount.ForeColor = ForeGround;
            OpenDetails.ForeColor = ForeGround;
            OpenDiscountCalculator.ForeColor = ForeGround;
            OpenMarket.ForeColor = ForeGround;
            PanelGiveaway.BackgroundColor = BackGround;
            LabelGiveaway.ForeColor = ForeGround;
            Label_Remaining.ForeColor = ForeGround;

        }
        private void PictureBox_Image_Click(object sender, EventArgs e)
        {
            if (isowned == true)
            {
                Process.Start("steam://nav/games/details/" + GetData.Appid);
            }
            else
            {
                Process.Start("steam://openurl/https://store.steampowered.com/app/" + GetData.Appid);
            }
        }
        private void DropDownRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading == true) { }
            else
            {
                if (DropDownRegion.Text.Contains("United States"))
                {
                    Settings.Currency.Name = "USD";
                    Settings.Currency.Number = 1;
                    Settings.Currency.ISO = "US";
                    Settings.Currency.Unit = "$";
                }
                if (DropDownRegion.Text.Contains("Britain"))
                {
                    Settings.Currency.Name = "Pound";
                    Settings.Currency.Number = 2;
                    Settings.Currency.ISO = "GB";
                    Settings.Currency.Unit = "£";
                }
                if (DropDownRegion.Text.Contains("Europe"))
                {
                    Settings.Currency.Name = "Euro";
                    Settings.Currency.Number = 3;
                    Settings.Currency.ISO = "NL";
                    Settings.Currency.Unit = "€";
                }
                if (DropDownRegion.Text.Contains("China"))
                {
                    Settings.Currency.Name = "Yuan";
                    Settings.Currency.Number = 23;
                    Settings.Currency.ISO = "CN";
                    Settings.Currency.Unit = "Yuan";
                }
                if (DropDownRegion.Text.Contains("Argentina"))
                {
                    Settings.Currency.Name = "ARS";
                    Settings.Currency.Number = 34;
                    Settings.Currency.ISO = "AR";
                    Settings.Currency.Unit = "ARS";
                }
                if (DropDownRegion.Text.Contains("Turkey"))
                {
                    Settings.Currency.Name = "Lira";
                    Settings.Currency.Number = 17;
                    Settings.Currency.ISO = "TR";
                    Settings.Currency.Unit = "TL";
                }
                if (DropDownRegion.Text.Contains("Russia"))
                {
                    Settings.Currency.Name = "Ruble";
                    Settings.Currency.Number = 5;
                    Settings.Currency.ISO = "RU";
                    Settings.Currency.Unit = "Py6";
                }
                if (DropDownRegion.Text.Contains("Brazil"))
                {
                    Settings.Currency.Name = "Real";
                    Settings.Currency.Number = 7;
                    Settings.Currency.ISO = "BR";
                    Settings.Currency.Unit = "R$";
                }
                Logger.LogSetting("Region", Properties.Settings.Default.CurrencyISO.ToString());
                PanelStatus.Visible = true;
                ButtonLoad.PerformClick();
            }
        }

        /*private void ConfigReader()
        {

            string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CodeMage\Config.cfg";
            if (File.Exists(ConfigPath))
            {
                string[] data = File.ReadAllLines(ConfigPath);
                string[] Developer = data[0].Trim(';').Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                //string[] Experiment = data[1].Trim(';').Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
        }*/
        private void LabelRequest_Click(object sender, EventArgs e)
        {
            Process.Start("https://store.steampowered.com/api/appdetails?appids=" + GetData.Appid + "&cc=" + Settings.Currency.ISO.ToString());
        }
        private void LabelDLCCount_Click(object sender, EventArgs e)
        {
            if (DataLoaded == true)
            {
                if (LoadData.Store.DLC.Count != 0)
                {
                    Form DLC = new DLCBrowser();
                    DLC.ShowDialog(this);
                }
            }
        }
        private void CleanResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure ?\nThis will Reset all settings and restart app.", "Reset Settings.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Logger.LogSettingsReset();
                var dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CodeMage\");
                dir.Attributes &= ~FileAttributes.ReadOnly;
                dir.Delete(true);
                Application.Restart();
            }

        }
        private void ButtonLoad_CLick(object sender, EventArgs e)
        {
            if (BackgroundWorker.IsBusy != true)
            {
                BackgroundWorker.RunWorkerAsync();
            }
            else
            {
                DialogResult result = MessageBox.Show("SteamPulse is Loading Another Proccess.\nCancel Request?", "SteamPulse Is Busy", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    BackgroundWorker.CancelAsync();
                }
            }
        }
        private void DeveloperSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DevSettings = new DevSetting();
            DevSettings.ShowDialog(this);
        }
        private void Label_KeyCount_MouseHover(object sender, EventArgs e)
        {
            /*if(FormulaCaption !="")
            {
                toolTip.Show(FormulaCaption, Label_KeyCount);
            }*/
        }
        private void Label_KeyCount_MouseLeave(object sender, EventArgs e)
        {

        }
        private void OpenDiscountCalculator_Click(object sender, EventArgs e)
        {
            if (EditionPrice != 0)
            {
                Form DiscountCalculator = new DiscountCalculator();
                DiscountCalculator.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("This feature isn't usable on this product.", "Discount Calculator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Label_AppName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {
            AppidSearch appidSearch = new AppidSearch();
            appidSearch.ShowDialog(this);
        }

        private void BugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugReports BugReports = new BugReports();
            BugReports.ShowDialog(this);
        }

        private void ButtonStatus_Click(object sender, EventArgs e)
        {
            Form Status = new Status();
            Status.ShowDialog(this);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (noGiveAwayLimit == true)
            {
                Label_Remaining.Text = "GiveAway Unlocked! 🎉";
                Label_Remaining.Location = new Point(((PanelGiveaway.Size.Width - Label_Remaining.Size.Width) / 2), 36);
                ButtonGiveaway.Enabled = true;
                Timer.Enabled = false;
            }
            else
            {
                if (DateTimeOffset.Now.ToUnixTimeSeconds() > GiveawayBegin)
                {
                    Label_Remaining.Text = "GiveAway Unlocked! 🎉";
                    Label_Remaining.Location = new Point(((PanelGiveaway.Size.Width - Label_Remaining.Size.Width) / 2), 36);
                    ButtonGiveaway.Enabled = true;
                    Timer.Enabled = false;
                }
                if (DateTimeOffset.Now.ToUnixTimeSeconds() > GiveawayEnd)
                {
                    Label_Remaining.Text = "GiveAway Ended! 🎉";
                    Label_Remaining.Location = new Point(((PanelGiveaway.Size.Width - Label_Remaining.Size.Width) / 2), 36);
                    ButtonGiveaway.Enabled = false;
                    Timer.Enabled = false;
                }
                else
                {
                    TimeSpan span = GiveawayBeginTime.ToLocalTime().Subtract(DateTime.Now);

                    Label_Remaining.Text = string.Format("Unlock in: {0}d {1}h {2}m {3}s", span.Days, span.Hours, span.Minutes, span.Seconds);
                    Label_Remaining.Location = new Point(((PanelGiveaway.Size.Width - Label_Remaining.Size.Width) / 2), 36);
                }
            }
        }

        private void Label_Ramaining_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("GiveAway Begin on: " + GiveawayBeginTime.ToLocalTime().ToString("dddd, dd MMMM yyyy HH:mm:ss"), Label_Remaining);
        }

        private void ComboBox_Editions_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void ButtonGiveaway_Click(object sender, EventArgs e)
        {
            if (DateTimeOffset.Now.ToUnixTimeSeconds() > GiveawayBegin || noGiveAwayLimit == true)
            {
                Form Giveaway = new Giveaway();
                Giveaway.ShowDialog(this);
            }
        }
    }
    public class Logger
    {
        private static readonly string LogPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CodeMage\SteamPulse.Log";
        internal static bool CheckExist()
        {
            if (File.Exists(LogPath))
            {
                return true;
            }
            else
            {
                Create();
                return true;
            }
        }
        public static void Delete()
        {
            if (CheckExist() == true)
            {
                File.Delete(LogPath);
            }
        }
        public static void Create()
        {
            var DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var LPath = Path.Combine(DocumentsPath, "CodeMage");
            try
            {
                Directory.CreateDirectory(LPath);
                var myFile = File.Create(LogPath);
                myFile.Close();
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write("##The logging system still is in development and may have some problems." + Environment.NewLine);
                    Logger.Write(string.Format("{0} - [System] Log Created by {1}, SteamPulse Version: {2}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Environment.UserName, Application.ProductVersion) + Environment.NewLine);
                }
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(Environment.NewLine + "*********************** - System Hardware Information - ***********************" + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - CPU: {0}", GetHardwareInformation.CPU.Model()) + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - GPU: {0}", GetHardwareInformation.GPU.Model()) + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - Ram: {0}GB", GetHardwareInformation.Ram.Size()) + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - OS:  {0}", GetHardwareInformation.OS.Name()) + Environment.NewLine);
                    Logger.Write("*********************** - System Hardware Information - ***********************" + Environment.NewLine);
                    Logger.Write("" + Environment.NewLine);
                }
            }
            catch
            {

            }
        }
        public static void LogRequest(string Message)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Main] Requested to SteamAPI: (AppID: {1}, Name: {2}, Region: {3}), Description: {4}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), GetData.Appid, LoadData.Store.Name, Settings.Currency.ISO, Message) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogBugReport()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] Bug Reported Successfully, Thank You!", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogMarket(string Message, double key = 0, double ticket = 0)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    if (key == 0 && ticket == 0)
                    {
                        Logger.Write(string.Format("{0} - [Market] Requested to SteamAPI, Region: {1} , IRT: {2}, Description: {3}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Settings.Currency.ISO, Settings.CheckIRT, Message) + Environment.NewLine);
                    }
                    else
                    {
                        Logger.Write(string.Format("{0} - [Market] Requested to SteamAPI, Region: {1} , IRT: {2} Price: Key: {4} {3}, Ticket: {5} {3}, Description: {6}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Settings.Currency.ISO, Settings.CheckIRT, Settings.Currency.Unit, key, ticket, Message) + Environment.NewLine);
                    }
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogUpdate(string UpdateType, Version Version, string Beta = "")
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] {1} {2} {3} Available", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), UpdateType, Version, Beta) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogSteamLogin(string status, string ID)
        {
            if (CheckExist() == true)
            {
                if (status == "Logined")
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - [Setting] Logined to Steam(ID: {1})", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), ID) + Environment.NewLine);
                    }
                }
                else
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - [Setting] Logouted from Steam", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogVersionChange()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] SteamPulse Upgraded to Version: {1}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Application.ProductVersion) + Environment.NewLine);
                }
            }
        }
        public static void LogMaintenancee()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] SteamPulse Opened in Maintenance Mode", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
        }

        public static void LogDeveloper(bool status)
        {
            if (CheckExist() == true)
            {
                if (status == true)
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - Developer Mode Enabled.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
                else
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - Developer Mode Disabled.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
            }
        }
        public static void LogSetting(string SettingName, string status)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Setting] Settings Updated('{1}' Changed to '{2}')", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), SettingName, status) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogDevSetting(string SettingName, string status)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Developer Settings] Settings Updated('{1}' Changed to '{2}')", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), SettingName, status) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogSettingsReset()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Setting] Settings Reseted.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
    }
    public class GlobalVariables
    {
        public struct Names
        {
            public static string MSFS => "Microsoft Loading Simulator";
        }
        public struct Images
        {
            public struct Header
            {
                public static string MSFS => "https://cdn.codemage.ir/Projects/SteamPulse/Resource/MSFS/header.jpg";
            }
            public struct Hero
            {
                public static string MSFS => "https://cdn.codemage.ir/Projects/SteamPulse/Resource/MSFS/library.jpg";
            }
        }
        public struct Colors
        {
            public struct Light
            {
                public static Color NileBlue => Color.FromArgb(24, 49, 83);
                public static Color White => Color.FromArgb(255, 255, 255);
                public static Color AthenGray => Color.FromArgb(241, 240, 245);
            }
            public struct Dark
            {
                public static Color White => Color.FromArgb(255, 255, 255);
                public static Color NileBlue => Color.FromArgb(24, 49, 83);
                public static Color Cello => Color.FromArgb(33, 63, 105);
            }
        }
    }
}
