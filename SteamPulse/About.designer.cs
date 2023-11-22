namespace SteamPulse
{
    partial class About
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.PanelUpdate = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.LabelUpdateStatus = new System.Windows.Forms.Label();
            this.LabelDownload = new System.Windows.Forms.Label();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelAppName = new System.Windows.Forms.Label();
            this.Button_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelUpdate.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.LabelCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LabelCopyright, "LabelCopyright");
            this.LabelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Click += new System.EventHandler(this.Label_copyright_Click);
            // 
            // PanelUpdate
            // 
            this.PanelUpdate.BackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.PanelUpdate, "PanelUpdate");
            this.PanelUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.PanelUpdate.BorderRadius = 20;
            this.PanelUpdate.BorderThickness = 1;
            this.PanelUpdate.Controls.Add(this.LabelVersion);
            this.PanelUpdate.Controls.Add(this.LabelUpdate);
            this.PanelUpdate.Controls.Add(this.LabelUpdateStatus);
            this.PanelUpdate.Controls.Add(this.LabelDownload);
            this.PanelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.PanelUpdate.Name = "PanelUpdate";
            this.PanelUpdate.ShowBorders = true;
            // 
            // LabelVersion
            // 
            resources.ApplyResources(this.LabelVersion, "LabelVersion");
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelVersion.Name = "LabelVersion";
            // 
            // LabelUpdate
            // 
            resources.ApplyResources(this.LabelUpdate, "LabelUpdate");
            this.LabelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.LabelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelUpdate.Name = "LabelUpdate";
            this.LabelUpdate.Click += new System.EventHandler(this.Label_update_Click);
            // 
            // LabelUpdateStatus
            // 
            resources.ApplyResources(this.LabelUpdateStatus, "LabelUpdateStatus");
            this.LabelUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelUpdateStatus.Name = "LabelUpdateStatus";
            this.LabelUpdateStatus.Click += new System.EventHandler(this.Label_update_status_Click);
            // 
            // LabelDownload
            // 
            resources.ApplyResources(this.LabelDownload, "LabelDownload");
            this.LabelDownload.BackColor = System.Drawing.Color.Transparent;
            this.LabelDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelDownload.Name = "LabelDownload";
            this.LabelDownload.Click += new System.EventHandler(this.Label_Download_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.PanelHeader, "PanelHeader");
            this.PanelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderRadius = 3;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.LabelAppName);
            this.PanelHeader.Controls.Add(this.Button_Exit);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            // 
            // LabelAppName
            // 
            resources.ApplyResources(this.LabelAppName, "LabelAppName");
            this.LabelAppName.BackColor = System.Drawing.Color.White;
            this.LabelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelAppName.Name = "LabelAppName";
            // 
            // Button_Exit
            // 
            this.Button_Exit.AllowAnimations = true;
            this.Button_Exit.AllowMouseEffects = true;
            this.Button_Exit.AllowToggling = false;
            this.Button_Exit.AnimationSpeed = 200;
            this.Button_Exit.AutoGenerateColors = false;
            this.Button_Exit.AutoRoundBorders = false;
            this.Button_Exit.AutoSizeLeftIcon = true;
            this.Button_Exit.AutoSizeRightIcon = true;
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            resources.ApplyResources(this.Button_Exit, "Button_Exit");
            this.Button_Exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Exit.ButtonText = "";
            this.Button_Exit.ButtonTextMarginLeft = 0;
            this.Button_Exit.ColorContrastOnClick = 45;
            this.Button_Exit.ColorContrastOnHover = 45;
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Button_Exit.CustomizableEdges = borderEdges1;
            this.Button_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Exit.IconMarginLeft = 11;
            this.Button_Exit.IconPadding = 10;
            this.Button_Exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Exit.IconSize = 25;
            this.Button_Exit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Button_Exit.IdleBorderRadius = 15;
            this.Button_Exit.IdleBorderThickness = 1;
            this.Button_Exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Button_Exit.IdleIconLeftImage = null;
            this.Button_Exit.IdleIconRightImage = null;
            this.Button_Exit.IndicateFocus = false;
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Button_Exit.OnDisabledState.BorderRadius = 15;
            this.Button_Exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Exit.OnDisabledState.BorderThickness = 1;
            this.Button_Exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Button_Exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Button_Exit.OnDisabledState.IconLeftImage = null;
            this.Button_Exit.OnDisabledState.IconRightImage = null;
            this.Button_Exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Button_Exit.onHoverState.BorderRadius = 15;
            this.Button_Exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Exit.onHoverState.BorderThickness = 1;
            this.Button_Exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Button_Exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.onHoverState.IconLeftImage = null;
            this.Button_Exit.onHoverState.IconRightImage = null;
            this.Button_Exit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Button_Exit.OnIdleState.BorderRadius = 15;
            this.Button_Exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Exit.OnIdleState.BorderThickness = 1;
            this.Button_Exit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Button_Exit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.OnIdleState.IconLeftImage = null;
            this.Button_Exit.OnIdleState.IconRightImage = null;
            this.Button_Exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Button_Exit.OnPressedState.BorderRadius = 15;
            this.Button_Exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Exit.OnPressedState.BorderThickness = 1;
            this.Button_Exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Button_Exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.OnPressedState.IconLeftImage = null;
            this.Button_Exit.OnPressedState.IconRightImage = null;
            this.Button_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Exit.TextMarginLeft = 0;
            this.Button_Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Button_Exit.UseDefaultRadiusAndThickness = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.PanelUpdate);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.About_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.About_MouseDown);
            this.PanelUpdate.ResumeLayout(false);
            this.PanelUpdate.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelUpdate;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelDownload;
        private System.Windows.Forms.Label LabelCopyright;
        public System.Windows.Forms.Label LabelUpdateStatus;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Exit;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label LabelAppName;
        private Bunifu.UI.WinForms.BunifuPanel PanelUpdate;
    }
}