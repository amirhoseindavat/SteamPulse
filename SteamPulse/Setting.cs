#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.6.4 Revision 13

#endregion

using Newtonsoft.Json.Linq;
using SteamAPI;
using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse
{
    public partial class Setting : Form
    {
        public static Boolean DarkMode;
        public static string FormParent;
        protected Boolean SettingChanged = false;
        protected Boolean ISLoading = true;
        protected Boolean ThreadISLoading = true;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Setting()
        {
            InitializeComponent();
            /*UserInfoProfile.Controls.Add(PictureBoxFrame);
            PictureBoxFrame.Location = new Point(-7, -7);
            PictureBoxFrame.BackColor = Color.Transparent;*/
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
        private void Setting_Load(object sender, EventArgs e)
        {
            PanelStatus.Size = new Size(378, 100);
            string SettingsProfileID = Properties.Settings.Default.UserSteamID.ToString();
            if (SettingsProfileID != "0")
            {
                PanelLogin.Visible = false;
                PanelStatus.Visible = true;
                LabelStatus.Text = "Loading Data...";
                BackgroundWorker.RunWorkerAsync();
            }
            else { }
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
            else
            {
                Settings.Currency.Name = "USD";
                Settings.Currency.Number = 1;
                Settings.Currency.ISO = "US";
                Settings.Currency.Unit = "$";
                DropDownRegion.SelectedIndex = 0;
            }

            if (Settings.MarketUpdateTime == 30)
            {
                DropDownMarketInterval.SelectedIndex = 0;
            }

            if (Settings.MarketUpdateTime == 45)
            {
                DropDownMarketInterval.SelectedIndex = 1;
            }

            if (Settings.MarketUpdateTime == 60)
            {
                DropDownMarketInterval.SelectedIndex = 2;
            }

            if (Settings.MarketUpdateTime == 120)
            {
                DropDownMarketInterval.SelectedIndex = 3;
            }

            ToggleIRT.Checked = Settings.CheckIRT;
            ToggleOwned.Checked = Settings.CheckOwned;

            ToggleDeveloper.Checked = Settings.DeveloperMode;

            ToggleUpdate.Checked = Settings.CheckUpdate;

            ToggleDarkMode.Checked = Settings.DarkMode;

            ToggleBeta.Enabled = Settings.CheckUpdate;
            if (ToggleBeta.Enabled == false)
            {
                ToggleBeta.ToggleStateOff.BackColor = Color.Gray;
                ToggleBeta.ToggleStateOff.BorderColor = Color.Gray;
            }
            else
            {
                ToggleBeta.Checked = Settings.InstallBeta;
                ToggleBeta.ToggleStateOff.BackColor = Color.FromArgb(191, 191, 191);
                ToggleBeta.ToggleStateOff.BorderColor = Color.FromArgb(191, 191, 191);
            }

            if (Settings.StartingPage == "Main")
            {
                DropDownStarting.SelectedIndex = 0;
            }

            if (Settings.StartingPage == "Market")
            {
                DropDownStarting.SelectedIndex = 1;
            }

            if (Settings.StartingPage == "Calculator")
            {
                DropDownStarting.SelectedIndex = 2;
            }

            DarkMode = Convert.ToBoolean(Properties.Settings.Default.DarkMode);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            Main.SettingisUpdated = false;
            LiveMarketPrice.SettingisUpdated = false;
            ISLoading = false;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DropDownRegion.Text))
            {
                if (Convert.ToBoolean(Properties.Settings.Default.FirstTime) == true)
                {
                    Properties.Settings.Default.FirstTime = false;
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text != "")
            {
                PanelLogin.Visible = false;
                PanelStatus.Visible = true;
                LabelStatus.Text = "Logging in...";
                if (SteamIDFinder(TextBoxLogin.Text) == "Can't Connect")
                {
                    PanelStatus.Visible = true;
                    LabelStatus.Text = "Can't Login, CLick To Retry.";
                    ToggleOwned.Enabled = false;
                    ToggleOwned.Checked = false;
                    Settings.CheckOwned = ToggleOwned.Checked;
                    ToggleOwned.ToggleStateOff.BackColor = Color.Gray;
                    ToggleOwned.ToggleStateOff.BorderColor = Color.Gray;
                }
                else
                {

                    string SettingsProfileID = SteamIDFinder(TextBoxLogin.Text);
                    if (SettingsProfileID != "0")
                    {
                        LabelStatus.Text = "Logging in...";
                        Properties.Settings.Default.UserSteamID = SettingsProfileID;
                        Properties.Settings.Default.Save();
                        ThreadISLoading = false;
                        BackgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        PanelStatus.Visible = true;
                        LabelStatus.Text = "Can't Login, CLick To Retry.";
                        ToggleOwned.Enabled = false;
                        ToggleOwned.Checked = false;
                        Settings.CheckOwned = ToggleOwned.Checked;
                        ToggleOwned.ToggleStateOff.BackColor = Color.Gray;
                        ToggleOwned.ToggleStateOff.BorderColor = Color.Gray;
                    }
                }

            }
            else
            {
                TextBoxLogin.BorderColorIdle = Color.Red;
            }
        }
        /*private void LoginSteam()
        {
            
        }*/
        private string SteamIDFinder(string value)
        {
            try
            {
                string UserID = "";
                if (value.Contains("steamcommunity.com"))
                {
                    if (value.Contains("id"))
                    {
                        Uri address = new Uri(value);
                        string UserSteam = address.Segments[2].Replace("/", "");
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        XmlDocument Data = new XmlDocument();
                        Data.Load("https://steamcommunity.com/id/" + UserSteam + "/?xml=1");
                        XmlElement Root = Data.DocumentElement;
                        XmlNodeList Nodes = Root.SelectNodes("/profile");

                        foreach (XmlNode Node in Nodes)
                        {
                            UserID = Node["steamID64"].InnerText;
                        }
                    }
                    else if (value.Contains("profiles"))
                    {
                        Uri address = new Uri(value);
                        UserID = address.Segments[2].Replace("/", "");
                    }
                    return UserID;
                }
                else if (Regex.IsMatch(value, @"^\d"))
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    XmlDocument Data = new XmlDocument();
                    Data.Load("https://steamcommunity.com/profiles/" + value + "/?xml=1");
                    XmlElement Root = Data.DocumentElement;
                    XmlNodeList Nodes = Root.SelectNodes("/profile");

                    foreach (XmlNode Node in Nodes)
                    {
                        UserID = Node["steamID64"].InnerText;
                    }
                    return UserID;
                }
                else
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    XmlDocument Data = new XmlDocument();
                    Data.Load("https://steamcommunity.com/id/" + value + "/?xml=1");
                    XmlElement Root = Data.DocumentElement;
                    XmlNodeList Nodes = Root.SelectNodes("/profile");

                    foreach (XmlNode Node in Nodes)
                    {
                        UserID = Node["steamID64"].InnerText;
                    }
                    return UserID;
                }
            }
            catch
            {
                return "Can't Connect";
            }
        }
        private void UserInfoLogout_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            PanelStatus.Visible = true;
            TextBoxLogin.Text = "";
            Properties.Settings.Default.UserSteamID = "0";
            Properties.Settings.Default.Save();
            Logger.LogSteamLogin("Logout", Properties.Settings.Default.UserSteamID.ToString());
            ToggleOwned.Enabled = false;
            ToggleOwned.Checked = false;
            Settings.CheckOwned = ToggleOwned.Checked;
            ToggleOwned.ToggleStateOff.BackColor = Color.Gray;
            ToggleOwned.ToggleStateOff.BorderColor = Color.Gray;
        }
        private void DropDownRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == true)
            {

            }
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
                Main.SettingisUpdated = true;
                Logger.LogSetting("Region", Properties.Settings.Default.CurrencyISO.ToString());
            }
        }
        private void DropDownMarketInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownMarketInterval.Text.Contains("30"))
            {
                Settings.MarketUpdateTime = 30;
            }

            if (DropDownMarketInterval.Text.Contains("45"))
            {
                Settings.MarketUpdateTime = 45;
            }

            if (DropDownMarketInterval.Text.Contains("60"))
            {
                Settings.MarketUpdateTime = 60;
            }

            if (DropDownMarketInterval.Text.Contains("120"))
            {
                Settings.MarketUpdateTime = 120;
            }

            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Logger.LogSetting("Market Update Time", Properties.Settings.Default.MarketUpdateTime.ToString());
            }
        }
        private void ToggleIRT_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.CheckIRT = ToggleIRT.Checked;
            Main.SettingisUpdated = true;
            LiveMarketPrice.SettingisUpdated = true;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Logger.LogSetting("Calculate IRT Price", Properties.Settings.Default.CalculateIRT.ToString());
            }
        }
        private void ToggleOwned_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.CheckOwned = ToggleOwned.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Logger.LogSetting("Check For Owned Games", Properties.Settings.Default.CheckOwned.ToString());
            }
        }
        private void ToggleDarkMode_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.DarkMode = ToggleDarkMode.Checked;
            ChangeTheme(ToggleDarkMode.Checked);
            Main.DarkMode = ToggleDarkMode.Checked;
            LiveMarketPrice.DarkMode = ToggleDarkMode.Checked;
            Calculator.DarkMode = ToggleDarkMode.Checked;
            About.DarkMode = ToggleDarkMode.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Logger.LogSetting("Dark Mode", Properties.Settings.Default.DarkMode.ToString());
            }
        }
        private void ToggleUpdate_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.CheckUpdate = ToggleUpdate.Checked;
            if (ToggleUpdate.Checked == true)
            {
                ToggleBeta.Enabled = true;
                ToggleBeta.ToggleStateOff.BackColor = Color.FromArgb(191, 191, 191);
                ToggleBeta.ToggleStateOff.BorderColor = Color.FromArgb(191, 191, 191);
            }
            else
            {
                ToggleBeta.Enabled = false;
                ToggleBeta.Checked = false;
                ToggleBeta.ToggleStateOff.BackColor = Color.Gray;
                ToggleBeta.ToggleStateOff.BorderColor = Color.Gray;
                Settings.InstallBeta = ToggleBeta.Checked;
            }
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Logger.LogSetting("Check For Update", Properties.Settings.Default.CheckUpdate.ToString());
            }
        }
        private void ToggleBeta_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.InstallBeta = ToggleBeta.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Logger.LogSetting("Check For Beta", Properties.Settings.Default.InstallBeta.ToString());
            }
        }
        private void DropDownStarting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownStarting.Text.Contains("Main"))
            {
                Settings.StartingPage = "Main";
            }

            if (DropDownStarting.Text.Contains("Market"))
            {
                Settings.StartingPage = "Market";
            }

            if (DropDownStarting.Text.Contains("Calculator"))
            {
                Settings.StartingPage = "Calculator";
            }
        }
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ChangeTheme(Boolean Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                this.BackColor = GlobalVariables.Colors.Dark.Cello;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
            }
            PanelHeader.BackgroundColor = BackGround;
            LabelHeader.ForeColor = ForeGround;
            PanelLogin.BackgroundColor = BackGround;
            LabelLogin.ForeColor = ForeGround;
            PanelUserINfo.BackgroundColor = BackGround;
            UserInfoGames.ForeColor = ForeGround;
            UserInfoLevel.ForeColor = ForeGround;
            UserInfoLogout.ForeColor = ForeGround;
            UserInfoName.ForeColor = ForeGround;
            PanelRegion.BackgroundColor = BackGround;
            LabelRegion.ForeColor = ForeGround;
            PanelUpdateInterval.BackgroundColor = BackGround;
            LabelMarketInterval.ForeColor = ForeGround;
            PanelStarting.BackgroundColor = BackGround;
            LabelStarting.ForeColor = ForeGround;
            PanelIRT.BackgroundColor = BackGround;
            LabelIRT.ForeColor = ForeGround;
            PanelOwned.BackgroundColor = BackGround;
            LabelOwned.ForeColor = ForeGround;
            PanelDarkMode.BackgroundColor = BackGround;
            LabelDarkMode.ForeColor = ForeGround;
            PanelUpdate.BackgroundColor = BackGround;
            LabelUpdate.ForeColor = ForeGround;
            PanelBeta.BackgroundColor = BackGround;
            LabelBeta.ForeColor = ForeGround;
            PanelStatus.BackgroundColor = BackGround;
            LabelStatus.ForeColor = ForeGround;
            PanelDeveloper.BackgroundColor = BackGround;
            LabelDeveloper.ForeColor = ForeGround;
        }
        private void OnlineStatus_MouseEnter(object sender, EventArgs e)
        {
        }
        private void OnlineStatus_MouseLeave(object sender, EventArgs e)
        {
        }
        private void OnlineStatus_MouseHover(object sender, EventArgs e)
        {
        }

        private void ToggleDeveloper_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.DeveloperMode = ToggleDeveloper.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                    Logger.LogDeveloper(ToggleDeveloper.Checked);
            }
            Main.SettingisUpdated = true;
        }

        private void LabelStatus_Click(object sender, EventArgs e)
        {
            PanelLogin.Visible = true;
            //PanelStatus.Visible = true;
            Properties.Settings.Default.UserSteamID = "0";
            Properties.Settings.Default.Save();

        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string SteamID = Properties.Settings.Default.UserSteamID.ToString();
            try
            {

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument Data = new XmlDocument();
                Data.Load("https://steamcommunity.com/profiles/" + SteamID + "/?xml=1");
                XmlElement Root = Data.DocumentElement;
                XmlNodeList Nodes = Root.SelectNodes("/profile");
                string ProfileName = "";
                string ProfileAddress = "";
                //string avatarframe = "";

                foreach (XmlNode Node in Nodes)
                {
                    ProfileName = Node["steamID"].InnerText;
                    ProfileAddress = Node["avatarFull"].InnerText;
                }
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();

                JObject JsonObjectLevel = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetSteamLevel/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID));
                JToken Level = JsonObjectLevel.SelectToken(".response.player_level");

                JObject JsonObjectGameCount = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID+ "&include_played_free_games=true&include_free_sub=true&skip_unvetted_apps=true"));
                JToken Gamecount = JsonObjectGameCount.SelectToken(".response.game_count");
                string gamecountjson = JsonObjectGameCount.ToString();

                UserInfoName.Invoke((MethodInvoker)(() => UserInfoName.Text = ProfileName));

                UserInfoLevel.Invoke((MethodInvoker)(() => UserInfoLevel.Text = string.Format("Level : {0}", Level)));

                //avatarframe = LoadData.Community.AvatarFrame(SteamID);
                if (Gamecount != null)
                {
                    UserInfoGames.Invoke((MethodInvoker)(() => UserInfoGames.Text = string.Format("Games Owned : {0}", Gamecount)));
                }
                else
                {
                    UserInfoGames.Invoke((MethodInvoker)(() => UserInfoGames.Text = "Games Owned : Private"));
                }

                try
                {
                    UserInfoProfile.Invoke((MethodInvoker)(() => UserInfoProfile.Load(ProfileAddress)));
                    //PictureBoxFrame.Invoke((MethodInvoker)(() => PictureBoxFrame.Load(avatarframe)));
                }
                catch
                {
                    UserInfoProfile.Invoke((MethodInvoker)(() => UserInfoProfile.Image = Properties.Resources.DefaultAvatar));
                }


                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));
                if (ThreadISLoading == true)
                {
                }
                else
                {
                    Properties.Settings.Default.UserSteamID = SteamID;
                    /*Properties.Settings.Default.UserLevel = Level.ToString();
                    Properties.Settings.Default.UserGames = Gamecount.ToString();
                    Properties.Settings.Default.UserAvatar = ProfileAddress;
                    Properties.Settings.Default.UserName = ProfileName;*/

                    Properties.Settings.Default.Save();
                    if(ISLoading != true)
                    {
                        Logger.LogSteamLogin("Logined", Properties.Settings.Default.UserSteamID.ToString());
                    }

                }
                //true
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.Enabled = true));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BackColor = Color.FromArgb(191, 191, 191)));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BorderColor = Color.FromArgb(191, 191, 191)));
            }
            catch (Exception ex)
            {
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = String.Format("{0}, CLick To Retry.", ex.Message)));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.Enabled = false));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.Checked = false));
                Settings.CheckOwned = ToggleOwned.Checked;
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BackColor = Color.Gray));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BorderColor = Color.Gray));
            }
            ThreadISLoading = false;
        }
    }
    public class Settings
    {
        public struct Currency
        {
            public static string Name
            {
                get
                {
                    return Properties.Settings.Default.CurrencyName;
                }
                set
                {
                    Properties.Settings.Default.CurrencyName = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static int Number
            {
                get
                {
                    return Convert.ToInt32(Properties.Settings.Default.CurrencyNumber);
                }
                set
                {
                    Properties.Settings.Default.CurrencyNumber = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static string ISO
            {
                get
                {
                    return Properties.Settings.Default.CurrencyISO;
                }
                set
                {
                    Properties.Settings.Default.CurrencyISO = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static string Unit
            {
                get
                {
                    return Properties.Settings.Default.CurrencyUnit;
                }
                set
                {
                    Properties.Settings.Default.CurrencyUnit = value;
                    Properties.Settings.Default.Save();
                }
            }
        }
        public static string CalculatorMode
        {
            get
            {
                return Properties.Settings.Default.CalculatorMode;
            }
            set
            {
                Properties.Settings.Default.CalculatorMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int MarketUpdateTime
        {
            get
            {
                return Convert.ToInt32(Properties.Settings.Default.MarketUpdateTime);
            }
            set
            {
                Properties.Settings.Default.MarketUpdateTime = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean CheckIRT
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.CalculateIRT);
            }
            set
            {
                Properties.Settings.Default.CalculateIRT = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean CheckOwned
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.CheckOwned);
            }
            set
            {
                Properties.Settings.Default.CheckOwned = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean DarkMode
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.DarkMode);
            }
            set
            {
                Properties.Settings.Default.DarkMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean CheckUpdate
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.CheckUpdate);
            }
            set
            {
                Properties.Settings.Default.CheckUpdate = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string ItemCalculationMode
        {
            get
            {
                return Properties.Settings.Default.ItemCalculationMode;
            }
            set
            {
                Properties.Settings.Default.ItemCalculationMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int DefualtDlcCount
        {
            get
            {
                return Properties.Settings.Default.DefaultDLCCount;
            }
            set
            {
                Properties.Settings.Default.DefaultDLCCount = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean InstallBeta
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.InstallBeta);
            }
            set
            {
                Properties.Settings.Default.InstallBeta = value;
                Properties.Settings.Default.Save();
            }

        }
        public static string StartingPage
        {
            get
            {
                return Properties.Settings.Default.StartingPage;
            }
            set
            {
                Properties.Settings.Default.StartingPage = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string KeyCalcMode
        {
            get
            {
                return Properties.Settings.Default.KeyCalcMode;
            }
            set
            {
                Properties.Settings.Default.KeyCalcMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean LoadDLCImage
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.LoadDLCImage);
            }
            set
            {
                Properties.Settings.Default.LoadDLCImage = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean CalculateRemaining
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.CalculateRemaining);
            }
            set
            {
                Properties.Settings.Default.CalculateRemaining = value;
                Properties.Settings.Default.Save();
            }
        }
        public static Boolean DeveloperMode
        {
            get
            {
                return Convert.ToBoolean(Properties.Settings.Default.DeveloperMode);
            }
            set
            {
                Properties.Settings.Default.DeveloperMode = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
