using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamPulse.GlobalVariables;

namespace SteamPulse.Cards
{
    public partial class SideBar : UserControl
    {
        private Main main { get; set; }
        public SideBar(Main Form)
        {
            InitializeComponent();
            main = Form;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //BackgroundWorker.RunWorkerAsync();
            Search search = new Search(main);
            main.ShowInContainer(search);
            bunifuPanel1.BackgroundColor = Colors.Light.AltoSilver;
        }
    }
}
