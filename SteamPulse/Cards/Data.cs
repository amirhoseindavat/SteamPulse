using Newtonsoft.Json.Linq;
using SteamPulse.GlobalVariables;
using SteamPulse.Logger;
using SteamPulse.SettingsInterface;
using SteamPulse.SteamAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Data : UserControl
    {
        public static int Appid = 0;
        public static bool DarkMode;
        private bool isowned = false, BaseGameOwned = false;

        private bool DataLoaded = false;
        private double price;

        public static double EditionPrice;
        public static int EditionDiscount;
        private int SelectedEdition;
        private bool Loading = false;
        private readonly List<int> PackageIDs = new List<int>();

        public Data()
        {
            InitializeComponent();
        }
        private void Data_Load(object sender, EventArgs e)
        {
            BackgroundWorker.RunWorkerAsync();
            if (UserSettings.DarkMode)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }            
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Loading = true;
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Size = new Size(618, 439)));
            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Hunting Ducks..."));
            Thread.Sleep(100);

            if (UserSettings.Currency.ISO == "BR")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 7));
            }
            else if (UserSettings.Currency.ISO == "RU")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 6));
            }
            else if (UserSettings.Currency.ISO == "CN")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 3));
            }
            else if (UserSettings.Currency.ISO == "NL")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 2));
            }
            else if (UserSettings.Currency.ISO == "UK")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 1));
            }
            else if (UserSettings.Currency.ISO == "US")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 0));
            }
            else if (UserSettings.Currency.ISO == "TR")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 5));
            }
            else if (UserSettings.Currency.ISO == "AR")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 4));
            }
            else if (UserSettings.Currency.ISO == "UA")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 8));
            }
            else if (UserSettings.Currency.ISO == "IN")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 9));
            }
            else if (UserSettings.Currency.ISO == "KZ")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 10));
            }
            else if (UserSettings.Currency.ISO == "PH")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 11));
            }
            else if (UserSettings.Currency.ISO == "AZ")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 12));
            }
            else if (UserSettings.Currency.ISO == "PK")
            {
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 13));
            }
            else
            {
                UserSettings.Currency.Name = "USD";
                UserSettings.Currency.Number = 1;
                UserSettings.Currency.ISO = "US";
                UserSettings.Currency.Unit = "$";
                DropDownRegion.Invoke((MethodInvoker)(() => DropDownRegion.SelectedIndex = 0));
            }
            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Connecting to Steam"));
            GetData.ConnectToSteam.Store(Appid);
            Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = LoadData.Store.Name));


            
            

            if (LoadData.Store.Type == "dlc")
            {
                Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading DLC Data"));
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.BringToFront()));
                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.HeaderImage)));
                Label_DLC_TItle.Invoke((MethodInvoker)(() => Label_DLC_TItle.Visible = false));
                Label_DLC.Invoke((MethodInvoker)(() => Label_DLC.Visible = false));
                Label_Player_Count.Invoke((MethodInvoker)(() => Label_Player_Count.Visible = false));
                Label_Player_Count_Title.Invoke((MethodInvoker)(() => Label_Player_Count_Title.Visible = false));
                Label_Edition_Title.Invoke((MethodInvoker)(() => Label_Edition_Title.Visible = false));
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Visible = false));

                Label_Release_Title.Invoke((MethodInvoker)(() => Label_Release_Title.Location = new Point(274, 37)));
                Label_Release.Invoke((MethodInvoker)(() => Label_Release.Location = new Point(382, 37)));
                Label_Dev_Title.Invoke((MethodInvoker)(() => Label_Dev_Title.Location = new Point(274, 67)));
                Label_Dev.Invoke((MethodInvoker)(() => Label_Dev.Location = new Point(353, 67)));
                Label_Publisher_Title.Invoke((MethodInvoker)(() => Label_Publisher_Title.Location = new Point(274, 97)));
                Label_Publisher.Invoke((MethodInvoker)(() => Label_Publisher.Location = new Point(355, 97)));
                Panel_BaseGame.Invoke((MethodInvoker)(() => Panel_BaseGame.Visible = true));
                Panel_BaseGame.Invoke((MethodInvoker)(() => Panel_BaseGame.Size = new Size(372, 82)));
                bunifuSeparator1.Invoke((MethodInvoker)(() => bunifuSeparator1.Location = new Point(13, 36)));
                PictureBoxBaseGame.Invoke((MethodInvoker)(() => PictureBoxBaseGame.Load("https://cdn.cloudflare.steamstatic.com/steam/apps/" + LoadData.Store.RawData.SelectToken("$." + GetData.Appid + ".data.fullgame.appid") + "/capsule_184x69.jpg")));

            }
            else
            {
                Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading Game Data"));
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.BringToFront()));
                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.LibraryImage)));
                Label_DLC_TItle.Invoke((MethodInvoker)(() => Label_DLC_TItle.Visible = true));
                Label_DLC.Invoke((MethodInvoker)(() => Label_DLC.Visible = true));
                Label_Player_Count.Invoke((MethodInvoker)(() => Label_Player_Count.Visible = true));
                Label_Player_Count_Title.Invoke((MethodInvoker)(() => Label_Player_Count_Title.Visible = true));
                Label_Edition_Title.Invoke((MethodInvoker)(() => Label_Edition_Title.Visible = true));
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Visible = true));

                Label_Release_Title.Invoke((MethodInvoker)(() => Label_Release_Title.Location = new Point(274, 67)));
                Label_Release.Invoke((MethodInvoker)(() => Label_Release.Location = new Point(382, 67)));
                Label_Dev_Title.Invoke((MethodInvoker)(() => Label_Dev_Title.Location = new Point(274, 127)));
                Label_Dev.Invoke((MethodInvoker)(() => Label_Dev.Location = new Point(353, 127)));
                Label_Publisher_Title.Invoke((MethodInvoker)(() => Label_Publisher_Title.Location = new Point(274, 157)));
                Label_Publisher.Invoke((MethodInvoker)(() => Label_Publisher.Location = new Point(355, 157)));
                Panel_BaseGame.Invoke((MethodInvoker)(() => Panel_BaseGame.Visible = true));
                Panel_BaseGame.Invoke((MethodInvoker)(() => Panel_BaseGame.Size = new Size(1, 1)));
                bunifuSeparator1.Invoke((MethodInvoker)(() => bunifuSeparator1.Location = new Point(13, 6)));

            }

            Label_DLC.Invoke((MethodInvoker)(() => Label_DLC.Text = LoadData.Store.DLC.Count.ToString()));
            if (LoadData.Store.IsComingSoon == true)
            {
                try
                {
                    //LabelRelease.Text = String.Format("{0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), (LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = string.Format("{0} ({1} Years to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365)));
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = string.Format("{0} ({1} Months to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30)));
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = string.Format("{0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount)));
                    }
                    else
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy")));
                    }
                }
                catch
                {
                    Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = LoadData.Store.ReleaseDateString.ToString()));
                }
            }

            else
            {

                try
                {
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = string.Format("{0} ({1} Years Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365)));
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = string.Format("{0} ({1} Months Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30)));
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = string.Format("{0} ({1} days Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount)));
                    }
                    else
                    {
                        Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy")));
                    }
                }
                catch
                {
                    Label_Release.Invoke((MethodInvoker)(() => Label_Release.Text = LoadData.Store.ReleaseDateString.ToString()));
                }

            }
            if (LoadData.Store.IsComingSoon == true)
            {
                Label_Player_Count.Invoke((MethodInvoker)(() => Label_Player_Count.Text = "Not Released"));
            }
            else
            {
                Label_Player_Count.Invoke((MethodInvoker)(() => Label_Player_Count.Text = string.Format("{0:n0} ", LoadData.Store.PlayerCount)));
            }

            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Hunting More Ducks..."));
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.BringToFront()));
            Label_Dev.Invoke((MethodInvoker)(() => Label_Dev.Text = LoadData.Store.Developers));
            Label_Publisher.Invoke((MethodInvoker)(() => Label_Publisher.Text = LoadData.Store.Publishers));
            GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
            if (UserSettings.CheckOwned == true)
            {
                int ID = 0;
                if (LoadData.Store.Type == "game")
                {
                    ID = GetData.Appid;
                }
                else
                {
                    ID = Convert.ToInt32(LoadData.Store.RawData.SelectToken("$." + GetData.Appid + ".data.fullgame.appid"));
                }
                if (LoadData.Community.Isowned(ID))
                {
                    LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Text = "You Own This Game"));
                    if (LoadData.Store.Type == "dlc")
                    {
                        LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Text = "You Own Base Game"));
                        BaseGameOwned = true;
                    }
                    else
                    {
                        LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Text = "You Own This Game"));
                        if (LoadData.Community.Playtime(GetData.Appid) == 0)
                        {
                            if (LoadData.Store.IsComingSoon == true)
                            {
                                //LabelPlayTime.Text = "Playtime: Not Released";
                                Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Visible = false));
                                Label_PlayTime.Invoke((MethodInvoker)(() => Label_Name.Location = new Point(237, 69)));
                            }
                            else
                            {
                                Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Text = "Not Played"));
                            }
                        }
                        else
                        {
                            if (LoadData.Community.Playtime(GetData.Appid) < 120)
                            {
                                Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Text = string.Format("{0} Minutes", LoadData.Community.Playtime(GetData.Appid))));
                            }
                            else
                            {
                                Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Text = string.Format("{0} Hours", string.Format("{0:n0}", LoadData.Community.Playtime(GetData.Appid) / 60))));
                            }
                        }
                        Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Visible = true));
                        Label_PlayTime_Title.Invoke((MethodInvoker)(() => Label_PlayTime_Title.Visible = true));
                    }
                    isowned = true;
                    PictureBoxOwned.Invoke((MethodInvoker)(() => PictureBoxOwned.Location = new Point(274, 221)));
                    LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Location = new Point(302, 221)));
                    PanelPrice.Invoke((MethodInvoker)(() => PanelPrice.Location = new Point(261, 241)));
                }
                else
                {
                    if (LoadData.Store.Type == "dlc")
                    {
                        LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Text = "Base Game Not Owned"));
                    }
                    else
                    {
                        LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Text = "Not Owned"));
                    }
                    PictureBoxOwned.Invoke((MethodInvoker)(() => PictureBoxOwned.Image = Properties.Resources.xmark_solid));
                    LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.ForeColor = Color.Red));
                    Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Visible = false));
                    Label_PlayTime_Title.Invoke((MethodInvoker)(() => Label_PlayTime_Title.Visible = false));
                    PictureBoxOwned.Invoke((MethodInvoker)(() => PictureBoxOwned.Location = new Point(278, 187)));
                    LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Location = new Point(306, 187)));
                    PanelPrice.Invoke((MethodInvoker)(() => PanelPrice.Location = new Point(261, 212)));
                }

            }
            else
            {
                LabelOwned.Invoke((MethodInvoker)(() => LabelOwned.Visible = false));
                Label_PlayTime.Invoke((MethodInvoker)(() => Label_PlayTime.Visible = false));
                Label_PlayTime_Title.Invoke((MethodInvoker)(() => Label_PlayTime_Title.Visible = false));
                PictureBoxOwned.Invoke((MethodInvoker)(() => PictureBoxOwned.Visible = false));
                PanelPrice.Invoke((MethodInvoker)(() => PanelPrice.Location = new Point(261, 185)));
            }
            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading Editions"));
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.BringToFront()));
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
                //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standardd")));
                EditionDiscount = LoadData.Store.Price.Discount_Percent;

                if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].price_in_cents_with_discount") != null)
                {
                    //PackagePrice = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount"));
                    if (Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].price_in_cents_with_discount")) > 0)
                    {
                        PackageIDs.Add(Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].packageid")));
                        //MessageBox.Show(PackageIDs[0].ToString());
                        //MessageBox.Show(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                    }

                }
                foreach (int id in PackageIDs)
                {
                    string EditionName;
                    GetData.PackageID = id;
                    GetData.ConnectToSteam.Package();
                    EditionName = LoadData.Store.Packages.TrimmedName;
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

                    if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount") != null)
                    {
                        if (Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount")) > 0)
                        {
                            PackageIDs.Add(Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].packageid")));
                        }

                    }
                    else
                    {
                        break;
                    }

                }

                foreach (int id in PackageIDs)
                {
                    string EditionName;
                    GetData.PackageID = id;
                    GetData.ConnectToSteam.Package();
                    EditionName = LoadData.Store.Packages.TrimmedName;
                    if (GetData.Appid == 1250410)
                    {
                        EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                        EditionName = EditionName.Replace("Game of the Year", "");
                        EditionName = EditionName.Replace("40th Anniversary", "");
                    }
                    else if (GetData.Appid == 1716740)
                    {
                        EditionName = EditionName.Replace("STARFIELD", "");
                        EditionName = EditionName.Replace("EDITION", "");
                        EditionName = EditionName.Replace("(Pre-purchase)", "");
                    }
                    else if (GetData.Appid == 534380)
                    {
                        EditionName = EditionName.Replace("Dying Light 2", "");
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
            }
            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Finalizing"));
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.BringToFront()));
            ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.SelectedIndex = 0));
            if (UserSettings.CheckOwned == true)
            {
                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default.UserSteamID);
                isowned = LoadData.Community.Isowned(GetData.Appid);
            }
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Size = new Size(1, 1)));
            Loading = false;
        }
        private void ComboBox_Editions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEdition = ComboBox_Editions.SelectedIndex;
            Task.Factory.StartNew(() => LoadEdition());
        }
        private void LoadEdition()
        {
            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Loading..."));
            Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = "Loading..."));
            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "Loading..."));
            //PanelStatus.Visible = true;
            //LabelStatus.Text = "Loading Edition...";
            if (!ComboBox_Editions.Text.Contains("Not Available") && !ComboBox_Editions.Text.Contains("Free"))
            {
                ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Focus()));
                if (!ComboBox_Editions.Text.Contains("Free"))
                {
                    EditionPrice = 0;
                    GetData.PackageID = PackageIDs.ElementAt(SelectedEdition);
                    GetData.ConnectToSteam.Package();

                    EditionPrice = LoadData.Store.Packages.Price.Final;
                    //EditionName = LoadData.Store.Packages.TrimmedName;
                }
                else { }
                EditionDiscount = LoadData.Store.Packages.Price.Discount_Percent;
                if (EditionPrice == 0)
                {
                    if (LoadData.Store.IsFree == true)
                    {
                        Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Free"));
                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "0"));
                    }
                    else
                    {
                        if (LoadData.Store.Price.AvailabletoPurchase != true)
                        {
                            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Not Available to Purchase"));
                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "0"));
                        }
                        else { }
                    }
                }
                else
                {
                    if (EditionDiscount == 0)
                    {
                        Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = string.Format("{0} {1}", EditionPrice.ToString("N"), UserSettings.Currency.Unit)));
                    }
                    else
                    {
                        if (SelectedEdition == 0)
                        {
                            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = string.Format("{0} {1} - {2}%", EditionPrice.ToString("N"), UserSettings.Currency.Unit, LoadData.Store.Price.Discount_Percent.ToString())));
                        }
                        else
                        {
                            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = string.Format("{0} {1} - {2}%", EditionPrice.ToString("N"), UserSettings.Currency.Unit, EditionDiscount.ToString())));
                        }
                    }
                    if (!GetData.TicketIsConnected)
                    {
                        GetData.ConnectToSteam.Market.TF2Ticket();
                    }
                    else { }

                    if (EditionPrice < LoadData.Market.Ticket.LowestSellOrderNoFee && UserSettings.ItemCalculationMode != "Key Only")
                    {
                        double Ticket_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Ticket.LowestSellOrderNoFee;
                        double Ticket_rounded = (int)Math.Ceiling(Math.Round(Ticket_count, 1));
                        double Remaining = (Ticket_rounded * LoadData.Market.Ticket.LowestSellOrderNoFee) - EditionPrice;

                        if (Convert.ToBoolean(UserSettings.CheckIRT) == true)
                        {
                            if (!GetData.IRTIsConnected)
                            {
                                GetData.IRT.KeyAndTicket();
                            }
                            else { }

                            if (LoadData.IRT.Ticket.Price != 0)
                            {
                                if (UserSettings.CalculateRemaining == true && UserSettings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Ticket ~ {1} {2}", Ticket_rounded.ToString(), (int)Remaining, UserSettings.Currency.Unit)));
                                    Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0}", (int)Math.Ceiling(Ticket_count) * LoadData.IRT.Ticket.Price)));
                                }
                                else
                                {
                                    Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Ticket", Ticket_rounded.ToString())));
                                    Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0}", (int)Math.Ceiling(Ticket_count) * LoadData.IRT.Ticket.Price)));
                                }
                            }
                            else
                            {
                                if (UserSettings.CalculateRemaining == true && UserSettings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("Ticket Count: {0} ~ {1} {2}", Ticket_rounded, (int)Remaining, UserSettings.Currency.Unit)));
                                    Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = "null"));
                                }
                                else
                                {
                                    Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = Ticket_rounded + " Ticket"));
                                }
                            }
                        }
                        else
                        {
                            if (UserSettings.CalculateRemaining == true && UserSettings.DeveloperMode == true)
                            {
                                Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Ticket ~ {1} {2}", Ticket_rounded, (int)Remaining, UserSettings.Currency.Unit)));
                            }
                            else
                            {
                                Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = Ticket_rounded + " Ticket"));
                            }
                        }
                    }
                    else
                    {
                        if (!GetData.TicketIsConnected)
                        {
                            GetData.ConnectToSteam.Market.TF2Key();
                        }
                        double key_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Key.LowestSellOrderNoFee;
                        double KeyRoundedUp = (int)Math.Ceiling(key_count);
                        double Remaining = (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee) - EditionPrice;
                        int KeyRoundedDown = (int)Math.Floor(key_count);
                        double DownRemaining = EditionPrice - (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee);
                        double Remaining2 = ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee) - EditionPrice;


                        if (UserSettings.DeveloperMode == true)
                        {
                            if (UserSettings.KeyCalcMode != "Rounded to Up" && UserSettings.ItemCalculationMode != "Smart")
                            {
                                KeyRoundedUp = Math.Round(key_count, 2);
                            }
                        }
                        else { }
                        if (Convert.ToBoolean(UserSettings.CheckIRT) == true)
                        {
                            if (!GetData.IRTIsConnected)
                            {
                                GetData.IRT.KeyAndTicket();
                            }
                            else { }
                            if (LoadData.IRT.Key.Price != 0)
                            {
                                if (UserSettings.DeveloperMode == true && UserSettings.CalculateRemaining == true)
                                {
                                    if (UserSettings.DeveloperMode == true && UserSettings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                        {
                                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key + 1 Ticket ~ {1} {2} ", KeyRoundedDown, string.Format("{0:n2}", Remaining2), UserSettings.Currency.Unit)));
                                            Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0} ", (KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price)));
                                            //FormulaCaption = string.Format("Key = {0} - {1}IRT | Ticket = {2} - {3}IRT => {4} Key({5}) + 1 Ticket({6}) = {7} {10} - {8} IRT ~ Remains {9} {10}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), LoadData.Market.Ticket.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Ticket.Price), KeyRoundedDown, (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee), LoadData.Market.Ticket.LowestSellOrderNoFee, ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee), String.Format("{0:n0}", ((KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price)), (int)Remaining2, Settings.Currency.Unit);
                                        }
                                        else
                                        {
                                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key ~ {1} {2}", KeyRoundedUp, string.Format("{0:n2}", Remaining), UserSettings.Currency.Unit)));
                                            Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.IRT.Key.Price)));
                                            //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee), String.Format("{0:n0}", (KeyRoundedUp * LoadData.IRT.Key.Price)), (int)Remaining, Settings.Currency.Unit);
                                        }

                                    }
                                    else
                                    {
                                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key ~ {1} {2}", KeyRoundedUp, string.Format("{0:n2}", Remaining), UserSettings.Currency.Unit)));
                                        Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.IRT.Key.Price)));
                                        //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee), String.Format("{0:n0}", (KeyRoundedUp * LoadData.IRT.Key.Price)), (int)Remaining, Settings.Currency.Unit);
                                    }
                                }
                                else
                                {
                                    if (UserSettings.DeveloperMode == true && UserSettings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                        {
                                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key + 1 Ticket", KeyRoundedDown)));
                                            Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0} ", (KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price)));
                                        }
                                        else
                                        {
                                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key", KeyRoundedUp)));
                                            Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.IRT.Key.Price)));
                                        }
                                    }
                                    else
                                    {
                                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key", KeyRoundedUp)));
                                        Label_IRT.Invoke((MethodInvoker)(() => Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.IRT.Key.Price)));
                                    }
                                    //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), KeyRoundedUp, KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee, KeyRoundedUp * LoadData.IRT.Key.Price);
                                }

                            }
                            else
                            {
                                if (UserSettings.DeveloperMode == true && UserSettings.CalculateRemaining == true)
                                {
                                    if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                    {
                                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key + 1 Ticket ~ {1} {2} ", KeyRoundedDown, string.Format("{0:n2}", Remaining2), UserSettings.Currency.Unit)));
                                    }
                                    else
                                    {
                                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key - {1} {2}", KeyRoundedUp, string.Format("{0:n2}", Remaining), UserSettings.Currency.Unit)));
                                    }
                                }
                                else
                                {
                                    Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = KeyRoundedUp + " Key"));
                                }
                            }
                        }
                        else
                        {
                            if (UserSettings.DeveloperMode == true && UserSettings.CalculateRemaining == true)
                            {
                                Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = string.Format("{0} Key - {1} {2}", KeyRoundedUp, (int)Remaining, UserSettings.Currency.Unit)));
                            }
                            else
                            {
                                Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = KeyRoundedUp + " Key"));
                            }
                        }
                    }
                }
            }
            else
            {
                if (LoadData.Store.IsFree == true)
                {
                    Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Free"));
                    Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "0"));
                }
                else
                {
                    if (LoadData.Store.Price.AvailabletoPurchase != true)
                    {
                        Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Not Available to Purchase"));
                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "0"));
                    }
                    else { }
                }
            }
            //PanelStatus.Visible = false;
        }

        private void Label_DLC_Click(object sender, EventArgs e)
        {

        }
        private void DropDownRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Loading)
            {
                if (DropDownRegion.Text.Contains("United States"))
                {
                    UserSettings.Currency.Name = "USD";
                    UserSettings.Currency.Number = 1;
                    UserSettings.Currency.ISO = "US";
                    UserSettings.Currency.Unit = "$";
                }
                if (DropDownRegion.Text.Contains("Britain"))
                {
                    UserSettings.Currency.Name = "Pound";
                    UserSettings.Currency.Number = 2;
                    UserSettings.Currency.ISO = "GB";
                    UserSettings.Currency.Unit = "£";
                }
                if (DropDownRegion.Text.Contains("Europe"))
                {
                    UserSettings.Currency.Name = "Euro";
                    UserSettings.Currency.Number = 3;
                    UserSettings.Currency.ISO = "NL";
                    UserSettings.Currency.Unit = "€";
                }
                if (DropDownRegion.Text.Contains("China"))
                {
                    UserSettings.Currency.Name = "Yuan";
                    UserSettings.Currency.Number = 23;
                    UserSettings.Currency.ISO = "CN";
                    UserSettings.Currency.Unit = "Yuan";
                }
                if (DropDownRegion.Text.Contains("Argentina"))
                {
                    UserSettings.Currency.Name = "USD";
                    UserSettings.Currency.Number = 1;
                    UserSettings.Currency.ISO = "AR";
                    UserSettings.Currency.Unit = "$";
                }
                if (DropDownRegion.Text.Contains("Turkey"))
                {
                    UserSettings.Currency.Name = "USD";
                    UserSettings.Currency.Number = 1;
                    UserSettings.Currency.ISO = "TR";
                    UserSettings.Currency.Unit = "$";
                }
                if (DropDownRegion.Text.Contains("Russia"))
                {
                    UserSettings.Currency.Name = "Ruble";
                    UserSettings.Currency.Number = 5;
                    UserSettings.Currency.ISO = "RU";
                    UserSettings.Currency.Unit = "Py6";
                }
                if (DropDownRegion.Text.Contains("Brazil"))
                {
                    UserSettings.Currency.Name = "Real";
                    UserSettings.Currency.Number = 7;
                    UserSettings.Currency.ISO = "BR";
                    UserSettings.Currency.Unit = "R$";
                }
                if (DropDownRegion.Text.Contains("Ukraine"))
                {
                    UserSettings.Currency.Name = "hryvnia";
                    UserSettings.Currency.Number = 18;
                    UserSettings.Currency.ISO = "UA";
                    UserSettings.Currency.Unit = "₴";
                }
                if (DropDownRegion.Text.Contains("India"))
                {
                    UserSettings.Currency.Name = "Rupee";
                    UserSettings.Currency.Number = 24;
                    UserSettings.Currency.ISO = "IN";
                    UserSettings.Currency.Unit = "₹";
                }
                if (DropDownRegion.Text.Contains("Kazakhstan"))
                {
                    UserSettings.Currency.Name = "Tenge";
                    UserSettings.Currency.Number = 37;
                    UserSettings.Currency.ISO = "KZ";
                    UserSettings.Currency.Unit = "₸";
                }
                if (DropDownRegion.Text.Contains("Philippines"))
                {
                    UserSettings.Currency.Name = "Peso";
                    UserSettings.Currency.Number = 12;
                    UserSettings.Currency.ISO = "PH";
                    UserSettings.Currency.Unit = "₱";
                }
                if (DropDownRegion.Text.Contains("CIS - USD"))
                {
                    UserSettings.Currency.Name = "USD";
                    UserSettings.Currency.Number = 1;
                    UserSettings.Currency.ISO = "AZ";
                    UserSettings.Currency.Unit = "$";
                }
                if (DropDownRegion.Text.Contains("South Asia - USD"))
                {
                    UserSettings.Currency.Name = "USD";
                    UserSettings.Currency.Number = 1;
                    UserSettings.Currency.ISO = "PK";
                    UserSettings.Currency.Unit = "$";
                }
                GetData.KeyIsConnected = false;
                GetData.TicketIsConnected = false;

                Task.Factory.StartNew(() => GetData.ConnectToSteam.Market.TF2Key());
                Task.Factory.StartNew(() => GetData.ConnectToSteam.Market.TF2Ticket());

                Task.Factory.StartNew(() => LoadEdition());
            }
        }
        private void OpenSteam_Click(object sender, EventArgs e)
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
        private void OpenSteamDB_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamdb.info/app/" + GetData.Appid);
        }
        private void OpenPCGW_Click(object sender, EventArgs e)
        {
            Process.Start("https://pcgamingwiki.com/api/appid.php?appid=" + GetData.Appid);
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
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround, BackGround2;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.Cello;
                BackGround2 = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                OpenSteamDBIcon.Image = Properties.Resources.steamdb_logo_White;
                PictureBoxLoading.Image = Properties.Resources.SteamPulse_Logo_White;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.AthenGray;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackGround2 = GlobalVariables.Colors.Light.White;
                OpenSteamDBIcon.Image = Properties.Resources.steamdb_logo;
                PictureBoxLoading.Image = Properties.Resources.SteamPulse_Logo;
            }
            BackColor = BackGround2;
            LabelOwned.ForeColor = ForeGround;
            Label_BaseGame.ForeColor = ForeGround;
            Label_Dev.ForeColor = ForeGround;
            Label_Dev_Title.ForeColor = ForeGround;
            Label_DLC.ForeColor = ForeGround;
            Label_DLC_TItle.ForeColor = ForeGround;
            Label_Edition_Title.ForeColor = ForeGround;
            Label_IRT.ForeColor = ForeGround;
            Label_IRT_Title.ForeColor = ForeGround;
            Label_KeyCount.ForeColor = ForeGround;
            Label_KeyCount_Title.ForeColor = ForeGround;
            Label_Player_Count.ForeColor = ForeGround;
            Label_Player_Count_Title.ForeColor = ForeGround;
            Label_PlayTime.ForeColor = ForeGround;
            Label_PlayTime_Title.ForeColor = ForeGround;
            Label_Price.ForeColor = ForeGround;
            Label_Price_Title.ForeColor = ForeGround;
            Label_Publisher.ForeColor = ForeGround;
            Label_Publisher_Title.ForeColor = ForeGround;
            Label_Release.ForeColor = ForeGround;
            Label_Release_Title.ForeColor = ForeGround;
            Label_Status.ForeColor = ForeGround;
            OpenSteam.ForeColor = ForeGround;
            OpenSteamDB.ForeColor = ForeGround;
            OpenPCGW.ForeColor = ForeGround;
            DropDownRegion.BackgroundColor = BackGround2;
            DropDownRegion.BorderColor = BackGround2;
            DropDownRegion.ForeColor = ForeGround;
            DropDownRegion.IndicatorColor = ForeGround;
            ComboBox_Editions.BackgroundColor = BackGround2;
            ComboBox_Editions.BorderColor = BackGround2;
            ComboBox_Editions.ForeColor = ForeGround;
            ComboBox_Editions.IndicatorColor = ForeGround;
            Label_Name.ForeColor = ForeGround;
        }

        private void PictureBoxBaseGame_Click(object sender, EventArgs e)
        {
            if (BaseGameOwned)
            {
                Process.Start("steam://nav/games/details/" + LoadData.Store.RawData.SelectToken("$." + GetData.Appid + ".data.fullgame.appid"));
            }
            else
            {
                Process.Start("steam://openurl/https://store.steampowered.com/app/" + LoadData.Store.RawData.SelectToken("$." + GetData.Appid + ".data.fullgame.appid"));
            }
        }
    }
}