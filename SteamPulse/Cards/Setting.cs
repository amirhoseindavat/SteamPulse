using Newtonsoft.Json.Linq;
using SteamPulse.Logger;
using SteamPulse.SteamAPI;
using SteamPulse.SettingsInterface;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using SteamPulse;
using Bunifu.UI.WinForms;
using System.Threading.Tasks;

namespace SteamPulse.Cards
{
    public partial class Settings : UserControl
    {
        private Main main { get; set; }
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
        public Settings(Main Form)
        {
            InitializeComponent();
            main = Form;
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            string SettingsProfileID = Properties.Settings.Default.UserSteamID.ToString();
            if (SettingsProfileID != "0")
            {
                PanelLogin.Visible = false;
                PanelStatus.Visible = true;
                PanelStatus.Size = new Size(611, 158);
                PanelStatus.BackgroundColor = GlobalVariables.Colors.Light.AthenGray;
                LabelStatus.Text = "Loading Data...";
                //SteamID = Properties.UserSettings.Default.UserSteamID;
                BackgroundWorker.RunWorkerAsync();
            }
            else { }
            if (UserSettings.Currency.ISO == "BR")
            {
                DropDownRegion.SelectedIndex = 7;
            }
            else if (UserSettings.Currency.ISO == "RU")
            {
                DropDownRegion.SelectedIndex = 6;
            }
            else if (UserSettings.Currency.ISO == "CN")
            {
                DropDownRegion.SelectedIndex = 3;
            }
            else if (UserSettings.Currency.ISO == "NL")
            {
                DropDownRegion.SelectedIndex = 2;
            }
            else if (UserSettings.Currency.ISO == "UK")
            {
                DropDownRegion.SelectedIndex = 1;
            }
            else if (UserSettings.Currency.ISO == "US")
            {
                DropDownRegion.SelectedIndex = 0;
            }
            else if (UserSettings.Currency.ISO == "TR")
            {
                DropDownRegion.SelectedIndex = 5;
            }
            else if (UserSettings.Currency.ISO == "AR")
            {
                DropDownRegion.SelectedIndex = 4;
            }
            else if (UserSettings.Currency.ISO == "UA")
            {
                DropDownRegion.SelectedIndex = 8;
            }
            else if (UserSettings.Currency.ISO == "IN")
            {
                DropDownRegion.SelectedIndex = 9;
            }
            else if (UserSettings.Currency.ISO == "KZ")
            {
                DropDownRegion.SelectedIndex = 10;
            }
            else if (UserSettings.Currency.ISO == "PH")
            {
                DropDownRegion.SelectedIndex = 11;
            }
            else if (UserSettings.Currency.ISO == "AZ")
            {
                DropDownRegion.SelectedIndex = 12;
            }
            else if (UserSettings.Currency.ISO == "PK")
            {
                DropDownRegion.SelectedIndex = 13;
            }
            else
            {
                UserSettings.Currency.Name = "USD";
                UserSettings.Currency.Number = 1;
                UserSettings.Currency.ISO = "US";
                UserSettings.Currency.Unit = "$";
                DropDownRegion.SelectedIndex = 0;
            }


            ToggleIRT.Checked = UserSettings.CheckIRT;
            ToggleOwned.Checked = UserSettings.CheckOwned;

            ToggleDeveloper.Checked = UserSettings.DeveloperMode;

            ToggleUpdate.Checked = UserSettings.CheckUpdate;

            if (UserSettings.SystemDarkMode)
            {
                DropDownDarkMode.SelectedIndex = 2;
            }
            else
            {
                if (UserSettings.DarkMode)
                {
                    DropDownDarkMode.SelectedIndex = 1;
                }
                else
                {
                    DropDownDarkMode.SelectedIndex = 0;
                }
            }

            ToggleBeta.Enabled = UserSettings.CheckUpdate;
            if (ToggleBeta.Enabled == false)
            {
                ToggleBeta.ToggleStateOff.BackColor = Color.Gray;
                ToggleBeta.ToggleStateOff.BorderColor = Color.Gray;
            }
            else
            {
                ToggleBeta.Checked = UserSettings.InstallBeta;
                ToggleBeta.ToggleStateOff.BackColor = Color.FromArgb(191, 191, 191);
                ToggleBeta.ToggleStateOff.BorderColor = Color.FromArgb(191, 191, 191);
            }

            DarkMode = Convert.ToBoolean(Properties.Settings.Default.DarkMode);
            /*if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }*/

            Main.SettingisUpdated = false;
            ISLoading = false;
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
                    UserSettings.CheckOwned = ToggleOwned.Checked;
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
                        //SteamID = Properties.UserSettings.Default.UserSteamID;
                        BackgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        PanelStatus.Visible = true;
                        LabelStatus.Text = "Can't Login, CLick To Retry.";
                        ToggleOwned.Enabled = false;
                        ToggleOwned.Checked = false;
                        UserSettings.CheckOwned = ToggleOwned.Checked;
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
            PanelLogin.BringToFront();
            PanelStatus.Visible = true;
            TextBoxLogin.Text = "";
            Properties.Settings.Default.UserSteamID = "0";
            Properties.Settings.Default.Save();
            Log.LogSteamLogin("Logout", Properties.Settings.Default.UserSteamID.ToString());
            ToggleOwned.Enabled = false;
            ToggleOwned.Checked = false;
            UserSettings.CheckOwned = ToggleOwned.Checked;
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

                Main.SettingisUpdated = true;
                Log.LogSetting("Region", Properties.Settings.Default.CurrencyISO.ToString());

                GetData.KeyIsConnected = false;
                GetData.TicketIsConnected = false;

                Task.Factory.StartNew(() => GetData.ConnectToSteam.Market.TF2Key());
                Task.Factory.StartNew(() => GetData.ConnectToSteam.Market.TF2Ticket());
            }
        }

