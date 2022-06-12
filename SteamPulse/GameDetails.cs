#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.5.0 Revision 6

#endregion

using SteamAPI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class GameDetails : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static string GameImageURL = "";
        public static Boolean DarkMode;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public GameDetails()
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
        private void In_Game_Load(object sender, EventArgs e)
        {


            DarkMode = Convert.ToBoolean(Properties.Settings.Default["DarkMode"]);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            GetData.ConnectToSteam.Store();

            if (LoadData.Store.Type == "dlc")
            {
                Label_AppName.Text = "DLC Details";
                this.Name = "DLC Details";
                LabelOwned.Visible = false;
                LabelPlayTime.Visible = false;
                LabelName.Location = new Point(237, 69);
                Panel.Size = new Size(746, 344);
                this.Size = new Size(776, 407);
                PictureBoxOwned.Visible = false;
            }

            //label.Text = string.Format("{0} -{1}%", LoadData.Store.Name(), LoadData.Store.Price.Discount_Percent());
            try
            {
                if (GetData.Appid == 1250410)
                {
                    PictureBox.Load("https://cdn.codemage.ir/Projects/SteamPulse/Resource/MSFS/library.jpg");
                }
                else
                {
                    PictureBox.Load(LoadData.Store.LibraryImage);
                }
            }
            catch
            {
                if (GetData.Appid == 1250410)
                {
                    PictureBox.Load(LoadData.Store.LibraryImage);
                }
                else
                {
                    PictureBox.Load(LoadData.Store.HeaderImage);
                }
            }
            if (GetData.Appid == 1250410)
            {
                LabelName.Text = "Microsoft Loading Simulator";
            }
            else
            {
                LabelName.Text = LoadData.Store.Name;
            }

            if (LoadData.Store.IsComingSoon == true)
            {
                try
                {
                    //LabelRelease.Text = String.Format("Release Date: {0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), (LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        LabelRelease.Text = String.Format("Release Date: {0} ({1} Years to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365);
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        LabelRelease.Text = String.Format("Release Date: {0} ({1} Months to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30);
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        LabelRelease.Text = String.Format("Release Date: {0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount);
                    }
                    else
                    {
                        LabelRelease.Text = String.Format("Release Date: {0}", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"));
                    }
                }
                catch
                {
                    LabelRelease.Text = String.Format("Release Date: {0}", LoadData.Store.ReleaseDateString.ToString());
                }
            }

            else
            {

                try
                {
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        LabelRelease.Text = String.Format("Release Date: {0} ({1} Years Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365);
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        LabelRelease.Text = String.Format("Release Date: {0} ({1} Months Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30);
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        LabelRelease.Text = String.Format("Release Date: {0} ({1} days Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount);
                    }
                    else
                    {
                        LabelRelease.Text = String.Format("Release Date: {0}", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"));
                    }
                }
                catch
                {
                    LabelRelease.Text = String.Format("Release Date: {0}", LoadData.Store.ReleaseDateString.ToString());
                }

            }
            if (LoadData.Store.IsComingSoon == true)
            {
                LabelCount.Text = "Player Count: Not Released";
            }
            else
            {
                LabelCount.Text = String.Format("Player Count: {0}", String.Format("{0:n0} ", LoadData.Store.PlayerCount));
            }

            LabelDev.Text = String.Format("Developers: {0}", LoadData.Store.Developers);
            LabelPublisher.Text = String.Format("Publisher: {0}", LoadData.Store.Publishers);
            GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
            if (Convert.ToBoolean(Properties.Settings.Default["CheckOwned"]) == true)
            {
                if (LoadData.Community.Isowned(GetData.Appid) == true)
                {
                    LabelOwned.Text = "Owned";
                    if (LoadData.Community.Playtime(GetData.Appid) == 0)
                    {
                        if (LoadData.Store.IsComingSoon == true)
                        {
                            //LabelPlayTime.Text = "Playtime: Not Released";
                            LabelPlayTime.Visible = false;
                            LabelName.Location = new Point(237, 69);
                        }
                        else
                        {
                            LabelPlayTime.Text = "Playtime: Not Played";
                        }
                    }
                    else
                    {
                        if (LoadData.Community.Playtime(GetData.Appid) < 120)
                        {
                            LabelPlayTime.Text = String.Format("Playtime: {0} Minutes", LoadData.Community.Playtime(GetData.Appid));
                        }
                        else
                        {
                            LabelPlayTime.Text = String.Format("Playtime: {0} Hours", String.Format("{0:n0}", LoadData.Community.Playtime(GetData.Appid) / 60));
                        }
                    }
                }
                else
                {
                    LabelOwned.Text = "Not Owned";
                    PictureBoxOwned.Image = Properties.Resources.xmark_solid;
                    LabelPlayTime.Visible = false;
                    LabelName.Location = new Point(237, 69);
                }

            }
            else
            {
                LabelOwned.Visible = false;
                LabelPlayTime.Visible = false;
                LabelName.Location = new Point(237, 69);
                Panel.Size = new Size(746, 344);
                this.Size = new Size(776, 407);
                PictureBoxOwned.Visible = false;
            }

        }
        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenSteam_Click(object sender, EventArgs e)
        {
            Process.Start("steam://openurl/https://store.steampowered.com/app/" + GetData.Appid);
        }
        private void OpenSteamDB_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamdb.info/app/" + GetData.Appid);
        }
        private void OpenPCGW_Click(object sender, EventArgs e)
        {
            Process.Start("https://pcgamingwiki.com/api/appid.php?appid=" + GetData.Appid);
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
                OpenPCGWIcon.Image = Properties.Resources.OpenExternal;
                OpenSteamDBIcon.Image = Properties.Resources.OpenExternal;
                OpenSteamIcon.Image = Properties.Resources.OpenExternal;

            }
            else
            {
                BackGround = Color.FromArgb(255, 255, 255);
                ForeGround = Color.FromArgb(24, 49, 83);
                this.BackColor = Color.FromArgb(241, 240, 245);
                OpenPCGWIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenSteamDBIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenSteamIcon.Image = Properties.Resources.OpenExternalBlack;
            }
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            Panel.BackgroundColor = BackGround;
            LabelCount.ForeColor = ForeGround;
            LabelDev.ForeColor = ForeGround;
            LabelName.ForeColor = ForeGround;
            LabelOwned.ForeColor = ForeGround;
            LabelPlayTime.ForeColor = ForeGround;
            LabelPublisher.ForeColor = ForeGround;
            LabelRelease.ForeColor = ForeGround;
            bunifuSeparator1.LineColor = ForeGround;
            OpenSteam.ForeColor = ForeGround;
            OpenSteamDB.ForeColor = ForeGround;
            OpenPCGW.ForeColor = ForeGround;


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
