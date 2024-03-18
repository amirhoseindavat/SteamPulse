using Bunifu.UI.WinForms;
using SteamPulse.Logger;
using SteamPulse.SettingsInterface;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class BugReport : UserControl
    {
        private bool IsSended = false;
        private Main main { get; set; }
        public BugReport(Main Form)
        {
            InitializeComponent();
            main = Form;
        }
        private void TextBoxBugDesc_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBugDesc.Text.Length > 10)
            {
                DescriptionCouunter.ForeColor = Color.FromArgb(24, 49, 83);
                if (TextBoxBugDesc.Text.Length > 99)
                {
                    DescriptionCouunter.Location = new Point(558, 166);
                }
                else
                {
                    DescriptionCouunter.Location = new Point(566, 166);
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
                //DescriptionCouunter.Location = new Point(555, 166);
            }
        }
        private bool IsValidEmail(string eMail)
        {
            bool Result;

            try
            {
                System.Net.Mail.MailAddress eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            }

            return Result;
        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (LabelName.Text != null && DropDownSocialType.Text != "Select One" && LabelSocialMedia.Text != null && BugTitle.Text != null && LabelBugDesc.Text != null)
            {
                if (TextBoxBugDesc.Text.Length <= 400)
                {
                    if (DropDownSocialType.Text != "Email")
                    {
                        if (!IsSended)
                        {
                            BackgroundWorker.RunWorkerAsync();
                        }
                        else { }
                    }
                    else
                    {
                        if (IsValidEmail(TextBoxSocial.Text) == true)
                        {
                            if (!IsSended)
                            {
                                BackgroundWorker.RunWorkerAsync();
                            }
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
                    IsSended = true;
                    Log.LogBugReport();
                    ButtonSend.Invoke((MethodInvoker)(() => ButtonSend.Text = "Sended!"));
                    main.ShowNotification("Thank You! we received your report.", BunifuSnackbar.MessageTypes.Success);

                }
                catch (Exception ex)
                {
                    IsSended = false;
                    ButtonSend.Invoke((MethodInvoker)(() => ButtonSend.Text = "Error!"));
                    main.ShowNotification(ex.Message, BunifuSnackbar.MessageTypes.Error);

                }
            }
        }
        private void BugReport_Load(object sender, EventArgs e)
        {
            if (UserSettings.DarkMode == true)
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
                DescriptionCouunter.BackColor = Color.White;
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                BackColor = GlobalVariables.Colors.Dark.Cello;
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
                BackColor = GlobalVariables.Colors.Light.AthenGray;
            }
            BackColor = BackGround;
            GroupBoxInformation.BackColor = BackGround;
            GroupBoxInformation.ForeColor = ForeGround;
        }
        private void DropDownSocialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownSocialType.Text == "Email")
            {
                TextBoxSocial.PlaceholderText = "Enter Email";
            }
        }
    }
}
