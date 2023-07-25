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
        public AboutPanel()
        {
            InitializeComponent();
        }

        private void LabelCopyright_Click(object sender, EventArgs e)
        {

        }

        private void Label_About_Header_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void AboutPanel_Load(object sender, EventArgs e)
        {
            LabelVersion.Text = string.Format("Current Version : {0}", Application.ProductVersion);
            LabelUpdateStatus.Text = "Connecting To Server...";

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
                    int result = AppVersion.CompareTo(ServerVersion);
                    if (AppHash == AppID_XML)
                    {
                        if (Convert.ToBoolean(Properties.Settings.Default["CheckUpdate"]) == true)
                        {
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

                                        LabelUpdateStatus.Text = string.Format("Update {1} Beta Available.", UpdateType, BetaVersion);
                                        Log.LogUpdate("Update", BetaVersion, "Beta");
                                        LabelDownload.Visible = true;
                                        URL = "https://" + BetaURL_XML;
                                    }
                                    else if (Betaresult > 0)
                                    {
                                        LabelUpdateStatus.Text = string.Format("Version {0} Beta Installed.", Application.ProductVersion);
                                    }
                                    else
                                    {
                                        LabelUpdateStatus.Text = "Latest Version Installed.";
                                    }
                                }
                                else
                                {
                                    if (result < 0)
                                    {
                                        LabelUpdateStatus.Text = string.Format("{0} {1} Available.", UpdateType, ServerVersion);
                                        Log.LogUpdate(UpdateType, ServerVersion);
                                        LabelDownload.Visible = true;
                                        URL = "https://" + UpdateURL_XML;
                                    }
                                    else if (result > 0)
                                    {
                                        LabelUpdateStatus.Text = string.Format("Version {0} Beta Installed.", Application.ProductVersion);
                                    }
                                    else
                                    {
                                        LabelUpdateStatus.Text = "Latest Version Installed.";
                                    }
                                }
                            }
                            else
                            {
                                if (result < 0)
                                {
                                    LabelUpdateStatus.Text = string.Format("{0} {1} Available.", UpdateType, ServerVersion);
                                    Log.LogUpdate(UpdateType, ServerVersion);
                                    LabelDownload.Visible = true;
                                    URL = "https://" + UpdateURL_XML;
                                }
                                else if (result > 0)
                                {
                                    LabelUpdateStatus.Text = string.Format("Version {0} Beta Installed.", Application.ProductVersion);
                                }
                                else
                                {
                                    LabelUpdateStatus.Text = "Latest Version Installed.";
                                }
                            }
                        }
                        else
                        {
                            LabelUpdateStatus.Text = "Update Disabled.";
                        }
                    }
                    else { }
                }
            }
            catch
            {
                LabelUpdateStatus.Text = "Can't Get Data From Server. Click To Retry";
                LabelUpdateStatus.Cursor = Cursors.Hand;
                LabelDownload.Visible = false;
            }
        }

        private void Label_Download_Click(object sender, EventArgs e)
        {
            Process.Start(URL);
            Application.Exit();
        }
        private void Label_update_Click(object sender, EventArgs e)
        { }
        private void Label_update_status_Click(object sender, EventArgs e)
        {
            UpdateChecker();
        }
        private void Label_copyright_Click(object sender, EventArgs e)
        {
            Process.Start("https://codemage.ir");
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

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
            }
            Label_About_Header.ForeColor = ForeGround;
            LabelCopyright.ForeColor = ForeGround;
            LabelDownload.ForeColor = ForeGround;
            LabelUpdate.ForeColor = ForeGround;
            LabelUpdateStatus.ForeColor = ForeGround;
            LabelVersion.ForeColor = ForeGround;
            Label_About.ForeColor = ForeGround;
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
    }
}
