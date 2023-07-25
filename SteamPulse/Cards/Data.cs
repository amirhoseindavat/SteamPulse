using Newtonsoft.Json.Linq;
using SteamPulse.GlobalVariables;
using SteamPulse.Logger;
using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Data : UserControl
    {
        public static bool DarkMode;
        private bool isowned = false;

        private bool DataLoaded = false;
        private double price;

        public static double EditionPrice;
        public static int EditionDiscount;

        private readonly List<int> PackageIDs = new List<int>();

        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void Data_LoadD(object sender, EventArgs e)
        {
            Label_Name.Text = LoadData.Store.Name;
            PictureBox_Image.Load(LoadData.Store.LibraryImage);
            Label_DLC.Text = LoadData.Store.DLC.Count.ToString();
            if (LoadData.Store.IsComingSoon == true)
            {
                try
                {
                    //LabelRelease.Text = String.Format("{0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), (LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        Label_Release.Text = string.Format("{0} ({1} Years to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365);
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        Label_Release.Text = string.Format("{0} ({1} Months to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30);
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        Label_Release.Text = string.Format("{0} ({1} Days to Release)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount);
                    }
                    else
                    {
                        Label_Release.Text = LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy");
                    }
                }
                catch
                {
                    Label_Release.Text = LoadData.Store.ReleaseDateString.ToString();
                }
            }

            else
            {

                try
                {
                    int ReleasedDaysCount = Math.Abs((LoadData.Store.ReleaseDate - DateTime.Now).Days);
                    if (ReleasedDaysCount > 365)
                    {
                        Label_Release.Text = string.Format("{0} ({1} Years Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 365);
                    }
                    else if (ReleasedDaysCount > 30)
                    {
                        Label_Release.Text = string.Format("{0} ({1} Months Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount / 30);
                    }
                    else if (ReleasedDaysCount < 30)
                    {
                        Label_Release.Text = string.Format("{0} ({1} days Ago)", LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy"), ReleasedDaysCount);
                    }
                    else
                    {
                        Label_Release.Text = LoadData.Store.ReleaseDate.ToString("dd MMMM, yyyy");
                    }
                }
                catch
                {
                    Label_Release.Text = LoadData.Store.ReleaseDateString.ToString();
                }

            }
            if (LoadData.Store.IsComingSoon == true)
            {
                Label_Player_Count.Text = "Not Released";
            }
            else
            {
                Label_Player_Count.Text = string.Format("{0:n0} ", LoadData.Store.PlayerCount);
            }

            Label_Dev.Text = LoadData.Store.Developers;
            Label_Publisher.Text = LoadData.Store.Publishers;
            GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
            if (Settings.CheckOwned == true)
            {
                if (LoadData.Community.Isowned(GetData.Appid) == true)
                {
                    LabelOwned.Text = "You Own This Game";
                    isowned = true;
                    if (LoadData.Community.Playtime(GetData.Appid) == 0)
                    {
                        if (LoadData.Store.IsComingSoon == true)
                        {
                            //LabelPlayTime.Text = "Playtime: Not Released";
                            Label_PlayTime.Visible = false;
                            Label_Name.Location = new Point(237, 69);
                        }
                        else
                        {
                            Label_PlayTime.Text = "Playtime: Not Played";
                        }
                    }
                    else
                    {
                        if (LoadData.Community.Playtime(GetData.Appid) < 120)
                        {
                            Label_PlayTime.Text = string.Format("{0} Minutes", LoadData.Community.Playtime(GetData.Appid));
                        }
                        else
                        {
                            Label_PlayTime.Text = string.Format("{0} Hours", string.Format("{0:n0}", LoadData.Community.Playtime(GetData.Appid) / 60));
                        }
                    }
                }
                else
                {
                    LabelOwned.Text = "Not Owned";
                    PictureBoxOwned.Image = Properties.Resources.xmark_solid;
                    /*LabelPlayTime.Visible = false;
                    LabelName.Location = new Point(237, 69);*/
                }

            }
            else
            {
                /*LabelOwned.Visible = false;
                LabelPlayTime.Visible = false;
                LabelName.Location = new Point(237, 69);
                Panel.Size = new Size(746, 344);
                Size = new Size(776, 407);
                PictureBoxOwned.Visible = false;*/
            }
            //LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Loading Editions..."));
            Thread.Sleep(500);
            string package = LoadData.Store.Packages.ProductPackages;
            JObject JsonObject = JObject.Parse(GetData.Data);
            MatchCollection matches = Regex.Matches(package, @"\d+");

            string[] result = matches.Cast<Match>()
                                     .Take(10)
                                     .Select(match => match.Value)
                                     .ToArray();
            int edition_count;
            if (GetData.Appid == 271590)
            {
                edition_count = result.Length - 2;
            }
            else
            {
                edition_count = result.Length - 1;
            }

            if (result.Length == 1 && result.Length != 0)
            {
                //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standardd")));
                EditionDiscount = LoadData.Store.Price.Discount_Percent;

                if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].price_in_cents_with_discount") != null)
                {
                    //PackagePrice = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount"));
                    if (Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].price_in_cents_with_discount")) > 0)
                    {
                        PackageIDs.Add(Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].packageid")));
                        //MessageBox.Show(PackageIDs[0].ToString());
                        //MessageBox.Show(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                    }

                }
                foreach (int id in PackageIDs)
                {
                    string EditionName;
                    GetData.PackageID = id;
                    GetData.ConnectToSteam.Package();
                    EditionName = LoadData.Store.Packages.TrimmedName;
                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    EditionName = regex.Replace(EditionName, " ");

                    //char first = EditionName[0];
                    if (EditionName.StartsWith(" "))
                    {
                        EditionName = EditionName.Remove(0, 1);
                    }
                    else { }

                    if (EditionName == "" || EditionName == " ")
                    {
                        EditionName = "Standard";
                    }
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                }
            }
            else
            {
                if (LoadData.Store.Price.AvailabletoPurchase != true)
                {
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Not Available")));
                }
                else { }
                EditionDiscount = LoadData.Store.Price.Discount_Percent;
                for (int i = 0; i <= edition_count; i++)
                {

                    /*GetData.PackageID = PackageIDs[i];
                    //GetData.PackageID = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].packageid"));
                    GetData.ConnectToSteam.Package();*/

                    //MessageBox.Show(LoadData.Store.Packages.GetPackageIDbyIndex(i).ToString());


                    //int PackagePrice = 0;

                    if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount") != null)
                    {
                        //PackagePrice = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount"));
                        if (Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount")) > 0)
                        {
                            PackageIDs.Add(Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].packageid")));
                            //MessageBox.Show(PackageIDs[0].ToString());
                            //MessageBox.Show(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                        }

                    }
                    else
                    {
                        break;
                    }



                    /*string EditionName;
                    if (PackageIDs.Count >=1)
                    {
                        GetData.PackageID = PackageIDs[i];

                        GetData.ConnectToSteam.Package();
                        EditionName = LoadData.Store.Packages.TrimmedName;
                        if (GetData.Appid == 1250410)
                        {
                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                            EditionName = EditionName.Replace("Game of the Year", "");
                            EditionName = EditionName.Replace("40th Anniversary", "");
                        }

                        RegexOptions options = RegexOptions.None;
                        Regex regex = new Regex("[ ]{2,}", options);
                        EditionName = regex.Replace(EditionName, " ");

                        //char first = EditionName[0];
                        if (EditionName.StartsWith(" "))
                        {
                            EditionName = EditionName.Remove(0, 1);
                        }
                        else { }

                        if (EditionName == "" || EditionName == " ")
                        {
                            EditionName = "Standard";
                        }
                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                    }
                    else
                    {
                        //break;
                    }*/


                    //old edition method
                    /*if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text") != null)
                    {
                        string dataRemover = JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text").ToString();
                        string Temp = dataRemover.Replace("<span class=\"discount_original_price\">", "");
                        string output = Temp.Replace("</span>", "");
                        double EditionPrice = Convert.ToDouble(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                        EditionPrice /= 100;
                        output = output.Replace(LoadData.Store.Name.ToString(), "");
                        output = output.Replace(":", "");

                        string EditionName = Regex.Replace(output, @"[\d]", string.Empty);
                        EditionName = EditionName.Replace(".,", "");
                        EditionName = EditionName.Replace(",.", "");
                        EditionName = EditionName.Replace("ARS$", "");
                        EditionName = EditionName.Replace(".", "");
                        EditionName = EditionName.Replace("$", "");
                        EditionName = EditionName.Replace("-", "");
                        EditionName = EditionName.Replace(",", "");
                        EditionName = EditionName.Replace("Edition ", "");
                        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                        EditionName = rgx.Replace(EditionName.ToString(), "");
                        if (Settings.Currency.Name == "Ruble")
                        {
                            EditionName = EditionName.Replace("p", "");
                        }

                        if (Settings.Currency.Name == "Lira")
                        {
                            EditionName = EditionName.Replace("TL", "");
                        }

                        if (GetData.Appid == 1250410)
                        {
                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                            EditionName = EditionName.Replace("Game of the Year", "");
                        }
                        else if (GetData.Appid == 292030)
                        {
                            EditionName = EditionName.Remove(0, 22);
                        }

                        RegexOptions options = RegexOptions.None;
                        Regex regex = new Regex("[ ]{2,}", options);
                        EditionName = regex.Replace(EditionName, " ");
                        char first = EditionName[0];
                        if (char.IsWhiteSpace(first))
                        {
                            EditionName = EditionName.Remove(0, 1);
                        }
                        else { }

                        if (EditionName == "" || EditionName == " ")
                        {
                            EditionName = "Standard";
                        }
                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - {1} {2}", EditionName, EditionPrice.ToString("N"), Settings.Currency.Unit))));

                    }
                    else
                    {
                        break;
                    }*/
                }

                foreach (int id in PackageIDs)
                {
                    string EditionName;
                    GetData.PackageID = id;
                    GetData.ConnectToSteam.Package();
                    EditionName = LoadData.Store.Packages.TrimmedName;
                    if (GetData.Appid == 1250410)
                    {
                        EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                        EditionName = EditionName.Replace("Game of the Year", "");
                        EditionName = EditionName.Replace("40th Anniversary", "");
                    }
                    else if (GetData.Appid == 1716740)
                    {
                        EditionName = EditionName.Replace("STARFIELD", "");
                        EditionName = EditionName.Replace("EDITION", "");
                        EditionName = EditionName.Replace("(Pre-purchase)", "");
                    }
                    else if (GetData.Appid == 534380)
                    {
                        EditionName = EditionName.Replace("Dying Light 2", "");
                    }

                    RegexOptions options = RegexOptions.None;
                    Regex regex = new Regex("[ ]{2,}", options);
                    EditionName = regex.Replace(EditionName, " ");

                    //char first = EditionName[0];
                    if (EditionName.StartsWith(" "))
                    {
                        EditionName = EditionName.Remove(0, 1);
                    }
                    else { }

                    if (EditionName == "" || EditionName == " ")
                    {
                        EditionName = "Standard";
                    }
                    ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                }
            }
            //LabelStatus.Invoke((MethodInvoker)(() => LabelStatus.Text = "Finalizing..."));
            if (Settings.CheckOwned == true)
            {
                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default.UserSteamID);
                isowned = LoadData.Community.Isowned(GetData.Appid);
            }
        }

        private void ComboBox_Editions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PanelStatus.Visible = true;
            //LabelStatus.Text = "Loading Edition...";
            if (!ComboBox_Editions.Text.Contains("Not Available") && !ComboBox_Editions.Text.Contains("Free"))
            {
                ComboBox_Editions.Focus();
                if (!ComboBox_Editions.Text.Contains("Free"))
                {
                    EditionPrice = 0;
                    //GetData.PackageID = LoadData.Store.Packages.GetPackageIDbyIndex(ComboBox_Editions.SelectedIndex);
                    GetData.PackageID = PackageIDs.ElementAt(ComboBox_Editions.SelectedIndex);
                    GetData.ConnectToSteam.Package();

                    Label_Edition.Text = ComboBox_Editions.Text;

                    /*if (ComboBox_Editions.SelectedIndex != 0)
                    {
                        try
                        {
                            PictureBox_Image.Load(LoadData.Store.Packages.HeaderImage);
                        }
                        catch
                        {
                            PictureBox_Image.Load(LoadData.Store.HeaderImage);
                        }
                    }
                    else
                    {
                        PictureBox_Image.Load(LoadData.Store.HeaderImage);
                    }*/

                    EditionPrice = LoadData.Store.Packages.Price.Final;
                    //EditionName = LoadData.Store.Packages.TrimmedName;
                }
                else { }
                EditionDiscount = LoadData.Store.Packages.Price.Discount_Percent;
                if (EditionPrice == 0)
                {
                    if (LoadData.Store.IsFree == true)
                    {
                        Label_Price.Text = "Free";
                        Label_KeyCount.Text = "0";
                    }
                    else
                    {
                        if (LoadData.Store.Price.AvailabletoPurchase != true)
                        {
                            Label_Price.Text = "Not Available to Purchase";
                            Label_KeyCount.Text = "0";
                        }
                        else { }
                    }
                }
                else
                {
                    if (EditionDiscount == 0)
                    {
                        Label_Price.Text = string.Format("{0} {1}", EditionPrice.ToString("N"), Settings.Currency.Unit);
                    }
                    else
                    {
                        if (ComboBox_Editions.SelectedIndex == 0)
                        {
                            Label_Price.Text = string.Format("{0} {1} - {2}%", EditionPrice.ToString("N"), Settings.Currency.Unit, LoadData.Store.Price.Discount_Percent.ToString());
                        }
                        else
                        {
                            Label_Price.Text = string.Format("{0} {1} - {2}%", EditionPrice.ToString("N"), Settings.Currency.Unit, EditionDiscount.ToString());
                        }
                    }
                    GetData.ConnectToSteam.Market.TF2Ticket();
                    if (EditionPrice < LoadData.Market.Ticket.LowestSellOrderNoFee && Settings.ItemCalculationMode != "Key Only")
                    {
                        double Ticket_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Ticket.LowestSellOrderNoFee;
                        double Ticket_rounded = (int)Math.Ceiling(Math.Round(Ticket_count, 1));
                        double Remaining = (Ticket_rounded * LoadData.Market.Ticket.LowestSellOrderNoFee) - EditionPrice;
                        /*if (Settings.DeveloperMode == true)
                        {
                            if (Settings.KeyCalcMode == "Rounded to Up") { }
                            else
                            {
                                Ticket_rounded = Math.Round(Ticket_count, 2);
                            }
                        }
                        else { }*/

                        if (Convert.ToBoolean(Settings.CheckIRT) == true)
                        {
                            GetData.IRT.Ticket();
                            if (LoadData.IRT.Ticket.Price != 0)
                            {
                                if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Text = string.Format("Ticket Count: {0} ~ {1} {2}", Ticket_rounded.ToString(), (int)Remaining, Settings.Currency.Unit);
                                    Label_IRT.Text = string.Format("{0:n0}", (int)Math.Ceiling(Ticket_count) * LoadData.IRT.Ticket.Price);
                                }
                                else
                                {
                                    Label_KeyCount.Text = string.Format("Ticket Count: {0}", Ticket_rounded.ToString());
                                    Label_IRT.Text = string.Format("{0:n0}", (int)Math.Ceiling(Ticket_count) * LoadData.IRT.Ticket.Price);
                                }
                            }
                            else
                            {
                                if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                                {
                                    Label_KeyCount.Text = string.Format("Ticket Count: {0} ~ {1} {2}", Ticket_rounded, (int)Remaining, Settings.Currency.Unit);
                                    Label_IRT.Text = "null";
                                }
                                else
                                {
                                    Label_KeyCount.Text = "Ticket Count: " + Ticket_rounded;
                                }
                            }
                        }
                        else
                        {
                            if (Settings.CalculateRemaining == true && Settings.DeveloperMode == true)
                            {
                                Label_KeyCount.Text = string.Format("Ticket Count: {0} ~ {1} {2}", Ticket_rounded, (int)Remaining, Settings.Currency.Unit);
                            }
                            else
                            {
                                Label_KeyCount.Text = "Ticket Count: " + Ticket_rounded;
                            }
                        }
                    }
                    else
                    {
                        GetData.ConnectToSteam.Market.TF2Key();
                        double key_count = Convert.ToDouble(EditionPrice) / LoadData.Market.Key.LowestSellOrderNoFee;
                        double KeyRoundedUp = (int)Math.Ceiling(key_count);
                        double Remaining = (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee) - EditionPrice;
                        int KeyRoundedDown = (int)Math.Floor(key_count);
                        double DownRemaining = EditionPrice - (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee);
                        double Remaining2 = ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee) - EditionPrice;


                        if (Settings.DeveloperMode == true)
                        {
                            if (Settings.KeyCalcMode != "Rounded to Up" && Settings.ItemCalculationMode != "Smart")
                            {
                                KeyRoundedUp = Math.Round(key_count, 2);
                            }
                        }
                        else { }
                        if (Convert.ToBoolean(Settings.CheckIRT) == true)
                        {
                            GetData.IRT.Key();
                            if (LoadData.IRT.Key.Price != 0)
                            {
                                if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                                {
                                    if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                        {
                                            Label_KeyCount.Text = string.Format("Item Count: {0} Key + 1 Ticket ~ {1} {2} ", KeyRoundedDown, (int)Remaining2, Settings.Currency.Unit);
                                            Label_IRT.Text = string.Format("{0:n0} ", (KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price);
                                            //FormulaCaption = string.Format("Key = {0} - {1}IRT | Ticket = {2} - {3}IRT => {4} Key({5}) + 1 Ticket({6}) = {7} {10} - {8} IRT ~ Remains {9} {10}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), LoadData.Market.Ticket.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Ticket.Price), KeyRoundedDown, (KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee), LoadData.Market.Ticket.LowestSellOrderNoFee, ((KeyRoundedDown * LoadData.Market.Key.LowestSellOrderNoFee) + LoadData.Market.Ticket.LowestSellOrderNoFee), String.Format("{0:n0}", ((KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price)), (int)Remaining2, Settings.Currency.Unit);
                                        }
                                        else
                                        {
                                            Label_KeyCount.Text = string.Format("Key Count: {0} ~ {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
                                            Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.IRT.Key.Price);
                                            //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee), String.Format("{0:n0}", (KeyRoundedUp * LoadData.IRT.Key.Price)), (int)Remaining, Settings.Currency.Unit);
                                        }

                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = string.Format("Key Count: {0} ~ {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
                                        Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(key_count) * LoadData.IRT.Key.Price);
                                        //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT ~ Remains {5} {6}", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), KeyRoundedUp, (KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee), String.Format("{0:n0}", (KeyRoundedUp * LoadData.IRT.Key.Price)), (int)Remaining, Settings.Currency.Unit);
                                    }
                                }
                                else
                                {
                                    if (Settings.DeveloperMode == true && Settings.ItemCalculationMode == "Smart")
                                    {
                                        if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                        {
                                            Label_KeyCount.Text = string.Format("{0} Key + 1 Ticket", KeyRoundedDown);
                                            Label_IRT.Text = string.Format("{0:n0} ", (KeyRoundedDown * LoadData.IRT.Key.Price) + LoadData.IRT.Ticket.Price);
                                        }
                                        else
                                        {
                                            Label_KeyCount.Text = string.Format("{0} Key", KeyRoundedUp);
                                            Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.IRT.Key.Price);
                                        }
                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = string.Format("Key Count: {0}", KeyRoundedUp);
                                        Label_IRT.Text = string.Format("{0:n0} ", (int)Math.Ceiling(Math.Round(key_count, 1)) * LoadData.IRT.Key.Price);
                                    }
                                    //FormulaCaption = String.Format("Key = {0} - {1}IRT => {2} Key({3}) - {4} IRT", LoadData.Market.Key.LowestSellOrderNoFee, String.Format("{0:n0} ", LoadData.IRT.Key.Price), KeyRoundedUp, KeyRoundedUp * LoadData.Market.Key.LowestSellOrderNoFee, KeyRoundedUp * LoadData.IRT.Key.Price);
                                }

                            }
                            else
                            {
                                if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                                {
                                    if (DownRemaining < LoadData.Market.Ticket.LowestSellOrderNoFee && LoadData.IRT.Ticket.Stock != 0)
                                    {
                                        Label_KeyCount.Text = string.Format("{0} Key + 1 Ticket ~ {1} {2} ", KeyRoundedDown, (int)Remaining2, Settings.Currency.Unit);
                                    }
                                    else
                                    {
                                        Label_KeyCount.Text = string.Format("{0} Key - {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
                                    }
                                }
                                else
                                {
                                    Label_KeyCount.Text = KeyRoundedUp + " Key";
                                }
                            }
                        }
                        else
                        {
                            if (Settings.DeveloperMode == true && Settings.CalculateRemaining == true)
                            {
                                Label_KeyCount.Text = string.Format("{0} Key - {1} {2}", KeyRoundedUp, (int)Remaining, Settings.Currency.Unit);
                            }
                            else
                            {
                                Label_KeyCount.Text = KeyRoundedUp + " Key";
                            }
                        }
                    }
                }
            }
            else
            {
                if (LoadData.Store.IsFree == true)
                {
                    Label_Price.Text = "Free";
                    Label_KeyCount.Text = "0";
                }
                else
                {
                    if (LoadData.Store.Price.AvailabletoPurchase != true)
                    {
                        Label_Price.Text = "Not Available to Purchase";
                        Label_KeyCount.Text = "0";
                    }
                    else { }
                }
            }
            //PanelStatus.Visible = false;
        }

        private void Label_Publisher_Click(object sender, EventArgs e)
        {

        }

        private void Label_DLC_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string test = "0";
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Size = new Size(644, 468)));
            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Size = new Size(644, 34)));
            PackageIDs.Clear();
            if (!string.IsNullOrEmpty(test))
            {
                // Pre-Load
                Label_Status.Invoke((MethodInvoker)(() => Label_Status.Font = new Font("Poppins Black", 40)));

                //GetData.Appid = Convert.ToInt32(TextBox_URL.Text);
                /*LabelDLC.Invoke((MethodInvoker)(() => LabelDLC.TextAlign = ContentAlignment.MiddleCenter));
                LabelDLC.Invoke((MethodInvoker)(() => LabelDLC.BringToFront()));
                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = ""));*/

                Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Connecting..."));
                //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Clear()));
                EditionPrice = 0;
                //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Loading..."));

                //Initial Load
                try
                {
                    if (GetData.ConnectToSteam.Store(Convert.ToInt32(227300)) == true)
                    {
                        // if Loaded product is dlc
                        Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading Data..."));
                        if (LoadData.Store.Type == "dlc")
                        {
                            if (LoadData.Store.Name.Contains("-"))
                            {
                                string[] name = LoadData.Store.Name.Split(new[] { " - " }, StringSplitOptions.None);
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + name[1]));
                            }
                            else if (LoadData.Store.Name.Contains(":"))
                            {
                                string[] name = LoadData.Store.Name.Split(new[] { ":" }, StringSplitOptions.None);
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + name[1]));
                            }
                            else
                            {
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + LoadData.Store.Name));
                            }

                            PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.HeaderImage)));

                        }
                        else
                        {
                            //msfs easter-egg
                            if (GetData.Appid == 1250410)
                            {
                                Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + Names.MSFS));
                                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(Images.Header.MSFS)));
                            }
                            else
                            {
                                if (LoadData.Store.IsComingSoon == true && LoadData.Store.Price.AvailabletoPurchase == true)
                                {
                                    Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = string.Format("Name: {0} (Pre-Order)", LoadData.Store.Name)));
                                }
                                else
                                {
                                    Label_Name.Invoke((MethodInvoker)(() => Label_Name.Text = "Name: " + LoadData.Store.Name));
                                }

                                PictureBox_Image.Invoke((MethodInvoker)(() => PictureBox_Image.Load(LoadData.Store.HeaderImage)));
                            }
                        }

                        // if loaded game is free
                        if (LoadData.Store.IsFree == true)
                        {
                            Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: Free"));
                            Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "Item Count: 0"));

                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading DLC..."));
                            Thread.Sleep(500);

                            /* LabelDLC.Invoke((MethodInvoker)(() => LabelDLC.TextAlign = ContentAlignment.TopCenter));
                             LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Visible = true));
                             LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Dock = DockStyle.Bottom));
                             LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.BringToFront()));

                             if (LoadData.Store.DLC.Count != 0)
                             {
                                 LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Hand));
                                 LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = string.Format("{0} DLC Found,Click to Open", LoadData.Store.DLC.Count)));

                             }
                             else
                             {
                                 LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                                 LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "No DLC Found."));
                             }*/
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading Editions..."));
                            Thread.Sleep(500);


                            string package = LoadData.Store.Packages.ProductPackages;
                            JObject JsonObject = JObject.Parse(GetData.Data);
                            MatchCollection matches = Regex.Matches(package, @"\d+");

                            string[] result = matches.Cast<Match>()
                                                     .Take(10)
                                                     .Select(match => match.Value)
                                                     .ToArray();
                            int edition_count = result.Length - 1;
                            if (result.Length == 1 && result.Length != 0)
                            {
                                //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                EditionDiscount = LoadData.Store.Price.Discount_Percent;
                            }
                            else
                            {
                                price = LoadData.Store.Price.Final;
                                string PriceString;
                                if (price == 0.00)
                                {
                                    if (LoadData.Store.IsFree == true)
                                    {
                                        Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: Free"));
                                        Label_KeyCount.Invoke((MethodInvoker)(() => Label_KeyCount.Text = "Item Count: 0"));
                                        //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                    }
                                    else
                                    {
                                        if (LoadData.Store.Price.AvailabletoPurchase != true)
                                        {
                                            //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Not Available")));
                                        }
                                        else { }
                                    }
                                }
                                else
                                {
                                    PriceString = LoadData.Store.Price.Final.ToString("N");
                                    //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standard")));
                                    EditionDiscount = LoadData.Store.Price.Discount_Percent;
                                }
                                for (int i = 1; i < edition_count; i++)
                                {
                                    GetData.PackageID = Convert.ToInt32(result[i]);
                                    GetData.ConnectToSteam.Package();
                                    EditionPrice = LoadData.Store.Packages.Price.Final;
                                    string EditionName = LoadData.Store.Packages.TrimmedName;
                                    if (EditionPrice == 0)
                                    {
                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");
                                        char first = EditionName[0];
                                        if (char.IsWhiteSpace(first))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }
                                        //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - Free", EditionName))));
                                    }
                                    else
                                    {
                                        if (GetData.Appid == 1250410)
                                        {
                                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                            EditionName = EditionName.Replace("Game of the Year", "");
                                        }

                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");

                                        if (EditionName.StartsWith(" "))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }
                                        //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                                    }
                                }
                            }
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Finalizing..."));
                            if (Settings.CheckOwned == true)
                            {
                                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default["UserSteamID"].ToString());
                                isowned = LoadData.Community.Isowned(GetData.Appid);
                            }
                        }
                        else
                        {
                            // check for discount
                            /*if (LoadData.Store.Price.Discount_Percent == 0)
                            {
                                Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: " + string.Format("{0} {1}", Convert.ToDouble(LoadData.Store.Price.Final).ToString("N"), Settings.Currency.Unit)));
                            }
                            else
                            {
                                Label_Price.Invoke((MethodInvoker)(() => Label_Price.Text = "Price: " + string.Format("{0} {1} - {2}%", Convert.ToDouble(LoadData.Store.Price.Final).ToString("N"), Settings.Currency.Unit, LoadData.Store.Price.Discount_Percent.ToString())));
                            }*/

                            GetData.ConnectToSteam.Market.TF2Ticket();
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading DLC..."));
                            Thread.Sleep(500);

                            /*LabelDLC.Invoke((MethodInvoker)(() => LabelDLC.TextAlign = ContentAlignment.TopCenter));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Visible = true));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Dock = DockStyle.Bottom));
                            LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.BringToFront()));

                            //check for dlc
                            if (LoadData.Store.DLC.Count != 0)
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Hand));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = string.Format("{0} DLC Found,Click to Open", LoadData.Store.DLC.Count)));
                            }
                            else
                            {
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Cursor = Cursors.Default));
                                LabelDLCCount.Invoke((MethodInvoker)(() => LabelDLCCount.Text = "No DLC Found."));
                            }*/

                            //check for editions
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Loading Editions..."));
                            Thread.Sleep(500);
                            string package = LoadData.Store.Packages.ProductPackages;
                            JObject JsonObject = JObject.Parse(GetData.Data);
                            MatchCollection matches = Regex.Matches(package, @"\d+");

                            string[] result = matches.Cast<Match>()
                                                     .Take(10)
                                                     .Select(match => match.Value)
                                                     .ToArray();
                            int edition_count;
                            if (GetData.Appid == 271590)
                            {
                                edition_count = result.Length - 2;
                            }
                            else
                            {
                                edition_count = result.Length - 1;
                            }

                            if (result.Length == 1 && result.Length != 0)
                            {
                                //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Standardd")));
                                EditionDiscount = LoadData.Store.Price.Discount_Percent;

                                if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].price_in_cents_with_discount") != null)
                                {
                                    //PackagePrice = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount"));
                                    if (Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].price_in_cents_with_discount")) > 0)
                                    {
                                        PackageIDs.Add(Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[0].packageid")));
                                        //MessageBox.Show(PackageIDs[0].ToString());
                                        //MessageBox.Show(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                                    }

                                }
                                foreach (int id in PackageIDs)
                                {
                                    string EditionName;
                                    GetData.PackageID = id;
                                    GetData.ConnectToSteam.Package();
                                    EditionName = LoadData.Store.Packages.TrimmedName;
                                    RegexOptions options = RegexOptions.None;
                                    Regex regex = new Regex("[ ]{2,}", options);
                                    EditionName = regex.Replace(EditionName, " ");

                                    //char first = EditionName[0];
                                    if (EditionName.StartsWith(" "))
                                    {
                                        EditionName = EditionName.Remove(0, 1);
                                    }
                                    else { }

                                    if (EditionName == "" || EditionName == " ")
                                    {
                                        EditionName = "Standard";
                                    }
                                    //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                                }
                            }
                            else
                            {
                                if (LoadData.Store.Price.AvailabletoPurchase != true)
                                {
                                    //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Insert(0, "Not Available")));
                                }
                                else { }
                                EditionDiscount = LoadData.Store.Price.Discount_Percent;
                                for (int i = 0; i <= edition_count; i++)
                                {

                                    /*GetData.PackageID = PackageIDs[i];
                                    //GetData.PackageID = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].packageid"));
                                    GetData.ConnectToSteam.Package();*/

                                    //MessageBox.Show(LoadData.Store.Packages.GetPackageIDbyIndex(i).ToString());


                                    //int PackagePrice = 0;

                                    if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount") != null)
                                    {
                                        //PackagePrice = Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount"));
                                        if (Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount")) > 0)
                                        {
                                            PackageIDs.Add(Convert.ToInt32(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].packageid")));
                                            //MessageBox.Show(PackageIDs[0].ToString());
                                            //MessageBox.Show(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                                        }

                                    }
                                    else
                                    {
                                        break;
                                    }



                                    /*string EditionName;
                                    if (PackageIDs.Count >=1)
                                    {
                                        GetData.PackageID = PackageIDs[i];
                                        
                                        GetData.ConnectToSteam.Package();
                                        EditionName = LoadData.Store.Packages.TrimmedName;
                                        if (GetData.Appid == 1250410)
                                        {
                                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                            EditionName = EditionName.Replace("Game of the Year", "");
                                            EditionName = EditionName.Replace("40th Anniversary", "");
                                        }

                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");

                                        //char first = EditionName[0];
                                        if (EditionName.StartsWith(" "))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }

                                        if (EditionName == "" || EditionName == " ")
                                        {
                                            EditionName = "Standard";
                                        }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                                    }
                                    else
                                    {
                                        //break;
                                    }*/


                                    //old edition method
                                    /*if (JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text") != null)
                                    {
                                        string dataRemover = JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].option_text").ToString();
                                        string Temp = dataRemover.Replace("<span class=\"discount_original_price\">", "");
                                        string output = Temp.Replace("</span>", "");
                                        double EditionPrice = Convert.ToDouble(JsonObject.SelectToken("$." + GetData.Appid + ".data.package_groups[0].subs[" + i + "].price_in_cents_with_discount").ToString());
                                        EditionPrice /= 100;
                                        output = output.Replace(LoadData.Store.Name.ToString(), "");
                                        output = output.Replace(":", "");

                                        string EditionName = Regex.Replace(output, @"[\d]", string.Empty);
                                        EditionName = EditionName.Replace(".,", "");
                                        EditionName = EditionName.Replace(",.", "");
                                        EditionName = EditionName.Replace("ARS$", "");
                                        EditionName = EditionName.Replace(".", "");
                                        EditionName = EditionName.Replace("$", "");
                                        EditionName = EditionName.Replace("-", "");
                                        EditionName = EditionName.Replace(",", "");
                                        EditionName = EditionName.Replace("Edition ", "");
                                        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                                        EditionName = rgx.Replace(EditionName.ToString(), "");
                                        if (Settings.Currency.Name == "Ruble")
                                        {
                                            EditionName = EditionName.Replace("p", "");
                                        }

                                        if (Settings.Currency.Name == "Lira")
                                        {
                                            EditionName = EditionName.Replace("TL", "");
                                        }

                                        if (GetData.Appid == 1250410)
                                        {
                                            EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                            EditionName = EditionName.Replace("Game of the Year", "");
                                        }
                                        else if (GetData.Appid == 292030)
                                        {
                                            EditionName = EditionName.Remove(0, 22);
                                        }

                                        RegexOptions options = RegexOptions.None;
                                        Regex regex = new Regex("[ ]{2,}", options);
                                        EditionName = regex.Replace(EditionName, " ");
                                        char first = EditionName[0];
                                        if (char.IsWhiteSpace(first))
                                        {
                                            EditionName = EditionName.Remove(0, 1);
                                        }
                                        else { }

                                        if (EditionName == "" || EditionName == " ")
                                        {
                                            EditionName = "Standard";
                                        }
                                        ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(string.Format("{0} - {1} {2}", EditionName, EditionPrice.ToString("N"), Settings.Currency.Unit))));

                                    }
                                    else
                                    {
                                        break;
                                    }*/
                                }

                                foreach (int id in PackageIDs)
                                {
                                    string EditionName;
                                    GetData.PackageID = id;
                                    GetData.ConnectToSteam.Package();
                                    EditionName = LoadData.Store.Packages.TrimmedName;
                                    if (GetData.Appid == 1250410)
                                    {
                                        EditionName = EditionName.Replace("Microsoft Flight Simulator", "");
                                        EditionName = EditionName.Replace("Game of the Year", "");
                                        EditionName = EditionName.Replace("40th Anniversary", "");
                                    }
                                    else if (GetData.Appid == 1716740)
                                    {
                                        EditionName = EditionName.Replace("STARFIELD", "");
                                        EditionName = EditionName.Replace("EDITION", "");
                                        EditionName = EditionName.Replace("(Pre-purchase)", "");
                                    }
                                    else if (GetData.Appid == 534380)
                                    {
                                        EditionName = EditionName.Replace("Dying Light 2", "");
                                    }

                                    RegexOptions options = RegexOptions.None;
                                    Regex regex = new Regex("[ ]{2,}", options);
                                    EditionName = regex.Replace(EditionName, " ");

                                    //char first = EditionName[0];
                                    if (EditionName.StartsWith(" "))
                                    {
                                        EditionName = EditionName.Remove(0, 1);
                                    }
                                    else { }

                                    if (EditionName == "" || EditionName == " ")
                                    {
                                        EditionName = "Standard";
                                    }
                                    //omboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Items.Add(EditionName)));
                                }
                            }
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Finalizing..."));
                            if (Settings.CheckOwned == true)
                            {
                                GetData.ConnectToSteam.Community.GetOwnedGames(Properties.Settings.Default.UserSteamID);
                                isowned = LoadData.Community.Isowned(GetData.Appid);
                            }
                        }
                        //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.SelectedIndex = 0));
                        //false
                        PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));
                        DataLoaded = true;
                        Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Data Loaded Successfully"));
                    }
                    else
                    {
                        if (GetData.ErrorCode == 3)
                        {
                            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Font = new Font("Poppins Black", 25)));
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Can't Connect to Steam"));
                            //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                        }
                        if (GetData.ErrorCode == 2)
                        {
                            PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = true));
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Can't Load Data"));
                            Label_Status.Invoke((MethodInvoker)(() => Label_Status.Font = new Font("Poppins Black", 25)));
                            //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    PanelStatus.Invoke((MethodInvoker)(() => PanelStatus.Visible = false));
                    Label_Status.Invoke((MethodInvoker)(() => Label_Status.Text = "Error!"));
                    //ComboBox_Editions.Invoke((MethodInvoker)(() => ComboBox_Editions.Text = "Can't Load"));
                    MessageBox.Show(ex.Message + "\n\nDescription:\n" + ex.InnerException + "\n\nTrace:\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Log.LogRequest(Label_Status.Text);
            }
        }
    }
}
