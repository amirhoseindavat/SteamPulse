using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace Giveaway
{
    public partial class Main : Form
    {
        private long Giveawayend;
        private DateTime EndTime;
        private readonly int[] Winners = new int[5];
        public static JToken RawData;
        public static int count;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = EndTime.ToLocalTime().Subtract(DateTime.Now);

            Label_Remaining.Text = string.Format("Remaining time: {0}d {1}h {2}m {3}s", span.Days, span.Hours, span.Minutes, span.Seconds);

            if (DateTimeOffset.Now.ToUnixTimeSeconds() > Giveawayend)
            {
                Label_Remaining.Text = "Giveaway Ended.";
            }
        }

        private void CheckUserStatus()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            string DownloadedData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/giveaway/count");
            JToken RawData = JToken.Parse(DownloadedData);
            count = Convert.ToInt32(RawData.SelectToken(".count").ToString());

            LabelCount.Text = "Entered Users: " + RawData.SelectToken(".count").ToString();



        }

        private void Main_Load(object sender, EventArgs e)
        {


            LoadGiveawayData();

            CheckUserStatus();
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Giveawayend);
            EndTime = dateTimeOffset.DateTime;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            string DownloadedData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/giveaway/getallentries");
            RawData = JToken.Parse(DownloadedData);

            int rowId = Convert.ToInt32(DataTable.Rows.Add());


            for (int i = 0; ; i++)
            {
                DataGridViewRow row = DataTable.Rows[rowId];
                if (RawData.SelectToken(".[" + i + "].id") == null)
                {
                    DataTable.Rows.Remove(DataTable.Rows[rowId]);
                    break;
                }
                else
                {
                    row.Cells["ID"].Value = RawData.SelectToken(".[" + i + "].id");
                    row.Cells["Firstname"].Value = RawData.SelectToken(".[" + i + "].firstname");
                    row.Cells["lastname"].Value = RawData.SelectToken(".[" + i + "].lastname");
                    row.Cells["Telegram"].Value = RawData.SelectToken(".[" + i + "].telegram");
                }
                rowId++;
                DataTable.Rows.Add();
            }

            //LabelCount.Text = "Entered Users: " + RawData.SelectToken(".count").ToString();


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

        private void ButtonWinners_Click(object sender, EventArgs e)
        {
            /*var rnd = new Random();
            var randomNumbers = Enumerable.Range(1000,count).OrderBy(x => rnd.Next()).Take(10).ToList();
            int index = 1;
            foreach(var number in randomNumbers)
            {
                for (int i =0; i< count ;i++)
                {
                    if (Convert.ToInt32(RawData.SelectToken(".[" + i + "].id")) == number)
                    {
                        MessageBox.Show(
                            String.Format("Winner#{0}\nID: {1}\nFirst Name: {2}\nLast Name: {3}\nTelegram: {4}",
                            index,
                            RawData.SelectToken(".[" + i + "].id"),
                            RawData.SelectToken(".[" + i + "].firstname"),
                            RawData.SelectToken(".[" + i + "].lastname"),
                            RawData.SelectToken(".[" + i + "].telegram")
                            ),
                            "Congratulations!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        index++;
                    }
                }
            }      */
            Form viewwinners = new ViewWinners();
            viewwinners.ShowDialog();
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
