#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.2.0 Revision 8
// last Edit: 10/29/22 V2.0

#endregion

using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class Calculator : Form
    {
        private string CalculationMode = "";
        private int Number = 0;
        public static bool DarkMode;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Calculator()
        {
            InitializeComponent();
        }
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Textbox.Text))
            {
                decimal input;
                input = decimal.Parse(Textbox.Text, System.Globalization.NumberStyles.Currency);
                Textbox.Text = input.ToString("#,#");
                Textbox.SelectionStart = Textbox.Text.Length;
                Number = Convert.ToInt32(Regex.Replace(Textbox.Text, @"[^\d]", ""));
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (Settings.CalculatorMode == "Wallet => Item")
            {
                if (Number < LoadData.Market.Ticket.LowestSellOrderNoFee)
                {
                    double Ticket_Count = Convert.ToDouble(Number) / LoadData.Market.Ticket.LowestSellOrderNoFee;
                    double count3 = Math.Round(Ticket_Count, 1);
                    int Ticket_count_rounded = (int)Math.Ceiling(count3);
                    if (Settings.CheckIRT == true)
                    {
                        GetData.IRT.Ticket();
                        if (LoadData.IRT.Ticket.Price != 0)
                        {
                            LabelResult.Text = string.Format("Result: {0} Ticket - {1} IRT", Ticket_count_rounded.ToString(), string.Format("{0:n0} ", Ticket_count_rounded * LoadData.IRT.Ticket.Price));
                        }
                        else
                        {
                            LabelResult.Text = "Ticket Count: " + Ticket_count_rounded.ToString();
                        }
                    }
                    else
                    {
                        LabelResult.Text = "Ticket Count: " + Ticket_count_rounded.ToString();
                    }
                }
                else
                {
                    double key_countt = Convert.ToDouble(Number) / LoadData.Market.Key.LowestSellOrderNoFee;
                    double countt = Math.Round(key_countt, 1);
                    int count_roundedd = (int)Math.Ceiling(countt);
                    int KeyRoundedDown = (int)Math.Floor(key_countt);
                    double DownRemaining = Number - (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee);
                    //double Remaining2 = ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee) - DownRemaining;
                    if (Settings.CheckIRT == true)
                    {
                        GetData.IRT.Key();
                        if (LoadData.IRT.Key.Price != 0)
                        {
                            if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                            {
                                if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                {
                                    LabelResult.Text = string.Format("Result: {0} Key + 1 Ticket - {1} IRT", KeyRoundedDown.ToString(), string.Format("{0:n0} ", (KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price));
                                }
                                else
                                {
                                    LabelResult.Text = string.Format("Result: {0} Key - {1} IRT", count_roundedd.ToString(), string.Format("{0:n0} ", count_roundedd * LoadData.IRT.Key.Price));
                                }
                            }
                            else
                            {
                                LabelResult.Text = string.Format("Result: {0} Key - {1} IRT", count_roundedd.ToString(), string.Format("{0:n0} ", count_roundedd * LoadData.IRT.Key.Price));
                            }
                        }
                        else
                        {
                            if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && Settings.ItemCalculationMode == "Smart" && LoadData.IRT.Ticket.Stock != 0)
                            {
                                LabelResult.Text = string.Format("Result: {0} Key + 1 Ticket ", KeyRoundedDown.ToString());
                            }
                            else
                            {
                                LabelResult.Text = string.Format("Result: {0} Key", count_roundedd.ToString());
                            }
                        }
                    }
                    else
                    {
                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && Settings.ItemCalculationMode == "Smart" && LoadData.IRT.Ticket.Stock != 0)
                        {
                            LabelResult.Text = string.Format("Result: {0} Key + 1 Ticket ", KeyRoundedDown.ToString());
                        }
                        else
                        {
                            LabelResult.Text = string.Format("Result: {0} Key", count_roundedd.ToString());
                        }
                    }
                }
            }
            else if (Settings.CalculatorMode == "Ticket => Wallet")
            {
                double wallet = LoadData.Market.Ticket.LowestSellOrderNoFee * Convert.ToInt32(Number);
                LabelResult.Text = string.Format("Result: {0} {1}", wallet.ToString("N"), Settings.Currency.Unit);
            }
            else if (Settings.CalculatorMode == "Key => Wallet")
            {
                double wallet2 = LoadData.Market.Key.LowestSellOrderNoFee * Convert.ToInt32(Number);
                LabelResult.Text = string.Format("Result: {0} {1}", wallet2.ToString("N"), Settings.Currency.Unit);
            }
            else if (Settings.CalculatorMode == "Selling Fee")
            {
                double fee = Convert.ToInt32(Number) / 1.15;
                LabelResult.Text = string.Format("Result: {0} {1}", fee.ToString("N"), Settings.Currency.Unit);
            }
        }
        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Textbox_Click(object sender, EventArgs e)
        {
            Textbox.SelectAll();
        }
        private void Textbox_MouseDown(object sender, MouseEventArgs e)
        {
            Textbox.SelectAll();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            GetData.ConnectToSteam.Market.TF2Ticket();
            GetData.ConnectToSteam.Market.TF2Key();
            CalculationMode = Settings.CalculatorMode;
            if (CalculationMode == "Wallet => Item")
            {
                DropDownCalculation.SelectedIndex = 0;
            }
            else if (CalculationMode == "Key => Wallet")
            {
                DropDownCalculation.SelectedIndex = 1;
            }
            else if (CalculationMode == "Ticket => Wallet")
            {
                DropDownCalculation.SelectedIndex = 2;
            }
            else if (CalculationMode == "Selling Fee")
            {
                DropDownCalculation.SelectedIndex = 3;
            }

            DarkMode = Settings.DarkMode;
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
        private void LiveMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form market = new LiveMarketPrice();
            market.ShowDialog();
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
        private void BunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.CalculatorMode = DropDownCalculation.Text.ToString();
            Properties.Settings.Default.Save();
            if (DropDownCalculation.Text == "Wallet => Item")
            {
                Textbox.PlaceholderText = "Enter Wallet Count";
            }
            else if (DropDownCalculation.Text == "Key => Wallet")
            {
                Textbox.PlaceholderText = "Enter Key Count";
            }
            else if (DropDownCalculation.Text == "Ticket => Wallet")
            {
                Textbox.PlaceholderText = "Enter Ticket Count";
            }
            else if (DropDownCalculation.Text == "Selling Fee")
            {
                Textbox.PlaceholderText = "Enter Selling Count";
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
                ButtonLoad.Image = Properties.Resources.BTNLoadLight;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.AthenGray;
                ButtonLoad.Image = Properties.Resources.BTNLoadDark;
            }
            ButtonLoad.BackColor = BackGround;
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelInput.BackgroundColor = BackGround;
            LabelEnter.ForeColor = ForeGround;
            LabelMode.ForeColor = ForeGround;
            LabelResult.ForeColor = ForeGround;
            PanelResult.BackgroundColor = BackGround;

        }
        private void Calculator_Activated(object sender, EventArgs e)
        {
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
