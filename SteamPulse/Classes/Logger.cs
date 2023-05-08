#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1 
// last Edit: 2/16/23 V2.1
#endregion

using SteamPulse.HardWareInformation;
using SteamPulse.SteamAPI;
using SteamPulse.UserSettings;
using System;
using System.IO;
using System.Windows.Forms;

namespace SteamPulse.Logger
{
    public class Log
    {
        private static readonly string LogPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CodeMage\SteamPulse.Log";
        internal static bool CheckExist()
        {
            if (File.Exists(LogPath))
            {
                return true;
            }
            else
            {
                Create();
                return true;
            }
        }
        public static void Delete()
        {
            if (CheckExist() == true)
            {
                File.Delete(LogPath);
            }
        }
        public static void Create()
        {
            var DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var LPath = Path.Combine(DocumentsPath, "CodeMage");
            try
            {
                Directory.CreateDirectory(LPath);
                var myFile = File.Create(LogPath);
                myFile.Close();
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write("##The logging system still is in development and may have some problems." + Environment.NewLine);
                    Logger.Write(string.Format("{0} - [System] Log Created by {1}, SteamPulse Version: {2}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Environment.UserName, Application.ProductVersion) + Environment.NewLine);
                }
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(Environment.NewLine + "*********************** - System Hardware Information - ***********************" + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - CPU: {0}", GetHardwareInformation.CPU.Model()) + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - GPU: {0}", GetHardwareInformation.GPU.Model()) + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - Ram: {0}GB", GetHardwareInformation.Ram.Size()) + Environment.NewLine);
                    Logger.Write(string.Format("*********************** - OS:  {0}", GetHardwareInformation.OS.Name()) + Environment.NewLine);
                    Logger.Write("*********************** - System Hardware Information - ***********************" + Environment.NewLine);
                    Logger.Write("" + Environment.NewLine);
                }
            }
            catch
            {

            }
        }
        public static void LogRequest(string Message)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Main] Requested to SteamPulse.Classes.SteamAPI: (AppID: {1}, Name: {2}, Region: {3}), Description: {4}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), GetData.Appid, LoadData.Store.Name, Settings.Currency.ISO, Message) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogBugReport()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] Bug Reported Successfully, Thank You!", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogMarket(string Message, double key = 0, double ticket = 0)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    if (key == 0 && ticket == 0)
                    {
                        Logger.Write(string.Format("{0} - [Market] Requested to SteamPulse.Classes.SteamAPI, Region: {1} , IRT: {2}, Description: {3}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Settings.Currency.ISO, Settings.CheckIRT, Message) + Environment.NewLine);
                    }
                    else
                    {
                        Logger.Write(string.Format("{0} - [Market] Requested to SteamPulse.Classes.SteamAPI, Region: {1} , IRT: {2} Price: Key: {4} {3}, Ticket: {5} {3}, Description: {6}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Settings.Currency.ISO, Settings.CheckIRT, Settings.Currency.Unit, key, ticket, Message) + Environment.NewLine);
                    }
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogUpdate(string UpdateType, Version Version, string Beta = "")
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] {1} {2} {3} Available", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), UpdateType, Version, Beta) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogSteamLogin(string status, string ID)
        {
            if (CheckExist() == true)
            {
                if (status == "Logined")
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - [Setting] Logined to Steam(ID: {1})", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), ID) + Environment.NewLine);
                    }
                }
                else
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - [Setting] Logouted from Steam", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogVersionChange()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] SteamPulse Upgraded to Version: {1}", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), Application.ProductVersion) + Environment.NewLine);
                }
            }
        }
        public static void LogMaintenancee()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [System] SteamPulse Opened in Maintenance Mode", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
        }

        public static void LogDeveloper(bool status)
        {
            if (CheckExist() == true)
            {
                if (status == true)
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - Developer Mode Enabled.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
                else
                {
                    using (StreamWriter Logger = File.AppendText(LogPath))
                    {
                        Logger.Write(string.Format("{0} - Developer Mode Disabled.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                    }
                }
            }
        }
        public static void LogSetting(string SettingName, string status)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Setting] Settings Updated('{1}' Changed to '{2}')", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), SettingName, status) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogDevSetting(string SettingName, string status)
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Developer Settings] Settings Updated('{1}' Changed to '{2}')", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss"), SettingName, status) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
        public static void LogSettingsReset()
        {
            if (CheckExist() == true)
            {
                using (StreamWriter Logger = File.AppendText(LogPath))
                {
                    Logger.Write(string.Format("{0} - [Setting] Settings Reseted.", DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss")) + Environment.NewLine);
                }
            }
            else
            {
                Create();
            }
        }
    }
}
