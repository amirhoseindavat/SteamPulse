using SteamPulse.SettingsInterface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Dashboard : UserControl
    {
        private Main main { get; set; }
        public Dashboard(Main Form)
        {
            InitializeComponent();
            main = Form;
        }
        private void LabelHelp_Click(object sender, EventArgs e)
        {
            Help Help = new Help(main);
            main.ShowInContainer(Help);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (UserSettings.DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
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
            BackColor = BackGround;
            LabelHelp.ForeColor = ForeGround;
            LabelInfo.ForeColor = ForeGround;
        }
    }
}