        private void ToggleIRT_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            UserSettings.CheckIRT = ToggleIRT.Checked;
            Main.SettingisUpdated = true;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Log.LogSetting("Calculate IRT Price", Properties.Settings.Default.CalculateIRT.ToString());
                if(ToggleIRT.Checked)
                {
                    GetData.IRTIsConnected = false;
                    Task.Factory.StartNew(() => GetData.IRT.KeyAndTicket());
                }
                
            }
        }

        private void ToggleOwned_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            UserSettings.CheckOwned = ToggleOwned.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Log.LogSetting("Check For Owned Games", Properties.Settings.Default.CheckOwned.ToString());
            }
        }

        private void ToggleUpdate_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            UserSettings.CheckUpdate = ToggleUpdate.Checked;
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
                UserSettings.InstallBeta = ToggleBeta.Checked;
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
            UserSettings.InstallBeta = ToggleBeta.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Log.LogSetting("Check For Beta", Properties.Settings.Default.InstallBeta.ToString());
            }
        }

        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround, BackGround2;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.Cello;
                ForeGround = GlobalVariables.Colors.Dark.White;
                BackGround2 = GlobalVariables.Colors.Dark.NileBlue;
                ButtonOpenDeveloperSettings.Image = Properties.Resources.OpenExternal;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.AthenGray;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackGround2 = GlobalVariables.Colors.Light.White;
                ButtonOpenDeveloperSettings.Image = Properties.Resources.OpenExternalBlack;
            }
            this.BackColor = BackGround2;
            PanelLogin.BackgroundColor = BackGround;
            LabelLogin.ForeColor = ForeGround;
            PanelUserINfo.BackgroundColor = BackGround;
            UserInfoGames.ForeColor = ForeGround;
            UserInfoLevel.ForeColor = ForeGround;
            UserInfoLogout.ForeColor = ForeGround;
            UserInfoName.ForeColor = ForeGround;
            PanelRegion.BackgroundColor = BackGround;
            LabelRegion.ForeColor = ForeGround;
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
            UserInfoMemberSince.ForeColor = ForeGround;
            UserInfoBan.ForeColor = ForeGround;
            ButtonOpenDeveloperSettings.BackColor = BackGround;
            Label_Login_Notice.ForeColor = ForeGround;
        }

        private void ToggleDeveloper_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            UserSettings.DeveloperMode = ToggleDeveloper.Checked;
            ButtonOpenDeveloperSettings.Visible = ToggleDeveloper.Checked;
            if (ISLoading == true)
            {
                SettingChanged = false;
            }
            else
            {
                Log.LogDeveloper(ToggleDeveloper.Checked);
                //Notification.Show(main,"Developer Mode Activated, Click to Open", BunifuSnackbar.MessageTypes.Success);

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
                string MemberSince = "";
                //PictureBoxYear.Invoke((MethodInvoker)(() => PictureBoxYear.Visible = false));




                //string avatarframe = "";

                foreach (XmlNode Node in Nodes)
                {
                    ProfileName = Node["steamID"].InnerText;
                    ProfileAddress = Node["avatarFull"].InnerText;
                    if(Node["privacyState"].InnerText == "public")
                    {
                        MemberSince = Node["memberSince"].InnerText;
                    }
                    else
                    {
                        MemberSince = "Private";
                    }
                    
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
                if (JsonObjecAvatar.SelectToken(".response.avatar.image_small") != null)
                {
                    ProfileAddress = "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/" + JsonObjecAvatar.SelectToken(".response.avatar.image_small").ToString();
                }

                JObject JsonObjectLevel = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetSteamLevel/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID));
                JToken Level = JsonObjectLevel.SelectToken(".response.player_level");

                JObject JsonObjectGameCount = JObject.Parse(client.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + GetData.APIKEY + "&steamid=" + SteamID + "&include_played_free_games=true&include_free_sub=true&skip_unvetted_apps=false"));
                JToken Gamecount = JsonObjectGameCount.SelectToken(".response.game_count");
                string gamecountjson = JsonObjectGameCount.ToString();

                UserInfoName.Invoke((MethodInvoker)(() => UserInfoName.Text = ProfileName));
                /*
                string MemberSinceCounter = "";
                try
                {
                    int DaysCount = Math.Abs((DateTime.Parse(MemberSince) - DateTime.Now).Days);
                    if (DaysCount > 365)
                    {
                        //MemberSinceCounter = string.Format("({0} Years Ago)" , DaysCount / 365);
                        PictureBoxYear.Invoke((MethodInvoker)(() => PictureBoxYear.Visible = true));
                        PictureBoxYear.Invoke((MethodInvoker)(() => PictureBoxYear.Load("https://community.cloudflare.steamstatic.com/public/images/badges/02_years/steamyears"+ Convert.ToInt32(DaysCount / 365) + "_80.png")));
                    }
                    else if (DaysCount > 30)
                    {
                        MemberSinceCounter = string.Format("({0} Months Ago)", DaysCount / 30);
                    }
                    else if (DaysCount < 30)
                    {
                        MemberSinceCounter = string.Format("({0} days Ago)", DaysCount);
                    }
                    UserInfoMemberSince.Invoke((MethodInvoker)(() => UserInfoMemberSince.Text = string.Format("Member since: {0} {1}", MemberSince, MemberSinceCounter)));
                }
                catch
                {
                    UserInfoMemberSince.Invoke((MethodInvoker)(() => UserInfoMemberSince.Text = string.Format("Member since: {0}", MemberSince)));
                }*/

                UserInfoMemberSince.Invoke((MethodInvoker)(() => UserInfoMemberSince.Text = string.Format("Member since: {0}", MemberSince)));

                UserInfoBan.Invoke((MethodInvoker)(() => UserInfoBan.Text = "Ban status: In good standing"));

                UserInfoLevel.Invoke((MethodInvoker)(() => UserInfoLevel.Text = string.Format("Level: {0}", Level)));

                //avatarframe = LoadData.Community.AvatarFrame(SteamID);
                if (Gamecount != null)
                {
                    UserInfoGames.Invoke((MethodInvoker)(() => UserInfoGames.Text = string.Format("Games Owned: {0}", Gamecount)));
                }
                else
                {
                    UserInfoGames.Invoke((MethodInvoker)(() => UserInfoGames.Text = "Games Owned: Private"));
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
                UserSettings.CheckOwned = ToggleOwned.Checked;
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BackColor = Color.Gray));
                ToggleOwned.Invoke((MethodInvoker)(() => ToggleOwned.ToggleStateOff.BorderColor = Color.Gray));
            }
            ThreadISLoading = false;
        }

        private void DropDownDarkMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownDarkMode.SelectedIndex == 2)
            {
                UserSettings.SystemDarkMode = true;
                UserSettings.DarkMode = ShouldSystemUseDarkMode();
            }
            else
            {
                UserSettings.SystemDarkMode = false;
                if (DropDownDarkMode.SelectedIndex == 1)
                {
                    UserSettings.DarkMode = true;
                    ChangeTheme(true);
                    Main.DarkMode = true;
                    AboutPanel.DarkMode = true;

                    
                    
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
                    UserSettings.DarkMode = false;
                    ChangeTheme(default);
                    Main.DarkMode = false;
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
            main.ReloadSidebar();
            main.UpdateDarkMode();
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

        private void ButtonOpenDeveloperSettings_Click(object sender, EventArgs e)
        {
            if (SideBar.Active == Main.SideBars.Settings && ToggleDeveloper.Checked)
            {
                //Active = Main.SideBars.Search;
                DeveloperSettings DeveloperSetting = new DeveloperSettings(main);
                main.ShowInContainer(DeveloperSetting, SideBar.Active);
            }
            else
            {
                /*Active = Main.SideBars.Welcome;
                Welcome welcome = new Welcome(main);
                main.ShowInContainer(welcome);*/
            }
        }
    }
}
