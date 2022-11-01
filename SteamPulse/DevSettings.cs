#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.6.0 Revision 3
// last Edit: 10/26/22 V2.0
#endregion

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class DevSetting : Form
    {
        public static Boolean DarkMode;

        protected Boolean ISLoading = true;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public DevSetting()
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
        private void DevSetting_Load(object sender, EventArgs e)
        {
            DarkMode = Convert.ToBoolean(Properties.Settings.Default["DarkMode"]);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            ToggleImprove.Checked = Settings.LoadDLCImage;

            ToggleRemain.Checked = Settings.CalculateRemaining;

            ToggleHistogram.Checked = Settings.HistogramData;

            if (Settings.KeyCalcMode == "Rounded to Up")
            {
                DropDownCalc.SelectedIndex = 0;
            }
            else if (Settings.KeyCalcMode == "Exact Value")
            {
                DropDownCalc.SelectedIndex = 1;
            }
            else { }

            if (Settings.DefualtDlcCount == 5)
            {
                DropDownDLC.SelectedIndex = 0;
            }

            if (Settings.DefualtDlcCount == 10)
            {
                DropDownDLC.SelectedIndex = 1;
            }

            if (Settings.DefualtDlcCount == 20)
            {
                DropDownDLC.SelectedIndex = 2;
            }

            if (Settings.DefualtDlcCount == 50)
            {
                DropDownDLC.SelectedIndex = 3;
            }

            if (Settings.DefualtDlcCount == 100)
            {
                DropDownDLC.SelectedIndex = 4;
            }

            if (Settings.DefualtDlcCount == 200)
            {
                DropDownDLC.SelectedIndex = 5;
            }

            if (Settings.DefualtDlcCount == 500)
            {
                DropDownDLC.SelectedIndex = 6;
            }

            if (Settings.DefualtDlcCount == 1000)
            {
                DropDownDLC.SelectedIndex = 7;
            }

            if (Settings.DefualtDlcCount == 2000)
            {
                DropDownDLC.SelectedIndex = 8;
            }
            else { }

            if (Settings.ItemCalculationMode == "Smart")
            {
                DropDownItemCalc.SelectedIndex = 0;
            }

            if (Settings.ItemCalculationMode == "Key Only")
            {
                DropDownItemCalc.SelectedIndex = 1;
            }
            else { }

            if (DropDownItemCalc.Text == "Key Only")
            {
                this.Size = new Size(409, 470);
            }
            else
            {
                this.Size = new Size(409, 395);
            }


            ISLoading = false;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LabelHeader.ForeColor = ForeGround;
            PanelCalc.BackgroundColor = BackGround;
            LabelCalc.ForeColor = ForeGround;
            PanelImprove.BackgroundColor = BackGround;
            LabelImprove.ForeColor = ForeGround;
            PanelRemain.BackgroundColor = BackGround;
            CalcRemaining.ForeColor = ForeGround;
            PanelDLC.BackgroundColor = BackGround;
            DLCCount.ForeColor = ForeGround;
            PanelItemCalc.BackgroundColor = BackGround;
            LabelItemCalc.ForeColor = ForeGround;
            LabelHistogram.ForeColor = ForeGround;
            PanelHistogram.BackgroundColor = BackGround;
        }

        private void ToggleImprove_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ISLoading == false)
            {
                Settings.LoadDLCImage = ToggleImprove.Checked;
                Logger.LogDevSetting("Load DLC Image", ToggleImprove.Checked.ToString());
            }

            else { }

        }

        private void DropDownCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == false)
            {
                Main.SettingisUpdated = true;
                Settings.KeyCalcMode = DropDownCalc.Text;
                Logger.LogDevSetting("Key Calculation Mode", DropDownCalc.Text.ToString());
            }
            else { }
        }

        private void ToggleRemain_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ISLoading == false)
            {
                Main.SettingisUpdated = true;
                Settings.CalculateRemaining = ToggleRemain.Checked;
                Logger.LogDevSetting("Calculate Remaining Wallet", ToggleRemain.Checked.ToString());
                Main.SettingisUpdated = true;
            }
            else { }
        }

        private void DropDownDLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == false)
            {
                Settings.DefualtDlcCount = Convert.ToInt32(DropDownDLC.Text);
                Logger.LogDevSetting("DLC Loading Limit", DropDownDLC.Text.ToString());
            }
            else { }
        }

        private void DropDownItemCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == false)
            {
                Main.SettingisUpdated = true;
                Settings.ItemCalculationMode = DropDownItemCalc.Text;
                Logger.LogDevSetting("Item Calculation Mode", DropDownItemCalc.Text.ToString());
                Main.SettingisUpdated = true;
                if (DropDownItemCalc.Text == "Key Only")
                {
                    this.Size = new Size(409, 470);
                }
                else
                {
                    this.Size = new Size(409, 395);
                }
            }
            else { }
        }

        private void ToggleHistogram_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ISLoading == false)
            {
                Settings.HistogramData = ToggleHistogram.Checked;
                Logger.LogDevSetting("Show Histogram Data", ToggleHistogram.Checked.ToString());
            }
            else { }
        }
    }
}
