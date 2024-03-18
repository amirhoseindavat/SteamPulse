using SteamPulse.SettingsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPulse.Cards
{
    public partial class Giveaway : UserControl
    {
        public static bool noGiveAwayLimit = false , giveawayisactive = false;
        public static long GiveawayBegin, GiveawayEnd;
        public static string GiveawayTitle;
        private DateTime GiveawayBeginTime;
        public static string GiveawayPic,GiveawayPicLight;
        public Giveaway()
        {
            InitializeComponent();
        }

        private void Giveaway_Load(object sender, EventArgs e)
        {
            LabelGiveaway.Text = GiveawayTitle;
            if (UserSettings.DarkMode)
            {
                ChangeTheme(true);
            }
            else
            {
                ChangeTheme(default);
            }

            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(GiveawayBegin);
            GiveawayBeginTime = dateTimeOffset.DateTime;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (noGiveAwayLimit == true)
            {
                Label_Remaining.Text = "GiveAway Started! 🎉";
                ButtonGiveaway.Enabled = true;
                ButtonGiveaway.Cursor = Cursors.Hand;
                Timer.Enabled = false;
            }
            else
            {
                if (DateTimeOffset.Now.ToUnixTimeSeconds() > GiveawayBegin)
                {
                    Label_Remaining.Text = "GiveAway Started! 🎉";
                    ButtonGiveaway.Enabled = true;
                    ButtonGiveaway.Cursor = Cursors.Hand;
                    Timer.Enabled = false;
                }
                else
                {
                    TimeSpan span = GiveawayBeginTime.ToLocalTime().Subtract(DateTime.Now);

                    Label_Remaining.Text = string.Format("GiveAway Begin in: {0}d {1}h {2}m {3}s", span.Days, span.Hours, span.Minutes, span.Seconds);
                    if (DateTimeOffset.Now.ToUnixTimeSeconds() > GiveawayBegin)
                    {
                        Label_Remaining.Text = "GiveAway Started! 🎉";
                        ButtonGiveaway.Enabled = true;
                        ButtonGiveaway.Cursor = Cursors.Hand;
                        Timer.Enabled = false;
                    }
                }
            }
        }

        private void ButtonGiveaway_Click(object sender, EventArgs e)
        {
            if (DateTimeOffset.Now.ToUnixTimeSeconds() > GiveawayBegin || noGiveAwayLimit == true)
            {
                Form Giveaway = new SteamPulse.Giveaway();
                Giveaway.ShowDialog(this);
            }
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
                PictureBoxLeft.Load(GiveawayPicLight);
                PictureBoxRight.Load(GiveawayPicLight);

            }
            else
            {
                BackGround = GlobalVariables.Colors.Light.AthenGray;
                ForeGround = GlobalVariables.Colors.Light.NileBlue;
                BackGround2 = GlobalVariables.Colors.Light.White;
                PictureBoxLeft.Load(GiveawayPic);
                PictureBoxRight.Load(GiveawayPic);

            }
            BackColor = BackGround2;
            LabelGiveaway.ForeColor = ForeGround;
            Label_Remaining.ForeColor = ForeGround;

        }
    }
}
