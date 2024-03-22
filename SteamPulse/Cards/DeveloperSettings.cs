using SteamPulse.Logger;
using SteamPulse.SettingsInterface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class DeveloperSettings : UserControl
    {
        public static bool DarkMode;
        private Main main { get; set; }

        protected bool ISLoading = true;
        public DeveloperSettings(Main Form)
        {
            InitializeComponent();
            main = Form;
        }
        private void DeveloperSettings_Load(object sender, EventArgs e)
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

            ToggleImprove.Checked = UserSettings.LoadDLCImage;

            ToggleRemain.Checked = UserSettings.CalculateRemaining;

            ToggleHistogram.Checked = UserSettings.HistogramData;

            if (UserSettings.KeyCalcMode == "Rounded to Up")
            {
                DropDownCalc.SelectedIndex = 0;
            }
            else if (UserSettings.KeyCalcMode == "Exact Value")
            {
                DropDownCalc.SelectedIndex = 1;
            }
            else { }

            if (UserSettings.DefualtDlcCount == 5)
            {
                DropDownDLC.SelectedIndex = 0;
            }

            if (UserSettings.DefualtDlcCount == 10)
            {
                DropDownDLC.SelectedIndex = 1;
            }

            if (UserSettings.DefualtDlcCount == 20)
            {
                DropDownDLC.SelectedIndex = 2;
            }

            if (UserSettings.DefualtDlcCount == 50)
            {
                DropDownDLC.SelectedIndex = 3;
            }

            if (UserSettings.DefualtDlcCount == 100)
            {
                DropDownDLC.SelectedIndex = 4;
            }

            if (UserSettings.DefualtDlcCount == 200)
            {
                DropDownDLC.SelectedIndex = 5;
            }

            if (UserSettings.DefualtDlcCount == 500)
            {
                DropDownDLC.SelectedIndex = 6;
            }

            if (UserSettings.DefualtDlcCount == 1000)
            {
                DropDownDLC.SelectedIndex = 7;
            }

            if (UserSettings.DefualtDlcCount == 2000)
            {
                DropDownDLC.SelectedIndex = 8;
            }
            else { }

            if (UserSettings.ItemCalculationMode == "Smart")
            {
                DropDownItemCalc.SelectedIndex = 0;
            }

            if (UserSettings.ItemCalculationMode == "Key Only")
            {
                DropDownItemCalc.SelectedIndex = 1;
            }
            else { }

            if (DropDownItemCalc.Text == "Key Only")
            {
                Size = new Size(409, 470);
            }
            else
            {
                Size = new Size(409, 395);
            }


            ISLoading = false;
        }
        private void ChangeTheme(bool Darkmode)
        {
            Color BackGround;
            Color ForeGround;
            if (Darkmode == true)
            {
                BackGround = GlobalVariables.Colors.Dark.Cello;
                ForeGround = GlobalVariables.Colors.Dark.White;
                BackColor = GlobalVariables.Colors.Dark.NileBlue;
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.AthenGray;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackColor = GlobalVariables.Colors.Light.White;
            }
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
            PanelIRTSource.BackgroundColor = BackGround;
            LabelIRTSource.ForeColor = ForeGround;
            
        }
        private void ToggleImprove_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ISLoading == false)
            {
                UserSettings.LoadDLCImage = ToggleImprove.Checked;
                Log.LogDevSetting("Load DLC Image", ToggleImprove.Checked.ToString());
            }

            else { }

        }
        private void DropDownCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == false)
            {
                Main.SettingisUpdated = true;
                UserSettings.KeyCalcMode = DropDownCalc.Text;
                Log.LogDevSetting("Key Calculation Mode", DropDownCalc.Text.ToString());
            }
            else { }
        }
        private void ToggleRemain_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ISLoading == false)
            {
                Main.SettingisUpdated = true;
                UserSettings.CalculateRemaining = ToggleRemain.Checked;
                Log.LogDevSetting("Calculate Remaining Wallet", ToggleRemain.Checked.ToString());
                Main.SettingisUpdated = true;
            }
            else { }
        }
        private void DropDownDLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == false)
            {
                UserSettings.DefualtDlcCount = Convert.ToInt32(DropDownDLC.Text);
                Log.LogDevSetting("DLC Loading Limit", DropDownDLC.Text.ToString());
            }
            else { }
        }
        private void DropDownItemCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ISLoading == false)
            {
                Main.SettingisUpdated = true;
                UserSettings.ItemCalculationMode = DropDownItemCalc.Text;
                Log.LogDevSetting("Item Calculation Mode", DropDownItemCalc.Text.ToString());
                Main.SettingisUpdated = true;
                if (DropDownItemCalc.Text == "Key Only")
                {
                    Size = new Size(409, 470);
                }
                else
                {
                    Size = new Size(409, 395);
                }
            }
            else { }
        }
        private void ToggleHistogram_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ISLoading == false)
            {
                UserSettings.HistogramData = ToggleHistogram.Checked;
                Log.LogDevSetting("Show Histogram Data", ToggleHistogram.Checked.ToString());
            }
            else { }
        }
    }
}
