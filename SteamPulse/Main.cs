using Bunifu.UI.WinForms;
using SteamPulse.Cards;
using SteamPulse.GlobalVariables;
using SteamPulse.Logger;
using SteamPulse.SettingsInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse
{
    public partial class Main : Form
    {
        //----------------------Variables----------------------//
        //string FormulaCaption = "";
        private readonly string AppHash = Hasher("SteamPulse");
        public static string SearchID;
        private bool giveawayisactive = false, IsSaleActive = false;

        public static long Saleend;
        public static string Salename = "", SaleBanner = "", SaleURL = "";

        public static double EditionPrice;
        public static int EditionDiscount;
        public static bool SettingisUpdated = false;
        public static bool DarkMode;

        private bool IsFormExtended = false;

        public enum SideBars { Search, Market, Settings, DeveloperSettings, BugReports, About, Help, DashBoard }

        private readonly List<int> PackageIDs = new List<int>();

        //-----------------------Detect System Theme----------------//

        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

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
        public void ReloadSidebar()
        {
            SideBar SideBar = new SideBar(this)
            {
                Dock = DockStyle.Fill
            };
            Panel_SideBar.Controls.Clear();
            Panel_SideBar.Controls.Add(SideBar);
            SideBar.BringToFront();
        }
        public void ShowNotification(string Caption, BunifuSnackbar.MessageTypes Type)
        {
            Invoke((MethodInvoker)(() => Notification.Show(this, Caption, Type)));
        }
        public void UpdateDarkMode()
        {
            if (UserSettings.SystemDarkMode)
            {
                if (DarkMode == true)
                {
                    ChangeTheme(true);
                }
                else
                {
                    ChangeTheme(default);
                }
            }
            else
            {
                if (DarkMode == true)
                {
                    ChangeTheme(true);
                }
                else
                {
                    ChangeTheme(default);
                }
            }

            if (giveawayisactive)
            {
                Cards.Giveaway Giveaway = new Cards.Giveaway
                {
                    Dock = DockStyle.Fill
                };
                PanelHead.Controls.Clear();
                PanelHead.Controls.Add(Giveaway);
                PanelHead.BringToFront();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            MainUpdateChecker();

            SideBar Sidebar = new SideBar(this)
            {
                Dock = DockStyle.Fill
            };
            Panel_SideBar.Controls.Clear();
            Panel_SideBar.Controls.Add(Sidebar);
            Sidebar.BringToFront();

            bool MaintenanceMode = Maintenance.MaintenanceMode;
            if (MaintenanceMode == true)
            {
                Label_AppName.Text = "SteamPulse - Maintenance Mode";
            }
            else
            {
                Label_AppName.Text = "SteamPulse";
            }

            DarkMode = UserSettings.DarkMode;


            if (giveawayisactive || IsSaleActive)
            {
                //Size = new Size(944, 690);
                PanelHead.Visible = true;
                Size = new Size(944, 725);

                if (giveawayisactive)
                {
                    Cards.Giveaway Giveaway = new Cards.Giveaway
                    {
                        Dock = DockStyle.Fill
                    };
                    PanelHead.Controls.Clear();
                    PanelHead.Controls.Add(Giveaway);
                    PanelHead.BringToFront();
                }
                else
                {
                    SalesBanner SalesBanner = new SalesBanner
                    {
                        Dock = DockStyle.Fill
                    };
                    PanelHead.Controls.Clear();
                    PanelHead.Controls.Add(SalesBanner);
                    PanelHead.BringToFront();
                }

                IsFormExtended = true;
            }
            else
            {
                IsFormExtended = false;
                PanelHead.Visible = false;
                //Size = new Size(944, 552);
                Size = new Size(944, 539);
            }
            Dashboard Dashboard = new Dashboard(this);
            ShowInContainer(Dashboard, SideBars.DashBoard);

            if (UserSettings.SystemDarkMode)
            {
                if (DarkMode == true)
                {
                    ChangeTheme(true);
                }
                else
                {
                    ChangeTheme(default);
                }
            }
            else
            {
                if (DarkMode == true)
                {
                    ChangeTheme(true);
                }
                else
                {
                    ChangeTheme(default);
                }
            }

            CenterToScreen();

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
            NotifyIcon.Visible = false;
            Close();
        }
        private void MainUpdateChecker()
        {
            try
            {
                Version AppVersion = new Version(Application.ProductVersion);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument data2 = new XmlDocument();
                data2.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                XmlElement root2 = data2.DocumentElement;
                XmlNodeList nodes2 = root2.SelectNodes("/Data/Application");
                foreach (XmlNode node in nodes2)
                {
                    string app_id_xml2 = node["AppID"].InnerText;
                    Version ServerVersion = new Version(node["CurrentVersion"].InnerText);
                    string UpdateType = node["UpdateType"].InnerText;
                    int result = AppVersion.CompareTo(ServerVersion);
                    Cards.Giveaway.giveawayisactive = Convert.ToBoolean(node["NewGiveaway"].InnerText);
                    giveawayisactive = Cards.Giveaway.giveawayisactive;
                    Cards.Giveaway.GiveawayBegin = Convert.ToInt32(node["GiveawayBegin"].InnerText);
                    Cards.Giveaway.GiveawayEnd = Convert.ToInt32(node["GiveawayEnd"].InnerText);
                    Cards.Giveaway.GiveawayTitle = Convert.ToString(node["GiveawayTitle"].InnerText);
                    Cards.Giveaway.GiveawayPic = Convert.ToString(node["GiveawayBadge"].InnerText);
                    Cards.Giveaway.GiveawayPicLight = Convert.ToString(node["GiveawayBadgeLight"].InnerText);
                    Cards.Giveaway.GiveawayTitle = Convert.ToString(node["GiveawayTitle"].InnerText);
                    IsSaleActive = Convert.ToBoolean(node["Sale"].InnerText);
                    Salename = node["Salename"].InnerText.ToString();
                    Saleend = Convert.ToInt64(node["Saleend"].InnerText);
                    SaleBanner = node["Salebanner"].InnerText.ToString();
                    SaleURL = node["Saleurl"].InnerText.ToString();
                    if (AppHash == app_id_xml2)
                    {
                        if (Convert.ToBoolean(UserSettings.CheckUpdate) == true)
                        {
                            if (Convert.ToBoolean(UserSettings.InstallBeta) == true)
                            {
                                Version BetaVersion = new Version(node["BetaVersion"].InnerText);
                                string BetaDate_XML = node["BetaDate"].InnerText;
                                string BetaURL_XML = node["BetaURL"].InnerText;
                                bool Beta = Convert.ToBoolean(node["Beta"].InnerText);
                                int BetaResult = AppVersion.CompareTo(BetaVersion);
                                if (Beta == true)
                                {
                                    if (BetaResult < 0)
                                    {
                                        ShowNotification(string.Format("Update {1} Beta Available, Check About for More Information.", UpdateType, BetaVersion), BunifuSnackbar.MessageTypes.Information);
                                        Log.LogUpdate("Update", BetaVersion, "Beta");
                                        SideBar.UpdateAvailable = true;
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
                                        ShowNotification(string.Format("{0} {1} Available, Check About for More Information.", UpdateType, ServerVersion), BunifuSnackbar.MessageTypes.Information);
                                        Log.LogUpdate(UpdateType, ServerVersion);
                                        SideBar.UpdateAvailable = true;
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
                                    ShowNotification(string.Format("{0} {1} Available, Check About for More Information.", UpdateType, ServerVersion), BunifuSnackbar.MessageTypes.Information);
                                    Log.LogUpdate(UpdateType, ServerVersion);
                                    SideBar.UpdateAvailable = true;
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
        public void ShowInContainer(UserControl userControl, SideBars ActiveTab = SideBars.DashBoard)
        {
            userControl.Dock = DockStyle.Fill;
            //PanelContainer.Parent = null;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();

            if (ActiveTab == SideBars.DashBoard)
            {
                Panel_Activetab.Visible = true;
                Panel_Activetab.BringToFront();
                //Panel_Activetab.BackColor = Colors.Light.White;
                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 231);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 231 - 186);
                }

                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }
            else if (ActiveTab == SideBars.Search)
            {
                Panel_Activetab.Visible = true;
                Panel_Activetab.BringToFront();
                //Panel_Activetab.BackColor = Colors.Light.White;
                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 311);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 311 - 186);
                }
                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }
            else if (ActiveTab == SideBars.Market)
            {
                Panel_Activetab.Visible = true;
                Panel_Activetab.BringToFront();
                //Panel_Activetab.BackColor = Colors.Light.White;
                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 391);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 391 - 186);
                }
                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }
            else if (ActiveTab == SideBars.Settings)
            {
                Panel_Activetab.Visible = true;
                Panel_Activetab.BringToFront();
                //anel_Activetab.BackColor = Colors.Light.White;
                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 471);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 471 - 186);
                }
                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }
            else if (ActiveTab == SideBars.BugReports)
            {
                Panel_Activetab.Visible = true;
                Panel_Activetab.BringToFront();
                //Panel_Activetab.BackColor = Colors.Light.White;
                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 551);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 551 - 186);
                }
                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }
            else if (ActiveTab == SideBars.About)
            {
                Panel_Activetab.Visible = true;
                Panel_Activetab.BringToFront();
                //Panel_Activetab.BackColor = Colors.Light.White;
                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 630);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 630 - 186);
                }
                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }
            else
            {
                Panel_Activetab.Visible = false;
                Panel_Activetab.SendToBack();
                if (DarkMode)
                {
                    Panel_Activetab.BackColor = Colors.Dark.NileBlue;
                }
                else
                {
                    Panel_Activetab.BackColor = Colors.Light.AthenGray;
                }

                if (IsFormExtended)
                {
                    Panel_Activetab.Location = new Point(650, 231);
                }
                else
                {
                    Panel_Activetab.Location = new Point(650, 231 - 186);
                }
                Panel_Activetab.Size = new Size(Panel_Activetab.Size.Width, 64);
            }

        }
        private static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = Colors.Dark.NileBlue;
                ForeGround = Colors.Dark.White;
                BackColor = Colors.Dark.Cello;
                ButtonStatus.Image = Properties.Resources.StatusWhite;
            }
            else
            {
                BackGround = Colors.Light.White;
                ForeGround = Colors.Light.NileBlue;
                BackColor = Colors.Light.AthenGray;
                ButtonStatus.Image = Properties.Resources.StatusBlack;
            }
            Panel_Activetab.BackColor = BackGround;
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelHead.BackgroundColor = BackGround;
            PanelContainer.BackgroundColor = BackGround;

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
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure ?\nThis will Reset all settings and restart app.", "Reset Settings.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Log.LogSettingsReset();
                DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CodeMage\");
                dir.Attributes &= ~FileAttributes.ReadOnly;
                dir.Delete(true);
                Application.Restart();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*private void OpenDiscountCalculator_Click(object sender, EventArgs e)
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
}*/
        private void Label_AppName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void ButtonStatus_Click(object sender, EventArgs e)
        {
            Form Status = new Status();
            Status.ShowDialog(this);
        }

        private void Label_Ramaining_MouseEnter(object sender, EventArgs e)
        {
            //toolTip.Show("GiveAway Begin on: " + GiveawayBeginTime.ToLocalTime().ToString("dddd, dd MMMM yyyy HH:mm:ss"), Label_Remaining);
        }

    }
}
