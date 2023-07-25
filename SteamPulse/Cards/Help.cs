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

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Welcome Welcome = new Welcome(main);
            main.ShowInContainer(Welcome);
        }
    }
}
