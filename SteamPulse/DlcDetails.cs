#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// C# Steam API
//
// https://Amirhoseindavat.ir
//
// Beta Build
//
// Version 1.9
#endregion

using SteamAPI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class DlcDetails : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static string GameImageURL = "";
        public static Boolean DarkMode;
        private Boolean isowned = false;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public DlcDetails()
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

            GetData.ConnectToSteam.Store();

            try
            {
                PictureBox.Load(LoadData.Store.LibraryImage);
            }
            catch
            {
                PictureBox.Load(LoadData.Store.HeaderImage);
            }
            GetData.DLCID = GetData.Appid;

            LabelName.Text = String.Format("Name: {0}", LoadData.Store.DLC.Data.Name);

            LabelGameName.Text = String.Format("Game: {0}", LoadData.Store.DLC.Data.OrigialGamename);          

            isowned = LoadData.Community.Isowned(LoadData.Store.DLC.Data.OrigialGameID);

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

            LabelDev.Text = String.Format("Developers: {0}", LoadData.Store.Developers);
            LabelPublisher.Text = String.Format("Publisher: {0}", LoadData.Store.Publishers);
            GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());

        }
        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenSteam_Click(object sender, EventArgs e)
        {
            if (isowned == true)
            {
                Process.Start("steam://nav/games/details/" + LoadData.Store.DLC.Data.OrigialGameID);
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
        private void ChangeTheme(Boolean Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                this.BackColor = GlobalVariables.Colors.Dark.Cello;
                OpenPCGWIcon.Image = Properties.Resources.OpenExternal;
                OpenSteamDBIcon.Image = Properties.Resources.OpenExternal;
                OpenSteamIcon.Image = Properties.Resources.OpenExternal;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
                OpenPCGWIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenSteamDBIcon.Image = Properties.Resources.OpenExternalBlack;
                OpenSteamIcon.Image = Properties.Resources.OpenExternalBlack;
            }
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            Panel.BackgroundColor = BackGround;
            LabelDev.ForeColor = ForeGround;
            LabelName.ForeColor = ForeGround;
            LabelGameName.ForeColor = ForeGround;
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
