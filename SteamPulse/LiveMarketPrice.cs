#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.5.0 Revision 3

#endregion
using SteamAPI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SteamPulse
{
    public partial class LiveMarketPrice : Form
    {
        public static Boolean SettingisUpdated;
        public static Boolean DarkMode;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public LiveMarketPrice()
        {
            InitializeComponent();
        }
        int timer = 30;
        double Key_before;
        double Ticket_before;
        public void Price_updater()
        {
            GetData.ConnectToSteam.Market.TF2Key();
            KeyMarket.Text = String.Format("{0} {1}", LoadData.Market.Key.LowestPrice, Settings.Currency.Unit);
            KeyYou.Text = String.Format("{0} {1}", LoadData.Market.Key.User_Price, Settings.Currency.Unit);

            GetData.ConnectToSteam.Market.TF2Ticket();
            TicketMarket.Text = String.Format("{0} {1}", LoadData.Market.Ticket.LowestPrice, Settings.Currency.Unit);
            TicketYou.Text = String.Format("{0} {1}", LoadData.Market.Ticket.User_Price, Settings.Currency.Unit);

            IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
            Logger.LogMarket("Data Loaded Successfully.", LoadData.Market.Key.LowestPrice, LoadData.Market.Ticket.User_Price);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer--;
            for (int i = 0; i > Settings.MarketUpdateTime; i++)
            {
                updater_label.Text = "Status : Updating in " + timer.ToString() + " Second";
                timer--;
            }
            if (timer <= 5)
            {
                updater_label.Text = "Status : Updating in " + timer.ToString() + " Second";
                if (timer == 0)
                {
                    Key_before = LoadData.Market.Key.LowestPrice;
                    Ticket_before = LoadData.Market.Ticket.LowestPrice;
                    updater_label.Text = "Status : Updating";
                    timer = Convert.ToInt32(Settings.MarketUpdateTime);

                    Price_updater();
                    IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
                    KeyStatus();
                    TicketStatus();
                    if (LoadData.Market.Key.LowestPrice == 0 && LoadData.Market.Ticket.LowestPrice == 0)
                    {
                        updater_label.Text = "Status : Steam is Uncreachable!";
                        Logger.LogMarket("Steam is Uncreachable!");
                    }
                    else
                    {
                        updater_label.Text = "Status : Updated on " + DateTime.Now.ToString("h:mm:ss tt");
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Price_updater();
            if (LoadData.Market.Key.LowestPrice == 0 && LoadData.Market.Ticket.LowestPrice == 0)
            {
                updater_label.Text = "Status : Steam isUncreachable!";
            }
            else
            {
                updater_label.Text = "Status : Updated on " + DateTime.Now.ToString("h:mm:ss tt");
            }

            IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));

            DarkMode = Convert.ToBoolean(Settings.DarkMode);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
        }
        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KeyStatus()
        {
            if (Key_before < LoadData.Market.Key.LowestPrice)
            {
                Key_indicator.Image = Properties.Resources.Up;
            }
            else if (Key_before > LoadData.Market.Key.LowestPrice)
            {
                Key_indicator.Image = Properties.Resources.Down;
            }
            else if (Key_before == LoadData.Market.Key.LowestPrice)
            {
                if (Settings.DarkMode == true)
                {
                    Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                }
                else
                {
                    Ticket_indicator.Image = Properties.Resources.NoChangeLight;
                }
            }
        }
        private void TicketStatus()
        {
            if (Ticket_before < LoadData.Market.Ticket.LowestPrice)
            {
                Ticket_indicator.Image = Properties.Resources.Up;
            }
            else if (Ticket_before > LoadData.Market.Ticket.LowestPrice)
            {
                Ticket_indicator.Image = Properties.Resources.Down;
            }
            else if (Ticket_before == LoadData.Market.Ticket.LowestPrice)
            {
                if (Settings.DarkMode == true)
                {
                    Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                }
                else
                {
                    Ticket_indicator.Image = Properties.Resources.NoChangeLight;
                }
            }
        }
        private void LiveMarketPrice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void IRTCHeck(Boolean status)
        {
            if (status == true)
            {
                this.Size = new Size(456, 423);
                PanelKeyIRT.Visible = true;
                PanelTicketIRT.Visible = true;
                if (GetData.GamingClub.Key() == true)
                {
                    if (LoadData.GamingClub.Key != 0)
                    {
                        KeyIRT.Text = String.Format("Price : {0}IRT", String.Format("{0:n0} ", LoadData.GamingClub.Key));
                    }
                }
                else
                {
                    KeyIRT.Text = String.Format("Price : {0} IRT", 0);
                }

                if (GetData.GamingClub.Ticket() == true)
                {
                    if (LoadData.GamingClub.Ticket != 0)
                    {
                        TicketIRT.Text = String.Format("Price : {0}IRT", String.Format("{0:n0} ", LoadData.GamingClub.Ticket));
                    }
                }
                else
                {
                    TicketIRT.Text = String.Format("Price : {0} IRT", 0);
                }
            }
            else if (status == false)
            {
                this.Size = new Size(456, 371);
                PanelKeyIRT.Visible = false;
                PanelTicketIRT.Visible = false;
            }

        }
        private void LiveMarketPrice_Activated(object sender, EventArgs e)
        {
            if (SettingisUpdated == true)
            {
                IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
                SettingisUpdated = false;
            }
            else { }

            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
        }
        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calculator = new Calculator();
            calculator.ShowDialog();
        }
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Setting();
            settings.ShowDialog();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TicketIRT_Click(object sender, EventArgs e)
        {
            Process.Start("https://gaming-club.ir/product/tour-of-duty-ticket");
        }
        private void KeyIRT_Click(object sender, EventArgs e)
        {
            Process.Start("https://gaming-club.ir/product/mann-co-supply-crate-key");
        }
        private void PictureBoxTIcket_Click(object sender, EventArgs e)
        {
            Process.Start("steam://openurl/https://steamcommunity.com/market/listings/440/Tour%20of%20Duty%20Ticket");
        }
        private void PictureBoxKey_Click(object sender, EventArgs e)
        {
            Process.Start("steam://openurl/https://steamcommunity.com/market/listings/440/Mann%20Co.%20Supply%20Crate%20Key");
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
                Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                Key_indicator.Image = Properties.Resources.NoChangeDark;

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
                Ticket_indicator.Image = Properties.Resources.NoChangeLight;
                Key_indicator.Image = Properties.Resources.NoChangeLight;
            }
            PanelHeader.BackgroundColor = BackGround;
            LabelAppName.BackColor = BackGround;
            LabelAppName.ForeColor = ForeGround;
            updater_label.ForeColor = ForeGround;
            PanelTicket.BackgroundColor = BackGround;
            PanelKey.BackgroundColor = BackGround;
            LabelKey.ForeColor = ForeGround;
            LabelTicket.ForeColor = ForeGround;
            LabelKey.ForeColor = ForeGround;
            PanelKeyPrice.BackgroundColor = BackGround;
            PanelTicketPRice.BackgroundColor = BackGround;
            TicketMarket.ForeColor = ForeGround;
            TicketYou.ForeColor = ForeGround;
            KeyMarket.ForeColor = ForeGround;
            KeyYou.ForeColor = ForeGround;
            KeySeparator.LineColor = ForeGround;
            TicketSeparator.LineColor = ForeGround;
            PanelTicketIRT.BackgroundColor = BackGround;
            PanelKeyIRT.BackgroundColor = BackGround;
            KeyIRT.ForeColor = ForeGround;
            TicketIRT.ForeColor = ForeGround;
        }
    }
}
