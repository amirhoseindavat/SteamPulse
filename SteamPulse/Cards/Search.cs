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
        private Main Main { get; set; }
        public Search(Main Form)
        {
            InitializeComponent();
            Main = Form;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            BackgroundWorker.RunWorkerAsync();
            Data.Appid = Convert.ToInt32(TextBox_URL.Text);
            Data Welcome = new Data();
            Main.ShowInContainer(Welcome);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox_URL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
