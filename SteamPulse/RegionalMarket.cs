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
    public partial class RegionalMarket : Form
    {
        public static bool SettingisUpdated;
        public static bool DarkMode;
        private bool DataLoaded = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public RegionalMarket()
        {
            InitializeComponent();
        }

        private int timer = Settings.MarketUpdateTime;
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
                if (!BackgroundWorker.IsBusy)
                {
                    Label_Update_Status.Text = "Status : Updating in " + timer.ToString() + " Second";
                    if (timer == 0)
                    {
                        Label_Update_Status.Text = "Status : Updating";
                        timer = Convert.ToInt32(Settings.MarketUpdateTime);

                        BackgroundWorker.RunWorkerAsync();
                        IRTCHeck(Convert.ToBoolean(Settings.CheckIRT));
                        if (LoadData.Market.Key.LowestSellOrder == 0 && LoadData.Market.Ticket.LowestSellOrder == 0)
                        {
                            Label_Update_Status.Text = "Status : Steam is Uncreachable!";
                            Log.LogMarket("Steam is Uncreachable!");
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
            Close();
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
                Size = new Size(464, 899);
                PanelStatus.Size = new Size(434, 808);
                PanelStatus.BringToFront();
                PanelKeyIRT.Visible = true;
                PanelTicketIRT.Visible = true;

            }
            else if (status == false)
            {
                Size = new Size(464, 820);
                PanelStatus.Size = new Size(425, 732);
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

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;

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
            PanelKeyPrice_TR.BackgroundColor = BackGround;
            PanelKeyPrice_AR.BackgroundColor = BackGround;
            PanelKeyPrice_UA.BackgroundColor = BackGround;
            PanelKeyPrice_RU.BackgroundColor = BackGround;
            PanelKeyPrice_BR.BackgroundColor = BackGround;
            PanelKeyPrice_IN.BackgroundColor = BackGround;
            PanelKeyPrice_US.BackgroundColor = BackGround;
            PanelTicketPrice_TR.BackgroundColor = BackGround;
            PanelTicketPrice_AR.BackgroundColor = BackGround;
            PanelTicketPrice_UA.BackgroundColor = BackGround;
            PanelTicketPrice_RU.BackgroundColor = BackGround;
            PanelTicketPrice_BR.BackgroundColor = BackGround;
            PanelTicketPrice_IN.BackgroundColor = BackGround;
            PanelTicketPrice_US.BackgroundColor = BackGround;
            Label_Key_LowestSellOrder_TR.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_TR.ForeColor = ForeGround;
            Label_Key_LowestSellOrder_AR.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_AR.ForeColor = ForeGround;
            Label_Key_LowestSellOrder_UA.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_UA.ForeColor = ForeGround;
            Label_Key_LowestSellOrder_RU.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_RU.ForeColor = ForeGround;
            Label_Key_LowestSellOrder_BR.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_BR.ForeColor = ForeGround;
            Label_Key_LowestSellOrder_IN.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_IN.ForeColor = ForeGround;
            Label_Key_LowestSellOrder_US.ForeColor = ForeGround;
            Label_Key_LowestSellOrderNoFee_US.ForeColor = ForeGround;

            Label_Ticket_LowestSellOrder_TR.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_TR.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrder_AR.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_AR.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrder_UA.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_UA.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrder_RU.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_RU.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrder_BR.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_BR.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrder_IN.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_IN.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrder_US.ForeColor = ForeGround;
            Label_Ticket_LowestSellOrderNoFee_US.ForeColor = ForeGround;
            KeySeparator.LineColor = ForeGround;
            KeySeparator_2.LineColor = ForeGround;
            KeySeparator_3.LineColor = ForeGround;
            KeySeparator_4.LineColor = ForeGround;
            KeySeparator_5.LineColor = ForeGround;
            KeySeparator_6.LineColor = ForeGround;
            KeySeparator_7.LineColor = ForeGround;
            KeySeparator_IRT.LineColor = ForeGround;
            TicketSeparator.LineColor = ForeGround;
            TicketSeparator1.LineColor = ForeGround;
            TicketSeparator3.LineColor = ForeGround;
            TicketSeparator4.LineColor = ForeGround;
            TicketSeparator5.LineColor = ForeGround;
            TicketSeparator6.LineColor = ForeGround;
            TicketSeparator7.LineColor = ForeGround;
            TicketSeparator_IRT.LineColor = ForeGround;
            PanelTicketIRT.BackgroundColor = BackGround;
            PanelKeyIRT.BackgroundColor = BackGround;
            Key_IRT_Price.ForeColor = ForeGround;
            Key_IRT_Stock.ForeColor = ForeGround;
            Ticket_IRT_Price.ForeColor = ForeGround;
            Ticket_IRT_Stock.ForeColor = ForeGround;
            PanelStatus.BackgroundColor = BackGround;
            LabelStatus.ForeColor = ForeGround;
        }

        private void Key_indicator_Click(object sender, EventArgs e)
        {

        }

        private void PanelKeyIRT_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Connecting to Steam"));
            Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Loading Data"));

            //Key
            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.TR);
            Label_Key_LowestSellOrder_TR.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_TR.Text = string.Format("{0} $", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_TR.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_TR.Text = string.Format("{0} $", LoadData.Market.Key.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.AR);
            Label_Key_LowestSellOrder_AR.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_AR.Text = string.Format("{0} $", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_AR.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_AR.Text = string.Format("{0} $", LoadData.Market.Key.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.UA);
            Label_Key_LowestSellOrder_UA.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_UA.Text = string.Format("{0} ₴", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_UA.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_UA.Text = string.Format("{0} ₴", LoadData.Market.Key.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.RU);
            Label_Key_LowestSellOrder_RU.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_RU.Text = string.Format("{0} pуб", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_RU.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_RU.Text = string.Format("{0} pуб", LoadData.Market.Key.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.BR);
            Label_Key_LowestSellOrder_BR.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_BR.Text = string.Format("{0} R$", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_BR.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_BR.Text = string.Format("{0} R$", LoadData.Market.Key.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.IN);
            Label_Key_LowestSellOrder_IN.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_IN.Text = string.Format("{0} ₹", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_IN.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_IN.Text = string.Format("{0} ₹", LoadData.Market.Key.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Key(GetData.Regions.US);
            Label_Key_LowestSellOrder_US.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder_US.Text = string.Format("{0} $", LoadData.Market.Key.LowestSellOrder)));
            Label_Key_LowestSellOrderNoFee_US.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee_US.Text = string.Format("{0} $", LoadData.Market.Key.LowestSellOrderNoFee)));


            //Ticket
            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.TR);
            Label_Ticket_LowestSellOrder_TR.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_TR.Text = string.Format("{0} $", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_TR.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_TR.Text = string.Format("{0} $", LoadData.Market.Ticket.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.AR);
            Label_Ticket_LowestSellOrder_AR.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_AR.Text = string.Format("{0} $", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_AR.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_AR.Text = string.Format("{0} $", LoadData.Market.Ticket.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.UA);
            Label_Ticket_LowestSellOrder_UA.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_UA.Text = string.Format("{0} ₴", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_UA.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_UA.Text = string.Format("{0} ₴", LoadData.Market.Ticket.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.RU);
            Label_Ticket_LowestSellOrder_RU.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_RU.Text = string.Format("{0} pуб", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_RU.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_RU.Text = string.Format("{0} pуб", LoadData.Market.Ticket.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.BR);
            Label_Ticket_LowestSellOrder_BR.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_BR.Text = string.Format("{0} R$", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_BR.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_BR.Text = string.Format("{0} R$", LoadData.Market.Ticket.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.IN);
            Label_Ticket_LowestSellOrder_IN.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_IN.Text = string.Format("{0} ₹", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_IN.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_IN.Text = string.Format("{0} ₹", LoadData.Market.Ticket.LowestSellOrderNoFee)));

            GetData.ConnectToSteam.Market.TF2Ticket(GetData.Regions.US);
            Label_Ticket_LowestSellOrder_US.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder_US.Text = string.Format("{0} $", LoadData.Market.Ticket.LowestSellOrder)));
            Label_Ticket_LowestSellOrderNoFee_US.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee_US.Text = string.Format("{0} $", LoadData.Market.Ticket.LowestSellOrderNoFee)));



            if (Settings.CheckIRT && !DataLoaded)
            {
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading IRT"));
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                if (GetData.IRT.Key() == true)
                {
                    if (LoadData.IRT.Key.Price != 0)
                    {
                        Key_IRT_Price.Invoke((MethodInvoker)(() => Key_IRT_Price.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.IRT.Key.Price))));
                    }
                }
                else
                {
                    Key_IRT_Price.Invoke((MethodInvoker)(() => Key_IRT_Price.Text = string.Format("Price : {0} IRT", 0)));
                }

                Key_IRT_Stock.Invoke((MethodInvoker)(() => Key_IRT_Stock.Text = string.Format("Stock : {0}", LoadData.IRT.Key.Stock)));

                if (GetData.IRT.Ticket() == true)
                {
                    if (LoadData.IRT.Ticket.Price != 0)
                    {
                        Ticket_IRT_Price.Invoke((MethodInvoker)(() => Ticket_IRT_Price.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.IRT.Ticket.Price))));
                    }
                }
                else
                {
                    Ticket_IRT_Price.Invoke((MethodInvoker)(() => Ticket_IRT_Price.Text = string.Format("Price : {0} IRT", 0)));
                }
                Ticket_IRT_Stock.Invoke((MethodInvoker)(() => Ticket_IRT_Stock.Text = string.Format("Stock : {0}", LoadData.IRT.Ticket.Stock)));
                DataLoaded = true;
            }

            if (LoadData.Market.Key.LowestSellOrder == 0 && LoadData.Market.Ticket.LowestSellOrder == 0)
            {
                Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Steam is Uncreachable!"));
            }
            else
            {
                Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Updated on " + DateTime.Now.ToString("h:mm:ss tt")));
            }

            Log.LogMarket("Data Loaded Successfully.", LoadData.Market.Key.LowestSellOrder, LoadData.Market.Ticket.LowestSellOrderNoFee);

            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));

            if (!Timer.Enabled)
            {
                Timer.Enabled = true;
            }
        }
    }
}
