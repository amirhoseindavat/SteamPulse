using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace Giveaway
{
    public partial class ViewWinners : Form
    {
        private long Giveawayend;
        private DateTime EndTime;
        private readonly int[] Winners = new int[5];

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public ViewWinners()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            /*TimeSpan span = EndTime.ToLocalTime().Subtract(DateTime.Now);

            Label_Remaining.Text = string.Format("Remaining time: {0}d {1}h {2}m {3}s", span.Days, span.Hours, span.Minutes, span.Seconds);

            if (DateTimeOffset.Now.ToUnixTimeSeconds() > Giveawayend)
            {
                Label_Remaining.Text = "Giveaway Ended.";
            }*/
        }

        /*private void CheckUserStatus()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            string DownloadedData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/giveaway/count");
            JToken RawData = JToken.Parse(DownloadedData);
            count = Convert.ToInt32(RawData.SelectToken(".count").ToString());

            LabelCount.Text = "Entered Users: " + RawData.SelectToken(".count").ToString();



        }*/

        private void ViewWinners_Load(object sender, EventArgs e)
        {
            

            int rowId = Convert.ToInt32(DataTable.Rows.Add());

            var rnd = new Random();
            var randomNumbers = Enumerable.Range(1000, Main.count).OrderBy(x => rnd.Next()).Take(10).ToList();
            int index = 1;
            foreach (var number in randomNumbers)
            {
                for (int i = 0; i < Main.count; i++)
                {
                    if (Convert.ToInt32(Main.RawData.SelectToken(".[" + i + "].id")) == number)
                    {
                        DataGridViewRow row = DataTable.Rows[rowId];
                        row.Cells["ID"].Value = Main.RawData.SelectToken(".[" + i + "].id");
                        row.Cells["Firstname"].Value = Main.RawData.SelectToken(".[" + i + "].firstname");
                        row.Cells["lastname"].Value = Main.RawData.SelectToken(".[" + i + "].lastname");
                        row.Cells["Telegram"].Value = Main.RawData.SelectToken(".[" + i + "].telegram");
                        index++;
                        rowId++;
                        DataTable.Rows.Add();
                    }
                    
                }
            }
        }

        private void LoadGiveawayData()
        {
            try
            {
                var AppVersion = new Version(Application.ProductVersion);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument data2 = new XmlDocument();
                data2.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                XmlElement root2 = data2.DocumentElement;
                XmlNodeList nodes2 = root2.SelectNodes("/Data/Application");
                foreach (XmlNode node in nodes2)
                {
                    Giveawayend = Convert.ToInt32(node["GiveawayEnd"].InnerText);
                }
            }
            catch { }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
