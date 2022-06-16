#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.7.1 Revision 2

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
        //string FormulaCaption = "";
        private readonly string AppHash = Hasher("SteamPulse");
        private Boolean isowned = false;
        string EditionName;
        public static double EditionPrice;
        double price;
        public static int EditionDiscount;
        public static Boolean SettingisUpdated = false;
        public static Boolean DarkMode;
        bool IsLoading = true;
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
        private void Main_Load(object sender, EventArgs e)
        {
            Boolean MaintenanceMode = Maintenance.MaintenanceMode;
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
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            if (BackgroundWorker.IsBusy)
            {
                BackgroundWorker.CancelAsync();
            }

            this.Close();
        }
        private void TextBox_URL_TextChanged(object sender, EventArgs e)
        {
            TextBox_URL.Text = UrlFixer(TextBox_URL.Text);
            TextBox_URL.ForeColor = Color.Black;
        }
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
                    EditionPrice = Convert.ToDouble(Regex.Replace(ComboBox_Editions.Text, "[^0-9]", ""));
                    if (Settings.Currency.Name == "Ruble")
                    {
                        string PriceString = EditionPrice.ToString();
                        PriceString = PriceString.Remove(PriceString.Length - 1);
                        EditionPrice = Convert.ToDouble(PriceString);
                    }
                    EditionPrice /= 100;
                    EditionName = Regex.Replace(ComboBox_Editions.Text, @"[\d-]", string.Empty);
                    EditionName = EditionName.Replace(".,", "");
                    EditionName = EditionName.Replace(",.", "");
                    EditionName = EditionName.Replace(".", "");
                    EditionName = EditionName.Replace(",", "");
                    EditionName = EditionName.Replace("TL", "");
                    Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    EditionName = rgx.Replace(EditionName.ToString(), "");
                    if (Settings.Currency.Name == "Ruble")
                    {
                        EditionName = EditionName.Replace("p", "");
                        EditionName = EditionName.Replace("py", "");
                    }
                    if (Settings.Currency.Name == "Lira")
                    {
                        EditionName = EditionName.Replace("TL", "");
                    }
                }
                else { }
                string discount_percent_pack = LoadData.Store.RawData.SelectToken(GetData.Appid + ".data.package_groups[0].subs[" + ComboBox_Editions.SelectedIndex + "].percent_savings_text").ToString();
                if (discount_percent_pack == " ")
                {
                    EditionDiscount = 0;
                }
                else
                {
                    discount_percent_pack = discount_percent_pack.Remove(0, 1);
                    discount_percent_pack = discount_percent_pack.Remove(2, 1);
                    EditionDiscount = Convert.ToInt32(discount_percent_pack);
                }
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
                    if (EditionPrice < LoadData.Market.Ticket.User_Price && Settings.ItemCalculationMode != "Key Only")
                    {
                        double Ticket_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Ticket.User_Price;
                        double Ticket_rounded = (int)Math.Ceiling(Math.Round(Ticket_count, 1));
                        double Remaining = (Ticket_rounded * LoadData.Market.Ticket.User_Price) - EditionPrice;
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
                            GetData.ConnecttoShop.Ticket();
                            if (LoadData.Shop.Ticket != 0)
                            {
                                if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Text = String.Format("Ticket Count: {0} - {1} IRT - {2} {3} Remains", Ticket_rounded.ToString(), String.Format("{0:n0} ", (int)Math.Ceiling(Ticket_count) * LoadData.Shop.Ticket), (int)Remaining, Settings.Currency.Unit);
                                }
                                else
                                {
                                    Label_KeyCount.Text = String.Format("Ticket Count: {0} - {1} IRT ", Ticket_rounded.ToString(), String.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(Ticket_count, 1)) * LoadData.Shop.Ticket));
                                }
                            }
                            else
                            {
                                if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Text = String.Format("Ticket Count: {0} - {1}{2}", Ticket_rounded, (int)Remaining, Settings.Currency.Unit);
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
                                Label_KeyCount.Text = String.Format("Ticket Count: {0} - {1}{2}", Ticket_rounded, (int)Remaining, Settings.Currency.Unit);
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
                        double key_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Key.User_Price;
                        double KeyRoundedUp = (int)Math.Ceiling(key_count);
                        double Remaining = (KeyRoundedUp * LoadData.Market.Key.User_Price) - EditionPrice;
                        int KeyRoundedDown = (int)Math.Floor(key_count);
                        double DownRemaining = EditionPrice - (KeyRoundedDown * LoadData.Market.Key.User_Price);
                        double Remaining2 = ((KeyRoundedDown * LoadData.Market.Key.User_Price) + LoadData.Market.Ticket.User_Price) - EditionPrice;


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
                            GetData.ConnecttoShop.Key();
                            if (LoadData.Shop.Key != 0)
                            {
                                if (Settings.CalculateRemaining == true)
                                {
                                    if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.User_Price)
                                        {
                                            Label_KeyCount.Text = String.Format("Item Count: {0} Key + 1 Ticket - {1} IRT ~ {2} {3} ", KeyRoundedDown, String.Format("{0:n0} ", (KeyRoundedDown * LoadData.Shop.Key) + LoadData.Shop.Ticket), (int)Remaining2, Settings.Currency.Unit);
                                            //FormulaCaption = string.Format("Key = {0} - {1}IRT | Ticket = {2} - {3}IRT => {4} Key({5}) + 1 Ticket({6}) = {7} {10} - {8} IRT ~ Remains {9} {10}", LoadData.Market.Key.User_Price, String.Format("{0:n0} ", LoadData.Shop.Key), LoadData.Market.Ticket.User_Price, String.Format("{0:n0} ", LoadData.Shop.Ticket), KeyRoundedDown, (KeyRoundedDown * LoadData.Market.Key.User_Price), LoadData.Market.Ticket.User_Price, ((KeyRoundedDown * LoadData.Market.Key.User_Price) + LoadData.Market.Ticket.User_Price), String.Format("{0:n0}", ((KeyRoundedDown * LoadData.Shop.Key) + LoadData.Shop.Ticket)), (int)Remaining2, Settings.Currency.Unit);
                                        }
                                        else
                                        {
                                            Label_KeyCount.Text = String.Format("Key Count: {0} - {1} IRT - {2} {3} Remains", KeyRoundedUp, String.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.Shop.Key), (int)Remaining, Settings.Currency.Unit);
                                            //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.User_Price, String.Format("{0:n0} ", LoadData.Shop.Key), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.User_Price), String.Format("{0:n0}", (KeyRoundedUp * LoadData.Shop.Key)), (int)Remaining, Settings.Currency.Unit);
                                        }

                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = String.Format("Key Count: {0} - {1} IRT - {2} {3} Remains", KeyRoundedUp, String.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.Shop.Key), (int)Remaining, Settings.Currency.Unit);
                                        //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.User_Price, String.Format("{0:n0} ", LoadData.Shop.Key), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.User_Price), String.Format("{0:n0}", (KeyRoundedUp * LoadData.Shop.Key)), (int)Remaining, Settings.Currency.Unit);
                                    }
                                }
                                else
                                {
                                    if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.User_Price)
                                        {
                                            Label_KeyCount.Text = String.Format("Item Count: {0} Key + 1 Ticket - {1} IRT", KeyRoundedDown, String.Format("{0:n0} ", (KeyRoundedDown * LoadData.Shop.Key) + LoadData.Shop.Ticket));
                                        }
                                        else
                                        {
                                            Label_KeyCount.Text = String.Format("Key Count: {0} - {1} IRT", KeyRoundedUp, String.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.Shop.Key));
                                        }
                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = String.Format("Key Count: {0} - {1} IRT", KeyRoundedUp, String.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.Shop.Key));
                                    }
                                    //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT", LoadData.Market.Key.User_Price, String.Format("{0:n0} ", LoadData.Shop.Key), KeyRoundedUp, KeyRoundedUp * LoadData.Market.Key.User_Price, KeyRoundedUp * LoadData.Shop.Key);
                                }

                            }
                            else
                            {
                                if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                                {
                                    if (DownRemaining < LoadData.Market.Ticket.User_Price)
                                    {
                                        Label_KeyCount.Text = String.Format("Item Count: {0} Key + 1 Ticket ~ {1} {2} ", KeyRoundedDown, (int)Remaining2, Settings.Currency.Unit);
                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = String.Format("Key Count: {0} - {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
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
                            if (Settings.CalculateRemaining == true)
                            {
                                Label_KeyCount.Text = String.Format("Key Count: {0} - {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
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
                    if (AppHash == app_id_xml2)
                    {
                        if (Convert.ToBoolean(Settings.CheckUpdate) == true)
                        {
                            if (Convert.ToBoolean(Settings.InstallBeta) == true)
                            {
                                var BetaVersion = new Version(node["BetaVersion"].InnerText);
                                string BetaDate_XML = node["BetaDate"].InnerText;
                                string BetaURL_XML = node["BetaURL"].InnerText;
                                Boolean Beta = Convert.ToBoolean(node["Beta"].InnerText);
                                var BetaResult = AppVersion.CompareTo(BetaVersion);
                                if (Beta == true)
                                {
                                    if (BetaResult < 0)
                                    {
                                        Label_Update.Text = string.Format("Update {1} Beta Available.", UpdateType, BetaVersion);
                                        Label_Update.Visible = true;
                                    }
                                    else if (BetaResult > 0)
                                    {
                                        Boolean MaintenanceMode = Maintenance.MaintenanceMode;
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
                                        Label_Update.Visible = true;
                                    }
                                    else if (result > 0)
                                    {
                                        Boolean MaintenanceMode = Maintenance.MaintenanceMode;
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
                                    Label_Update.Visible = true;
                                }
                                else if (result > 0)
                                {
                                    Boolean MaintenanceMode = Maintenance.MaintenanceMode;
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
        private string UrlFixer(string value)
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
        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
            if (!string.IsNullOrEmpty(TextBox_URL.Text))
            {
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Connecting..."));
                GetData.Appid = Convert.ToInt32(TextBox_URL.Text);
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Clear()));
                EditionPrice = 0;
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Loading..."));
                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Loading..."));
                try
                {
                    if (GetData.ConnectToSteam.Store() == true)
                    {
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
                            if (GetData.Appid == 1250410)
                            {
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + "Microsoft Loading Simulator"));
                                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load("https://cdn.codemage.ir/Projects/SteamPulse/Resource/MSFS/header.jpg")));
                            }
                            else
                            {
                                if (LoadData.Store.IsComingSoon == true && LoadData.Store.Price.AvailabletoPurchase == true)
                                {
                                    Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = String.Format("Name: {0} (Pre-Order)", LoadData.Store.Name)));
                                }
                                else
                                {
                                    Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + LoadData.Store.Name));
                                }

                                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.HeaderImage)));
                            }
                        }

                        if (LoadData.Store.IsFree == true)
                        {
                            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: Free"));
                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "Item Count: 0"));

                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading DLC..."));
                            Thread.Sleep(500);

                            if (LoadData.Store.DLC.Count != 0)
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Hand));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = String.Format("{0} DLC Found,Click to Open", LoadData.Store.DLC.Count)));
                            }
                            else
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "No DLC Found."));
                            }
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading Editions..."));
                            Thread.Sleep(500);


                            string package = LoadData.Store.Packages;
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
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard - Free")));
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
                                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, string.Format("Standard - {0} {1}", PriceString, Settings.Currency.Unit))));
                                    EditionDiscount = LoadData.Store.Price.Discount_Percent;
                                }
                                for (int i = 1; i < edition_count; i++)
                                {
                                    string dataRemover = JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text").ToString();
                                    string Temp = dataRemover.Replace("<span class=\"discount_original_price\">", "");
                                    string output = Temp.Replace("</span>", "");
                                    EditionPrice = 0;
                                    EditionPrice = Convert.ToDouble(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                                    if (EditionPrice == 0)
                                    {

                                        output = output.Replace(LoadData.Store.Name, "");
                                        output = output.Replace(":", "");
                                        String EditionName = Regex.Replace(output, @"[\d]", string.Empty);
                                        EditionName = EditionName.Replace(".,", "");
                                        EditionName = EditionName.Replace("ARS$", "");
                                        EditionName = EditionName.Replace(".", "");
                                        EditionName = EditionName.Replace("$", "");
                                        EditionName = EditionName.Replace("-", "");
                                        EditionName = EditionName.Replace("™", "");
                                        EditionName = EditionName.Replace("®", "");
                                        EditionName = EditionName.Replace("®", "");
                                        EditionName = EditionName.Replace(" Edition ", "");
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
                                        EditionPrice /= 100;
                                        output = output.Replace(LoadData.Store.Name, "");
                                        output = output.Replace(":", "");
                                        String EditionName = Regex.Replace(output, @"[\d]", string.Empty);
                                        EditionName = EditionName.Replace(".,", "");
                                        EditionName = EditionName.Replace("ARS$", "");
                                        EditionName = EditionName.Replace(".", "");
                                        EditionName = EditionName.Replace("$", "");
                                        EditionName = EditionName.Replace("-", "");
                                        EditionName = EditionName.Replace("Edition ", "");
                                        EditionName = EditionName.Replace("™", "");
                                        EditionName = EditionName.Replace("®", "");
                                        EditionName = EditionName.Replace("®", "");
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
                                            output = output.Replace("Microsoft Flight Simulator", "");
                                            output = output.Replace("Game of the Year", "");
                                        }
                                        if (GetData.Appid == 1938090)
                                        {
                                            output = output.Replace("Call of Duty Modern Warfare II  ", "");
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
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - {1} {2}", EditionName, EditionPrice.ToString("N"), Settings.Currency.Unit))));
                                    }
                                }
                            }
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Finalizing..."));
                            if(Settings.CheckOwned == true)
                            {
                                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
                                isowned = LoadData.Community.Isowned(GetData.Appid);
                            }
                        }
                        else
                        {
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

                            if (LoadData.Store.DLC.Count != 0)
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Hand));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = String.Format("{0} DLC Found,Click to Open", LoadData.Store.DLC.Count)));
                            }
                            else
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "No DLC Found."));
                            }
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading Editions..."));
                            Thread.Sleep(500);
                            string package = LoadData.Store.Packages;
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
                                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, string.Format("Standard - {0} {1}", LoadData.Store.Price.Final.ToString("N"), Settings.Currency.Unit))));
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
                                    if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text") != null)
                                    {
                                        string dataRemover = JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text").ToString();
                                        string Temp = dataRemover.Replace("<span class=\"discount_original_price\">", "");
                                        string output = Temp.Replace("</span>", "");
                                        Double EditionPrice = Convert.ToDouble(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                                        EditionPrice /= 100;
                                        output = output.Replace(LoadData.Store.Name.ToString(), "");
                                        output = output.Replace(":", "");

                                        String EditionName = Regex.Replace(output, @"[\d]", string.Empty);
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

                                        if(EditionName == "" || EditionName == " ")
                                        {
                                            EditionName = "Standard";
                                        }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - {1} {2}", EditionName, EditionPrice.ToString("N"), Settings.Currency.Unit))));

                                    }
                                    else
                                    {
                                        break;
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
                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.SelectedIndex = 0));
                        //false
                        PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));
                        LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Data Loaded Successfully"));
                    }
                    else
                    {
                        if (GetData.ErrorCode == 3)
                        {
                            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Can't Connect to Steam"));
                            ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Can't Load"));
                        }
                        if (GetData.ErrorCode == 2)
                        {
                            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Can't Load Data"));
                            ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Can't Load"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = ex.Message));
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                    LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                    LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "Can't Load"));
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
            Form Market = new LiveMarketPrice();
            Market.ShowDialog();
        }
        private void OpenDetails_Click(object sender, EventArgs e)
        {
            Form GameDetails = new GameDetails();
            GameDetails.ShowDialog();
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
            Form Market = new LiveMarketPrice();
            Market.ShowDialog(this);
        }
        static string Hasher(string input)
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
            LoadRegion();
            if (SettingisUpdated == true)
            {
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
        }
        private void ChangeTheme(Boolean Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = Color.FromArgb(24, 49, 83);
                ForeGround = Color.FromArgb(255, 255, 255);
                this.BackColor = Color.FromArgb(33, 63, 105);
                ButtonLoad.Image = Properties.Resources.BTNLoadLight;
                OpenDetailsIcon.Image = Properties.Resources.OpenExternal;
                OpenDiscountCalculatorIcon.Image = Properties.Resources.OpenExternal;
                OpenMarketIcon.Image = Properties.Resources.OpenExternal;
                ButtonSetting.Image = Properties.Resources.Settings;
            }
            else
            {
                BackGround = Color.FromArgb(255, 255, 255);
                ForeGround = Color.FromArgb(24, 49, 83);
                this.BackColor = Color.FromArgb(241, 240, 245);
                ButtonLoad.Image = Properties.Resources.BTNLoadDark;
                OpenDetailsIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenDiscountCalculatorIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenMarketIcon.Image = Properties.Resources.OpenExternalBlack;
                ButtonSetting.Image = Properties.Resources.SettingsBlack;
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

            PanelDLC.BackgroundColor = BackGround;
            PanelDLC.ForeColor = ForeGround;
            LabelDLC.ForeColor = ForeGround;
            LabelDLCCount.ForeColor = ForeGround;
            OpenDetails.ForeColor = ForeGround;
            OpenDiscountCalculator.ForeColor = ForeGround;
            OpenMarket.ForeColor = ForeGround;
        }
        private void PictureBox_Image_Click(object sender, EventArgs e)
        {
            if(isowned == true)
                Process.Start("steam://nav/games/details/"+GetData.Appid);
            else
                Process.Start("steam://openurl/https://store.steampowered.com/app/" + GetData.Appid);
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
            if (LoadData.Store.DLC.Count != 0)
            {
                Form DLC = new DLCBrowser();
                DLC.ShowDialog(this);
            }
            else { }
        }
        private void CleanResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure ?\nThis will Reset all settings and restart app.", "Reset Settings.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Logger.LogSettingsReset();
                Properties.Settings.Default.LastVersion = Application.ProductVersion;
                Properties.Settings.Default.Save();
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
                DialogResult result = MessageBox.Show("SteamPulse is Loading Another Proccess.\nCancel previuos Request?", "SteamPulse Is Busy", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
    }
    public class Logger
    {
        private static readonly string LogPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CodeMage\SteamPulse.Log";
        internal static Boolean CheckExist()
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
            if (File.Exists(LogPath))
            {
                File.Delete(LogPath);
            }
        }
        public static void Create()
        {
            var DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var LPath = Path.Combine(DocumentsPath, "CodeMage");
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
                Logger.Write(String.Format("*********************** - CPU: {0}", GetHardwareInformation.CPU.Model()) + Environment.NewLine);
                Logger.Write(String.Format("*********************** - GPU: {0}", GetHardwareInformation.GPU.Model()) + Environment.NewLine);
                Logger.Write(String.Format("*********************** - Ram: {0}GB", GetHardwareInformation.Ram.Size()) + Environment.NewLine);
                Logger.Write(String.Format("*********************** - OS:  {0}", GetHardwareInformation.OS.Name()) + Environment.NewLine);
                Logger.Write("*********************** - System Hardware Information - ***********************" + Environment.NewLine);
                Logger.Write("" + Environment.NewLine);
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
                        Logger.Write(string.Format("{0} - [Market] Requested to SteamAPI, Region: {1} , IRT: {2} Price: Key: {4} {3}, Ticket :{5} {3}, Description: {6}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Settings.Currency.ISO, Settings.CheckIRT, Settings.Currency.Unit, key, ticket, Message) + Environment.NewLine);
                    }
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogUpdate(string UpdateType, double Version, string Beta)
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
                        Logger.Write(String.Format("{0} - [Setting] Logined to Steam(ID: {1})", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), ID) + Environment.NewLine);
                    }
                }
                else
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(String.Format("{0} - [Setting] Logouted from Steam", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogVersionChange(String status)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(String.Format("{0} - [System] SteamPulse {1} to Version: {2}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), status, Application.ProductVersion) + Environment.NewLine);
                }
            }
        }
        public static void LogMaintenancee()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(String.Format("{0} - [System] SteamPulse Opened in Maintenance Mode", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
        }

        public static void LogDeveloper(Boolean status)
        {
            if (CheckExist() == true)
            {
                if (status == true)
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(String.Format("{0} - Developer Mode Enabled.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
                else
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(String.Format("{0} - Developer Mode Disabled.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
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
                    Logger.Write(String.Format("{0} - [Setting] Settings Updated('{1}' Changed to '{2}')", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), SettingName, status) + Environment.NewLine);
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
                    Logger.Write(String.Format("{0} - [Developer Settings] Settings Updated('{1}' Changed to '{2}')", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), SettingName, status) + Environment.NewLine);
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
                    Logger.Write(String.Format("{0} - [Setting] Settings Reseted.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
    }
}
