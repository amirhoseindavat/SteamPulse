#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.3.0 Revision 0

#endregion
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class Maintenance : Form
    {
        public static Boolean MaintenanceMode = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        int n = 0;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Maintenance()
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
        private void Label_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Maintenance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void LabelLaunch_Click(object sender, EventArgs e)
        {
            MaintenanceMode = true;
            if (!string.IsNullOrEmpty(Properties.Settings.Default["CurrencyName"].ToString()))
            {
                if (Properties.Settings.Default["StartingPage"].ToString() == "Main")
                {
                    this.Hide();
                    Form main = new Main();
                    Logger.LogMaintenancee();
                    main.ShowDialog();
                    this.Close();
                }
                if (Properties.Settings.Default["StartingPage"].ToString() == "Market")
                {
                    this.Hide();
                    Form market = new LiveMarketPrice();
                    Logger.LogMaintenancee();
                    market.ShowDialog();
                    this.Close();
                }
                if (Properties.Settings.Default["StartingPage"].ToString() == "Calculator")
                {
                    this.Hide();
                    Form calculator = new Calculator();
                    Logger.LogMaintenancee();
                    calculator.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                Form setting = new Setting();
                setting.ShowDialog();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            n++;
            if (n == 3)
            {
                LabelLaunch.Visible = true;
                n = 0;
            }
        }
        private void Maintenance_Load(object sender, EventArgs e)
        {

        }
    }
}
