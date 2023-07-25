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
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.LabelDownload = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.Label_About = new System.Windows.Forms.Label();
            this.Label_About_Header = new System.Windows.Forms.Label();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelUpdateStatus = new System.Windows.Forms.Label();
            this.Separator = new Bunifu.UI.WinForms.BunifuSeparator();
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
            // 
            // LabelUpdate
            // 
            this.LabelUpdate.AutoSize = true;
            this.LabelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.LabelUpdate.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelUpdate.Location = new System.Drawing.Point(16, 385);
            this.LabelUpdate.Name = "LabelUpdate";
            this.LabelUpdate.Size = new System.Drawing.Size(74, 21);
            this.LabelUpdate.TabIndex = 37;
            this.LabelUpdate.Text = "Update : ";
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
            this.LabelCopyright.Size = new System.Drawing.Size(568, 23);
            this.LabelCopyright.TabIndex = 34;
            this.LabelCopyright.Text = "Devoloped By CodeMage";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelCopyright.Click += new System.EventHandler(this.LabelCopyright_Click);
            // 
            // Label_About
            // 
            this.Label_About.BackColor = System.Drawing.Color.Transparent;
            this.Label_About.Font = new System.Drawing.Font("Motiva Sans", 13F);
            this.Label_About.Location = new System.Drawing.Point(28, 30);
            this.Label_About.Name = "Label_About";
            this.Label_About.Size = new System.Drawing.Size(522, 250);
            this.Label_About.TabIndex = 33;
            this.Label_About.Text = resources.GetString("Label_About.Text");
            this.Label_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_About_Header
            // 
            this.Label_About_Header.BackColor = System.Drawing.Color.Transparent;
            this.Label_About_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_About_Header.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold);
            this.Label_About_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_About_Header.Location = new System.Drawing.Point(0, 0);
            this.Label_About_Header.Margin = new System.Windows.Forms.Padding(0);
            this.Label_About_Header.Name = "Label_About_Header";
            this.Label_About_Header.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.Label_About_Header.Size = new System.Drawing.Size(568, 26);
            this.Label_About_Header.TabIndex = 32;
            this.Label_About_Header.Text = "About";
            this.Label_About_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_About_Header.Click += new System.EventHandler(this.Label_About_Header_Click);
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
            this.LabelUpdateStatus.Location = new System.Drawing.Point(80, 385);
            this.LabelUpdateStatus.Name = "LabelUpdateStatus";
            this.LabelUpdateStatus.Size = new System.Drawing.Size(0, 21);
            this.LabelUpdateStatus.TabIndex = 39;
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
            this.Separator.Size = new System.Drawing.Size(530, 14);
            this.Separator.TabIndex = 35;
            // 
            // AboutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelUpdateStatus);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelUpdate);
            this.Controls.Add(this.LabelDownload);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.Label_About);
            this.Controls.Add(this.Label_About_Header);
            this.Name = "AboutPanel";
            this.Size = new System.Drawing.Size(568, 468);
            this.Load += new System.EventHandler(this.AboutPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelUpdate;
        private System.Windows.Forms.Label LabelDownload;
        private Bunifu.UI.WinForms.BunifuSeparator Separator;
        private System.Windows.Forms.Label LabelCopyright;
        private System.Windows.Forms.Label Label_About;
        private System.Windows.Forms.Label Label_About_Header;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelUpdateStatus;
    }
}
