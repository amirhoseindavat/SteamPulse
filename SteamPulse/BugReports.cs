#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.8.0 Revision 4

#endregion

using SteamPulse.UserSettings;
using SteamPulse.Logger;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class BugReports : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string ExceptionError;
        public BugReports()
        {
            InitializeComponent();
        }
        private void TextBoxBugDesc_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBugDesc.Text.Length > 10)
            {
                DescriptionCouunter.ForeColor = Color.FromArgb(24, 49, 83);
                if (TextBoxBugDesc.Text.Length > 99)
                {
                    DescriptionCouunter.Location = new Point(352, 216);
                }
                else
                {
                    DescriptionCouunter.Location = new Point(360, 216);
                }
                DescriptionCouunter.Visible = true;
                DescriptionCouunter.Text = TextBoxBugDesc.Text.Length.ToString();
            }
            if (TextBoxBugDesc.Text.Length < 10)
            {
                DescriptionCouunter.Visible = false;
            }
            if (TextBoxBugDesc.Text.Length >= 400)
            {
                DescriptionCouunter.Text = (400 - TextBoxBugDesc.Text.Length).ToString();
                DescriptionCouunter.ForeColor = Color.Red;
            }
        }
        bool IsValidEmail(string eMail)
        {
            bool Result;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            }

            return Result;
        }
        private void LabelSend_Click(object sender, EventArgs e)
        {
            if (LabelName.Text != null && DropDownSocialType.Text != "Select One" && LabelSocialMedia.Text != null && BugTitle.Text != null && LabelBugDesc.Text != null)
            {
                if (TextBoxBugDesc.Text.Length <= 400)
                {
                    if (DropDownSocialType.Text != "Email")
                    {
                        if (LabelSend.Text != "Sended Successfuly")
                            BackgroundWorker.RunWorkerAsync();
                        else { }
                    }
                    else
                    {
                        if (IsValidEmail(TextBoxSocial.Text) == true)
                        {
                            if (LabelSend.Text != "Sended Successfuly")
                                BackgroundWorker.RunWorkerAsync();
                            else { }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Reduce Description to 400 word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Fill all Field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string urlAddress = "https://api.codemage.ir/Projects/SteamPulse/db/bugreport.php";
            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                    { "name", TextBoxName.Text },
                    { "socialtype", DropDownSocialType.Text },
                    { "socialmedia", TextBoxSocial.Text },
                    { "title", TextBoxBugTitle.Text },
                    { "description", TextBoxBugDesc.Text },
                    { "status", "Not Viewed." }
                };
                try
                {
                    client.UploadValues(urlAddress, postData);
                    LabelSend.Invoke((MethodInvoker)(() => LabelSend.Text = "Sended Successfuly"));
                    Log.LogBugReport();
                    LabelSend.Invoke((MethodInvoker)(() => LabelSend.ForeColor = Color.Green));
                }
                catch (Exception ex)
                {
                    LabelSend.Invoke((MethodInvoker)(() => LabelSend.Text = "Failed to Send"));
                    LabelSend.Invoke((MethodInvoker)(() => LabelSend.ForeColor = Color.Red));
                    ExceptionError = ex.Message;

                }
            }
        }
        private void LabelSend_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(LabelSend, ExceptionError);
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
        private void BugReports_Load(object sender, EventArgs e)
        {
            if (Settings.DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
        }
        private void ChangeTheme(Boolean Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                DescriptionCouunter.BackColor = Color.White;
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                this.BackColor = GlobalVariables.Colors.Dark.Cello;
                GroupBoxBug.BackColor = BackGround;
                GroupBoxBug.ForeColor = ForeGround;
                TextBoxBugDesc.ForeColor = BackGround;
                TextBoxBugTitle.ForeColor = BackGround;
                TextBoxName.ForeColor = BackGround;
                TextBoxSocial.ForeColor = BackGround;
                DescriptionCouunter.ForeColor = ForeGround;
                DescriptionCouunter.BackColor = Color.White;

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
            }
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelInformation.BackgroundColor = BackGround;
            GroupBoxInformation.BackColor = BackGround;
            GroupBoxInformation.ForeColor = ForeGround;
            PanelBug.BackgroundColor = BackGround;
        }
        private void DropDownSocialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownSocialType.Text == "Email")
                TextBoxSocial.PlaceholderText = "Enter Email";
        }
    }
}
