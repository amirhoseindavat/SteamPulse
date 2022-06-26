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
using System;
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
        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UpgradeRequired == true)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save(); 
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
    }
}
