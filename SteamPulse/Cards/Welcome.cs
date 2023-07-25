using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamPulse.Cards;

namespace SteamPulse.Cards
{
    public partial class Welcome : UserControl

    {
        private Main main { get; set; }
        public Welcome(Main Form)
        {
            InitializeComponent();
            main = Form;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cards.Help Help = new Cards.Help(main);
            main.ShowInContainer(Help);
        }
    }
}
