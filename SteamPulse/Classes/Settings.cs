#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1 
// last Edit: 2/16/23 V2.1
#endregion

using System;

namespace SteamPulse.UserSettings
{
    public class Settings
    {
        public struct Currency
        {
            public static string Name
            {
                get => Properties.Settings.Default.CurrencyName;
                set
                {
                    Properties.Settings.Default.CurrencyName = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static int Number
            {
                get => Convert.ToInt32(Properties.Settings.Default.CurrencyNumber);
                set
                {
                    Properties.Settings.Default.CurrencyNumber = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static string ISO
            {
                get => Properties.Settings.Default.CurrencyISO;
                set
                {
                    Properties.Settings.Default.CurrencyISO = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static string Unit
            {
                get => Properties.Settings.Default.CurrencyUnit;
                set
                {
                    Properties.Settings.Default.CurrencyUnit = value;
                    Properties.Settings.Default.Save();
                }
            }
        }
        public static string CalculatorMode
        {
            get => Properties.Settings.Default.CalculatorMode;
            set
            {
                Properties.Settings.Default.CalculatorMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int MarketUpdateTime
        {
            get => Convert.ToInt32(Properties.Settings.Default.MarketUpdateTime);
            set
            {
                Properties.Settings.Default.MarketUpdateTime = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool CheckIRT
        {
            get => Convert.ToBoolean(Properties.Settings.Default.CalculateIRT);
            set
            {
                Properties.Settings.Default.CalculateIRT = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool CheckOwned
        {
            get => Convert.ToBoolean(Properties.Settings.Default.CheckOwned);
            set
            {
                Properties.Settings.Default.CheckOwned = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool DarkMode
        {
            get => Convert.ToBoolean(Properties.Settings.Default.DarkMode);
            set
            {
                Properties.Settings.Default.DarkMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool SystemDarkMode
        {
            get => Convert.ToBoolean(Properties.Settings.Default.UseSystemDarkmode);
            set
            {
                Properties.Settings.Default.UseSystemDarkmode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool CheckUpdate
        {
            get => Convert.ToBoolean(Properties.Settings.Default.CheckUpdate);
            set
            {
                Properties.Settings.Default.CheckUpdate = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string ItemCalculationMode
        {
            get => Properties.Settings.Default.ItemCalculationMode;
            set
            {
                Properties.Settings.Default.ItemCalculationMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int DefualtDlcCount
        {
            get => Properties.Settings.Default.DefaultDLCCount;
            set
            {
                Properties.Settings.Default.DefaultDLCCount = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool InstallBeta
        {
            get => Convert.ToBoolean(Properties.Settings.Default.InstallBeta);
            set
            {
                Properties.Settings.Default.InstallBeta = value;
                Properties.Settings.Default.Save();
            }

        }
        public static string StartingPage
        {
            get => Properties.Settings.Default.StartingPage;
            set
            {
                Properties.Settings.Default.StartingPage = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string KeyCalcMode
        {
            get => Properties.Settings.Default.KeyCalcMode;
            set
            {
                Properties.Settings.Default.KeyCalcMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool LoadDLCImage
        {
            get => Convert.ToBoolean(Properties.Settings.Default.LoadDLCImage);
            set
            {
                Properties.Settings.Default.LoadDLCImage = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool CalculateRemaining
        {
            get => Convert.ToBoolean(Properties.Settings.Default.CalculateRemaining);
            set
            {
                Properties.Settings.Default.CalculateRemaining = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool HistogramData
        {
            get => Convert.ToBoolean(Properties.Settings.Default.HistogramData);
            set
            {
                Properties.Settings.Default.HistogramData = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool DeveloperMode
        {
            get => Convert.ToBoolean(Properties.Settings.Default.DeveloperMode);
            set
            {
                Properties.Settings.Default.DeveloperMode = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool EnteredGiveaway
        {
            get => Convert.ToBoolean(Properties.Settings.Default.EnteredGiveaway);
            set
            {
                Properties.Settings.Default.EnteredGiveaway = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
