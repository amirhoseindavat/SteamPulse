﻿#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.3.0 Revision 3
// last Edit: 10/29/22 V2.0
#endregion


using Microsoft.Win32;
using SteamPulse.Logger;
using SteamPulse.SettingsInterface;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse
{
    public partial class Launcher : Form
    {
        private readonly string AppHash = Hasher("SteamPulse");

        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        //readonly RegistryKey RegistryCheck = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Classes\\steampulse");
        public Launcher()
        {
            InitializeComponent();
        }

        public static bool FormIsOpen(string FormName)
        {
            bool Status = false;
            FormCollection Forms = Application.OpenForms;
            foreach (Form Form in Forms)
            {
                if (Form.Name == FormName)
                {
                    Status = true;
                }
            }
            return Status;
        }

        [STAThread]
        private void Launcher_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => SteamAPI.GetData.ConnectToSteam.Market.TF2Key());
            Task.Factory.StartNew(() => SteamAPI.GetData.ConnectToSteam.Market.TF2Ticket());

            if (UserSettings.CheckIRT)
            {
                Task.Factory.StartNew(() => SteamAPI.GetData.IRT.KeyAndTicket());
            }
            else { }

            if (UserSettings.SystemDarkMode)
            {
                UserSettings.DarkMode = ShouldSystemUseDarkMode();
            }

            RegistryScheme();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                string argument = args[1];
                argument = argument.Replace("steampulse://", "");
                if (argument.Contains("market"))
                {
                    /* Form market = new LiveMarketPrice();
                     market.ShowDialog(this);
                     Close();*/
                }
                if (argument.Contains("settings"))
                {
                    /*Form setting = new Setting();
                    setting.ShowDialog(this);
                    Close();*/
                }
                if (argument.Contains("regionalmarket"))
                {
                    /*Form setting = new Setting();
                    setting.ShowDialog(this);
                    Close();*/
                }
                /*if (argument.Contains("resetsettings"))
                {
                    DialogResult result = MessageBox.Show("Are you Sure ?\nThis will Reset all settings and restart app.", "Reset Settings.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Properties.Settings.Default.Reset();
                        Logger.LogSettingsReset();
                        var dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CodeMage\");
                        dir.Attributes &= ~FileAttributes.ReadOnly;
                        dir.Delete(true);
                        this.Close();
                    }
                }*/
                if (argument.Contains("clearlog"))
                {
                    DialogResult result = MessageBox.Show("Are you Sure ?\nThis will Clear Log File", "Clear Log.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Log.Delete();
                        MessageBox.Show("The log file deleted successfully", "Log Cleared.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (argument.Contains("calculator"))
                {
                    /*Form calc = new Calculator();
                    calc.ShowDialog(this);
                    Close();*/
                }
                if (argument.Contains("giveaway"))
                {
                    Form giveaway = new Giveaway();
                    giveaway.ShowDialog(this);
                    Close();
                }
                if (argument.Contains("nogiveawaylimit"))
                {
                    Form main = new Main();
                    Cards.Giveaway.noGiveAwayLimit = true;
                    main.ShowDialog();
                    Close();
                }
                if (argument.Contains("open"))
                {
                    Form main = new Main();
                    Main.SearchID = argument.Replace("open/", "");
                    if (Main.SearchID != "")
                    {
                        main.ShowDialog(this);
                    }
                    else { }
                    Close();
                }
            }
            else
            {

                if (Properties.Settings.Default.UpgradeRequired == true)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.UpgradeRequired = false;
                    Properties.Settings.Default.Save();
                    Log.LogVersionChange();
                }

                if (UserSettings.SystemDarkMode)
                {
                    UserSettings.DarkMode = ShouldSystemUseDarkMode();
                }

                Log.CheckExist();
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    XmlDocument data2 = new XmlDocument();
                    data2.Load("https://api.codemage.ir/Projects/SteamPulse/Data.xml");
                    XmlElement root2 = data2.DocumentElement;
                    XmlNodeList nodes2 = root2.SelectNodes("/Data/Application");
                    foreach (XmlNode node in nodes2)
                    {
                        string app_id_xml2 = node["AppID"].InnerText;
                        bool maintenance = Convert.ToBoolean(node["Maintenance"].InnerText);
                        if (AppHash == app_id_xml2)
                        {
                            if (maintenance == true)
                            {
                                Form maintenancee = new Maintenance();
                                maintenancee.ShowDialog();
                                Close();
                            }
                            else
                            {
                                InstanceChecker();
                            }
                        }
                    }
                }
                catch
                {
                    InstanceChecker();
                }
            }
        }

        private static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void InstanceChecker()
        {
            string mutex_id = "SteamPulse";
            using (Mutex mutex = new Mutex(false, mutex_id))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Instance Already Running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {

                    Form main = new Main();
                    main.ShowDialog(this);
                    Close();


                }

            }
        }
        private void RegistryScheme()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\steampulse"))
            {
                string applicationLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;

                key.SetValue("", "URL:SteamPulse Browser Protocol");
                key.SetValue("URL Protocol", "");

                using (RegistryKey defaultIcon = key.CreateSubKey("DefaultIcon"))
                {
                    defaultIcon.SetValue("", applicationLocation + ",1");
                }

                using (RegistryKey commandKey = key.CreateSubKey(@"shell\open\command"))
                {
                    commandKey.SetValue("", "\"" + applicationLocation + "\" \"%1\"");
                }
            }
        }
    }
}
