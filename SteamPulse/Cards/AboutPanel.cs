using SteamPulse.Logger;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse.Cards
{
    public partial class AboutPanel : UserControl
    {
        private string URL;
        private readonly string AppHash = Hasher("SteamPulse");
        public static bool DarkMode;
        private Main Main { get; set; }
        public AboutPanel(Main Form)
        {
            InitializeComponent();
            Main = Form;
        }
        private void LabelCopyright_Click(object sender, EventArgs e)
        {
            Process.Start("https://codemage.ir");
        }
        private void LabelHeader_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
        private void AboutPanel_Load(object sender, EventArgs e)
        {
            LabelVersion.Text = string.Format("Current version : {0} LTS", Application.ProductVersion);
            if (SettingsInterface.UserSettings.CheckUpdate)
            {

                LabelUpdateStatus.Text = "Connecting to server...";
                Timer.Enabled = true;
            }
            else
            {
                PictureBoxLoading.Visible = false;
                LabelUpdateStatus.Location = new Point(18, 385);
                LabelUpdateStatus.Text = "Update disabled.";
                Timer.Enabled = false;
            }
            DarkMode = Convert.ToBoolean(Properties.Settings.Default["DarkMode"]);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
        }
        public void UpdateChecker()
        {
            try
            {
                Version AppVersion = new Version(Application.ProductVersion);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument Data = new XmlDocument();
                Data.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                XmlElement Root = Data.DocumentElement;
                XmlNodeList Nodes = Root.SelectNodes("/Data/Application");
                foreach (XmlNode Node in Nodes)
                {
                    string AppID_XML = Node["AppID"].InnerText;
                    Version ServerVersion = new Version(Node["CurrentVersion"].InnerText);
                    string UpdateDate_XML = Node["UpdateDate"].InnerText;
                    string UpdateURL_XML = Node["UpdateURL"].InnerText;
                    string UpdateType = Node["UpdateType"].InnerText;
                    int Result = AppVersion.CompareTo(ServerVersion);
                    if (AppHash == AppID_XML)
                    {
                        if (Convert.ToBoolean(Properties.Settings.Default["CheckUpdate"]) == true)
                        {
                            LabelUpdateStatus.Location = new Point(18, 385);
                            PictureBoxLoading.Visible = false;
                            if (Convert.ToBoolean(Properties.Settings.Default["InstallBeta"]) == true)
                            {
                                Version BetaVersion = new Version(Node["BetaVersion"].InnerText);
                                int Betaresult = AppVersion.CompareTo(BetaVersion);
                                string BetaDate_XML = Node["BetaDate"].InnerText;
                                string BetaURL_XML = Node["BetaURL"].InnerText;
                                bool Beta = Convert.ToBoolean(Node["Beta"].InnerText);
                                if (Beta == true)
                                {
                                    if (Betaresult < 0)
                                    {

                                        LabelUpdateStatus.Text = string.Format("Update {1} beta available.", UpdateType, BetaVersion);
                                        Log.LogUpdate("Update", BetaVersion, "Beta");
                                        LabelDownload.Visible = true;
                                        URL = "https://" + BetaURL_XML;
                                    }
                                    else if (Betaresult > 0)
                                    {
                                        LabelUpdateStatus.Text = string.Format("Version {0} beta installed.", Application.ProductVersion);
                                    }
                                    else
                                    {
                                        LabelUpdateStatus.Text = "Steampulse is up to date.";
                                    }
                                }
                                else
                                {
                                    if (Result < 0)
                                    {
                                        LabelUpdateStatus.Text = string.Format("{0} {1} available.", UpdateType, ServerVersion);
                                        Log.LogUpdate(UpdateType, ServerVersion);
                                        LabelDownload.Visible = true;
                                        URL = "https://" + UpdateURL_XML;
                                    }
                                    else if (Result > 0)
                                    {
                                        LabelUpdateStatus.Text = string.Format("Version {0} beta installed.", Application.ProductVersion);
                                    }
                                    else
                                    {
                                        LabelUpdateStatus.Text = "Steampulse is up to date.";
                                    }
                                }
                            }
                            else
                            {
                                if (Result < 0)
                                {
                                    LabelUpdateStatus.Text = string.Format("{0} {1} available.", UpdateType, ServerVersion);
                                    Log.LogUpdate(UpdateType, ServerVersion);
                                    LabelDownload.Visible = true;
                                    URL = "https://" + UpdateURL_XML;
                                }
                                else if (Result > 0)
                                {
                                    LabelUpdateStatus.Text = string.Format("SteamPulse is up to date.", Application.ProductVersion);
                                }
                                else
                                {
                                    LabelUpdateStatus.Text = "Steampulse is up to date.";
                                }
                            }
                        }
                        else
                        {
                            PictureBoxLoading.Visible = false;
                            LabelUpdateStatus.Text = "Update disabled.";
                        }
                    }
                    else { }
                }
            }
            catch
            {
                PictureBoxLoading.Visible = false;
                LabelUpdateStatus.Text = "Can't get data from server. click to retry";
                LabelUpdateStatus.Cursor = Cursors.Hand;
                LabelDownload.Visible = false;
            }
        }
        private void LabelDownload_Click(object sender, EventArgs e)
        {
            Process.Start(URL);
            Application.Exit();
        }
        private void LabelUpdate_Click(object sender, EventArgs e)
        { }
        private void LabelUpdateStatus_Click(object sender, EventArgs e)
        {
            UpdateChecker();
        }
        private static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                ForeGround = GlobalVariables.Colors.Dark.White;
                BackColor = GlobalVariables.Colors.Dark.NileBlue;
                PictureBoxDonate.Image = Properties.Resources.donate_white;
                PictureBoxEmail.Image = Properties.Resources.envelope_white;
                PictureBoxGithub.Image = Properties.Resources.github_white;
                PictureBoxTelegram.Image = Properties.Resources.telegram_light;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.White;
            }
            LabelHeader.ForeColor = ForeGround;
            LabelCopyright.ForeColor = ForeGround;
            LabelDownload.ForeColor = ForeGround;
            LabelUpdateStatus.ForeColor = ForeGround;
            LabelVersion.ForeColor = ForeGround;
            LabelAbout.ForeColor = ForeGround;
            LabelDonate.ForeColor = ForeGround;
            LabelEmail.ForeColor = ForeGround;
            LabelTelegram.ForeColor = ForeGround;
            LabelGithub.ForeColor = ForeGround;
            LabelSteamPulseWeb.ForeColor = ForeGround;
            Separator.LineColor = ForeGround;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            i++;
            if (i == 1)
            {
                try
                {
                    UpdateChecker();
                }
                catch
                {
                    LabelUpdateStatus.Text = "Checking Update Failed. Click To Retry";
                    LabelUpdateStatus.Cursor = Cursors.Hand;
                    LabelDownload.Visible = false;
                }
                Timer.Enabled = false;
            }
        }
        private void Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/amirhoseindavat/SteamPulse");
        }
        private void Telegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/SteamPulse");
        }
        private void Email_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:info@codemage.ir");
        }
        private void SteamPulseWeb_Click(object sender, EventArgs e)
        {
            Process.Start("https://SteamPulse.ir");
        }
        private void Donate_Click(object sender, EventArgs e)
        {
            Process.Start("https://CodeMage.ir/Donate");
        }

        private void LabelVersion_Click(object sender, EventArgs e)
        {

        }

        private void LabelAbout_Click(object sender, EventArgs e)
        {

        }

        private void LabelUpdateStatus_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBoxLoading_Click(object sender, EventArgs e)
        {

        }

        private void Separator_Click(object sender, EventArgs e)
        {

        }
    }
}
