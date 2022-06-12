#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// C# Steam API
//
// https://Amirhoseindavat.ir
//
// Beta Build
//
// Version 0.6 Revision 14
#endregion

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamPulse;
using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace SteamAPI
{
    /// <summary>
    /// Connect and GetData.
    /// </summary>
    class GetData
    {
        public static int Appid { get; set; }
        public static int DLCID { get; set; }
        internal static string Data { get; set; }
        internal static string MarketDataKey { get; set; }
        internal static string MarketDataTicket { get; set; }
        internal static string CommunityData { get; set; }
        internal static string WishlistData { get; set; }
        internal static string ShopData { get; set; }
        private static string APIKEY { get { return "C0C2746E5859F6EAD7B27E79C6D9BC76"; } }
        public static int ErrorCode { get; set; }
        /// <summary>
        /// Connect to Steam and GetData.
        /// </summary>
        public struct ConnectToSteam
        {
            public static int GetAppIDByName(string Name)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient client = new WebClient();
                string data = client.DownloadString("https://api.steampowered.com/ISteamApps/GetAppList/v2/");
                JObject JsonObject = JObject.Parse(data);
                int appid;
                int i = 1;

                for (; ; )
                {
                    i++;
                    JToken JsonName = JsonObject.SelectToken(".applist.apps.[" + i + "].name");

                    StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                    if (comparer.Compare(JsonName.ToString(), Name) == 0)
                    {
                        JToken Appid = JsonObject.SelectToken(".applist.apps.[" + i + "].appid");
                        appid = Convert.ToInt32(Appid);
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                return appid;
            }
            /// <summary>
            /// Connect to Steam Store.
            /// </summary>
            /// <remarks>
            /// Returns:if success: true, if fail: false.
            /// </remarks>
            public static Boolean Store()
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    Data = "";
                    Data = client.DownloadString("https://store.steampowered.com/api/appdetails?appids=" + Appid + "&cc=" + Settings.Currency.ISO);
                    if (Data == "")
                    {
                        if (Appid == 0)
                        {
                            ErrorCode = 0;
                        }
                        else
                        {
                            ErrorCode = 1;
                        }
                        return false;
                    }
                    else
                    {
                        JObject JsonObject = JObject.Parse(Data);
                        Boolean Status = Convert.ToBoolean(JsonObject.SelectToken("$." + Appid + ".success"));
                        if (Status == true)
                        {
                            return true;
                        }
                        else
                        {
                            ErrorCode = 2;
                            return false;
                        }
                    }
                }
                catch
                {
                    ErrorCode = 3;
                    return false;
                }
            }
            /// <summary>
            /// Connect to Steam Community and GetData.
            /// </summary>
            public struct Community
            {
                /// <summary>
                /// Get Owned Games, Parametr: User's SteamID64
                /// </summary>
                public static Boolean GetOwnedGames(String SteamID)
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        CommunityData = client.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + APIKEY + "&steamid=" + SteamID);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            /// <summary>
            /// Connect to Steam Market.
            /// </summary>
            public struct Market
            {
                /// <summary>
                /// Load Team Fortress 2 Keys Data.
                /// </summary>
                public static Boolean TF2Key()
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        MarketDataKey = client.DownloadString("https://steamcommunity.com/market/priceoverview/?appid=440&currency=" + Settings.Currency.Number + "&market_hash_name=Mann%20Co.%20Supply%20Crate%20Key");
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                /// <summary>
                /// Load Team Fortress 2 Ticket Data.
                /// </summary>
                public static Boolean TF2Ticket()
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        MarketDataTicket = client.DownloadString("https://steamcommunity.com/market/priceoverview/?appid=440&currency=" + Settings.Currency.Number + "&market_hash_name=Tour%20of%20Duty%20Ticket");
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
        /// <summary>
        /// Connect to Gaming-Club.ir.
        /// </summary>
        public struct ConnecttoShop
        {
            /// <summary>
            /// Load Key IRT Price.
            /// </summary>
            public static Boolean Key()
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    ShopData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/ShopData");
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            /// <summary>
            /// Load Ticket IRT Price.
            /// </summary>
            public static Boolean Ticket()
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    ShopData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/ShopData");
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
    /// <summary>
    /// Load Data After Connecting.
    /// </summary>
    class LoadData
    {
        /// <summary>
        /// Load Data from Store.
        /// </summary>
        public struct Store
        {
            private static string OnlyAlphaNumeric(String Data)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                return rgx.Replace(Data.ToString(), "");
            }
            private static string RemoveExtraSpace(String Data)
            {
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                return regex.Replace(Data, "");
            }
            private static string ArraytoString(string Data, string Data2 = "", int count = 0)
            {
                if (count == 2)
                {
                    return string.Format("{0}, {1}", Data, Data2);
                }
                else
                {
                    return Data;
                }
            }
            internal static JObject RawData
            {
                get
                {
                    JObject JsonObject = JObject.Parse(GetData.Data);
                    return JsonObject;
                }

            }
            /// <summary>
            /// Name of the Game.
            /// </summary>
            public static string Name
            {
                get
                {
                    JToken name = RawData.SelectToken("$." + GetData.Appid + ".data.name");
                    if (name == null)
                    {
                        return "Can't Load Data";
                    }
                    else
                    {
                        return OnlyAlphaNumeric(name.ToString());
                    }
                }
            }
            /// <summary>
            /// Check if Game Is Free.
            /// </summary>
            /// <remarks>
            /// Returns:if free: true, else: false.
            /// </remarks>
            public static Boolean IsFree
            {
                get
                {
                    return Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.is_free"));
                }
            }
            /// <summary>
            /// Type of Product(Game,DLC).
            /// </summary>
            public static string Type
            {
                get
                {
                    return RawData.SelectToken("$." + GetData.Appid + ".data.type").ToString();
                }
            }
            /// <summary>
            /// Full Name of Game for dlc.
            /// </summary>
            public static string FullNameofDLC
            {
                get
                {
                    if (Type == "dlc")
                    {
                        return RawData.SelectToken("$." + GetData.Appid + ".data.fullgame.name").ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            /// <summary>
            /// Developers of Product(Game,DLC).
            /// </summary>
            public static string Developers
            {
                get
                {
                    if (RawData.SelectToken("$." + GetData.Appid + ".data.developers[1]") != null)
                    {
                        return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.developers[0]").ToString(), RawData.SelectToken("$." + GetData.Appid + ".data.developers[1]").ToString(), 2));
                    }
                    else
                    {
                        return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.developers[0]").ToString()));
                    }
                }
            }
            /// <summary>
            /// Publishers of Product.
            /// </summary>
            public static string Publishers
            {
                get
                {
                    if (RawData.SelectToken("$." + GetData.Appid + ".data.publishers[1]") != null)
                    {
                        return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.publishers[0]").ToString(), RawData.SelectToken("$." + GetData.Appid + ".data.publishers[1]").ToString(), 2));
                    }
                    else
                    {
                        return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.publishers[0]").ToString()));
                    }
                }
            }
            /// <summary>
            /// Website of Product.
            /// </summary>
            public static string Website
            {
                get
                {
                    return RawData.SelectToken("$." + GetData.Appid + ".data.website").ToString();
                }
            }
            /// <summary>
            /// Controller Support of Product.
            /// </summary>
            public static string Controller_Support
            {
                get
                {
                    return RawData.SelectToken("$." + GetData.Appid + ".data.controller_support").ToString();
                }
            }
            /// <summary>
            /// Required Age of Product.
            /// </summary>
            public static int Required_Age
            {
                get
                {
                    return Convert.ToInt32(RawData.SelectToken("$." + GetData.Appid + ".data.required_age"));
                }
            }
            /// <summary>
            /// Description of Product.
            /// </summary>
            public static string Description
            {
                get
                {
                    return RawData.SelectToken("$." + GetData.Appid + ".data.short_description").ToString();
                }
            }
            /// <summary>
            /// HeaderImage of Product.
            /// </summary>
            public static string HeaderImage
            {
                get
                {
                    return RawData.SelectToken("$." + GetData.Appid + ".data.header_image").ToString();
                }
            }
            /// <summary>
            /// Library Image of Product.
            /// </summary>
            public static string LibraryImage
            {
                get
                {
                    string LibraryImage = "https://cdn.cloudflare.steamstatic.com/steam/apps/" + GetData.Appid + "/library_600x900.jpg";
                    return LibraryImage;
                }
            }
            /// <summary>
            /// Player Count of Product.
            /// </summary>
            public static int PlayerCount
            {
                get
                {
                    WebClient client = new WebClient();
                    try
                    {
                        JObject JsonObject = JObject.Parse(client.DownloadString("https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1?appid=" + GetData.Appid));
                        JToken PlayerCount = JsonObject.SelectToken("$.response.player_count");
                        if (JsonObject != null)
                        {
                            return Convert.ToInt32(PlayerCount);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
            /// <summary>
            /// Release Date of Product.
            /// </summary>
            public static DateTime ReleaseDate
            {
                get
                {
                    string Date = RawData.SelectToken("$." + GetData.Appid + ".data.release_date.date").ToString();
                    Date = Date.Replace("th", "");
                    return Convert.ToDateTime(Date);
                }
            }
            /// <summary>
            /// Raw Release Date of Product.
            /// </summary>
            public static string ReleaseDateString
            {
                get
                {
                    return RawData.SelectToken("$." + GetData.Appid + ".data.release_date.date").ToString();
                }
            }
            /// <summary>
            /// Check if Game is Coming Soon.
            /// </summary>
            public static Boolean IsComingSoon
            {
                get
                {
                    return Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.release_date.coming_soon"));
                }
            }
            public static Boolean IsValidDate
            {
                get
                {
                    if (ReleaseDate.ToString("dd") != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            /*public static string PackageGroups
            {
                get
                {
                    JToken type = RawData.SelectToken("$." + GetData.Appid + ".data.package_groups");
                    return type.ToString();
                }
            }*/
            /// <summary>
            /// Package of Product.
            /// </summary>
            public static string Packages
            {
                get
                {
                    try
                    {
                        if (Price.AvailabletoPurchase != false)
                        {
                            return RawData.SelectToken("$." + GetData.Appid + ".data.packages").ToString();
                        }
                        else
                        {
                            return "No Package";
                        }
                    }
                    catch (NullReferenceException)
                    {
                        return "No Package";
                    }
                }
            }
            public static string PackageGroups
            {
                get
                {
                    try
                    {
                        if (Price.AvailabletoPurchase != false)
                        {
                            return RawData.SelectToken("$." + GetData.Appid + ".data.package_groups").ToString();
                        }
                        else
                        {
                            return "No Package";
                        }
                    }
                    catch (NullReferenceException)
                    {
                        return "No Package";
                    }
                }
            }
            /// <summary>
            /// Price of Product.
            /// </summary>
            public struct Price
            {
                /// <summary>
                /// Product is Available to Purchase?.
                /// </summary>
                /// <remarks>
                /// Returns:if Available to Purchase: true, else: false.
                /// </remarks>
                public static Boolean AvailabletoPurchase
                {
                    get
                    {
                        if (RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.initial") != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                /// <summary>
                /// Currency of Product.
                /// </summary>
                public static string Currency
                {
                    get
                    {
                        if (IsFree == true)
                        {
                            return "";
                        }
                        else
                        {
                            return RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.currency").ToString();
                        }
                    }
                }
                /// <summary>
                /// Initial Price of Product (Original Price).
                /// </summary>
                public static double Initial
                {
                    get
                    {
                        if (IsFree == true)
                        {
                            return 0;
                        }
                        else
                        {
                            return Convert.ToDouble(RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.initial")) / 100;
                        }
                    }
                }
                /// <summary>
                /// Final Price of Product (Including Sale).
                /// </summary>
                public static double Final
                {
                    get
                    {
                        if (GetData.Appid != 0)
                        {
                            if (IsFree == true)
                            {
                                return 0;
                            }
                            else
                            {
                                return Convert.ToDouble(RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.final")) / 100;
                            }
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// Discount Percent of Product.
                /// </summary>
                public static int Discount_Percent
                {
                    get
                    {
                        if (IsFree == true)
                        {
                            return 0;
                        }
                        else
                        {
                            return Convert.ToInt32(RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.discount_percent"));
                        }
                    }

                }
                /// <summary>
                /// Initial Formatted Price of Product (Original Price).
                /// </summary>
                public static string Initial_Formatted
                {
                    get
                    {
                        if (IsFree == true)
                        {
                            return "0";
                        }
                        else
                        {
                            return RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.initial_formatted").ToString();
                        }
                    }

                }
                /// <summary>
                /// Final Formatted Price of Product (Including Sale).
                /// </summary>
                public static string Final_Formatted
                {
                    get
                    {
                        if (IsFree == true)
                        {
                            return "0";
                        }
                        else
                        {
                            return RawData.SelectToken("$." + GetData.Appid + ".data.price_overview.final_formatted").ToString();
                        }
                    }
                }
            }
            /// <summary>
            /// Platforms of Product.
            /// </summary>
            public struct Platform
            {
                public static Boolean Windows
                {
                    get
                    {
                        return Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.platforms.windows"));
                    }
                }
                public static Boolean Mac
                {
                    get
                    {
                        return Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.platforms.mac"));
                    }
                }
                public static Boolean Linux
                {
                    get
                    {
                        return Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.platforms.linux"));
                    }
                }
            }
            /// <summary>
            /// DLC's of Product.
            /// </summary>
            public class DLC
            {
                private static bool ContainDLC
                {
                    get
                    {
                        try
                        {
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                            WebClient client = new WebClient();
                            JObject JsonObject = JObject.Parse(client.DownloadString("https://store.steampowered.com/api/appdetails?appids=" + GetData.Appid + "&cc=" + Settings.Currency.ISO));
                            if (RawData.SelectToken("$." + GetData.Appid + ".data.dlc") == null)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        catch (NullReferenceException)
                        {
                            return false;
                        }
                    }
                }
                /// <summary>
                /// Load All DLC's of Product.
                /// </summary>
                public static MatchCollection GetAllDLC
                {
                    get
                    {
                        if (ContainDLC == true)
                        {
                            return Regex.Matches(RawData.SelectToken("$." + GetData.Appid + ".data.dlc").ToString(), @"\d+");
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                /// <summary>
                /// Return Count of All DLC.
                /// </summary>
                public static int Count
                {
                    get
                    {
                        if (ContainDLC == true)
                        {
                            return RawData.SelectToken("$." + GetData.Appid + ".data.dlc").ToList().Count;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// Contains Data of DLC.
                /// </summary>
                public struct Data
                {
                    private static JObject DataDLC
                    {
                        get
                        {
                            WebClient client = new WebClient();
                            string data = client.DownloadString("https://store.steampowered.com/api/appdetails?appids=" + GetData.DLCID + "&cc=" + Settings.Currency.ISO + "&l=en");
                            JObject JsonObject = JObject.Parse(data);
                            return JsonObject;
                        }
                    }
                    /// <summary>
                    /// Name of DLC.
                    /// </summary>
                    public static string Name
                    {
                        get
                        {
                            if (DataDLC.SelectToken(GetData.DLCID + ".data.name").ToString().Contains("-"))
                            {
                                string[] tokens = DataDLC.SelectToken(GetData.DLCID + ".data.name").ToString().Split(new[] { " - " }, StringSplitOptions.None);
                                return OnlyAlphaNumeric(tokens[1]);
                            }
                            else if (DataDLC.SelectToken(GetData.DLCID + ".data.name").ToString().Contains(":"))
                            {
                                string[] tokens = DataDLC.SelectToken(GetData.DLCID + ".data.name").ToString().Split(new[] { ":" }, StringSplitOptions.None);
                                return OnlyAlphaNumeric(tokens[1]);
                            }
                            else
                            {
                                return OnlyAlphaNumeric(DataDLC.SelectToken(GetData.DLCID + ".data.name").ToString());
                            }
                        }
                    }
                    /// <summary>
                    /// Image of DLC.
                    /// </summary>
                    public static string HeaderImage
                    {
                        get
                        {
                            return DataDLC.SelectToken(GetData.DLCID + ".data.header_image").ToString();
                        }
                    }
                    /// <summary>
                    /// Price of DLC.
                    /// </summary>
                    public static double Price
                    {
                        get
                        {
                            double price = Convert.ToDouble(DataDLC.SelectToken(GetData.DLCID + ".data.price_overview.final"));
                            price /= 100;
                            return price;
                        }
                    }
                    /// <summary>
                    /// Discount of DLC.
                    /// </summary>
                    public static int Discount
                    {
                        get
                        {
                            JToken Discount_Percent = DataDLC.SelectToken("$." + GetData.DLCID + ".data.price_overview.discount_percent");
                            if (Isfree == true)
                            {
                                return 0;
                            }
                            else
                            {
                                return Convert.ToInt32(Discount_Percent);
                            }
                        }
                    }
                    /// <summary>
                    /// Check if DLC is Free.
                    /// </summary>
                    /// <remarks>
                    /// Returns:if free: true, else: false.
                    /// </remarks>
                    public static Boolean Isfree
                    {
                        get
                        {
                            return Convert.ToBoolean(DataDLC.SelectToken(GetData.DLCID + ".data.is_free"));
                        }
                    }
                    /// <summary>
                    /// Check if DLC is Coming Soon.
                    /// </summary>
                    /// <remarks>
                    /// Returns:if free: true, else: false.
                    /// </remarks>
                    public static Boolean ComingSoon
                    {
                        get
                        {
                            return Convert.ToBoolean(DataDLC.SelectToken(GetData.DLCID + ".data.release_date.coming_soon"));
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Load Steam Community Data.
        /// </summary>
        public struct Community
        {
            /// <summary>
            /// Check if user Own a Game.
            /// </summary>
            /// <remarks>
            /// Returns:if free: true, else: false.
            /// </remarks>
            public static Boolean Isowned(int Appid)
            {
                Boolean status = false;
                JObject JsonObject = JObject.Parse(GetData.CommunityData);
                int i = 0;
                for (; ; )
                {
                    i++;
                    JToken app_id = JsonObject.SelectToken(".response.games.[" + i + "].appid");
                    if (app_id == null)
                    {
                        break;
                    }

                    if (Appid == Convert.ToInt32(app_id))
                    {
                        status = true;
                        break;
                    }
                    else { }
                }
                return status;
            }
            /// <summary>
            /// Return Playtime in Minute
            /// </summary>
            public static int Playtime(int Appid)
            {
                if (Isowned(Appid) == true)
                {
                    JObject JsonObject = JObject.Parse(GetData.CommunityData);
                    int i = 0;
                    int time;
                    for (; ; )
                    {
                        i++;
                        JToken app_id = JsonObject.SelectToken(".response.games.[" + i + "].appid");
                        if (Appid == Convert.ToInt32(app_id))
                        {
                            JToken Play_Time = JsonObject.SelectToken(".response.games.[" + i + "].playtime_forever");
                            time = Convert.ToInt32(Play_Time);
                            break;
                        }
                    }
                    return time;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Get Data of Steam Market
        /// </summary>
        public struct Market
        {
            /// <summary>
            /// Get Data of TF2Key
            /// </summary>
            public class Key
            {
                /// <summary>
                /// Lowest Price (Live).
                /// </summary>
                public static Double LowestPrice
                {
                    get
                    {
                        if (GetData.MarketDataKey != "")
                        {
                            dynamic data_object = JsonConvert.DeserializeObject<dynamic>(GetData.MarketDataKey);
                            string price = data_object["lowest_price"].ToString();
                            double price_full;
                            price_full = Convert.ToDouble(Regex.Replace(price, "[^0-9]", ""));
                            price_full /= 100;
                            return price_full;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// User Price (Including Steam Selling Fee).
                /// </summary>
                public static Double User_Price
                {
                    get
                    {
                        if (LowestPrice != 0)
                        {
                            double User_Price = LowestPrice;
                            User_Price /= 1.15;
                            User_Price = Math.Round(User_Price, 2);
                            return User_Price;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                private static int Quanity
                {
                    get { return 0; }
                }
            }
            /// <summary>
            /// Get Data of TF2 Ticket
            /// </summary>
            public class Ticket
            {
                /// <summary>
                /// Lowest Price (Live).
                /// </summary>
                public static Double LowestPrice
                {
                    get
                    {
                        if (GetData.MarketDataTicket != "")
                        {
                            dynamic data_object = JsonConvert.DeserializeObject<dynamic>(GetData.MarketDataTicket);
                            string price = data_object["lowest_price"].ToString();
                            double price_full;
                            price_full = Convert.ToDouble(Regex.Replace(price, "[^0-9]", ""));
                            price_full /= 100;
                            return price_full;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// User Price (Including Steam Selling Fee).
                /// </summary>
                public static Double User_Price
                {
                    get
                    {
                        if (LowestPrice != 0)
                        {
                            double User_Price = LowestPrice;
                            User_Price /= 1.15;
                            User_Price = Math.Round(User_Price, 2);
                            return User_Price;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                private static int Quanity
                {
                    get { return 0; }
                }
            }
        }
        /// <summary>
        /// Connect To Gaming-Club.ir.
        /// </summary>
        public struct Shop
        {
            /// <summary>
            /// Key IRT Price.
            /// </summary>
            public static int Key
            {
                get
                {
                    if (GetData.ShopData != "")
                    {
                        JObject JsonObject = JObject.Parse(GetData.ShopData);
                        return Convert.ToInt32(JsonObject.SelectToken("$.Key"));
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            /// <summary>
            /// Ticket IRT Price.
            /// </summary>
            public static int Ticket
            {
                get
                {
                    if (GetData.ShopData != "")
                    {
                        JObject JsonObject = JObject.Parse(GetData.ShopData);
                        return Convert.ToInt32(JsonObject.SelectToken("$.Ticket"));
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
