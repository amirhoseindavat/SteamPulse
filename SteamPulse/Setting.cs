#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.6.4 Revision 14

#endregion

using Newtonsoft.Json.Linq;
using SteamPulse.Logger;
using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
using System;
using System.Diagnostics;
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
        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        public static bool DarkMode;
        public static string FormParent;
        protected bool SettingChanged = false;
        protected bool ISLoading = true;
        protected bool ThreadISLoading = true;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string OnlineStatusSteam = "";
        //private string SteamID;
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
                //SteamID = Properties.Settings.Default.UserSteamID;
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
            else if (Settings.Currency.Name == "hryvnia")
            {
                DropDownRegion.SelectedIndex = 8;
            }
            else if (Settings.Currency.Name == "Rupee")
            {
                DropDownRegion.SelectedIndex = 9;
            }
            else if (Settings.Currency.Name == "Tenge")
            {
                DropDownRegion.SelectedIndex = 10;
            }
            else if (Settings.Currency.Name == "Peso")
            {
                DropDownRegion.SelectedIndex = 11;
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

            if (Settings.SystemDarkMode)
            {
                DropDownDarkMode.SelectedIndex = 2;
            }
            else
            {
                if (Settings.DarkMode)
                {
                    DropDownDarkMode.SelectedIndex = 1;
                }
                else
                {
                    DropDownDarkMode.SelectedIndex = 0;
                }
            }

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
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text != "")
            {
                PanelLogin.Visible = false;
                PanelStatus.Visible = true;
                LabelStatus.Font = new Font(LabelStatus.Font.FontFamily, 13.0F, LabelStatus.Font.Style);
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
                        //SteamID = Properties.Settings.Default.UserSteamID;
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
                    Properties.Settings.Default.UserSteamID = UserID;
                    Properties.Settings.Default.Save();
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
                    Properties.Settings.Default.UserSteamID = UserID;
                    Properties.Settings.Default.Save();

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
            Log.LogSteamLogin("Logout", Properties.Settings.Default.UserSteamID.ToString());
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
                if (DropDownRegion.Text.Contains("Ukraine"))
                {
                    Settings.Currency.Name = "hryvnia";
                    Settings.Currency.Number = 18;
                    Settings.Currency.ISO = "UA";
                    Settings.Currency.Unit = "₴";
                }
                if (DropDownRegion.Text.Contains("India"))
                {
                    Settings.Currency.Name = "Rupee";
                    Settings.Currency.Number = 24;
                    Settings.Currency.ISO = "IN";
                    Settings.Currency.Unit = "₹";
                }
                if (DropDownRegion.Text.Contains("Kazakhstan"))
                {
                    Settings.Currency.Name = "Tenge";
                    Settings.Currency.Number = 37;
                    Settings.Currency.ISO = "KZ";
                    Settings.Currency.Unit = "₸";
                }
                if (DropDownRegion.Text.Contains("Philippines"))
                {
                    Settings.Currency.Name = "Peso";
                    Settings.Currency.Number = 12;
                    Settings.Currency.ISO = "PH";
                    Settings.Currency.Unit = "₱";
                }

                Main.SettingisUpdated = true;
                Log.LogSetting("Region", Properties.Settings.Default.CurrencyISO.ToString());
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
                Log.LogSetting("Market Update Time", Properties.Settings.Default.MarketUpdateTime.ToString());
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
                Log.LogSetting("Calculate IRT Price", Properties.Settings.Default.CalculateIRT.ToString());
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
                Log.LogSetting("Check For Owned Games", Properties.Settings.Default.CheckOwned.ToString());
            }
        }
        private void ToggleDarkMode_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

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
                Log.LogSetting("Check For Update", Properties.Settings.Default.CheckUpdate.ToString());
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
                Log.LogSetting("Check For Beta", Properties.Settings.Default.InstallBeta.ToString());
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
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                BackColor = GlobalVariables.Colors.Dark.Cello;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
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
        private void ToggleDeveloper_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            Settings.DeveloperMode = ToggleDeveloper.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Log.LogDeveloper(ToggleDeveloper.Checked);
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
            try
            {
                string SteamID = Properties.Settings.Default.UserSteamID;

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
                    //ProfileAddress = "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/items/2459330/4fd363ecf75460a2e94eef79ad57ce70759fb071.gif";
                    //avatarframe = "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/items/2459330/99dca1cd53a58ed9b05a4d6e7bb54942bc49a2e8.png";
                }



                Color OnlineColor = Color.FromArgb(3, 169, 244);
                Color AwayColor = Color.FromArgb(129, 212, 250);
                Color IngameColor = Color.FromArgb(76, 175, 80);
                Color OfflineColor = Color.FromArgb(191, 191, 191);

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();

                JObject JsonObjecAvatar = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetAnimatedAvatar/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID));
                if(JsonObjecAvatar.SelectToken(".response.avatar.image_small") != null)
                {
                    ProfileAddress = "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/" + JsonObjecAvatar.SelectToken(".response.avatar.image_small").ToString();
                }

                JObject JsonObjectLevel = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetSteamLevel/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID));
                JToken Level = JsonObjectLevel.SelectToken(".response.player_level");

                JObject JsonObjectGameCount = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID + "&include_played_free_games=true&include_free_sub=true&skip_unvetted_apps=false"));
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
                    /*PictureBoxAvatarFrame.Invoke((MethodInvoker)(() => PictureBoxAvatarFrame.Load(avatarframe)));
                    PictureBoxAvatarFrame.Invoke((MethodInvoker)(() => PictureBoxAvatarFrame.BringToFront()));
                    PictureBoxAvatarFrame.Invoke((MethodInvoker)(() => PictureBoxAvatarFrame.BackColor = Color.Transparent));
                    PictureBoxAvatarFrame.Invoke((MethodInvoker)(() => PictureBoxAvatarFrame.Parent = UserInfoProfile));
                    PictureBoxAvatarFrame.Invoke((MethodInvoker)(() => PictureBoxAvatarFrame.Location = new Point(0, 0)));*/
                    //PictureBoxFrame.Invoke((MethodInvoker)(() => PictureBoxFrame.Load(avatarframe)));
                }
                catch
                {
                    UserInfoProfile.Invoke((MethodInvoker)(() => UserInfoProfile.Image = Properties.Resources.DefaultAvatar));
                }

                GetData.ConnectToSteam.Community.GetPlayerSummaries(SteamID);

                /*Bitmap Bmp = new Bitmap(Width, Height);
                using (Graphics gfx = Graphics.FromImage(Bmp))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(redvalue, greenvalue, bluevalue)))
                {
                    gfx.FillRectangle(brush, 0, 0, width, height);
                }*/

                if (LoadData.Community.UserStatus.OnlineStatus != -1)
                {
                    if (LoadData.Community.UserStatus.OnlineStatus == 1)
                    {
                        onlineStatus.Invoke((MethodInvoker)(() => onlineStatus.ForeColor = OnlineColor));
                        OnlineStatusSteam = "Online";
                    }
                    else if (LoadData.Community.UserStatus.OnlineStatus == 85)
                    {
                        onlineStatus.Invoke((MethodInvoker)(() => onlineStatus.ForeColor = IngameColor));
                        OnlineStatusSteam = string.Format("In-Game: {0}", LoadData.Community.UserStatus.CurrentPlayingGame);
                    }
                    else if (LoadData.Community.UserStatus.OnlineStatus == 3)
                    {
                        onlineStatus.Invoke((MethodInvoker)(() => onlineStatus.ForeColor = AwayColor));
                        OnlineStatusSteam = "Away";
                    }
                    else
                    {
                        onlineStatus.Invoke((MethodInvoker)(() => onlineStatus.ForeColor = OfflineColor));
                        OnlineStatusSteam = "Offline";
                    }
                }
                else
                {
                    onlineStatus.Invoke((MethodInvoker)(() => onlineStatus.ForeColor = OfflineColor));
                    OnlineStatusSteam = "Offline";
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
                    if (ISLoading != true)
                    {
                        Log.LogSteamLogin("Logined", Properties.Settings.Default.UserSteamID.ToString());
                    }

                }
                //true
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.Enabled = true));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BackColor = Color.FromArgb(191, 191, 191)));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BorderColor = Color.FromArgb(191, 191, 191)));
            }
            catch (Exception ex)
            {
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Font = new Font(LabelStatus.Font.FontFamily, 10.0F, LabelStatus.Font.Style)));
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = string.Format("{0} \n Click To Retry.", ex.Message)));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.Enabled = false));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.Checked = false));
                Settings.CheckOwned = ToggleOwned.Checked;
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BackColor = Color.Gray));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BorderColor = Color.Gray));
            }
            ThreadISLoading = false;
        }

        private void OnlineStatus_MouseHover(object sender, EventArgs e)
        {
            if (OnlineStatusSteam != "")
            {
                ToolTip.SetToolTip(onlineStatus, OnlineStatusSteam);
            }
            else { }
        }

        private void DropDownDarkMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownDarkMode.SelectedIndex == 2)
            {
                Settings.SystemDarkMode = true;
                Settings.DarkMode = ShouldSystemUseDarkMode();
            }
            else
            {
                Settings.SystemDarkMode = false;
                if (DropDownDarkMode.SelectedIndex == 1)
                {
                    Settings.DarkMode = true;
                    ChangeTheme(true);
                    Main.DarkMode = true;
                    LiveMarketPrice.DarkMode = true;
                    Calculator.DarkMode = true;
                    Cards.AboutPanel.DarkMode = true;
                    if (ISLoading == true)
                    {
                        SettingChanged = false;
                    }
                    else
                    {
                        Log.LogSetting("Dark Mode", Properties.Settings.Default.DarkMode.ToString());
                    }
                }
                else
                {
                    Settings.DarkMode = false;
                    ChangeTheme(default);
                    Main.DarkMode = false;
                    LiveMarketPrice.DarkMode = false;
                    Calculator.DarkMode = false;
                    Cards.AboutPanel.DarkMode = false;
                    if (ISLoading == true)
                    {
                        SettingChanged = false;
                    }
                    else
                    {
                        Log.LogSetting("Dark Mode", Properties.Settings.Default.DarkMode.ToString());
                    }
                }
            }
        }

        private void UserInfoProfile_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("steam://openurl/https://steamcommunity.com/profiles/" + Properties.Settings.Default.UserSteamID);
            }
            catch
            {
                Process.Start("https://steamcommunity.com/profiles/" + Properties.Settings.Default.UserSteamID);
            }
        }
    }
}
