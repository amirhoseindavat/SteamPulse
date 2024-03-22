using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class SalesBanner : UserControl
    {
        private DateTime EndTime;
        public static Color Theme;
        public static string type = "";
        public SalesBanner()
        {
            InitializeComponent();
        }

        private void SalesBanner_Load(object sender, EventArgs e)
        {
            PictureBox_IMG.Load(Main.SaleBanner);
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Main.Saleend);
            EndTime = dateTimeOffset.DateTime;
            ButtonViewSale.Text = "View " + type;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = EndTime.ToLocalTime().Subtract(DateTime.Now);

            Label_Remaining.Text = string.Format("Remaining time: {0}d {1}h {2}m {3}s", span.Days, span.Hours, span.Minutes, span.Seconds,Main.Salename);

            /*if (DateTimeOffset.Now.ToUnixTimeSeconds() > Giveawayend)
            {
                Label_Remaining.Text = "Giveaway Ended.";
            }*/
            if (DateTimeOffset.Now.ToUnixTimeSeconds() > Main.Saleend)
            {
                Label_Remaining.Visible = false;
            }
        }
        private void ButtonViewSale_Click(object sender, EventArgs e)
        {
            Process.Start("steam://openurl/"+Main.SaleURL);
        }
    }
}
