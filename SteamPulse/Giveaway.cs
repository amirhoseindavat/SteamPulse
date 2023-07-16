#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.7.0 Revision 2
// last Edit: 10/29/22 V2.0
#endregion

using Newtonsoft.Json.Linq;
using SteamPulse.UserSettings;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
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
    public partial class Giveaway : Form
    {
        private long Giveawayend;
        private DateTime EndTime;
        private JToken RawData;
        public static bool DarkMode, UserHasEntered = false, UserReadedRules = false;
        private string RulesURL;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Giveaway()
        {
            InitializeComponent();
        }

        private void LoadGiveawayData()
        {
            try
            {
                Version AppVersion = new Version(Application.ProductVersion);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                XmlDocument data2 = new XmlDocument();
                data2.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                XmlElement root2 = data2.DocumentElement;
                XmlNodeList nodes2 = root2.SelectNodes("/Data/Application");
                foreach (XmlNode node in nodes2)
                {
                    Giveawayend = Convert.ToInt32(node["GiveawayEnd"].InnerText);
                    RulesURL = node["GiveawayRules"].InnerText.ToString();
                }
            }
            catch { }
        }

        private void Giveaway_Load(object sender, EventArgs e)
        {
            DarkMode = Settings.DarkMode;
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            LoadGiveawayData();

            CheckUserStatus();

            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Giveawayend);
            EndTime = dateTimeOffset.DateTime;
        }
        private void CheckUserStatus()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            string DownloadedData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/giveaway/getentryinformation/?hash=" + Hasher(Environment.UserName + Environment.OSVersion + Environment.MachineName));
            RawData = JToken.Parse(DownloadedData);

            if (RawData.SelectToken(".[0].id") != null)
            {
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Size = new Size(360, 432)));
                Label_Remaining.Invoke((MethodInvoker)(() => Label_Remaining.BringToFront()));
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = string.Format("You Have 1 Entry\nYour Information:\nID:  {0}\nName:  {1}\nLast Name:  {2}\nTelegram:  {3}", RawData.SelectToken(".[0].id"), RawData.SelectToken(".[0].firstname"), RawData.SelectToken(".[0].lastname"), RawData.SelectToken(".[0].telegram"))));
            }
            else
            {
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));
            }
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

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                BackColor = GlobalVariables.Colors.Dark.Cello;
                OpenRulesIcon.Image = Properties.Resources.OpenExternal;
                TextBoxName.ForeColor = BackGround;
                TextBoxTelegram.ForeColor = BackGround;
                TextBoxLastName.ForeColor = BackGround;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
                OpenRulesIcon.Image = Properties.Resources.OpenExternalBlack;
                TextBoxName.ForeColor = ForeGround;
                TextBoxTelegram.ForeColor = ForeGround;
                TextBoxLastName.ForeColor = ForeGround;
            }
            PanelHeader.BackgroundColor = BackGround;
            Label_Remaining.ForeColor = ForeGround;
            LabelAppName.ForeColor = ForeGround;
            GroupBoxInformation.BackColor = BackGround;
            GroupBoxInformation.ForeColor = ForeGround;
            PanelGiveaway.BackgroundColor = BackGround;

            PanelStatus.BackgroundColor = BackGround;
            LabelStatus.ForeColor = ForeGround;

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!UserHasEntered)
            {
                if (CheckBoxRules.Checked && UserReadedRules)
                {
                    if (DateTimeOffset.Now.ToUnixTimeSeconds() < Giveawayend)
                    {
                        if (TextBoxName.Text.Length > 1 && TextBoxLastName.Text.Length > 1 && TextBoxTelegram.Text.Length > 1)
                        {
                            BackgroundWorker.RunWorkerAsync();
                        }
                        else
                        {
                            MessageBox.Show("Please Fill all Fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giveaway Ended.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please read and accept rules!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Already Have 1 Entry in this Giveaway", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenRulesIcon_Click(object sender, EventArgs e)
        {
            UserReadedRules = true;
            Process.Start(RulesURL);
        }

        private void LabelRules_Click(object sender, EventArgs e)
        {
            if (CheckBoxRules.Checked)
            {
                CheckBoxRules.Checked = false;
            }
            else
            {
                CheckBoxRules.Checked = true;
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string urlAddress = "https://api.codemage.ir/Projects/SteamPulse/giveaway/newentry/index.php";
            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                    { "hash", Hasher(Environment.UserName+ Environment.OSVersion+ Environment.MachineName) },
                    { "firstname", TextBoxName.Text },
                    { "lastname", TextBoxLastName.Text },
                    { "telegram", TextBoxTelegram.Text }
                };
                try
                {
                    byte[] PHPResponse = client.UploadValues(urlAddress, postData);
                    UTF8Encoding String_UTF8 = new UTF8Encoding();
                    //Logger
                    if (String_UTF8.GetString(PHPResponse).Contains("Duplicate"))
                    {
                        MessageBox.Show("You Already Have 1 Entry in this Giveaway", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CheckUserStatus();
                        MessageBox.Show("Data sended successfully.\nServer Message:\n" + String_UTF8.GetString(PHPResponse), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nDescription:\n" + ex.InnerException + "\n\nTrace:\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
