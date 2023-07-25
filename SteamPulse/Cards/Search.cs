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
    public partial class Search : UserControl
    {
        private Main main { get; set; }
        public Search(Main Form)
        {
            InitializeComponent();
            main = Form;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            BackgroundWorker.RunWorkerAsync();
            Welcome Welcome = new Welcome(main);
            main.ShowInContainer(Welcome);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
