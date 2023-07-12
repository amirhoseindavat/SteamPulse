#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.6.4 Revision 5

#endregion

using Bunifu.UI.WinForms;
using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SteamPulse
{
    public partial class DLCBrowser : Form
    {
        public static bool DarkMode, IRTCheck, LoadImage, abort = false;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string[] ID;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public DLCBrowser()
        {
            InitializeComponent();
        }
        double sum = 0;

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
        private void DLC_Load(object sender, EventArgs e)
        {
            IRTCheck = Settings.CheckIRT;
            if (IRTCheck == true)
            {
                irtprice.Visible = true;
                this.Size = new Size(898 + 150, 465);
                PanelMain.Size = new Size(860 + 150, 396);
                DataTable.Size = new Size(818 + 150, 302);

            }
            if (Settings.LoadDLCImage == true)
            {
                image.Visible = true;
            }
            else
            {
                image.Visible = false;
            }

            DarkMode = Convert.ToBoolean(Settings.DarkMode);
            if (DarkMode == true)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            this.CenterToParent();

            BackgroundWorker.RunWorkerAsync();

        }
        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int limit = 100;
            if (Settings.DeveloperMode == true)
            {
                limit = Settings.DefualtDlcCount;
            }
            try
            {
                ID = LoadData.Store.DLC.GetAllDLC.Cast<Match>()
                                     .Take(limit)
                                     .Select(match2 => match2.Value)
                                     .ToArray();
                int dlc_count = ID.Length;


                if (limit < LoadData.Store.DLC.Count)
                {
                    LabelName.Invoke((MethodInvoker)(() => LabelName.Text = string.Format("Game: {0}, Showing {1} of {2} DLC", LoadData.Store.Name, limit, LoadData.Store.DLC.Count)));
                }
                else
                {
                    LabelName.Invoke((MethodInvoker)(() => LabelName.Text = string.Format("Game: {0}, Showing {1} of {1} DLC", LoadData.Store.Name, LoadData.Store.DLC.Count)));
                }

                LabelName.Invoke((MethodInvoker)(() => LabelName.Visible = true));

                int rowId = Convert.ToInt32(DataTable.Invoke((MethodInvoker)(() => DataTable.Rows.Add())));
                int i = 1;
                GetData.ConnectToSteam.Market.TF2Ticket();
                GetData.ConnectToSteam.Market.TF2Key();
                double KeyIRT = LoadData.IRT.Key.Price;
                double TicketIRT = LoadData.IRT.Ticket.Price;
                foreach (string appid in ID)
                {
                    GetData.DLCID = Convert.ToInt32(appid);

                    DataGridViewRow row = DataTable.Rows[rowId];

                    //DataTable.Invoke((MethodInvoker)(() => row.Cells["number"].Value = i));

                    string DLCName = LoadData.Store.DLC.Data.Name;

                    string dlc_name = DLCName;

                    if (Settings.DeveloperMode == true)
                    {
                        if (Settings.LoadDLCImage == false)
                        {

                        }
                        else
                        {
                            WebRequest request = WebRequest.Create(LoadData.Store.DLC.Data.HeaderImage);
                            WebResponse response = request.GetResponse();
                            Stream responseStream = response.GetResponseStream();
                            Bitmap bitmap = new Bitmap(responseStream);
                            try
                            {
                                DataTable.Invoke((MethodInvoker)(() => row.Cells["image"].Value = bitmap));
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {
                        WebRequest request = WebRequest.Create(LoadData.Store.DLC.Data.HeaderImage);
                        WebResponse response = request.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        Bitmap bitmap = new Bitmap(responseStream);
                        try
                        {
                            DataTable.Invoke((MethodInvoker)(() => row.Cells["image"].Value = bitmap));
                        }
                        catch
                        {

                        }
                    }
                    //row.Cells["image"].Value = bitmap;
                    string dlc_price = "Coming Soon";
                    //DataTable.Invoke((MethodInvoker)(() => row.Cells["View"].Value = "View DLC"));

                    DataTable.Invoke((MethodInvoker)(() => row.Cells["name"].Value = dlc_name));
                    if (LoadData.Store.DLC.Data.Isfree == true)
                    {
                        dlc_price = "Free";
                        DataTable.Invoke((MethodInvoker)(() => row.Cells["price"].Value = string.Format("{0}", dlc_price)));

                        if (IRTCheck == true)
                        {
                            DataTable.Invoke((MethodInvoker)(() => row.Cells["irtprice"].Value = string.Format("{0}", dlc_price)));
                        }
                    }
                    else
                    {
                        if (LoadData.Store.DLC.Data.ComingSoon == true)
                        {
                            DataTable.Invoke((MethodInvoker)(() => row.Cells["price"].Value = string.Format("{0}", dlc_price)));
                            if (IRTCheck == true)
                            {
                                DataTable.Invoke((MethodInvoker)(() => row.Cells["irtprice"].Value = string.Format("{0}", dlc_price)));
                            }
                        }
                        else
                        {
                            if (LoadData.Store.DLC.Data.Discount > 0)
                            {
                                DataTable.Invoke((MethodInvoker)(() => row.Cells["price"].Value = string.Format("{0} {1} - {2}%", string.Format("{0:n0}", LoadData.Store.DLC.Data.Price), Settings.Currency.Unit, LoadData.Store.DLC.Data.Discount)));
                            }
                            else
                            {
                                DataTable.Invoke((MethodInvoker)(() => row.Cells["price"].Value = string.Format("{0} {1}", string.Format("{0:n0}", LoadData.Store.DLC.Data.Price), Settings.Currency.Unit)));
                            }

                            if (IRTCheck == true)
                            {
                                if (LoadData.Store.DLC.Data.Price < LoadData.Market.Ticket.LowestSellOrderNoFee)
                                {
                                    DataTable.Invoke((MethodInvoker)(() => row.Cells["irtprice"].Value = string.Format("{0} Ticket - {1}IRT", (int)Math.Ceiling(Math.Round(LoadData.Store.DLC.Data.Price / LoadData.Market.Ticket.LowestSellOrderNoFee, 1)), string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(LoadData.Store.DLC.Data.Price / LoadData.Market.Ticket.LowestSellOrderNoFee, 1)) * TicketIRT))));
                                }
                                else
                                {
                                    DataTable.Invoke((MethodInvoker)(() => row.Cells["irtprice"].Value = string.Format("{0} Key - {1}IRT", (int)Math.Ceiling(Math.Round(LoadData.Store.DLC.Data.Price / LoadData.Market.Key.LowestSellOrderNoFee, 1)), string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(LoadData.Store.DLC.Data.Price / LoadData.Market.Key.LowestSellOrderNoFee, 1)) * KeyIRT))));
                                }
                            }
                            else { }
                        }

                    }
                    LabelLowded.Invoke((MethodInvoker)(() => LabelLowded.Visible = true));
                    LabelLowded.Invoke((MethodInvoker)(() => LabelLowded.Text = string.Format("{0} Loaded", i)));
                    if (i == dlc_count)
                    {
                        LabelLowded.Invoke((MethodInvoker)(() => LabelLowded.Visible = false));
                    }
                    else
                    {
                        rowId++;
                        i++;
                        DataTable.Invoke((MethodInvoker)(() => DataTable.Rows.Add()));
                    }
                    sum += LoadData.Store.DLC.Data.Price;
                }
                if (sum == 0)
                {
                    LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = "Sum: Free"));
                }
                else if (sum < LoadData.Market.Ticket.LowestSellOrderNoFee)
                {
                    if (Settings.CheckIRT == true)
                    {

                        if (TicketIRT != 0)
                        {
                            LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = string.Format("Sum: {0} {1} - {2} Ticket - {3}IRT", sum, Settings.Currency.Unit, (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Ticket.LowestSellOrderNoFee, 1)), string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Ticket.LowestSellOrderNoFee, 1)) * TicketIRT))));
                        }
                        else
                        {
                            LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = string.Format("Sum: {0} {1} - {2} Ticket", sum, Settings.Currency.Unit, (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Ticket.LowestSellOrderNoFee, 1)))));
                        }
                    }
                    else
                    {
                        LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = string.Format("Sum: {0} {1} - {2} Ticket", sum, Settings.Currency.Unit, (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Ticket.LowestSellOrderNoFee, 1)))));
                    }
                }
                else
                {
                    if (Settings.CheckIRT == true)
                    {
                        if (KeyIRT != 0)
                        {
                            LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = string.Format("Sum: {0} {1} - {2} Key - {3}IRT", sum, Settings.Currency.Unit, (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Key.LowestSellOrderNoFee, 1)), string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Key.LowestSellOrderNoFee, 1)) * KeyIRT))));
                        }
                        else
                        {
                            LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = string.Format("Sum: {0} {1} - {2} Key", sum, Settings.Currency.Unit, (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Key.LowestSellOrderNoFee, 1)))));
                        }
                    }
                    else
                    {
                        LabelSum.Invoke((MethodInvoker)(() => LabelSum.Text = string.Format("Sum: {0} {1} - {2} Key", sum, Settings.Currency.Unit, (int)Math.Ceiling(Math.Round(sum / LoadData.Market.Key.LowestSellOrderNoFee, 1)))));
                    }
                }
                LabelSum.Invoke((MethodInvoker)(() => LabelSum.Visible = true));
            }
            catch
            {

            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (BackgroundWorker.IsBusy)
            {
                BackgroundWorker.CancelAsync();
            }

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

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Process.Start("steampulse://open/" + ID[e.RowIndex]);
            }
        }
        private void DataTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = DefaultCursor;
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
                this.BackColor = GlobalVariables.Colors.Dark.Cello;
                DataTable.AllowCustomTheming = true;
                DataTable.BackgroundColor = Color.FromArgb(33, 63, 105);

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.White;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                this.BackColor = GlobalVariables.Colors.Light.AthenGray;
                DataTable.AllowCustomTheming = false;
                DataTable.Theme = BunifuDataGridView.PresetThemes.Light;
                DataTable.BackgroundColor = Color.FromArgb(241, 240, 245);
            }
            PanelHeader.BackgroundColor = BackGround;
            Label_AppName.ForeColor = ForeGround;
            PanelMain.BackgroundColor = BackGround;
            LabelName.ForeColor = ForeGround;
            LabelSum.ForeColor = ForeGround;
            LabelLowded.ForeColor = ForeGround;

        }
        private void DLC_Resize(object sender, EventArgs e)
        {

        }
    }
}
