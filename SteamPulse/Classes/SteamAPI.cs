#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// C# Steam API
//
// https://Amirhoseindavat.ir
//
// Beta Build
//
// Version 0.7 Revision 18
// last Edit: 10/28/22 V2.0
#endregion

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamPulse.UserSettings;
using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace SteamPulse.SteamAPI
{

    /// <summary>
    /// Connect and GetData.
    /// </summary>
    internal class GetData
    {
        public static int Appid { get; private set; }
        public static int PackageID { get; set; }
        public static int DLCID { get; set; }
        protected internal static string Data { get; private set; }
        protected internal static string PackageData { get; private set; }
        protected internal static string MarketDataKey { get; private set; }
        protected internal static string MarketDataTicket { get; private set; }
        protected internal static string CommunityData { get; private set; }
        protected internal static string ProfileData { get; private set; }
        protected internal static string PlayerData { get; private set; }
        protected internal static string WishlistData { get; private set; }
        protected internal static string GamingClubData { get; private set; }
        protected internal static string MarketHistogramKey { get; private set; }
        protected internal static string MarketHistogramTicket { get; private set; }
        internal static string APIKEY => "C0C2746E5859F6EAD7B27E79C6D9BC76";
        public static int ErrorCode { get; private set; }
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
            public static bool Store(int Appid)
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
                        bool Status = Convert.ToBoolean(JsonObject.SelectToken("$." + Appid + ".success"));
                        if (Status == true)
                        {
                            GetData.Appid = Appid;
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

            public static bool Package()
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    PackageData = "";
                    PackageData = client.DownloadString("https://store.steampowered.com/api/packagedetails/?cc=" + Settings.Currency.ISO + "&packageids=" + PackageID);
                    if (PackageData == "")
                    {
                        if (PackageID == 0)
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
                        JObject JsonObject = JObject.Parse(PackageData);
                        bool Status = Convert.ToBoolean(JsonObject.SelectToken("$." + PackageID + ".success"));
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
                public static bool GetOwnedGames(string SteamID)
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        CommunityData = client.DownloadString("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + APIKEY + "&steamid=" + SteamID + "&include_played_free_games=true&include_free_sub=true&skip_unvetted_apps=false");
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                public static bool GetAvatarFrame(string SteamID)
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        ProfileData = client.DownloadString("https://api.steampowered.com/IPlayerService/GetAvatarFrame/v1/?key=" + APIKEY + "&steamid=" + SteamID);
                        return true;

                    }
                    catch
                    {
                        return false;
                    }
                }

                public static bool GetPlayerSummaries(string SteamID)
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        PlayerData = client.DownloadString("https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=" + APIKEY + "&steamids=" + SteamID);
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
                public static bool TF2Key()
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
                        MarketDataTicket = "";
                        return false;
                    }
                }
                //public 

                
                /// <summary>
                /// Load Team Fortress 2 Ticket Data.
                /// </summary>
                public static bool TF2Ticket()
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
                        MarketDataTicket = "";
                        return false;
                    }
                }
                public static bool TF2KeyHistogram()
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        MarketHistogramKey = client.DownloadString("https://steamcommunity.com/market/itemordershistogram?country=" + Settings.Currency.ISO + "&language=english&currency=" + Settings.Currency.Number + "&item_nameid=1&two_factor=0");
                        return true;
                    }
                    catch
                    {
                        MarketHistogramKey = "";
                        return false;
                    }
                }
                public static bool TF2TicketHistogram()
                {
                    try
                    {
                        WebClient client = new WebClient();
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        MarketHistogramTicket = client.DownloadString("https://steamcommunity.com/market/itemordershistogram?country=" + Settings.Currency.ISO + "&language=english&currency=" + Settings.Currency.Number + "&item_nameid=20&two_factor=0");
                        return true;
                    }
                    catch
                    {
                        //Logger.LogMarket(ex.Message);
                        MarketHistogramTicket = "";
                        return false;
                    }
                }
            }
        }
        /// <summary>
        /// Connect to Gaming-Club.ir.
        /// </summary>
        public struct GamingClub
        {
            /// <summary>
            /// Load Key IRT Price.
            /// </summary>
            public static bool Key()
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    GamingClubData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/ShopData");
                    return true;
                }
                catch
                {
                    GamingClubData = "";
                    return false;
                }
            }
            /// <summary>
            /// Load Ticket IRT Price.
            /// </summary>
            public static bool Ticket()
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    WebClient client = new WebClient();
                    GamingClubData = client.DownloadString("https://api.codemage.ir/Projects/SteamPulse/ShopData");
                    return true;
                }
                catch
                {
                    GamingClubData = "";
                    return false;
                }
            }
        }
    }

    /// <summary>
    /// Load Data After Connecting.
    /// </summary>
    internal class LoadData
    {
        /// <summary>
        /// Load Data from Store.
        /// </summary>
        public struct Store
        {
            /// <summary>
            /// Remove Anything but Alphabet or numeric (internal use)
            /// </summary>
            private static string OnlyAlphaNumeric(string Data)
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -:-]");
                return rgx.Replace(Data.ToString(), "");
            }
            /// <summary>
            /// Remove Extra Space from string (internal use)
            /// </summary>
            private static string RemoveExtraSpace(string Data)
            {
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                return regex.Replace(Data, "");
            }
            /// <summary>
            /// Merge two or more Developer or Publisher to one string (internal use)
            /// </summary>
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
            /// <summary>
            /// RawData for JToken
            /// </summary>
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
            public static bool IsFree => Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.is_free"));
            /// <summary>
            /// Type of Product(Game,DLC).
            /// </summary>
            public static string Type => RawData.SelectToken("$." + GetData.Appid + ".data.type").ToString();
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
                    try
                    {
                        if (RawData.SelectToken("$." + GetData.Appid + ".data.developers[1]") != null)
                        {
                            return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.developers[0]").ToString(), RawData.SelectToken("$." + GetData.Appid + ".data.developers[1]").ToString(), 2));
                        }
                        else
                        {
                            if (RawData.SelectToken("$." + GetData.Appid + ".data.developers[0]") != null)
                            {
                                return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.developers[0]").ToString()));
                            }
                            else
                            {
                                return "N/A";
                            }
                        }
                    }
                    catch
                    {
                        return "N/A";
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
                        if (RawData.SelectToken("$." + GetData.Appid + ".data.publishers[0]") != null)
                        {
                            return RemoveExtraSpace(ArraytoString(RawData.SelectToken("$." + GetData.Appid + ".data.publishers[0]").ToString()));
                        }
                        else
                        {
                            return "N/A";
                        }
                    }
                }
            }
            /// <summary>
            /// Website of Product.
            /// </summary>
            public static string Website => RawData.SelectToken("$." + GetData.Appid + ".data.website").ToString();
            /// <summary>
            /// Controller Support of Product.
            /// </summary>
            public static string Controller_Support => RawData.SelectToken("$." + GetData.Appid + ".data.controller_support").ToString();
            /// <summary>
            /// Required Age of Product.
            /// </summary>
            public static int Required_Age => Convert.ToInt32(RawData.SelectToken("$." + GetData.Appid + ".data.required_age"));
            /// <summary>
            /// Description of Product.
            /// </summary>
            public static string Description => RawData.SelectToken("$." + GetData.Appid + ".data.short_description").ToString();
            /// <summary>
            /// HeaderImage of Product.
            /// </summary>
            public static string HeaderImage
            {
                get
                {
                    if (GetData.Appid == 1250410)
                    {
                        return GlobalVariables.Images.Header.MSFS;
                    }
                    else
                    {
                        return RawData.SelectToken("$." + GetData.Appid + ".data.header_image").ToString();
                    }

                }
            }
            /// <summary>
            /// Library Image of Product.
            /// </summary>
            public static string LibraryImage
            {
                get
                {

                    if (GetData.Appid == 1250410)
                    {
                        return GlobalVariables.Images.Hero.MSFS;
                    }
                    else
                    {
                        string LibraryImage = "https://cdn.cloudflare.steamstatic.com/steam/apps/" + GetData.Appid + "/library_600x900.jpg";
                        return LibraryImage;
                    }
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
            public static string ReleaseDateString => RawData.SelectToken("$." + GetData.Appid + ".data.release_date.date").ToString();
            /// <summary>
            /// Check if Game is Coming Soon.
            /// </summary>
            public static bool IsComingSoon => Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.release_date.coming_soon"));
            /// <summary>
            /// Is Release Date Valid ? (internal use)
            /// </summary>
            public static bool IsValidDate
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

            public struct Packages
            {
                private static JObject RawPackageData
                {
                    get
                    {
                        JObject JsonObject = JObject.Parse(GetData.PackageData);
                        return JsonObject;
                    }

                }
                /// <summary>
                /// Package of Product.
                /// </summary>
                public static string ProductPackages
                {
                    get
                    {
                        try
                        {
                            if (Store.Price.AvailabletoPurchase)
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
                public static int GetPackageIDbyIndex(int index)
                {
                    try
                    {
                        return Convert.ToInt32(RawData.SelectToken("$." + GetData.Appid + ".data.packages[" + index + "]"));
                    }
                    catch (NullReferenceException)
                    {
                        return -1;
                    }
                }

                public static string FullName
                {
                    get
                    {
                        JToken name = RawPackageData.SelectToken("$." + GetData.PackageID + ".data.name");
                        if (name == null)
                        {
                            return "Can't Load Data";
                        }
                        else
                        {
                            return name.ToString();
                        }
                    }
                }
                public static string TrimmedName
                {
                    get
                    {
                        try
                        {
                            if (FullName.Contains("-"))
                            {
                                string[] tokens = FullName.Split(new[] { " - " }, StringSplitOptions.None);
                                return tokens[1];
                            }
                            else if (FullName.Contains(":"))
                            {
                                string[] tokens = FullName.Split(new[] { ":" }, StringSplitOptions.None);
                                return tokens[1];
                            }
                            else
                            {
                                string full_name = OnlyAlphaNumeric(FullName);
                                return full_name.Replace(Name, "");
                            }
                        }
                        catch
                        {
                            string full_name = OnlyAlphaNumeric(FullName);
                            return full_name.Replace(Name, "");
                        }
                    }
                }
                /// <summary>
                /// HeaderImage of Package.
                /// </summary>
                public static string HeaderImage
                {
                    get
                    {
                        if (RawPackageData.SelectToken("$." + GetData.PackageID + ".data.header_image") != null)
                        {
                            return RawPackageData.SelectToken("$." + GetData.PackageID + ".data.header_image").ToString();
                        }
                        else
                        {
                            return Store.HeaderImage;
                        }
                    }
                }

                /// <summary>
                /// Price of Product.
                /// </summary>
                public struct Price
                {
                    /// <summary>
                    /// Package is Available to Purchase?.
                    /// </summary>
                    /// <remarks>
                    /// Returns:if Available to Purchase: true, else: false.
                    /// </remarks>
                    public static bool AvailabletoPurchase
                    {
                        get
                        {
                            if (RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.initial") != null)
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
                    /// Currency of Package.
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
                                return RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.currency").ToString();
                            }
                        }
                    }
                    /// <summary>
                    /// Initial Price of Package (Original Price).
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
                                return Convert.ToDouble(RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.initial")) / 100;
                            }
                        }
                    }
                    /// <summary>
                    /// Final Price of Package (Including Sale).
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
                                    return Convert.ToDouble(RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.final")) / 100;
                                }
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                    /// <summary>
                    /// Discount Percent of Package.
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
                                return Convert.ToInt32(RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.discount_percent"));
                            }
                        }

                    }
                    /// <summary>
                    /// Initial Formatted Price of Package (Original Price).
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
                                return RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.initial_formatted").ToString();
                            }
                        }

                    }
                    /// <summary>
                    /// Final Formatted Price of Package (Including Sale).
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
                                return RawPackageData.SelectToken("$." + GetData.PackageID + ".data.price.final_formatted").ToString();
                            }
                        }
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
                public static bool AvailabletoPurchase
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
                public static bool Windows => Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.platforms.windows"));
                public static bool Mac => Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.platforms.mac"));
                public static bool Linux => Convert.ToBoolean(RawData.SelectToken("$." + GetData.Appid + ".data.platforms.linux"));
            }
            /// <summary>
            /// DLC's of Product.
            /// </summary>
            public class DLC
            {
                /// <summary>
                /// check for game if has dlc or not
                /// </summary>
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
                        catch
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
                    public static string HeaderImage => DataDLC.SelectToken(GetData.DLCID + ".data.header_image").ToString();
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

                    public static int OrigialGameID => Convert.ToInt32(DataDLC.SelectToken(GetData.DLCID + ".data.fullgame.appid"));
                    public static string OrigialGamename => DataDLC.SelectToken(GetData.DLCID + ".data.fullgame.name").ToString();
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
                    public static bool Isfree => Convert.ToBoolean(DataDLC.SelectToken(GetData.DLCID + ".data.is_free"));
                    /// <summary>
                    /// Check if DLC is Coming Soon.
                    /// </summary>
                    /// <remarks>
                    /// Returns:if free: true, else: false.
                    /// </remarks>
                    public static bool ComingSoon => Convert.ToBoolean(DataDLC.SelectToken(GetData.DLCID + ".data.release_date.coming_soon"));
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
            /// Returns:if owned: true, else: false.
            /// </remarks>
            public static bool Isowned(int Appid)
            {
                try
                {
                    bool status = false;
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
                catch
                {
                    return false;
                }
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
            public struct UserStatus
            {
                private static bool IsInGame = false;

                /// <summary>
                /// Return current status
                /// </summary>
                public static int OnlineStatus
                {
                    get
                    {
                        try
                        {
                            GetData.ConnectToSteam.Community.GetPlayerSummaries(SteamPulse.Properties.Settings.Default.UserSteamID);

                            int status = 0;

                            JObject JsonObject = JObject.Parse(GetData.PlayerData);

                            if (JsonObject.SelectToken(".response.players[0].gameextrainfo") != null)
                            {
                                IsInGame = true;
                            }
                            else
                            {
                                IsInGame = false;
                            }
                            status = Convert.ToInt32(JsonObject.SelectToken(".response.players[0].personastate"));
                            if (IsInGame == true)
                            {
                                return 85;
                            }
                            else
                            {
                                return status;
                            }

                        }
                        catch
                        {
                            return -1;
                        }
                    }
                }
                /// <summary>
                /// Return currenct playing game
                /// </summary>
                public static string CurrentPlayingGame
                {
                    get
                    {
                        if (IsInGame == true)
                        {
                            JObject JsonObject = JObject.Parse(GetData.PlayerData);
                            return JsonObject.SelectToken(".response.players[0].gameextrainfo").ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            /// <summary>
            /// Get Avatar Frame
            /// </summary>
            public static string AvatarFrame(string steamid)
            {
                if (GetData.ConnectToSteam.Community.GetAvatarFrame(steamid) == true)
                {
                    JObject JsonObject = JObject.Parse(GetData.ProfileData);
                    JToken AvatarFrame = JsonObject.SelectToken(".response.avatar_frame.image_small");
                    return "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/" + AvatarFrame.ToString();
                }
                else
                {
                    return "";
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
                /// Return lowest sellorder price (Live).
                /// </summary>
                public static double LowestSellOrder
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketDataKey != "")
                            {
                                dynamic data_object = JsonConvert.DeserializeObject<dynamic>(GetData.MarketDataKey);
                                if (data_object != null)
                                {
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
                /// Return sell order quantity
                /// </summary>
                public static int SellOrderQuantity
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketHistogramKey != "")
                            {
                                JObject HistogramData = JObject.Parse(GetData.MarketHistogramKey);
                                string[] tokens = HistogramData.SelectToken(".sell_order_summary").ToString().Split(new[] { "</span>" }, StringSplitOptions.None);
                                return Convert.ToInt32(Regex.Replace(tokens[0], "[^0-9]", ""));
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
                /// Return buy order quantity
                /// </summary>
                public static int BuyOrderQuantity
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketHistogramKey != "")
                            {
                                JObject HistogramData = JObject.Parse(GetData.MarketHistogramKey);
                                string[] tokens = HistogramData.SelectToken(".buy_order_summary").ToString().Split(new[] { "</span>" }, StringSplitOptions.None);
                                return Convert.ToInt32(Regex.Replace(tokens[0], "[^0-9]", ""));
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
                /// Return highset buy order bid
                /// </summary>
                public static double HighestBuyOrder
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketHistogramKey != "")
                            {
                                JObject HistogramData = JObject.Parse(GetData.MarketHistogramKey);
                                return (Convert.ToDouble(HistogramData.SelectToken(".highest_buy_order").ToString()) / 100);
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
                /// Return highset buy order bid (without steam fee)
                /// </summary>
                /// <value></value>
                public static double HighestBuyOrderNoFee
                {
                    get
                    {
                        if (HighestBuyOrder != 0)
                        {
                            double User_Price = HighestBuyOrder;
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
                /// <summary>
                /// Return user price (without steam fee)
                /// </summary>
                public static double LowestSellOrderNoFee
                {
                    get
                    {
                        if (LowestSellOrder != 0)
                        {
                            double User_Price = LowestSellOrder;
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
            }
            /// <summary>
            /// Get Data of TF2 Ticket
            /// </summary>
            public class Ticket
            {
                /// <summary>
                /// Return lowest sellorder price (Live).
                /// </summary>
                public static double LowestSellOrder
                {
                    get
                    {
                        try
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
                        catch
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// Return user price (without steam fee)
                /// </summary>
                public static double LowestSellOrderNoFee
                {
                    get
                    {
                        if (LowestSellOrder != 0)
                        {
                            double User_Price = LowestSellOrder;
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

                /// <summary>
                /// Return sell order quantity
                /// </summary>
                public static int SellOrderQuantity
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketHistogramTicket != "")
                            {
                                JObject HistogramData = JObject.Parse(GetData.MarketHistogramTicket);
                                string[] tokens = HistogramData.SelectToken(".sell_order_summary").ToString().Split(new[] { "</span>" }, StringSplitOptions.None);
                                return Convert.ToInt32(Regex.Replace(tokens[0], "[^0-9]", ""));
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
                /// Return buy order quantity
                /// </summary>
                public static int BuyOrderQuantity
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketHistogramTicket != "")
                            {
                                JObject HistogramData = JObject.Parse(GetData.MarketHistogramTicket);
                                string[] tokens = HistogramData.SelectToken(".buy_order_summary").ToString().Split(new[] { "</span>" }, StringSplitOptions.None);
                                return Convert.ToInt32(Regex.Replace(tokens[0], "[^0-9]", ""));
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
                /// Return highset buy order bid
                /// </summary>
                public static double HighestBuyOrder
                {
                    get
                    {
                        try
                        {
                            if (GetData.MarketHistogramTicket != "")
                            {
                                JObject HistogramData = JObject.Parse(GetData.MarketHistogramTicket);
                                return (Convert.ToDouble(HistogramData.SelectToken(".highest_buy_order").ToString()) / 100);
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
                /// Return highset buy order bid (without steam fee)
                /// </summary>
                public static double HighestBuyOrderNoFee
                {
                    get
                    {
                        if (HighestBuyOrder != 0)
                        {
                            double User_Price = HighestBuyOrder;
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

            }
        }
        /// <summary>
        /// Connect To Gaming-Club.ir.
        /// </summary>
        public struct GamingClub
        {
            /// <summary>
            /// Key IRT Price.
            /// </summary>
            public struct Key
            {
                /// <summary>
                /// Return current price for key from GamingClub in IRT
                /// </summary>
                public static int Price
                {
                    get
                    {
                        //if (GetData.GamingClub.Key() == true)
                        if (GetData.GamingClubData != "")
                        {
                            JObject JsonObject = JObject.Parse(GetData.GamingClubData);
                            return Convert.ToInt32(JsonObject.SelectToken("$.Key"));
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// Return current stock number for key from GamingClub in IRT
                /// </summary>
                public static int Stock
                {
                    get
                    {
                        //if (GetData.GamingClub.Key() == true)
                        if (GetData.GamingClubData != "")
                        {
                            JObject JsonObject = JObject.Parse(GetData.GamingClubData);
                            return Convert.ToInt32(JsonObject.SelectToken("$.KeyStock"));
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            /// <summary>
            /// Ticket IRT Price.
            /// </summary>
            public struct Ticket
            {
                /// <summary>
                /// Return current price for ticket from GamingClub in IRT
                /// </summary>
                public static int Price
                {
                    get
                    {
                        //if (GetData.GamingClub.Ticket() == true)
                        if (GetData.GamingClubData != "")
                        {
                            JObject JsonObject = JObject.Parse(GetData.GamingClubData);
                            return Convert.ToInt32(JsonObject.SelectToken("$.Ticket"));
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                /// <summary>
                /// Return current stock number for ticket from GamingClub in IRT
                /// </summary>
                public static int Stock
                {
                    get
                    {
                        //if (GetData.GamingClub.Key() == true)
                        if (GetData.GamingClubData != "")
                        {
                            JObject JsonObject = JObject.Parse(GetData.GamingClubData);
                            return Convert.ToInt32(JsonObject.SelectToken("$.TicketStock"));
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
}
