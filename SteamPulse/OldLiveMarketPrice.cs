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
using SteamPulse.Logger;
using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SteamPulse
{
    public partial class OldLiveMarketPrice : Form
    {
        public static bool SettingisUpdated;
        public static bool DarkMode;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public OldLiveMarketPrice()
        {
            InitializeComponent();
        }

        private int timer = 30;
        private double Key_before;
        private double Ticket_before;
        public void Price_updater()
        {
            GetData.ConnectToSteam.Market.TF2Key();
            KeyMarket.Text = string.Format("{0} {1}", LoadData.Market.Key.LowestSellOrder, Settings.Currency.Unit);
            KeyYou.Text = string.Format("{0} {1}", LoadData.Market.Key.LowestSellOrderNoFee, Settings.Currency.Unit);

            GetData.ConnectToSteam.Market.TF2Ticket();
            TicketMarket.Text = string.Format("{0} {1}", LoadData.Market.Ticket.LowestSellOrder, Settings.Currency.Unit);
            TicketYou.Text = string.Format("{0} {1}", LoadData.Market.Ticket.LowestSellOrderNoFee, Settings.Currency.Unit);

            IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
            Log.LogMarket("Data Loaded Successfully.", LoadData.Market.Key.LowestSellOrder, LoadData.Market.Ticket.LowestSellOrderNoFee);
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
                    Key_before = LoadData.Market.Key.LowestSellOrder;
                    Ticket_before = LoadData.Market.Ticket.LowestSellOrder;
                    updater_label.Text = "Status : Updating";
                    timer = Convert.ToInt32(Settings.MarketUpdateTime);

                    Price_updater();
                    IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
                    KeyStatus();
                    TicketStatus();
                    if (LoadData.Market.Key.LowestSellOrder == 0 && LoadData.Market.Ticket.LowestSellOrder == 0)
                    {
                        updater_label.Text = "Status : Steam is Uncreachable!";
                        Log.LogMarket("Steam is Uncreachable!");
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
            if (LoadData.Market.Key.LowestSellOrder == 0 && LoadData.Market.Ticket.LowestSellOrder == 0)
            {
                updater_label.Text = "Status : Steam is Uncreachable!";
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
            Close();
        }
        private void KeyStatus()
        {
            if (Key_before < LoadData.Market.Key.LowestSellOrder)
            {
                Key_indicator.Image = Properties.Resources.Up;
            }
            else if (Key_before > LoadData.Market.Key.LowestSellOrder)
            {
                Key_indicator.Image = Properties.Resources.Down;
            }
            else if (Key_before == LoadData.Market.Key.LowestSellOrder)
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
            if (Ticket_before < LoadData.Market.Ticket.LowestSellOrder)
            {
                Ticket_indicator.Image = Properties.Resources.Up;
            }
            else if (Ticket_before > LoadData.Market.Ticket.LowestSellOrder)
            {
                Ticket_indicator.Image = Properties.Resources.Down;
            }
            else if (Ticket_before == LoadData.Market.Ticket.LowestSellOrder)
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
        private void IRTCHeck(bool status)
        {
            if (status == true)
            {
                Size = new Size(456, 423);
                PanelKeyIRT.Visible = true;
                PanelTicketIRT.Visible = true;
                if (GetData.IRT.Key() == true)
                {
                    if (LoadData.IRT.Key.Price != 0)
                    {
                        KeyIRT.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.IRT.Key.Price));
                    }
                }
                else
                {
                    KeyIRT.Text = string.Format("Price : {0} IRT", 0);
                }

                if (GetData.IRT.Ticket() == true)
                {
                    if (LoadData.IRT.Ticket.Price != 0)
                    {
                        TicketIRT.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.IRT.Ticket.Price));
                    }
                }
                else
                {
                    TicketIRT.Text = string.Format("Price : {0} IRT", 0);
                }
            }
            else if (status == false)
            {
                Size = new Size(456, 371);
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
            Close();
        }
        private void TicketIRT_Click(object sender, EventArgs e)
        {
            Process.Start(LoadData.IRT.Ticket.BuyURL);
        }
        private void KeyIRT_Click(object sender, EventArgs e)
        {
            Process.Start(LoadData.IRT.Key.BuyURL);
        }
        private void PictureBoxTIcket_Click(object sender, EventArgs e)
        {
            Process.Start("steam://openurl/https://steamcommunity.com/market/listings/440/Tour%20of%20Duty%20Ticket");
        }
        private void PictureBoxKey_Click(object sender, EventArgs e)
        {
            Process.Start("steam://openurl/https://steamcommunity.com/market/listings/440/Mann%20Co.%20Supply%20Crate%20Key");
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
                Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                Key_indicator.Image = Properties.Resources.NoChangeDark;

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
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
