using Newtonsoft.Json.Linq;
using SteamPulse.SettingsInterface;
using SteamPulse.SteamAPI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Search : UserControl
    {
        private readonly bool SourceInput = false;
        private double KeyPriceNoFee = 0;
        private double KeyPrice = 0;
        private double TicketPriceNoFee = 0;
        private double TicketPrice;
        private readonly double MarketFee = 1.15;


        private string SearchText;
        private JToken RawData;

        private Main Main { get; set; }
        public Search(Main Form)
        {
            InitializeComponent();
            Main = Form;
        }
        private void TextBox_URL_TextChanged(object sender, EventArgs e)
        {
            TextBox_URL.Text = URLtoAppID(TextBox_URL.Text);
            TextBox_URL.ForeColor = Color.Black;
        }
        private void Button_Back_Click(object sender, EventArgs e)
        {
            Dashboard Welcome = new Dashboard(Main);
            Main.ShowInContainer(Welcome);
            SideBar sideBar = new SideBar(Main);
            sideBar.Panel_DashBoard.BackgroundColor = Color.White;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Appid = Convert.ToInt32(TextBox_URL.Text);
                if (Data.Appid != 0)
                {
                    Data data = new Data();
                    Main.ShowInContainer(data, Main.SideBars.Search);
                }
            }
            catch
            {
                Main.ShowNotification("Error Loading Data, please check for Input", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //BackgroundWorker.RunWorkerAsync();
                bunifuImageButton1_Click(this, new EventArgs());
            }
            MessageBox.Show(e.KeyChar.ToString());
        }
        private string URLtoAppID(string value)
        {
            if (TextBox_URL.Text.Length > 8)
            {
                try
                {
                    if (value.Contains("agecheck"))
                    {
                        Uri address = new Uri(TextBox_URL.Text);
                        string appid = address.Segments[3].Replace("/", "");
                        return appid;
                    }
                    else
                    {
                        Uri address = new Uri(TextBox_URL.Text);
                        string appid = address.Segments[2].Replace("/", "");
                        return appid;
                    }
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return TextBox_URL.Text;
            }
        }
        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Search_Load(object sender, EventArgs e)
        {
            //pictureBox2.Load("https://store.akamai.steamstatic.com/public/images/applications/store/background_preview.png");
        }
        private void PixelArtCopyRight_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.artstation.com/artwork/18LnN8");
        }
        private void TextBox_URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuImageButton1_Click(this, new EventArgs());
            }
            MessageBox.Show(e.KeyCode.ToString());
        }
        private void Search_Load_1(object sender, EventArgs e)
        {
            if (UserSettings.DarkMode)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }
            PanelCalculatorLoading.Size = new Size(610, 161);
            Task.Factory.StartNew(() => LoadCalculatorData());
        }
        private void LoadCalculatorData()
        {
            try
            {
                DropDownSource.Invoke((MethodInvoker)(() => DropDownSource.Items.Insert(0, UserSettings.Currency.Name)));
                DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.Items.Insert(0, UserSettings.Currency.Name)));
                DropDownSource.Invoke((MethodInvoker)(() => DropDownSource.Items.Insert(1, "KEY")));
                DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.Items.Insert(1, "Key")));
                DropDownSource.Invoke((MethodInvoker)(() => DropDownSource.Items.Insert(2, "Ticket")));
                DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.Items.Insert(2, "Ticket")));
                if (UserSettings.CheckIRT)
                {
                    DropDownSource.Invoke((MethodInvoker)(() => DropDownSource.Items.Insert(3, "IRT")));
                    DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.Items.Insert(3, "IRT")));
                    if (!GetData.IRTIsConnected)
                    {
                        GetData.IRT.KeyAndTicket();
                    }
                    DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.Items.Insert(4, "Market Fee")));
                }
                else
                {
                    DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.Items.Insert(3, "Market Fee")));
                }
                DropDownSource.Invoke((MethodInvoker)(() => DropDownSource.SelectedIndex = 0));
                DropDownDestination.Invoke((MethodInvoker)(() => DropDownDestination.SelectedIndex = 0));
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
                PanelCalculatorLoading.Invoke((MethodInvoker)(() => PanelCalculatorLoading.Size = new Size(1, 1)));

                KeyPriceNoFee = LoadData.Market.Key.LowestSellOrderNoFee;
                KeyPrice = LoadData.Market.Key.LowestSellOrder;
                TicketPriceNoFee = LoadData.Market.Ticket.LowestSellOrderNoFee;
                TicketPrice = LoadData.Market.Ticket.LowestSellOrder;
            }
            catch
            {
                PanelCalculatorLoading.Invoke((MethodInvoker)(() => PanelCalculatorLoading.Size = new Size(610, 161)));
                LabelCalculatorLoading.Invoke((MethodInvoker)(() => LabelCalculatorLoading.Text = "Calculator Crashed!"));
            }
        }
        private void DropDownSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSource.Text))
            {
                TextBoxDestination.Text = Calculator(Convert.ToDouble(TextBoxSource.Text));
            }
            else
            {
                TextBoxDestination.Text = "0";
            }
        }
        private void TextBoxSource_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSource.Text))
            {
                TextBoxDestination.Text = Calculator(Convert.ToDouble(TextBoxSource.Text));
            }
            else
            {
                TextBoxDestination.Text = "0";
            }
        }
        private void DropDownDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSource.Text))
            {
                TextBoxDestination.Text = Calculator(Convert.ToDouble(TextBoxSource.Text));
            }
            else
            {
                TextBoxDestination.Text = "0";
            }
        }
        private void TextBoxDestination_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxSource.Text))
            {
                TextBoxDestination.Text = Calculator(Convert.ToDouble(TextBoxSource.Text));
            }
            else
            {
                TextBoxDestination.Text = "0";
            }
        }
        private string Calculator(double value)
        {
            string Response = "";
            if (!string.IsNullOrEmpty(TextBoxSource.Text))
            {
                //0 = Region
                //1 = Key
                //2 = Ticket
                //3 = IRT
                //4 = Market Fee

                // If Source Is user Region
                if (DropDownSource.SelectedIndex == 0)
                {
                    if (DropDownDestination.SelectedIndex == 0)
                    {
                        Response = value.ToString();
                    }
                    else if (DropDownDestination.SelectedIndex == 1)
                    {
                        Response = string.Format("{0:n0} Key", value / KeyPriceNoFee);
                    }
                    else if (DropDownDestination.SelectedIndex == 2)
                    {
                        Response = string.Format("{0:n0} Ticket", value / TicketPriceNoFee);
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = string.Format("{0:n0} IRT", value * (LoadData.IRT.Key.Price / KeyPriceNoFee));
                    }
                    else if (!UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = string.Format("{0:n0} {1}", value / MarketFee, UserSettings.Currency.Unit);
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 4)
                    {
                        Response = string.Format("{0:n0} {1}", value / MarketFee, UserSettings.Currency.Unit);
                    }
                    else
                    {
                        Response = "Wrong Parametr. Code 0xN";
                    }
                }

                // If Source Is Key
                else if (DropDownSource.SelectedIndex == 1)
                {
                    if (DropDownDestination.SelectedIndex == 0)
                    {
                        Response = string.Format("{0:n2} {1}", Math.Round(KeyPriceNoFee * value, 2), UserSettings.Currency.Unit);
                    }
                    else if (DropDownDestination.SelectedIndex == 1)
                    {
                        Response = value.ToString();
                    }
                    else if (DropDownDestination.SelectedIndex == 2)
                    {
                        Response = string.Format("{0:n0} Ticket", Math.Round(KeyPriceNoFee * value / TicketPriceNoFee, 0));
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = string.Format("{0:n0} IRT", Math.Round(value * LoadData.IRT.Key.Price, 0));
                    }
                    else if (!UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = string.Format("{0:n2} {1}", Math.Round((value * KeyPriceNoFee) - (value * KeyPrice), 2), UserSettings.Currency.Unit);
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 4)
                    {
                        Response = string.Format("{0:n2} {1}", Math.Round((value * KeyPriceNoFee) - (value * KeyPrice), 2), UserSettings.Currency.Unit);
                    }
                    else
                    {
                        Response = "Wrong Parametr. Code 1xN";
                    }
                }

                // If Source Is Ticket
                else if (DropDownSource.SelectedIndex == 2)
                {
                    if (DropDownDestination.SelectedIndex == 0)
                    {
                        Response = string.Format("{0:n0} {1}", Math.Round(TicketPriceNoFee * value, 2), UserSettings.Currency.Unit);
                    }
                    else if (DropDownDestination.SelectedIndex == 1)
                    {
                        Response = string.Format("{0:n0} Key", Math.Round((TicketPriceNoFee * value / KeyPriceNoFee), 0));
                    }
                    else if (DropDownDestination.SelectedIndex == 2)
                    {
                        Response = value.ToString();
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = string.Format("{0:n0} IRT", Math.Round(value * LoadData.IRT.Ticket.Price, 0));
                    }
                    else if (!UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = string.Format("{0:n2} {1}", Math.Round((value * TicketPriceNoFee) - (value * TicketPrice), 2), UserSettings.Currency.Unit);
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 4)
                    {
                        Response = string.Format("{0:n2} {1}", Math.Round((value * TicketPriceNoFee) - (value * TicketPrice), 2), UserSettings.Currency.Unit);
                    }
                    else
                    {
                        Response = "Wrong Parametr. Code 2xN";
                    }
                }

                // If Source Is IRT
                else if (UserSettings.CheckIRT && DropDownSource.SelectedIndex == 3)
                {
                    if (DropDownDestination.SelectedIndex == 0)
                    {
                        Response = string.Format("{0:n2} {1}", Math.Round(value / (LoadData.IRT.Key.Price / KeyPriceNoFee), 2), UserSettings.Currency.Unit);
                    }
                    else if (DropDownDestination.SelectedIndex == 1)
                    {
                        Response = string.Format("{0:n0} Key", Math.Round(value / LoadData.IRT.Key.Price, 0));
                    }
                    else if (DropDownDestination.SelectedIndex == 2)
                    {
                        Response = string.Format("{0:n0} Ticket", Math.Round(value / LoadData.IRT.Ticket.Price, 2));
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = value.ToString();
                    }
                    else if (!UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 3)
                    {
                        Response = "Impossible";
                    }
                    else if (UserSettings.CheckIRT && DropDownDestination.SelectedIndex == 4)
                    {
                        Response = "Impossible";
                    }
                    else
                    {
                        Response = "Wrong Parametr. Code I3xN";
                    }
                }
            }
            else
            {
                Response = "0";
            }
            return Response;
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
                PictureBoxExchange.Image = Properties.Resources.exchange_white;
                PictureBoxCalculatorLoading.Image = Properties.Resources.SteamPulse_Logo_White;
                ButtonLoadData.Image = Properties.Resources.SearchWhite;
                ButtonLoad.Image = Properties.Resources.BTNLoadLight;
                ButtonSearch.Image = Properties.Resources.SearchWhite;
                GroupBoxAppidSearch.SendToBack();
            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.AthenGray;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackGround2 = GlobalVariables.Colors.Light.White;
                PictureBoxExchange.Image = Properties.Resources.exchange;
                PictureBoxCalculatorLoading.Image = Properties.Resources.SteamPulse_Logo;
                ButtonLoadData.Image = Properties.Resources.SearchBlack;
                ButtonLoad.Image = Properties.Resources.SearchBlack;
                ButtonLoad.Image = Properties.Resources.BTNLoadDark;
                ButtonSearch.Image = Properties.Resources.SearchBlack;
            }
            BackColor = BackGround2;
            GroupBoxCalculator.BackColor = BackGround2;
            GroupBoxCalculator.ForeColor = ForeGround;
            GroupBoxSearch.BackColor = BackGround2;
            GroupBoxSearch.ForeColor = ForeGround;
            LabelSearchByName.ForeColor = ForeGround;
            LabelCalculatorLoading.ForeColor = ForeGround;
            GroupBoxAppidSearch.BackColor = BackGround2;
            GroupBoxAppidSearch.ForeColor = ForeGround;
            ButtonLoad.BackColor = BackGround2;
            ButtonSearch.BackColor = BackGround2;
            //TextBoxSearch.BackColor = BackGround2;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (ComboBoxResult.Text.Contains("-"))
            {
                string[] tokens = ComboBoxResult.Text.Split(new[] { " - " }, StringSplitOptions.None);
                Data.Appid = Convert.ToInt32(tokens[0]);
                Data data = new Data();
                Main.ShowInContainer(data, Main.SideBars.Search);
            }
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Text = "Searching..."));
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();
                string DownloadedData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/db/search.php?searchword=" + SearchText);
                RawData = JToken.Parse(DownloadedData);
                int i = 0;
                for (; ; )
                {
                    if (RawData.SelectToken(".[" + i + "].appid") == null)
                    {
                        break;
                    }
                    else
                    {
                        int appid = Convert.ToInt32(RawData.SelectToken(".[" + i + "].appid"));
                        string name = RawData.SelectToken(".[" + i + "].name").ToString(); ;
                        ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Items.Insert(i, string.Format("{0} - {1}", appid, name))));
                        i++;
                    }
                }
                if (ComboBoxResult.Items.Count == 0)
                {
                    ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Text = "Not Found..."));
                }
                else
                {
                    ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.SelectedIndex = 0));
                }

            }
            catch (Exception ex)
            {
                ComboBoxResult.Invoke((MethodInvoker)(() => ComboBoxResult.Text = "Searching Failed..."));
                Main.ShowNotification("Error Loading Data, please check for Input", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TextBoxSearch.Text))
                {

                    SearchText = TextBoxSearch.Text;
                    SearchText = SearchText.Replace(" ", "%20");
                    SearchText = "%25" + SearchText + "%25";
                    ComboBoxResult.Items.Clear();
                    BackgroundWorker.RunWorkerAsync();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Main.ShowNotification("Error Loading Data, please check for Input", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void LabelSearchByName_Click(object sender, EventArgs e)
        {
            GroupBoxAppidSearch.Size = new Size(610, 127);
            GroupBoxCalculator.Location = new Point(17, 141);
            PictureBoxPixelArt.Location = new Point(17, 317);
            PixelArtCopyRight.Location = new Point(518, 433);
            GroupBoxAppidSearch.BringToFront();
        }
    }
}
