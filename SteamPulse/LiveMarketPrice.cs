#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.5.0 Revision 5
// last Edit: 10/26/22 V2.0
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
        public static bool SettingisUpdated;
        public static bool DarkMode;
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
        double Key_Sell_before, Key_Buy_before;
        double Ticket_Sell_before , Ticket_Buy_before;
        public void Price_updater()
        {
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer--;
            for (int i = 0; i > Settings.MarketUpdateTime; i++)
            {
                Label_Update_Status.Text = "Status : Updating in " + timer.ToString() + " Second";
                timer--;
            }
            if (timer <= 5)
            {
                if(!BackgroundWorker.IsBusy)
                {
                    Label_Update_Status.Text = "Status : Updating in " + timer.ToString() + " Second";
                    if (timer == 0)
                    {
                        Key_Sell_before = LoadData.Market.Key.LowestSellOrder;
                        Ticket_Sell_before = LoadData.Market.Ticket.LowestSellOrder;
                        Key_Buy_before = LoadData.Market.Key.HighestBuyOrder;
                        Ticket_Buy_before = LoadData.Market.Ticket.HighestBuyOrder;
                        Label_Update_Status.Text = "Status : Updating";
                        timer = Convert.ToInt32(Settings.MarketUpdateTime);

                        BackgroundWorker.RunWorkerAsync();
                        IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
                        Key_Sell_Status();
                        Ticket_Sell_Status();
                        Key_Buy_Status();
                        Ticket_Buy_Status();
                        if (LoadData.Market.Key.LowestSellOrder == 0 && LoadData.Market.Ticket.LowestSellOrder == 0)
                        {
                            Label_Update_Status.Text = "Status : Steam is Uncreachable!";
                            Logger.LogMarket("Steam is Uncreachable!");
                        }
                        else
                        {
                            Label_Update_Status.Text = "Status : Updated on " + DateTime.Now.ToString("h:mm:ss tt");
                        }
                    }
                }
            }
        }
        private void LivMarket_Load(object sender, EventArgs e)
        {
            BackgroundWorker.RunWorkerAsync();

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
        private void Key_Sell_Status()
        {
            if (Key_Sell_before < LoadData.Market.Key.LowestSellOrder)
            {
                Key_indicator.Image = Properties.Resources.Up;
            }
            else if (Key_Sell_before > LoadData.Market.Key.LowestSellOrder)
            {
                Key_indicator.Image = Properties.Resources.Down;
            }
            else if (Key_Sell_before == LoadData.Market.Key.LowestSellOrder)
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
        private void Ticket_Sell_Status()
        {
            if (Ticket_Sell_before < LoadData.Market.Ticket.LowestSellOrder)
            {
                Ticket_indicator.Image = Properties.Resources.Up;
            }
            else if (Ticket_Sell_before > LoadData.Market.Ticket.LowestSellOrder)
            {
                Ticket_indicator.Image = Properties.Resources.Down;
            }
            else if (Ticket_Sell_before == LoadData.Market.Ticket.LowestSellOrder)
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
        private void Key_Buy_Status()
        {
            if (Key_Buy_before < LoadData.Market.Key.HighestBuyOrder)
            {
                Key_indicator.Image = Properties.Resources.Up;
            }
            else if (Key_Buy_before > LoadData.Market.Key.HighestBuyOrder)
            {
                Key_indicator.Image = Properties.Resources.Down;
            }
            else if (Key_Buy_before == LoadData.Market.Key.HighestBuyOrder)
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
        private void Ticket_Buy_Status()
        {
            if (Ticket_Buy_before < LoadData.Market.Ticket.HighestBuyOrder)
            {
                Ticket_indicator.Image = Properties.Resources.Up;
            }
            else if (Ticket_Buy_before > LoadData.Market.Ticket.HighestBuyOrder)
            {
                Ticket_indicator.Image = Properties.Resources.Down;
            }
            else if (Ticket_Buy_before == LoadData.Market.Ticket.HighestBuyOrder)
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
                this.Size = new Size(792, 525);
                PanelStatus.Size = new Size(763, 434);
                PanelKeyIRT.Visible = true;
                PanelTicketIRT.Visible = true;
                
            }
            else if (status == false)
            {
                this.Size = new Size(792, 442);
                PanelStatus.Size = new Size(763, 357);
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
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                this.BackColor = GlobalVariables.Colors.Dark.Cello;
                Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                Ticket_Histogram_Indicator.Image = Properties.Resources.NoChangeDark;
                Key_indicator.Image = Properties.Resources.NoChangeDark;
                Key_Histogram_Indicator.Image = Properties.Resources.NoChangeDark;

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
                Ticket_indicator.Image = Properties.Resources.NoChangeLight;
                Ticket_Histogram_Indicator.Image = Properties.Resources.NoChangeLight;
                Key_indicator.Image = Properties.Resources.NoChangeLight;
                Key_Histogram_Indicator.Image = Properties.Resources.NoChangeLight;

            }
            PanelHeader.BackgroundColor = BackGround;
            LabelAppName.BackColor = BackGround;
            LabelAppName.ForeColor = ForeGround;
            Label_Update_Status.ForeColor = ForeGround;
            PanelTicket.BackgroundColor = BackGround;
            PanelKey.BackgroundColor = BackGround;
            LabelKey.ForeColor = ForeGround;
            LabelTicket.ForeColor = ForeGround;
            LabelKey.ForeColor = ForeGround;
            PanelKeyPrice.BackgroundColor = BackGround;
            PanelTicketPRice.BackgroundColor = BackGround;
            Label_Ticket_LowestSellOrder.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee.ForeColor = ForeGround;
            Label_Key_LowestSellOrder.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee.ForeColor = ForeGround;
            KeySeparator.LineColor = ForeGround;
            KeySeparator1.LineColor = ForeGround;
            KeySeparator2.LineColor = ForeGround;
            TicketSeparator.LineColor = ForeGround;
            TicketSeparator1.LineColor = ForeGround;
            TicketSeparator2.LineColor = ForeGround;
            PanelTicketIRT.BackgroundColor = BackGround;
            PanelKeyIRT.BackgroundColor = BackGround;
            Key_IRT_Price.ForeColor = ForeGround;
            Key_IRT_Stock.ForeColor = ForeGround;
            Label_Key_HighestBuyOrder.ForeColor = ForeGround;
            Label_Key_HighestBuyOrderNoFee.ForeColor = ForeGround;
            Ticket_IRT_Price.ForeColor = ForeGround;
            Ticket_IRT_Stock.ForeColor = ForeGround;
            Label_Ticket_HighestBuyOrder.ForeColor = ForeGround;
            Label_Ticket_HighestBuyOrderNoFee.ForeColor = ForeGround;
            Panel_Key_BuyOrder.BackgroundColor = BackGround;
            Panel_Ticket_BuyOrder.BackgroundColor = BackGround;
            PanelStatus.BackgroundColor = BackGround;
            LabelStatus.ForeColor = ForeGround;
        }

        private void PanelKeyIRT_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Connecting to Steam"));
            Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Loading Data"));

            GetData.ConnectToSteam.Market.TF2Key();
            GetData.ConnectToSteam.Market.TF2KeyHistogram();
            Label_Key_LowestSellOrder.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder.Text = string.Format("{0} For Sale, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Key.SellOrderQuantity), LoadData.Market.Key.LowestSellOrder, Settings.Currency.Unit)));
            Label_Key_LowestSellOrderNoFee.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Key.LowestSellOrderNoFee, Settings.Currency.Unit)));

            Label_Key_HighestBuyOrder.Invoke((MethodInvoker)(() => Label_Key_HighestBuyOrder.Text = string.Format("{0} Request, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Key.BuyOrderQuantity), LoadData.Market.Key.HighestBuyOrder, Settings.Currency.Unit)));
            Label_Key_HighestBuyOrderNoFee.Invoke((MethodInvoker)(() => Label_Key_HighestBuyOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Key.HighestBuyOrderNoFee, Settings.Currency.Unit)));

            GetData.ConnectToSteam.Market.TF2Ticket();
            GetData.ConnectToSteam.Market.TF2TicketHistogram();
            Label_Ticket_LowestSellOrder.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder.Text = string.Format("{0} For Sale, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Ticket.SellOrderQuantity), LoadData.Market.Ticket.LowestSellOrder, Settings.Currency.Unit)));
            Label_Ticket_LowestSellOrderNoFee.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Ticket.LowestSellOrderNoFee, Settings.Currency.Unit)));

            Label_Ticket_HighestBuyOrder.Invoke((MethodInvoker)(() => Label_Ticket_HighestBuyOrder.Text = string.Format("{0} Request, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Ticket.BuyOrderQuantity), LoadData.Market.Ticket.HighestBuyOrder, Settings.Currency.Unit)));
            Label_Ticket_HighestBuyOrderNoFee.Invoke((MethodInvoker)(() => Label_Ticket_HighestBuyOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Ticket.HighestBuyOrderNoFee, Settings.Currency.Unit)));

            if (Settings.CheckIRT)
            {
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading IRT"));
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                if (GetData.GamingClub.Key() == true)
                {
                    if (LoadData.GamingClub.Key.Price != 0)
                    {
                        Key_IRT_Price.Invoke((MethodInvoker)(() => Key_IRT_Price.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.GamingClub.Key.Price))));
                    }
                }
                else
                {
                    Key_IRT_Price.Invoke((MethodInvoker)(() => Key_IRT_Price.Text = string.Format("Price : {0} IRT", 0)));
                }

                Key_IRT_Stock.Invoke((MethodInvoker)(() => Key_IRT_Stock.Text = string.Format("Stock : {0}", LoadData.GamingClub.Key.Stock)));

                if (GetData.GamingClub.Ticket() == true)
                {
                    if (LoadData.GamingClub.Ticket.Price != 0)
                    {
                        Ticket_IRT_Price.Invoke((MethodInvoker)(() => Ticket_IRT_Price.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.GamingClub.Ticket.Price))));
                    }
                }
                else
                {
                    Ticket_IRT_Price.Invoke((MethodInvoker)(() => Ticket_IRT_Price.Text = string.Format("Price : {0} IRT", 0)));
                }
                Ticket_IRT_Stock.Invoke((MethodInvoker)(() => Ticket_IRT_Stock.Text = string.Format("Stock : {0}", LoadData.GamingClub.Ticket.Stock)));
            }
            
            if (LoadData.Market.Key.LowestSellOrder == 0 && LoadData.Market.Ticket.LowestSellOrder == 0)
            {
                Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Steam is Uncreachable!"));
            }
            else
            {
                Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Updated on " + DateTime.Now.ToString("h:mm:ss tt")));
            }

            Logger.LogMarket("Data Loaded Successfully.", LoadData.Market.Key.LowestSellOrder, LoadData.Market.Ticket.LowestSellOrderNoFee);

            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));

            if(!Timer.Enabled)
                Timer.Enabled = true;
        }
    }
}
