using SteamPulse.SettingsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Help : UserControl
    {
        private Main main { get; set; }
        public Help(Main Form)
        {
            InitializeComponent();
            main = Form;
        }

        private void Help_Load(object sender, EventArgs e)
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
                Picture_About.Image = Properties.Resources.chevron_right_solid_White;
                Picture_Bugs.Image = Properties.Resources.chevron_right_solid_White;
                Picture_Calculator.Image = Properties.Resources.chevron_right_solid_White;
                Picture_Market.Image = Properties.Resources.chevron_right_solid_White;
                Picture_Search.Image = Properties.Resources.chevron_right_solid_White;
                Picture_Settings.Image = Properties.Resources.chevron_right_solid_White;
                
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
                Picture_About.Image = Properties.Resources.chevron_right_solid;
                Picture_Bugs.Image = Properties.Resources.chevron_right_solid;
                Picture_Calculator.Image = Properties.Resources.chevron_right_solid;
                Picture_Market.Image = Properties.Resources.chevron_right_solid;
                Picture_Search.Image = Properties.Resources.chevron_right_solid;
                Picture_Settings.Image = Properties.Resources.chevron_right_solid;
            }
            this.BackColor = BackGround;
            Label_About.ForeColor = ForeGround;
            Label_Bugs.ForeColor = ForeGround;
            Label_Calculator.ForeColor = ForeGround;
            Label_Settings.ForeColor = ForeGround;
            Label_Market.ForeColor = ForeGround;
            Label_Search.ForeColor = ForeGround;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard(main);
            main.ShowInContainer(Dashboard);
        }
    }
}
