#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.7.0 Revision 0

#endregion

using SteamAPI;
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

        readonly double InitialPrice = (Main.EditionPrice * 100) / (100 - Main.EditionDiscount);
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
            if (Settings.DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            if (GetData.Appid == 1250410)
            {
                LabelName.Text = String.Format("Name: {0}", GlobalVariables.Names.MSFS);
            }
            else
            {
                LabelName.Text = String.Format("Name: {0}", LoadData.Store.Name);
            }

            LabelPrice.Text = String.Format("Original Price : {0} {1}", Convert.ToDouble(InitialPrice).ToString("N"), Settings.Currency.Unit);
            GetData.ConnectToSteam.Market.TF2Key();
            GetData.ConnectToSteam.Market.TF2Ticket();
            GetData.GamingClub.Key();
            GetData.GamingClub.Ticket();
            LabelDiscountValue.Text = String.Format("{0}%", LoadData.Store.Price.Discount_Percent);
            PercentSlider.Value = Main.EditionDiscount;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PercentSlider_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            double final = (InitialPrice - ((InitialPrice / 100) * PercentSlider.Value));
            int keyCount = (int)Math.Ceiling(final / LoadData.Market.Key.User_Price);

            double DownRemaining = final - ((keyCount - 1) * LoadData.Market.Key.User_Price);
            LabelDiscountValue.Text = String.Format("{0}%", PercentSlider.Value);
            if (PercentSlider.Value != 0)
            {
                if (PercentSlider.Value == 100)
                {
                    LabelResult.Text = String.Format("Result: {0}", "Free");
                }
                else
                {
                    if (Settings.CheckIRT == true)
                    {
                        if (Settings.ItemCalculationMode == "Smart" && Settings.DeveloperMode == true)
                        {
                            if (DownRemaining < LoadData.Market.Ticket.User_Price)
                            {
                                if (final < LoadData.Market.Ticket.User_Price)
                                {
                                    LabelResult.Text = String.Format("Result: {0} {1} - 1 Ticket - {2} IRT", final.ToString("N"), Settings.Currency.Unit, String.Format("{0:n0} ", LoadData.GamingClub.Ticket));
                                }
                                else
                                {
                                    LabelResult.Text = String.Format("Result: {0} {1} - {2} Key + 1 Ticket - {3} IRT", final.ToString("N"), Settings.Currency.Unit, (keyCount - 1), String.Format("{0:n0} ", (((keyCount - 1) * LoadData.GamingClub.Key) + LoadData.GamingClub.Ticket)));
                                }
                            }
                            else
                            {
                                LabelResult.Text = String.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), Settings.Currency.Unit, keyCount, String.Format("{0:n0} ", (keyCount * LoadData.GamingClub.Key)));
                            }
                        }
                        else
                        {
                            LabelResult.Text = String.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), Settings.Currency.Unit, keyCount, String.Format("{0:n0} ", (keyCount * LoadData.GamingClub.Key)));
                        }
                    }
                    else
                    {
                        LabelResult.Text = String.Format("Result: {0} {1} - {2} Key", final.ToString("N"), Settings.Currency.Unit, keyCount);
                    }
                }

            }
            else if (PercentSlider.Value == 0)
            {
                if (Settings.CheckIRT == true)
                {
                    if (Settings.ItemCalculationMode == "Smart" && Settings.DeveloperMode == true)
                    {
                        if (DownRemaining < LoadData.Market.Ticket.User_Price)
                        {
                            if (final < LoadData.Market.Ticket.User_Price)
                            {
                                LabelResult.Text = String.Format("Result: {0} {1} - 1 Ticket - {2} IRT", final.ToString("N"), Settings.Currency.Unit, String.Format("{0:n0} ", LoadData.GamingClub.Ticket));
                            }
                            else
                            {
                                LabelResult.Text = String.Format("Result: {0} {1} - {2} Key + 1 Ticket - {3} IRT", final.ToString("N"), Settings.Currency.Unit, (keyCount - 1), String.Format("{0:n0} ", (((keyCount - 1) * LoadData.GamingClub.Key) + LoadData.GamingClub.Ticket)));
                            }
                        }
                        else
                        {
                            LabelResult.Text = String.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), Settings.Currency.Unit, keyCount, String.Format("{0:n0} ", (keyCount * LoadData.GamingClub.Key)));
                        }
                    }
                    else
                    {
                        LabelResult.Text = String.Format("Result: {0} {1} - {2} Key - {3} IRT", final.ToString("N"), Settings.Currency.Unit, keyCount, String.Format("{0:n0} ", (keyCount * LoadData.GamingClub.Key)));
                    }
                }
                else
                {
                    LabelResult.Text = String.Format("Result: {0} {1} - {2} Key", InitialPrice.ToString("N"), Settings.Currency.Unit, keyCount);
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
            PanelInput.BackgroundColor = BackGround;
            LabelName.ForeColor = ForeGround;
            LabelPrice.ForeColor = ForeGround;
            LabelPercent.ForeColor = ForeGround;
            LabelResult.ForeColor = ForeGround;
            LabelDiscountValue.ForeColor = ForeGround;

        }
    }
}
