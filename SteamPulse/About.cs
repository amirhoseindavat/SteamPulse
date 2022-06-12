#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.4.0 Revision 3

#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse
{
    public partial class About : Form
    {
        string URL;
        private readonly string AppHash = Hasher("SteamPulse");
        public static Boolean DarkMode;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public About()
        {
            InitializeComponent();
        }
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        private void About_Load(object sender, EventArgs e)
        {
            LabelVersion.Text = String.Format("Current Version : {0}", Application.ProductVersion);
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
                var AppVersion = new Version(Application.ProductVersion);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument Data = new XmlDocument();
                Data.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                XmlElement Root = Data.DocumentElement;
                XmlNodeList Nodes = Root.SelectNodes("/Data/Application");
                foreach (XmlNode Node in Nodes)
                {
                    string AppID_XML = Node["AppID"].InnerText;
                    var ServerVersion = new Version(Node["CurrentVersion"].InnerText);
                    string UpdateDate_XML = Node["UpdateDate"].InnerText;
                    string UpdateURL_XML = Node["UpdateURL"].InnerText;
                    string UpdateType = Node["UpdateType"].InnerText;
                    var result = AppVersion.CompareTo(ServerVersion);
                    if (AppHash == AppID_XML)
                    {
                        if (Convert.ToBoolean(Properties.Settings.Default["CheckUpdate"]) == true)
                        {
                            if (Convert.ToBoolean(Properties.Settings.Default["InstallBeta"]) == true)
                            {
                                var BetaVersion = new Version(Node["BetaVersion"].InnerText);
                                var Betaresult = AppVersion.CompareTo(BetaVersion);
                                string BetaDate_XML = Node["BetaDate"].InnerText;
                                string BetaURL_XML = Node["BetaURL"].InnerText;
                                Boolean Beta = Convert.ToBoolean(Node["Beta"].InnerText);
                                if (Beta == true)
                                {
                                    if (Betaresult < 0)
                                    {

                                        LabelUpdateStatus.Text = string.Format("Update {1} Beta Available.", UpdateType, BetaVersion);
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
        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void ChangeTheme(Boolean Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = Color.FromArgb(24, 49, 83);
                ForeGround = Color.FromArgb(255, 255, 255);
                this.BackColor = Color.FromArgb(33, 63, 105);

            }
            else
            {
                BackGround = Color.FromArgb(255, 255, 255);
                ForeGround = Color.FromArgb(24, 49, 83);
                this.BackColor = Color.FromArgb(241, 240, 245);
            }
            PanelHeader.BackgroundColor = BackGround;
            LabelAppName.BackColor = BackGround;
            LabelAppName.ForeColor = ForeGround;
            PanelUpdate.BackgroundColor = BackGround;
            LabelCopyright.ForeColor = ForeGround;
            LabelDownload.ForeColor = ForeGround;
            LabelUpdate.ForeColor = ForeGround;
            LabelUpdateStatus.ForeColor = ForeGround;
            LabelVersion.ForeColor = ForeGround;

        }

    }
}
