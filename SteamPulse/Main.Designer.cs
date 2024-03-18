namespace SteamPulse
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Elipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Activetab = new System.Windows.Forms.Panel();
            this.Panel_SideBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.PanelContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonStatus = new System.Windows.Forms.PictureBox();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.Label_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelHead = new Bunifu.UI.WinForms.BunifuPanel();
            this.Notification = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "SteamPulse";
            this.NotifyIcon.Visible = true;
            // 
            // Elipse2
            // 
            this.Elipse2.ElipseRadius = 5;
            this.Elipse2.TargetControl = this;
            // 
            // Panel_Activetab
            // 
            this.Panel_Activetab.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Activetab.Location = new System.Drawing.Point(650, 230);
            this.Panel_Activetab.Name = "Panel_Activetab";
            this.Panel_Activetab.Size = new System.Drawing.Size(50, 66);
            this.Panel_Activetab.TabIndex = 62;
            // 
            // Panel_SideBar
            // 
            this.Panel_SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel_SideBar.BackgroundColor = System.Drawing.Color.White;
            this.Panel_SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_SideBar.BackgroundImage")));
            this.Panel_SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_SideBar.BorderColor = System.Drawing.Color.Transparent;
            this.Panel_SideBar.BorderRadius = 20;
            this.Panel_SideBar.BorderThickness = 2;
            this.Panel_SideBar.Location = new System.Drawing.Point(688, 230);
            this.Panel_SideBar.Name = "Panel_SideBar";
            this.Panel_SideBar.ShowBorders = false;
            this.Panel_SideBar.Size = new System.Drawing.Size(241, 468);
            this.Panel_SideBar.TabIndex = 61;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelContainer.BackgroundColor = System.Drawing.Color.White;
            this.PanelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelContainer.BackgroundImage")));
            this.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelContainer.BorderColor = System.Drawing.Color.Transparent;
            this.PanelContainer.BorderRadius = 20;
            this.PanelContainer.BorderThickness = 0;
            this.PanelContainer.Location = new System.Drawing.Point(20, 230);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShowBorders = false;
            this.PanelContainer.Size = new System.Drawing.Size(644, 468);
            this.PanelContainer.TabIndex = 60;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundColor = System.Drawing.Color.White;
            this.PanelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeader.BackgroundImage")));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderRadius = 3;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.ButtonStatus);
            this.PanelHeader.Controls.Add(this.Label_AppName);
            this.PanelHeader.Controls.Add(this.Label_Exit);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(944, 35);
            this.PanelHeader.TabIndex = 35;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // ButtonStatus
            // 
            this.ButtonStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonStatus.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStatus.Image = global::SteamPulse.Properties.Resources.StatusBlack;
            this.ButtonStatus.Location = new System.Drawing.Point(895, 9);
            this.ButtonStatus.Name = "ButtonStatus";
            this.ButtonStatus.Size = new System.Drawing.Size(15, 15);
            this.ButtonStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonStatus.TabIndex = 61;
            this.ButtonStatus.TabStop = false;
            this.ButtonStatus.Click += new System.EventHandler(this.ButtonStatus_Click);
            // 
            // Label_AppName
            // 
            this.Label_AppName.AutoSize = true;
            this.Label_AppName.BackColor = System.Drawing.Color.White;
            this.Label_AppName.Font = new System.Drawing.Font("Motiva Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_AppName.Location = new System.Drawing.Point(7, 4);
            this.Label_AppName.Name = "Label_AppName";
            this.Label_AppName.Size = new System.Drawing.Size(107, 25);
            this.Label_AppName.TabIndex = 15;
            this.Label_AppName.Text = "SteamPulse";
            this.Label_AppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Label_AppName.MouseEnter += new System.EventHandler(this.Label_AppName_MouseEnter);
            // 
            // Label_Exit
            // 
            this.Label_Exit.AllowAnimations = true;
            this.Label_Exit.AllowMouseEffects = true;
            this.Label_Exit.AllowToggling = false;
            this.Label_Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label_Exit.AnimationSpeed = 200;
            this.Label_Exit.AutoGenerateColors = false;
            this.Label_Exit.AutoRoundBorders = false;
            this.Label_Exit.AutoSizeLeftIcon = true;
            this.Label_Exit.AutoSizeRightIcon = true;
            this.Label_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_Exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Label_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Label_Exit.BackgroundImage")));
            this.Label_Exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Label_Exit.ButtonText = "";
            this.Label_Exit.ButtonTextMarginLeft = 0;
            this.Label_Exit.ColorContrastOnClick = 45;
            this.Label_Exit.ColorContrastOnHover = 45;
            this.Label_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Label_Exit.CustomizableEdges = borderEdges2;
            this.Label_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Label_Exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Label_Exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Label_Exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Label_Exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Label_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label_Exit.ForeColor = System.Drawing.Color.White;
            this.Label_Exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Label_Exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Label_Exit.IconMarginLeft = 11;
            this.Label_Exit.IconPadding = 10;
            this.Label_Exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label_Exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Label_Exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Label_Exit.IconSize = 25;
            this.Label_Exit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Label_Exit.IdleBorderRadius = 15;
            this.Label_Exit.IdleBorderThickness = 1;
            this.Label_Exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Label_Exit.IdleIconLeftImage = null;
            this.Label_Exit.IdleIconRightImage = null;
            this.Label_Exit.IndicateFocus = false;
            this.Label_Exit.Location = new System.Drawing.Point(919, 9);
            this.Label_Exit.Name = "Label_Exit";
            this.Label_Exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Label_Exit.OnDisabledState.BorderRadius = 15;
            this.Label_Exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Label_Exit.OnDisabledState.BorderThickness = 1;
            this.Label_Exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Label_Exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Label_Exit.OnDisabledState.IconLeftImage = null;
            this.Label_Exit.OnDisabledState.IconRightImage = null;
            this.Label_Exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Label_Exit.onHoverState.BorderRadius = 15;
            this.Label_Exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Label_Exit.onHoverState.BorderThickness = 1;
            this.Label_Exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Label_Exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Label_Exit.onHoverState.IconLeftImage = null;
            this.Label_Exit.onHoverState.IconRightImage = null;
            this.Label_Exit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Label_Exit.OnIdleState.BorderRadius = 15;
            this.Label_Exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Label_Exit.OnIdleState.BorderThickness = 1;
            this.Label_Exit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Label_Exit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Label_Exit.OnIdleState.IconLeftImage = null;
            this.Label_Exit.OnIdleState.IconRightImage = null;
            this.Label_Exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Label_Exit.OnPressedState.BorderRadius = 15;
            this.Label_Exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Label_Exit.OnPressedState.BorderThickness = 1;
            this.Label_Exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Label_Exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Label_Exit.OnPressedState.IconLeftImage = null;
            this.Label_Exit.OnPressedState.IconRightImage = null;
            this.Label_Exit.Size = new System.Drawing.Size(15, 15);
            this.Label_Exit.TabIndex = 32;
            this.Label_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Label_Exit.TextMarginLeft = 0;
            this.Label_Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Label_Exit.UseDefaultRadiusAndThickness = true;
            this.Label_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // PanelHead
            // 
            this.PanelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHead.BackgroundColor = System.Drawing.Color.White;
            this.PanelHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHead.BackgroundImage")));
            this.PanelHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHead.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHead.BorderRadius = 20;
            this.PanelHead.BorderThickness = 1;
            this.PanelHead.Location = new System.Drawing.Point(20, 48);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.ShowBorders = true;
            this.PanelHead.Size = new System.Drawing.Size(909, 170);
            this.PanelHead.TabIndex = 41;
            // 
            // Notification
            // 
            this.Notification.AllowDragging = false;
            this.Notification.AllowMultipleViews = true;
            this.Notification.ClickToClose = true;
            this.Notification.DoubleClickToClose = true;
            this.Notification.DurationAfterIdle = 6000;
            this.Notification.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.ErrorOptions.ActionBorderRadius = 1;
            this.Notification.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Notification.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Notification.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Notification.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Notification.ErrorOptions.IconLeftMargin = 12;
            this.Notification.FadeCloseIcon = false;
            this.Notification.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Notification.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.InformationOptions.ActionBorderRadius = 1;
            this.Notification.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Notification.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Notification.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Notification.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Notification.InformationOptions.IconLeftMargin = 12;
            this.Notification.Margin = 10;
            this.Notification.MaximumSize = new System.Drawing.Size(0, 0);
            this.Notification.MaximumViews = 7;
            this.Notification.MessageRightMargin = 15;
            this.Notification.MinimumSize = new System.Drawing.Size(0, 0);
            this.Notification.ShowBorders = false;
            this.Notification.ShowCloseIcon = false;
            this.Notification.ShowIcon = true;
            this.Notification.ShowShadows = true;
            this.Notification.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.SuccessOptions.ActionBorderRadius = 1;
            this.Notification.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Notification.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Notification.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Notification.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Notification.SuccessOptions.IconLeftMargin = 12;
            this.Notification.ViewsMargin = 7;
            this.Notification.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notification.WarningOptions.ActionBorderRadius = 1;
            this.Notification.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notification.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notification.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Notification.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Notification.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Notification.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notification.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Notification.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Notification.WarningOptions.IconLeftMargin = 12;
            this.Notification.ZoomCloseIcon = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(944, 725);
            this.Controls.Add(this.Panel_SideBar);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelHead);
            this.Controls.Add(this.Panel_Activetab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(944, 725);
            this.MinimumSize = new System.Drawing.Size(944, 725);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamPulse";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Label_Exit;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox ButtonStatus;
        private Bunifu.UI.WinForms.BunifuPanel PanelHead;
        private Bunifu.Framework.UI.BunifuElipse Elipse2;
        public Bunifu.UI.WinForms.BunifuPanel PanelContainer;
        private System.Windows.Forms.Panel Panel_Activetab;
        public Bunifu.UI.WinForms.BunifuPanel Panel_SideBar;
        private Bunifu.UI.WinForms.BunifuSnackbar Notification;
    }
}