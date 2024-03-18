using SteamPulse.GlobalVariables;
using SteamPulse.SettingsInterface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class SideBar : UserControl
    {
        public static Main.SideBars Active = Main.SideBars.DashBoard;
        public static bool UpdateAvailable = false, DarkMode = false;
        private Main main { get; set; }
        public SideBar(Main Form)
        {
            InitializeComponent();
            main = Form;
        }
        private void Label_Search_Click(object sender, EventArgs e)
        {
            Active = Main.SideBars.DashBoard;
            Dashboard Dashboard = new Dashboard(main);
            main.ShowInContainer(Dashboard, Active);
        }
        private void Label_About_Click(object sender, EventArgs e)
        {
            Active = Main.SideBars.About;
            AboutPanel AboutPanel = new AboutPanel(main);
            main.ShowInContainer(AboutPanel, Active);
        }
        private void Label_Settings_Click(object sender, EventArgs e)
        {
            Active = Main.SideBars.Settings;
            Settings Settings = new Settings(main);
            main.ShowInContainer(Settings, Active);
        }
        private void Label_Calculator_Click(object sender, EventArgs e)
        {
            Active = Main.SideBars.Search;
            Search search = new Search(main);
            main.ShowInContainer(search, Active);
        }
        private void Label_Market_Click(object sender, EventArgs e)
        {
            Active = Main.SideBars.Market;
            Market Market = new Market(main);
            main.ShowInContainer(Market, Active);
        }
        private void Label_Bug_Click(object sender, EventArgs e)
        {
            Active = Main.SideBars.BugReports;
            BugReport BugReport = new BugReport(main);
            main.ShowInContainer(BugReport, Active);
        }
        private void SideBar_Load(object sender, EventArgs e)
        {
            if (UpdateAvailable)
            {
                UpdateNotification.Visible = true;
            }
            else { }
            DarkMode = Convert.ToBoolean(Properties.Settings.Default["DarkMode"]);
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
            }
            else
            {
                BackGround = Colors.Light.White;
                ForeGround = Colors.Light.NileBlue;
                BackColor = Colors.Light.AthenGray;
            }
            Panel_About.BackgroundColor = BackGround;
            Panel_Bug.BackgroundColor = BackGround;
            Panel_SearchAndCalculator.BackgroundColor = BackGround;
            Panel_Market.BackgroundColor = BackGround;
            Panel_DashBoard.BackgroundColor = BackGround;
            Panel_Settings.BackgroundColor = BackGround;
            Panel_About.BorderColor = BackGround;
            Panel_Bug.BorderColor = BackGround;
            Panel_SearchAndCalculator.BorderColor = BackGround;
            Panel_Market.BorderColor = BackGround;
            Panel_DashBoard.BorderColor = BackGround;
            Panel_Settings.BorderColor = BackGround;

            Label_About.ForeColor = ForeGround;
            Label_Bug.ForeColor = ForeGround;
            Label_SearchAndCalculator.ForeColor = ForeGround;
            Label_Market.ForeColor = ForeGround;
            Label_DashBoard.ForeColor = ForeGround;
            Label_Settings.ForeColor = ForeGround;

        }
    }
}
