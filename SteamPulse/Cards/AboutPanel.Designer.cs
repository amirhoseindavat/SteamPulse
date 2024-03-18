namespace SteamPulse.Cards
{
    partial class AboutPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPanel));
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelDownload = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelUpdateStatus = new System.Windows.Forms.Label();
            this.LabelGithub = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelDonate = new System.Windows.Forms.Label();
            this.LabelTelegram = new System.Windows.Forms.Label();
            this.LabelSteamPulseWeb = new System.Windows.Forms.Label();
            this.PictureBoxSteamPulseWeb = new System.Windows.Forms.PictureBox();
            this.PictureBoxTelegram = new System.Windows.Forms.PictureBox();
            this.PictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.PictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.PictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.PictureBoxGithub = new System.Windows.Forms.PictureBox();
            this.Separator = new Bunifu.UI.WinForms.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSteamPulseWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(16, 362);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(122, 21);
            this.LabelVersion.TabIndex = 36;
            this.LabelVersion.Text = "Current Version";
            this.LabelVersion.Click += new System.EventHandler(this.LabelVersion_Click);
            // 
            // LabelDownload
            // 
            this.LabelDownload.AutoSize = true;
            this.LabelDownload.BackColor = System.Drawing.Color.Transparent;
            this.LabelDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDownload.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownload.Location = new System.Drawing.Point(16, 408);
            this.LabelDownload.Name = "LabelDownload";
            this.LabelDownload.Size = new System.Drawing.Size(194, 21);
            this.LabelDownload.TabIndex = 38;
            this.LabelDownload.Text = "Click To Download Update";
            this.LabelDownload.Visible = false;
            this.LabelDownload.Click += new System.EventHandler(this.LabelDownload_Click);
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.LabelCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelCopyright.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCopyright.Location = new System.Drawing.Point(0, 445);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(644, 23);
            this.LabelCopyright.TabIndex = 34;
            this.LabelCopyright.Text = "Devoloped By © CodeMage.ir";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelCopyright.Click += new System.EventHandler(this.LabelCopyright_Click);
            // 
            // LabelAbout
            // 
            this.LabelAbout.BackColor = System.Drawing.Color.Transparent;
            this.LabelAbout.Font = new System.Drawing.Font("Motiva Sans", 13F);
            this.LabelAbout.Location = new System.Drawing.Point(17, 22);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(603, 192);
            this.LabelAbout.TabIndex = 33;
            this.LabelAbout.Text = resources.GetString("LabelAbout.Text");
            this.LabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAbout.Click += new System.EventHandler(this.LabelAbout_Click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeader.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelHeader.Location = new System.Drawing.Point(0, 0);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.LabelHeader.Size = new System.Drawing.Size(644, 26);
            this.LabelHeader.TabIndex = 32;
            this.LabelHeader.Text = "About";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelHeader.Click += new System.EventHandler(this.LabelHeader_Click);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelUpdateStatus
            // 
            this.LabelUpdateStatus.AutoSize = true;
            this.LabelUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelUpdateStatus.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelUpdateStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelUpdateStatus.Location = new System.Drawing.Point(41, 387);
            this.LabelUpdateStatus.Name = "LabelUpdateStatus";
            this.LabelUpdateStatus.Size = new System.Drawing.Size(169, 21);
            this.LabelUpdateStatus.TabIndex = 39;
            this.LabelUpdateStatus.Text = "Connecting to server...";
            this.LabelUpdateStatus.Click += new System.EventHandler(this.LabelUpdateStatus_Click_1);
            // 
            // LabelGithub
            // 
            this.LabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelGithub.AutoSize = true;
            this.LabelGithub.BackColor = System.Drawing.Color.Transparent;
            this.LabelGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelGithub.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.LabelGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelGithub.Location = new System.Drawing.Point(51, 314);
            this.LabelGithub.Margin = new System.Windows.Forms.Padding(0);
            this.LabelGithub.Name = "LabelGithub";
            this.LabelGithub.Size = new System.Drawing.Size(70, 26);
            this.LabelGithub.TabIndex = 78;
            this.LabelGithub.Text = "Github";
            this.LabelGithub.Click += new System.EventHandler(this.Github_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEmail.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.LabelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelEmail.Location = new System.Drawing.Point(51, 222);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(273, 26);
            this.LabelEmail.TabIndex = 81;
            this.LabelEmail.Text = "Contact us: Info@CodeMage.ir";
            this.LabelEmail.Click += new System.EventHandler(this.Email_Click);
            // 
            // LabelDonate
            // 
            this.LabelDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDonate.AutoSize = true;
            this.LabelDonate.BackColor = System.Drawing.Color.Transparent;
            this.LabelDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDonate.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.LabelDonate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelDonate.Location = new System.Drawing.Point(271, 314);
            this.LabelDonate.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDonate.Name = "LabelDonate";
            this.LabelDonate.Size = new System.Drawing.Size(74, 26);
            this.LabelDonate.TabIndex = 83;
            this.LabelDonate.Text = "Donate";
            this.LabelDonate.Click += new System.EventHandler(this.Donate_Click);
            // 
            // LabelTelegram
            // 
            this.LabelTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTelegram.AutoSize = true;
            this.LabelTelegram.BackColor = System.Drawing.Color.Transparent;
            this.LabelTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTelegram.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.LabelTelegram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelTelegram.Location = new System.Drawing.Point(51, 266);
            this.LabelTelegram.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTelegram.Name = "LabelTelegram";
            this.LabelTelegram.Size = new System.Drawing.Size(217, 26);
            this.LabelTelegram.TabIndex = 85;
            this.LabelTelegram.Text = "Telegram: @Steampulse";
            this.LabelTelegram.Click += new System.EventHandler(this.Telegram_Click);
            // 
            // LabelSteamPulseWeb
            // 
            this.LabelSteamPulseWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSteamPulseWeb.AutoSize = true;
            this.LabelSteamPulseWeb.BackColor = System.Drawing.Color.Transparent;
            this.LabelSteamPulseWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSteamPulseWeb.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.LabelSteamPulseWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelSteamPulseWeb.Location = new System.Drawing.Point(465, 314);
            this.LabelSteamPulseWeb.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSteamPulseWeb.Name = "LabelSteamPulseWeb";
            this.LabelSteamPulseWeb.Size = new System.Drawing.Size(155, 26);
            this.LabelSteamPulseWeb.TabIndex = 87;
            this.LabelSteamPulseWeb.Text = "SteamPulse Web";
            this.LabelSteamPulseWeb.Click += new System.EventHandler(this.SteamPulseWeb_Click);
            // 
            // PictureBoxSteamPulseWeb
            // 
            this.PictureBoxSteamPulseWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxSteamPulseWeb.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxSteamPulseWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSteamPulseWeb.Image = global::SteamPulse.Properties.Resources.Steam_Pulse_Logo;
            this.PictureBoxSteamPulseWeb.Location = new System.Drawing.Point(437, 314);
            this.PictureBoxSteamPulseWeb.Name = "PictureBoxSteamPulseWeb";
            this.PictureBoxSteamPulseWeb.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxSteamPulseWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSteamPulseWeb.TabIndex = 88;
            this.PictureBoxSteamPulseWeb.TabStop = false;
            this.PictureBoxSteamPulseWeb.Click += new System.EventHandler(this.SteamPulseWeb_Click);
            // 
            // PictureBoxTelegram
            // 
            this.PictureBoxTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxTelegram.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTelegram.Image = global::SteamPulse.Properties.Resources.telegram;
            this.PictureBoxTelegram.Location = new System.Drawing.Point(23, 266);
            this.PictureBoxTelegram.Name = "PictureBoxTelegram";
            this.PictureBoxTelegram.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxTelegram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTelegram.TabIndex = 86;
            this.PictureBoxTelegram.TabStop = false;
            this.PictureBoxTelegram.Click += new System.EventHandler(this.Telegram_Click);
            // 
            // PictureBoxDonate
            // 
            this.PictureBoxDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxDonate.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxDonate.Image = global::SteamPulse.Properties.Resources.donate;
            this.PictureBoxDonate.Location = new System.Drawing.Point(243, 314);
            this.PictureBoxDonate.Name = "PictureBoxDonate";
            this.PictureBoxDonate.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxDonate.TabIndex = 84;
            this.PictureBoxDonate.TabStop = false;
            this.PictureBoxDonate.Click += new System.EventHandler(this.Donate_Click);
            // 
            // PictureBoxEmail
            // 
            this.PictureBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxEmail.Image = global::SteamPulse.Properties.Resources.envelope;
            this.PictureBoxEmail.Location = new System.Drawing.Point(23, 222);
            this.PictureBoxEmail.Name = "PictureBoxEmail";
            this.PictureBoxEmail.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEmail.TabIndex = 82;
            this.PictureBoxEmail.TabStop = false;
            this.PictureBoxEmail.Click += new System.EventHandler(this.Email_Click);
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLoading.Image")));
            this.PictureBoxLoading.Location = new System.Drawing.Point(20, 390);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLoading.TabIndex = 80;
            this.PictureBoxLoading.TabStop = false;
            this.PictureBoxLoading.Click += new System.EventHandler(this.PictureBoxLoading_Click);
            // 
            // PictureBoxGithub
            // 
            this.PictureBoxGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxGithub.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxGithub.Image = global::SteamPulse.Properties.Resources.github;
            this.PictureBoxGithub.Location = new System.Drawing.Point(23, 314);
            this.PictureBoxGithub.Name = "PictureBoxGithub";
            this.PictureBoxGithub.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxGithub.TabIndex = 79;
            this.PictureBoxGithub.TabStop = false;
            this.PictureBoxGithub.Click += new System.EventHandler(this.Github_Click);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Separator.BackgroundImage")));
            this.Separator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.Separator.LineColor = System.Drawing.Color.Silver;
            this.Separator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(20, 341);
            this.Separator.Name = "Separator";
            this.Separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator.Size = new System.Drawing.Size(600, 14);
            this.Separator.TabIndex = 35;
            this.Separator.Click += new System.EventHandler(this.Separator_Click);
            // 
            // AboutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureBoxSteamPulseWeb);
            this.Controls.Add(this.LabelSteamPulseWeb);
            this.Controls.Add(this.PictureBoxTelegram);
            this.Controls.Add(this.LabelTelegram);
            this.Controls.Add(this.PictureBoxDonate);
            this.Controls.Add(this.LabelDonate);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.PictureBoxEmail);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.PictureBoxLoading);
            this.Controls.Add(this.PictureBoxGithub);
            this.Controls.Add(this.LabelGithub);
            this.Controls.Add(this.LabelUpdateStatus);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelDownload);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelAbout);
            this.Name = "AboutPanel";
            this.Size = new System.Drawing.Size(644, 468);
            this.Load += new System.EventHandler(this.AboutPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSteamPulseWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelDownload;
        private Bunifu.UI.WinForms.BunifuSeparator Separator;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.Label LabelHeader;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelUpdateStatus;
        private System.Windows.Forms.PictureBox PictureBoxGithub;
        private System.Windows.Forms.Label LabelGithub;
        private System.Windows.Forms.PictureBox PictureBoxLoading;
        private System.Windows.Forms.PictureBox PictureBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.PictureBox PictureBoxDonate;
        private System.Windows.Forms.Label LabelDonate;
        private System.Windows.Forms.PictureBox PictureBoxSteamPulseWeb;
        private System.Windows.Forms.Label LabelSteamPulseWeb;
        private System.Windows.Forms.PictureBox PictureBoxTelegram;
        private System.Windows.Forms.Label LabelTelegram;
    }
}
