namespace SteamPulse.Cards
{
    partial class SideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_DashBoard = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_DashBoard = new System.Windows.Forms.Label();
            this.Panel_SearchAndCalculator = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_SearchAndCalculator = new System.Windows.Forms.Label();
            this.Panel_Market = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_Market = new System.Windows.Forms.Label();
            this.Label_Settings = new System.Windows.Forms.Label();
            this.Panel_Settings = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_Bug = new System.Windows.Forms.Label();
            this.Panel_Bug = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_About = new System.Windows.Forms.Label();
            this.Panel_About = new Bunifu.UI.WinForms.BunifuPanel();
            this.UpdateNotification = new Bunifu.UI.WinForms.BunifuLabel();
            this.Panel_DashBoard.SuspendLayout();
            this.Panel_SearchAndCalculator.SuspendLayout();
            this.Panel_Market.SuspendLayout();
            this.Panel_Settings.SuspendLayout();
            this.Panel_Bug.SuspendLayout();
            this.Panel_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Panel_DashBoard
            // 
            this.Panel_DashBoard.BackgroundColor = System.Drawing.Color.White;
            this.Panel_DashBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_DashBoard.BackgroundImage")));
            this.Panel_DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_DashBoard.BorderColor = System.Drawing.Color.White;
            this.Panel_DashBoard.BorderRadius = 20;
            this.Panel_DashBoard.BorderThickness = 1;
            this.Panel_DashBoard.Controls.Add(this.Label_DashBoard);
            this.Panel_DashBoard.Location = new System.Drawing.Point(0, 0);
            this.Panel_DashBoard.Name = "Panel_DashBoard";
            this.Panel_DashBoard.ShowBorders = true;
            this.Panel_DashBoard.Size = new System.Drawing.Size(241, 66);
            this.Panel_DashBoard.TabIndex = 0;
            // 
            // Label_DashBoard
            // 
            this.Label_DashBoard.BackColor = System.Drawing.Color.Transparent;
            this.Label_DashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_DashBoard.Font = new System.Drawing.Font("Motiva Sans", 14F, System.Drawing.FontStyle.Bold);
            this.Label_DashBoard.Location = new System.Drawing.Point(0, 0);
            this.Label_DashBoard.Name = "Label_DashBoard";
            this.Label_DashBoard.Size = new System.Drawing.Size(241, 66);
            this.Label_DashBoard.TabIndex = 0;
            this.Label_DashBoard.Text = "Dashboard";
            this.Label_DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_DashBoard.Click += new System.EventHandler(this.Label_Search_Click);
            // 
            // Panel_SearchAndCalculator
            // 
            this.Panel_SearchAndCalculator.BackgroundColor = System.Drawing.Color.White;
            this.Panel_SearchAndCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_SearchAndCalculator.BackgroundImage")));
            this.Panel_SearchAndCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_SearchAndCalculator.BorderColor = System.Drawing.Color.White;
            this.Panel_SearchAndCalculator.BorderRadius = 20;
            this.Panel_SearchAndCalculator.BorderThickness = 1;
            this.Panel_SearchAndCalculator.Controls.Add(this.Label_SearchAndCalculator);
            this.Panel_SearchAndCalculator.Location = new System.Drawing.Point(0, 80);
            this.Panel_SearchAndCalculator.Name = "Panel_SearchAndCalculator";
            this.Panel_SearchAndCalculator.ShowBorders = true;
            this.Panel_SearchAndCalculator.Size = new System.Drawing.Size(241, 66);
            this.Panel_SearchAndCalculator.TabIndex = 1;
            // 
            // Label_SearchAndCalculator
            // 
            this.Label_SearchAndCalculator.BackColor = System.Drawing.Color.Transparent;
            this.Label_SearchAndCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_SearchAndCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_SearchAndCalculator.Font = new System.Drawing.Font("Motiva Sans", 14F, System.Drawing.FontStyle.Bold);
            this.Label_SearchAndCalculator.Location = new System.Drawing.Point(0, 0);
            this.Label_SearchAndCalculator.Name = "Label_SearchAndCalculator";
            this.Label_SearchAndCalculator.Size = new System.Drawing.Size(241, 66);
            this.Label_SearchAndCalculator.TabIndex = 1;
            this.Label_SearchAndCalculator.Text = "Search and Calculator";
            this.Label_SearchAndCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_SearchAndCalculator.Click += new System.EventHandler(this.Label_Calculator_Click);
            // 
            // Panel_Market
            // 
            this.Panel_Market.BackgroundColor = System.Drawing.Color.White;
            this.Panel_Market.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Market.BackgroundImage")));
            this.Panel_Market.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Market.BorderColor = System.Drawing.Color.White;
            this.Panel_Market.BorderRadius = 20;
            this.Panel_Market.BorderThickness = 1;
            this.Panel_Market.Controls.Add(this.Label_Market);
            this.Panel_Market.Location = new System.Drawing.Point(0, 160);
            this.Panel_Market.Name = "Panel_Market";
            this.Panel_Market.ShowBorders = true;
            this.Panel_Market.Size = new System.Drawing.Size(241, 66);
            this.Panel_Market.TabIndex = 2;
            // 
            // Label_Market
            // 
            this.Label_Market.BackColor = System.Drawing.Color.Transparent;
            this.Label_Market.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Market.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Market.Font = new System.Drawing.Font("Motiva Sans", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Market.Location = new System.Drawing.Point(0, 0);
            this.Label_Market.Name = "Label_Market";
            this.Label_Market.Size = new System.Drawing.Size(241, 66);
            this.Label_Market.TabIndex = 1;
            this.Label_Market.Text = "Market";
            this.Label_Market.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Market.Click += new System.EventHandler(this.Label_Market_Click);
            // 
            // Label_Settings
            // 
            this.Label_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Label_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Settings.Font = new System.Drawing.Font("Motiva Sans", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Settings.Location = new System.Drawing.Point(0, 0);
            this.Label_Settings.Name = "Label_Settings";
            this.Label_Settings.Size = new System.Drawing.Size(241, 66);
            this.Label_Settings.TabIndex = 1;
            this.Label_Settings.Text = "Settings";
            this.Label_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Settings.Click += new System.EventHandler(this.Label_Settings_Click);
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.BackgroundColor = System.Drawing.Color.White;
            this.Panel_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Settings.BackgroundImage")));
            this.Panel_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Settings.BorderColor = System.Drawing.Color.White;
            this.Panel_Settings.BorderRadius = 20;
            this.Panel_Settings.BorderThickness = 1;
            this.Panel_Settings.Controls.Add(this.Label_Settings);
            this.Panel_Settings.Location = new System.Drawing.Point(0, 240);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.ShowBorders = true;
            this.Panel_Settings.Size = new System.Drawing.Size(241, 66);
            this.Panel_Settings.TabIndex = 3;
            // 
            // Label_Bug
            // 
            this.Label_Bug.BackColor = System.Drawing.Color.Transparent;
            this.Label_Bug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Bug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Bug.Font = new System.Drawing.Font("Motiva Sans", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Bug.Location = new System.Drawing.Point(0, 0);
            this.Label_Bug.Name = "Label_Bug";
            this.Label_Bug.Size = new System.Drawing.Size(241, 66);
            this.Label_Bug.TabIndex = 1;
            this.Label_Bug.Text = "Bug Report";
            this.Label_Bug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Bug.Click += new System.EventHandler(this.Label_Bug_Click);
            // 
            // Panel_Bug
            // 
            this.Panel_Bug.BackgroundColor = System.Drawing.Color.White;
            this.Panel_Bug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Bug.BackgroundImage")));
            this.Panel_Bug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Bug.BorderColor = System.Drawing.Color.White;
            this.Panel_Bug.BorderRadius = 20;
            this.Panel_Bug.BorderThickness = 1;
            this.Panel_Bug.Controls.Add(this.Label_Bug);
            this.Panel_Bug.Location = new System.Drawing.Point(0, 320);
            this.Panel_Bug.Name = "Panel_Bug";
            this.Panel_Bug.ShowBorders = true;
            this.Panel_Bug.Size = new System.Drawing.Size(241, 66);
            this.Panel_Bug.TabIndex = 3;
            // 
            // Label_About
            // 
            this.Label_About.BackColor = System.Drawing.Color.Transparent;
            this.Label_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_About.Font = new System.Drawing.Font("Motiva Sans", 14F, System.Drawing.FontStyle.Bold);
            this.Label_About.Location = new System.Drawing.Point(0, 0);
            this.Label_About.Name = "Label_About";
            this.Label_About.Size = new System.Drawing.Size(241, 66);
            this.Label_About.TabIndex = 1;
            this.Label_About.Text = "About";
            this.Label_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_About.Click += new System.EventHandler(this.Label_About_Click);
            // 
            // Panel_About
            // 
            this.Panel_About.BackgroundColor = System.Drawing.Color.White;
            this.Panel_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_About.BackgroundImage")));
            this.Panel_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_About.BorderColor = System.Drawing.Color.White;
            this.Panel_About.BorderRadius = 20;
            this.Panel_About.BorderThickness = 1;
            this.Panel_About.Controls.Add(this.UpdateNotification);
            this.Panel_About.Controls.Add(this.Label_About);
            this.Panel_About.Location = new System.Drawing.Point(0, 399);
            this.Panel_About.Name = "Panel_About";
            this.Panel_About.ShowBorders = true;
            this.Panel_About.Size = new System.Drawing.Size(241, 66);
            this.Panel_About.TabIndex = 4;
            // 
            // UpdateNotification
            // 
            this.UpdateNotification.AllowParentOverrides = false;
            this.UpdateNotification.AutoEllipsis = false;
            this.UpdateNotification.AutoSize = false;
            this.UpdateNotification.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpdateNotification.CursorType = System.Windows.Forms.Cursors.Default;
            this.UpdateNotification.Font = new System.Drawing.Font("Nirmala UI", 50F);
            this.UpdateNotification.ForeColor = System.Drawing.Color.Red;
            this.UpdateNotification.Location = new System.Drawing.Point(146, 11);
            this.UpdateNotification.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateNotification.Name = "UpdateNotification";
            this.UpdateNotification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateNotification.Size = new System.Drawing.Size(18, 42);
            this.UpdateNotification.TabIndex = 2;
            this.UpdateNotification.Text = ".";
            this.UpdateNotification.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.UpdateNotification.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.UpdateNotification.Visible = false;
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.Panel_About);
            this.Controls.Add(this.Panel_Bug);
            this.Controls.Add(this.Panel_Settings);
            this.Controls.Add(this.Panel_Market);
            this.Controls.Add(this.Panel_SearchAndCalculator);
            this.Controls.Add(this.Panel_DashBoard);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(241, 468);
            this.Load += new System.EventHandler(this.SideBar_Load);
            this.Panel_DashBoard.ResumeLayout(false);
            this.Panel_SearchAndCalculator.ResumeLayout(false);
            this.Panel_Market.ResumeLayout(false);
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Bug.ResumeLayout(false);
            this.Panel_About.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel Panel_Market;
        private Bunifu.UI.WinForms.BunifuPanel Panel_SearchAndCalculator;
        private System.Windows.Forms.Label Label_DashBoard;
        private Bunifu.UI.WinForms.BunifuPanel Panel_About;
        private System.Windows.Forms.Label Label_About;
        private Bunifu.UI.WinForms.BunifuPanel Panel_Bug;
        private System.Windows.Forms.Label Label_Bug;
        private System.Windows.Forms.Label Label_Settings;
        private System.Windows.Forms.Label Label_Market;
        private System.Windows.Forms.Label Label_SearchAndCalculator;
        public Bunifu.UI.WinForms.BunifuPanel Panel_DashBoard;
        public Bunifu.UI.WinForms.BunifuPanel Panel_Settings;
        private Bunifu.UI.WinForms.BunifuLabel UpdateNotification;
    }
}
