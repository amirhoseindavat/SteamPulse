#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.8.0 Revision 3

#endregion

using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class AppidSearch : Form
    {
        string SearchText;
        JToken RawData;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public AppidSearch()
        {
            InitializeComponent();
        }
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (ComboBoxResult.Text.Contains("-"))
            {
                string[] tokens = ComboBoxResult.Text.Split(new[] { " - " }, StringSplitOptions.None);
                Main.SearchID = tokens[0];
                this.Close();
            }
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Text = "Searching..."));
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();
                string DownloadedData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/db/search.php?searchword=" + SearchText);
                RawData = JToken.Parse(DownloadedData);
                int i = 0;
                for (; ; )
                {
                    if (RawData.SelectToken(".[" + i + "].appid") == null)
                    {
                        break;
                    }
                    else
                    {
                        int appid = Convert.ToInt32(RawData.SelectToken(".[" + i + "].appid"));
                        string name = RawData.SelectToken(".[" + i + "].name").ToString(); ;
                        ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Items.Insert(i, string.Format("{0} - {1}", appid, name))));
                        i++;
                    }
                }
                if (ComboBoxResult.Items.Count == 0)
                {
                    ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Text = "Not Found..."));
                }
                else
                {
                    this.AcceptButton = ButtonLoad;
                    ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.SelectedIndex = 0));
                }

            }
            catch (Exception ex)
            {
                ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Text = "Searching Failed..."));
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Label_Exit_Click(object sender, EventArgs e)
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
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchText = TextBoxSearch.Text;
            SearchText = SearchText.Replace(" ", "%20");
            SearchText = "%25" + SearchText + "%25";
            ComboBoxResult.Items.Clear();
            BackgroundWorker.RunWorkerAsync();
        }
        private void AppidSearch_Load(object sender, EventArgs e)
        {
            TextBoxSearch.SelectAll();
            if (Settings.DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
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

                this.BackColor = GlobalVariables.Colors.Dark.Cello;
                ButtonLoad.Image = Properties.Resources.BTNLoadLight;
                ButtonSearch.Image = Properties.Resources.SearchWhite;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
                ButtonLoad.Image = Properties.Resources.BTNLoadDark;
                ButtonSearch.Image = Properties.Resources.SearchBlack;
            }
            ButtonLoad.BackColor = BackGround;
            ButtonSearch.BackColor = BackGround;
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelMain.BackgroundColor = BackGround;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = ButtonSearch;
        }
    }
}
