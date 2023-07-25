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

using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
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
        public static bool DarkMode;
        private bool isowned = false;
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


            DarkMode = Settings.DarkMode;
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            GetData.ConnectToSteam.Store(GetData.Appid);


            //label.Text = string.Format("{0} -{1}%", LoadData.Store.Name(), LoadData.Store.Price.Discount_Percent());
            try
            {
                if (GetData.Appid == 1250410)
                {
                    PictureBox.Load(GlobalVariables.Images.Hero.MSFS);
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
                LabelName.Text = GlobalVariables.Names.MSFS;
            }
            else
            {
                LabelName.Text = LoadData.Store.Name;
            }

            if (LoadData.Store.IsComingSoon == true)
            {
                try
                {
                    //LabelRelease.Text = String.Format("Release: {0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), (LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        LabelRelease.Text = string.Format("Release: {0} ({1} Years to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365);
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        LabelRelease.Text = string.Format("Release: {0} ({1} Months to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30);
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        LabelRelease.Text = string.Format("Release: {0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount);
                    }
                    else
                    {
                        LabelRelease.Text = string.Format("Release: {0}", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"));
                    }
                }
                catch
                {
                    LabelRelease.Text = string.Format("Release: {0}", LoadData.Store.ReleaseDateString.ToString());
                }
            }

            else
            {

                try
                {
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        LabelRelease.Text = string.Format("Release: {0} ({1} Years Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365);
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        LabelRelease.Text = string.Format("Release: {0} ({1} Months Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30);
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        LabelRelease.Text = string.Format("Release: {0} ({1} days Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount);
                    }
                    else
                    {
                        LabelRelease.Text = string.Format("Release: {0}", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"));
                    }
                }
                catch
                {
                    LabelRelease.Text = string.Format("Release: {0}", LoadData.Store.ReleaseDateString.ToString());
                }

            }
            if (LoadData.Store.IsComingSoon == true)
            {
                LabelCount.Text = "Player Count: Not Released";
            }
            else
            {
                LabelCount.Text = string.Format("Player Count: {0}", string.Format("{0:n0} ", LoadData.Store.PlayerCount));
            }

            LabelDev.Text = string.Format("Developers: {0}", LoadData.Store.Developers);
            LabelPublisher.Text = string.Format("Publisher: {0}", LoadData.Store.Publishers);
            GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
            if (Settings.CheckOwned == true)
            {
                if (LoadData.Community.Isowned(GetData.Appid) == true)
                {
                    LabelOwned.Text = "Owned";
                    isowned = true;
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
                            LabelPlayTime.Text = string.Format("Playtime: {0} Minutes", LoadData.Community.Playtime(GetData.Appid));
                        }
                        else
                        {
                            LabelPlayTime.Text = string.Format("Playtime: {0} Hours", string.Format("{0:n0}", LoadData.Community.Playtime(GetData.Appid) / 60));
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
                Size = new Size(776, 407);
                PictureBoxOwned.Visible = false;
            }

        }
        private void Label_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OpenSteam_Click(object sender, EventArgs e)
        {
            if (isowned == true)
            {
                Process.Start("steam://nav/games/details/" + GetData.Appid);
            }
            else
            {
                Process.Start("steam://openurl/https://store.steampowered.com/app/" + GetData.Appid);
            }
        }
        private void OpenSteamDB_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamdb.info/app/" + GetData.Appid);
        }
        private void OpenPCGW_Click(object sender, EventArgs e)
        {
            Process.Start("https://pcgamingwiki.com/api/appid.php?appid=" + GetData.Appid);
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
                OpenPCGWIcon.Image = Properties.Resources.OpenExternal;
                OpenSteamDBIcon.Image = Properties.Resources.OpenExternal;
                OpenSteamIcon.Image = Properties.Resources.OpenExternal;

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
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
