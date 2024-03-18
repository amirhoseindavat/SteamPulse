using SteamPulse.Logger;
using SteamPulse.SettingsInterface;
using SteamPulse.SteamAPI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Market : UserControl
    {
        public static bool SettingisUpdated;
        public static bool DarkMode;
        private bool DataLoaded = false;

        //private double Key_Sell_before, Key_Buy_before;
        //private double Ticket_Sell_before, Ticket_Buy_before;
        private Main main { get; set; }
        public Market(Main Form)
        {
            InitializeComponent();
            main = Form;
        }


        /*private void MarketTimer_Tick(object sender, EventArgs e)
        {
            timer--;
            for (int i = 0; i > UserSettings.MarketUpdateTime; i++)
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
                        Key_Sell_before = LoadData.Market.Key.LowestSellOrder;
                        Ticket_Sell_before = LoadData.Market.Ticket.LowestSellOrder;
                        Key_Buy_before = LoadData.Market.Key.HighestBuyOrder;
                        Ticket_Buy_before = LoadData.Market.Ticket.HighestBuyOrder;
                        Label_Update_Status.Text = "Status : Updating";
                        timer = Convert.ToInt32(UserSettings.MarketUpdateTime);

                        BackgroundWorker.RunWorkerAsync();
                        RepositionElements(Convert.ToBoolean(UserSettings.CheckIRT), Convert.ToBoolean(UserSettings.HistogramData));
                        Key_Sell_Status();
                        Ticket_Sell_Status();
                        Key_Buy_Status();
                        Ticket_Buy_Status();
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
        }*/
        private void Market_Load(object sender, EventArgs e)
        {

            BackgroundWorker.RunWorkerAsync();

            RepositionElements(Convert.ToBoolean(UserSettings.CheckIRT), Convert.ToBoolean(UserSettings.HistogramData));

            DarkMode = Convert.ToBoolean(UserSettings.DarkMode);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
        }
        /*private void Key_Sell_Status()
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
                if (UserSettings.DarkMode == true)
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
                if (UserSettings.DarkMode == true)
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
                if (UserSettings.DarkMode == true)
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
                if (UserSettings.DarkMode == true)
                {
                    Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                }
                else
                {
                    Ticket_indicator.Image = Properties.Resources.NoChangeLight;
                }
            }
        }*/
        private void RepositionElements(bool IRT, bool Histogram)
        {
            if (UserSettings.DeveloperMode)
            {

                if (!IRT && Histogram)
                {
                    PanelKeyIRT.Visible = false;
                    PanelTicketIRT.Visible = false;

                    Panel_Key_BuyOrder.Location = new Point(17, 359);
                    Panel_Ticket_BuyOrder.Location = new Point(327, 359);

                    PanelKeyPrice.Location = new Point(17, 282);
                    PanelTicketPRice.Location = new Point(327, 282);

                    PanelKey.Size = new Size(300, 262);
                    PanelTicket.Size = new Size(300, 262);
                }
                else if (IRT && !Histogram)
                {
                    Panel_Key_BuyOrder.Visible = false;
                    Panel_Ticket_BuyOrder.Visible = false;

                    PanelKeyPrice.Location = new Point(17, 282);
                    PanelTicketPRice.Location = new Point(327, 282);

                    PanelKey.Size = new Size(300, 262);
                    PanelTicket.Size = new Size(300, 262);
                }
                else if (!IRT && !Histogram)
                {
                    Panel_Key_BuyOrder.Visible = false;
                    Panel_Ticket_BuyOrder.Visible = false;

                    PanelKeyIRT.Visible = false;
                    PanelTicketIRT.Visible = false;

                    PanelKeyPrice.Location = new Point(17, 359);
                    PanelTicketPRice.Location = new Point(327, 359);

                    PanelKey.Size = new Size(300, 334);
                    PanelTicket.Size = new Size(300, 334);
                }
            }
            else
            {
                if (IRT)
                {
                    Panel_Key_BuyOrder.Visible = false;
                    Panel_Ticket_BuyOrder.Visible = false;

                    PanelKeyPrice.Location = new Point(17, 282);
                    PanelTicketPRice.Location = new Point(327, 282);

                    PanelKey.Size = new Size(300, 262);
                    PanelTicket.Size = new Size(300, 262);
                }
                else
                {
                    Panel_Key_BuyOrder.Visible = false;
                    Panel_Ticket_BuyOrder.Visible = false;

                    PanelKeyIRT.Visible = false;
                    PanelTicketIRT.Visible = false;

                    PanelKeyPrice.Location = new Point(17, 359);
                    PanelTicketPRice.Location = new Point(327, 359);

                    PanelKey.Size = new Size(300, 334);
                    PanelTicket.Size = new Size(300, 334);
                }
            }



        }
        private void MarketPrice_Activated(object sender, EventArgs e)
        {
            if (SettingisUpdated == true)
            {
                RepositionElements(Convert.ToBoolean(UserSettings.CheckIRT), Convert.ToBoolean(UserSettings.HistogramData));
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
            Color BackGround, BackGround2;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.Cello;
                BackGround2 = GlobalVariables.Colors.Dark.NileBlue;
                ForeGround = GlobalVariables.Colors.Dark.White;
                Ticket_indicator.Image = Properties.Resources.NoChangeDark;
                Ticket_Histogram_Indicator.Image = Properties.Resources.NoChangeDark;
                Key_indicator.Image = Properties.Resources.NoChangeDark;
                Key_Histogram_Indicator.Image = Properties.Resources.NoChangeDark;

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.AthenGray;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackGround2 = GlobalVariables.Colors.Light.White;
                Ticket_indicator.Image = Properties.Resources.NoChangeLight;
                Ticket_Histogram_Indicator.Image = Properties.Resources.NoChangeLight;
                Key_indicator.Image = Properties.Resources.NoChangeLight;
                Key_Histogram_Indicator.Image = Properties.Resources.NoChangeLight;

            }
            BackColor = BackGround2;
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
            PanelStatus.BackgroundColor = BackGround2;
            LabelStatus.ForeColor = ForeGround;
        }

        private void PanelKeyIRT_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Size = new Size(620, 452)));
            LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Connecting to Steam"));
            Label_Update_Status.Invoke((MethodInvoker)(() => Label_Update_Status.Text = "Status : Loading Data"));


            if (!GetData.KeyIsConnected)
            {
                GetData.ConnectToSteam.Market.TF2Key();
            }
            else { }
            if (!GetData.TicketIsConnected)
            {

                GetData.ConnectToSteam.Market.TF2Ticket();
            }
            else { }

            if (UserSettings.DeveloperMode && UserSettings.HistogramData)
            {
                GetData.ConnectToSteam.Market.TF2KeyHistogram();
                Label_Key_LowestSellOrder.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder.Text = string.Format("{0} For Sale, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Key.SellOrderQuantity), LoadData.Market.Key.LowestSellOrder, UserSettings.Currency.Unit)));
                Label_Key_LowestSellOrderNoFee.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Key.LowestSellOrderNoFee, UserSettings.Currency.Unit)));

                Label_Key_HighestBuyOrder.Invoke((MethodInvoker)(() => Label_Key_HighestBuyOrder.Text = string.Format("{0} Request, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Key.BuyOrderQuantity), LoadData.Market.Key.HighestBuyOrder, UserSettings.Currency.Unit)));
                Label_Key_HighestBuyOrderNoFee.Invoke((MethodInvoker)(() => Label_Key_HighestBuyOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Key.HighestBuyOrderNoFee, UserSettings.Currency.Unit)));

                GetData.ConnectToSteam.Market.TF2TicketHistogram();
                Label_Ticket_LowestSellOrder.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder.Text = string.Format("{0} For Sale, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Ticket.SellOrderQuantity), LoadData.Market.Ticket.LowestSellOrder, UserSettings.Currency.Unit)));
                Label_Ticket_LowestSellOrderNoFee.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Ticket.LowestSellOrderNoFee, UserSettings.Currency.Unit)));

                Label_Ticket_HighestBuyOrder.Invoke((MethodInvoker)(() => Label_Ticket_HighestBuyOrder.Text = string.Format("{0} Request, Starting: {1} {2}", string.Format("{0:n0} ", LoadData.Market.Ticket.BuyOrderQuantity), LoadData.Market.Ticket.HighestBuyOrder, UserSettings.Currency.Unit)));
                Label_Ticket_HighestBuyOrderNoFee.Invoke((MethodInvoker)(() => Label_Ticket_HighestBuyOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Ticket.HighestBuyOrderNoFee, UserSettings.Currency.Unit)));
            }
            else
            {
                Label_Key_LowestSellOrder.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrder.Text = string.Format("Price: {0} {1}", LoadData.Market.Key.LowestSellOrder, UserSettings.Currency.Unit)));
                Label_Key_LowestSellOrderNoFee.Invoke((MethodInvoker)(() => Label_Key_LowestSellOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Key.LowestSellOrderNoFee, UserSettings.Currency.Unit)));

                Label_Ticket_LowestSellOrder.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrder.Text = string.Format("Price: {0} {1}", LoadData.Market.Ticket.LowestSellOrder, UserSettings.Currency.Unit)));
                Label_Ticket_LowestSellOrderNoFee.Invoke((MethodInvoker)(() => Label_Ticket_LowestSellOrderNoFee.Text = string.Format("You receive: {0} {1}", LoadData.Market.Ticket.LowestSellOrderNoFee, UserSettings.Currency.Unit)));
            }




            if (UserSettings.CheckIRT && !DataLoaded)
            {
                LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading IRT"));
                PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));

                try
                {
                    if (!GetData.IRTIsConnected)
                    {
                        GetData.IRT.KeyAndTicket();
                    }
                    else { }
                    Key_IRT_Price.Invoke((MethodInvoker)(() => Key_IRT_Price.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.IRT.Key.Price))));
                    Ticket_IRT_Price.Invoke((MethodInvoker)(() => Ticket_IRT_Price.Text = string.Format("Price : {0}IRT", string.Format("{0:n0} ", LoadData.IRT.Ticket.Price))));

                    Key_IRT_Stock.Invoke((MethodInvoker)(() => Key_IRT_Stock.Text = string.Format("Stock : {0}", LoadData.IRT.Key.Stock)));
                    Ticket_IRT_Stock.Invoke((MethodInvoker)(() => Ticket_IRT_Stock.Text = string.Format("Stock : {0}", LoadData.IRT.Ticket.Stock)));

                }
                catch
                {
                    Key_IRT_Price.Invoke((MethodInvoker)(() => Key_IRT_Price.Text = string.Format("Price : {0} IRT", 0)));
                    Ticket_IRT_Price.Invoke((MethodInvoker)(() => Ticket_IRT_Price.Text = string.Format("Price : {0} IRT", 0)));
                }

                

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

            if (!MarketTimer.Enabled)
            {
                MarketTimer.Enabled = true;
            }
        }

    }
}
