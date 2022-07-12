#region Copyright (c) Amirhosein Davatgari. All rights reserved.
//
// Project SteamPulse
//
// https://Amirhoseindavat.ir
//
// Release Build
//
// Version 1.3.0 Revision 1

#endregion


using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace SteamPulse
{
    public partial class Launcher : Form
    {
        private readonly string AppHash = Hasher("SteamPulse");

        //readonly RegistryKey RegistryCheck = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Classes\\steampulse");
        public Launcher()
        {
            InitializeComponent();
        }

        public static bool FormIsOpen(string FormName)
        {
            Boolean Status = false;
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

            //This Section is disabled and need some work.

            RegistryScheme();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                string argument = args[1];
                argument = argument.Replace("steampulse://", "");
                if (argument.Contains("market"))
                {
                    Form market = new LiveMarketPrice();
                    market.ShowDialog();
                    this.Close();
                }
                if (argument.Contains("settings"))
                {
                    Form setting = new Setting();
                    setting.ShowDialog();
                    this.Close();
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
                        Logger.Delete();
                        MessageBox.Show("The log file deleted successfully", "Log Cleared.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (argument.Contains("calculator"))
                {
                    Form calc = new Calculator();
                    calc.ShowDialog();
                    this.Close();
                }
                if (argument.Contains("open"))
                {
                    Form main = new Main();
                    Main.SearchID = argument.Replace("open/", "");
                    if (Main.SearchID != "")
                    {
                        main.ShowDialog();
                    }
                    else { }
                    this.Close();

                }
            }
            else
            {

                if (Properties.Settings.Default.UpgradeRequired == true)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.UpgradeRequired = false;
                    Properties.Settings.Default.Save();
                    Logger.LogVersionChange();
                }
                Logger.CheckExist();
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
                                this.Close();
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
        static string Hasher(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

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
                    if (!string.IsNullOrEmpty(Properties.Settings.Default["CurrencyName"].ToString()))
                    {
                        if (Properties.Settings.Default.StartingPage == "Main")
                        {
                            Form main = new Main();
                            main.ShowDialog();
                            this.Close();
                        }
                        if (Properties.Settings.Default.StartingPage == "Market")
                        {
                            Form market = new LiveMarketPrice();
                            market.ShowDialog();
                            this.Close();
                        }
                        if (Properties.Settings.Default.StartingPage == "Calculator")
                        {
                            Form calculator = new Calculator();
                            calculator.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form setting = new Setting();
                        setting.ShowDialog();
                        this.Close();
                    }
                }

            }
        }
        private void RegistryScheme()
        {
            using (var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\steampulse"))
            {
                string applicationLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;

                key.SetValue("", "URL:SteamPulse Browser Protocol");
                key.SetValue("URL Protocol", "");

                using (var defaultIcon = key.CreateSubKey("DefaultIcon"))
                {
                    defaultIcon.SetValue("", applicationLocation + ",1");
                }

                using (var commandKey = key.CreateSubKey(@"shell\open\command"))
                {
                    commandKey.SetValue("", "\"" + applicationLocation + "\" \"%1\"");
                }
            }
        }
    }
}
