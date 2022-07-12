#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.8.1 

#endregion
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class Status : Form
    {
        readonly Color FlatRed = Color.FromArgb(244, 67, 54);
        readonly Color FlatGreen = Color.FromArgb(46, 204, 113);
        //readonly Color FlatGray = Color.FromArgb(191, 191, 191);

        readonly string SteamStore = "104.99.232.134";
        readonly string SteamCommunity = "23.62.135.246";
        readonly string CodeMage = "5.196.141.85";
        readonly string GamingClub = "185.73.226.40";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Status()
        {
            InitializeComponent();
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return pingable;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (PingHost(SteamStore))
            {
                IndicatorSteamStore.Invoke((MethodInvoker)(() => IndicatorSteamStore.IdleFillColor = FlatGreen));
                IndicatorSteamStore.Invoke((MethodInvoker)(() => IndicatorSteamStore.onHoverState.FillColor = FlatGreen));
            }
            else
            {
                IndicatorSteamStore.Invoke((MethodInvoker)(() => IndicatorSteamStore.IdleFillColor = FlatRed));
                IndicatorSteamStore.Invoke((MethodInvoker)(() => IndicatorSteamStore.onHoverState.FillColor = FlatRed));
            }

            if (PingHost(SteamCommunity))
            {
                IndicatorSteamCommunity.Invoke((MethodInvoker)(() => IndicatorSteamCommunity.IdleFillColor = FlatGreen));
                IndicatorSteamCommunity.Invoke((MethodInvoker)(() => IndicatorSteamCommunity.onHoverState.FillColor = FlatGreen));
            }
            else
            {
                IndicatorSteamCommunity.Invoke((MethodInvoker)(() => IndicatorSteamCommunity.IdleFillColor = FlatRed));
                IndicatorSteamCommunity.Invoke((MethodInvoker)(() => IndicatorSteamCommunity.onHoverState.FillColor = FlatRed));
            }
            if (PingHost(CodeMage))
            {
                IndicatorCodeMage.Invoke((MethodInvoker)(() => IndicatorCodeMage.IdleFillColor = FlatGreen));
                IndicatorCodeMage.Invoke((MethodInvoker)(() => IndicatorCodeMage.onHoverState.FillColor = FlatGreen));
            }
            else
            {
                IndicatorCodeMage.Invoke((MethodInvoker)(() => IndicatorCodeMage.IdleFillColor = FlatRed));
                IndicatorCodeMage.Invoke((MethodInvoker)(() => IndicatorCodeMage.onHoverState.FillColor = FlatRed));
            }
            if (PingHost(GamingClub))
            {
                IndicatorGamingClub.Invoke((MethodInvoker)(() => IndicatorGamingClub.IdleFillColor = FlatGreen));
                IndicatorGamingClub.Invoke((MethodInvoker)(() => IndicatorGamingClub.onHoverState.FillColor = FlatGreen));
            }
            else
            {
                IndicatorGamingClub.Invoke((MethodInvoker)(() => IndicatorGamingClub.IdleFillColor = FlatRed));
                IndicatorGamingClub.Invoke((MethodInvoker)(() => IndicatorGamingClub.onHoverState.FillColor = FlatRed));
            }
        }

        private void Status_Load(object sender, EventArgs e)
        {
            if (Settings.DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            if (PingHost(SteamStore))
            {
                IndicatorSteamStore.IdleFillColor = FlatGreen;
                IndicatorSteamStore.onHoverState.FillColor = FlatGreen;
            }
            else
            {
                IndicatorSteamStore.IdleFillColor = FlatRed;
                IndicatorSteamStore.onHoverState.FillColor = FlatRed;
            }

            if (PingHost(SteamCommunity))
            {
                IndicatorSteamCommunity.IdleFillColor = FlatGreen;
                IndicatorSteamCommunity.onHoverState.FillColor = FlatGreen;
            }
            else
            {
                IndicatorSteamCommunity.IdleFillColor = FlatRed;
                IndicatorSteamCommunity.onHoverState.FillColor = FlatRed;
            }
            if (PingHost(CodeMage))
            {
                IndicatorCodeMage.IdleFillColor = FlatGreen;
                IndicatorCodeMage.onHoverState.FillColor = FlatGreen;
            }
            else
            {
                IndicatorCodeMage.IdleFillColor = FlatRed;
                IndicatorCodeMage.onHoverState.FillColor = FlatRed;
            }
            if (PingHost(GamingClub))
            {
                IndicatorGamingClub.IdleFillColor = FlatGreen;
                IndicatorGamingClub.onHoverState.FillColor = FlatGreen;
            }
            else
            {
                IndicatorGamingClub.IdleFillColor = FlatRed;
                IndicatorGamingClub.onHoverState.FillColor = FlatRed;
            }
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            PanelMail.BackgroundColor = BackGround;
            LabelGamingClub.ForeColor = ForeGround;
            LabelCodeMage.ForeColor = ForeGround;
            LabelSteamCommunity.ForeColor = ForeGround;
            LabelSteamStore.ForeColor = ForeGround;
        }
    }
}
