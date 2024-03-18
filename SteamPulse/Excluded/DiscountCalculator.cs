#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.7.0 Revision 2
// last Edit: 10/29/22 V2.0

#endregion

using SteamPulse.SteamAPI;
using SteamPulse.SettingsInterface;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class DiscountCalculator : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private readonly double InitialPrice = (Main.EditionPrice * 100) / (100 - Main.EditionDiscount);
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public DiscountCalculator()
        {
            InitializeComponent();
        }
        private void PercentCalculator_Load(object sender, EventArgs e)
        {
            if (UserSettings.DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            if (GetData.Appid == 1250410)
            {
                LabelName.Text = string.Format("Name: {0}", GlobalVariables.Names.MSFS);
            }
            else
            {
                LabelName.Text = string.Format("Name: {0}", LoadData.Store.Name);
            }

            LabelPrice.Text = string.Format("Original Price : {0} {1}", Convert.ToDouble(InitialPrice).ToString("N"), UserSettings.Currency.Unit);
            GetData.ConnectToSteam.Market.TF2Key();
            GetData.ConnectToSteam.Market.TF2Ticket();
            GetData.IRT.KeyAndTicket();
            LabelDiscountValue.Text = string.Format("{0}%", LoadData.Store.Price.Discount_Percent);
            PercentSlider.Value = Main.EditionDiscount;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PercentSlider_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            double final = (InitialPrice - ((InitialPrice / 100) * PercentSlider.Value));
            int keyCount = (int)Math.Ceiling(final / LoadData.Market.Key.LowestSellOrderNoFee);

            double DownRemaining = final - ((keyCount - 1) * LoadData.Market.Key.LowestSellOrderNoFee);
            LabelDiscountValue.Text = string.Format("{0}%", PercentSlider.Value);
            if (PercentSlider.Value != 0)
            {
                if (PercentSlider.Value == 100)
                {
                    LabelResult.Text = string.Format("Result: {0}", "Free");
                }
                else
                {
                    if (UserSettings.CheckIRT == true)
                    {
                        if (UserSettings.ItemCalculationMode == "Smart" && UserSettings.DeveloperMode == true)
                        {
                            if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                            {
                                if (final < LoadData.Market.Ticket.LowestSellOrderNoFee)
                                {
                                    LabelResult.Text = string.Format("Result: {0} {1} - 1 Ticket - {2} IRT", final.ToString("N"), UserSettings.Currency.Unit, string.Format("{0:n0} ", LoadData.IRT.Ticket.Price));
                                }
                                else
                                {
                                    LabelResult.Text = string.Format("Result: {0} {1} - {2} Key + 1 Ticket - {3} IRT", final.ToString("N"), UserSettings.Currency.Unit, (keyCount - 1), string.Format("{0:n0} ", (((keyCount - 1) * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price)));
                                }
                            }
                            else
                            {
                                LabelResult.Text = string.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), UserSettings.Currency.Unit, keyCount, string.Format("{0:n0} ", (keyCount * LoadData.IRT.Key.Price)));
                            }
                        }
                        else
                        {
                            LabelResult.Text = string.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), UserSettings.Currency.Unit, keyCount, string.Format("{0:n0} ", (keyCount * LoadData.IRT.Key.Price)));
                        }
                    }
                    else
                    {
                        LabelResult.Text = string.Format("Result: {0} {1} - {2} Key", final.ToString("N"), UserSettings.Currency.Unit, keyCount);
                    }
                }

            }
            else if (PercentSlider.Value == 0)
            {
                if (UserSettings.CheckIRT == true)
                {
                    if (UserSettings.ItemCalculationMode == "Smart" && UserSettings.DeveloperMode == true)
                    {
                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                        {
                            if (final < LoadData.Market.Ticket.LowestSellOrderNoFee)
                            {
                                LabelResult.Text = string.Format("Result: {0} {1} - 1 Ticket - {2} IRT", final.ToString("N"), UserSettings.Currency.Unit, string.Format("{0:n0} ", LoadData.IRT.Ticket.Price));
                            }
                            else
                            {
                                LabelResult.Text = string.Format("Result: {0} {1} - {2} Key + 1 Ticket - {3} IRT", final.ToString("N"), UserSettings.Currency.Unit, (keyCount - 1), string.Format("{0:n0} ", (((keyCount - 1) * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price)));
                            }
                        }
                        else
                        {
                            LabelResult.Text = string.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), UserSettings.Currency.Unit, keyCount, string.Format("{0:n0} ", (keyCount * LoadData.IRT.Key.Price)));
                        }
                    }
                    else
                    {
                        LabelResult.Text = string.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), UserSettings.Currency.Unit, keyCount, string.Format("{0:n0} ", (keyCount * LoadData.IRT.Key.Price)));
                    }
                }
                else
                {
                    LabelResult.Text = string.Format("Result: {0} {1} - {2} Key", InitialPrice.ToString("N"), UserSettings.Currency.Unit, keyCount);
                }
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
            Label_AppName.BackColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelInput.BackgroundColor = BackGround;
            LabelName.ForeColor = ForeGround;
            LabelPrice.ForeColor = ForeGround;
            LabelPercent.ForeColor = ForeGround;
            LabelResult.ForeColor = ForeGround;
            LabelDiscountValue.ForeColor = ForeGround;

        }
    }
}
