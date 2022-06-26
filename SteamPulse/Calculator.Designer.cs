namespace SteamPulse
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.CalculatorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.liveMarketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonLoad = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PanelResult = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelResult = new System.Windows.Forms.Label();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.PanelInput = new Bunifu.UI.WinForms.BunifuPanel();
            this.DropDownCalculation = new Bunifu.UI.WinForms.BunifuDropdown();
            this.LabelMode = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelEnter = new Bunifu.UI.WinForms.BunifuLabel();
            this.Textbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CalculatorMenu.SuspendLayout();
            this.PanelResult.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.PanelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(101, 28);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Enter Wallet:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.Location = new System.Drawing.Point(51, 238);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(91, 21);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "Wallet to Key ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(175, 238);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(91, 21);
            this.bunifuLabel3.TabIndex = 7;
            this.bunifuLabel3.Text = "Key to Wallet";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CalculatorMenu
            // 
            this.CalculatorMenu.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.CalculatorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveMarketToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CalculatorMenu.Name = "TrayMenu";
            this.CalculatorMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CalculatorMenu.ShowImageMargin = false;
            this.CalculatorMenu.Size = new System.Drawing.Size(127, 88);
            // 
            // liveMarketToolStripMenuItem
            // 
            this.liveMarketToolStripMenuItem.Name = "liveMarketToolStripMenuItem";
            this.liveMarketToolStripMenuItem.Size = new System.Drawing.Size(126, 28);
            this.liveMarketToolStripMenuItem.Text = "Live Market";
            this.liveMarketToolStripMenuItem.Click += new System.EventHandler(this.LiveMarketToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(126, 28);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.ActiveImage = null;
            this.ButtonLoad.AllowAnimations = true;
            this.ButtonLoad.AllowBuffering = false;
            this.ButtonLoad.AllowToggling = false;
            this.ButtonLoad.AllowZooming = true;
            this.ButtonLoad.AllowZoomingOnFocus = false;
            this.ButtonLoad.BackColor = System.Drawing.Color.White;
            this.ButtonLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonLoad.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.ErrorImage")));
            this.ButtonLoad.FadeWhenInactive = false;
            this.ButtonLoad.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonLoad.Image = global::SteamPulse.Properties.Resources.BTNLoadDark;
            this.ButtonLoad.ImageActive = null;
            this.ButtonLoad.ImageLocation = null;
            this.ButtonLoad.ImageMargin = 0;
            this.ButtonLoad.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonLoad.ImageZoomSize = new System.Drawing.Size(31, 31);
            this.ButtonLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.InitialImage")));
            this.ButtonLoad.Location = new System.Drawing.Point(274, 15);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Rotation = 0;
            this.ButtonLoad.ShowActiveImage = true;
            this.ButtonLoad.ShowCursorChanges = true;
            this.ButtonLoad.ShowImageBorders = true;
            this.ButtonLoad.ShowSizeMarkers = false;
            this.ButtonLoad.Size = new System.Drawing.Size(31, 31);
            this.ButtonLoad.TabIndex = 39;
            this.ButtonLoad.ToolTipText = "";
            this.ButtonLoad.WaitOnLoad = false;
            this.ButtonLoad.Zoom = 0;
            this.ButtonLoad.ZoomSpeed = 10;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // PanelResult
            // 
            this.PanelResult.BackgroundColor = System.Drawing.Color.White;
            this.PanelResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelResult.BackgroundImage")));
            this.PanelResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelResult.BorderColor = System.Drawing.Color.Transparent;
            this.PanelResult.BorderRadius = 20;
            this.PanelResult.BorderThickness = 1;
            this.PanelResult.Controls.Add(this.LabelResult);
            this.PanelResult.Location = new System.Drawing.Point(12, 178);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.ShowBorders = true;
            this.PanelResult.Size = new System.Drawing.Size(322, 49);
            this.PanelResult.TabIndex = 40;
            // 
            // LabelResult
            // 
            this.LabelResult.BackColor = System.Drawing.Color.Transparent;
            this.LabelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelResult.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelResult.Location = new System.Drawing.Point(0, 0);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(322, 49);
            this.LabelResult.TabIndex = 0;
            this.LabelResult.Text = "Result";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundColor = System.Drawing.Color.White;
            this.PanelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeader.BackgroundImage")));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderRadius = 3;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.ContextMenuStrip = this.CalculatorMenu;
            this.PanelHeader.Controls.Add(this.ButtonExit);
            this.PanelHeader.Controls.Add(this.Label_AppName);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(344, 39);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.AllowAnimations = true;
            this.ButtonExit.AllowMouseEffects = true;
            this.ButtonExit.AllowToggling = false;
            this.ButtonExit.AnimationSpeed = 200;
            this.ButtonExit.AutoGenerateColors = false;
            this.ButtonExit.AutoRoundBorders = false;
            this.ButtonExit.AutoSizeLeftIcon = true;
            this.ButtonExit.AutoSizeRightIcon = true;
            this.ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ButtonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonExit.BackgroundImage")));
            this.ButtonExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonExit.ButtonText = "";
            this.ButtonExit.ButtonTextMarginLeft = 0;
            this.ButtonExit.ColorContrastOnClick = 45;
            this.ButtonExit.ColorContrastOnHover = 45;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonExit.CustomizableEdges = borderEdges1;
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonExit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonExit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonExit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonExit.IconMarginLeft = 11;
            this.ButtonExit.IconPadding = 10;
            this.ButtonExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonExit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonExit.IconSize = 25;
            this.ButtonExit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ButtonExit.IdleBorderRadius = 15;
            this.ButtonExit.IdleBorderThickness = 1;
            this.ButtonExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ButtonExit.IdleIconLeftImage = null;
            this.ButtonExit.IdleIconRightImage = null;
            this.ButtonExit.IndicateFocus = false;
            this.ButtonExit.Location = new System.Drawing.Point(319, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonExit.OnDisabledState.BorderRadius = 15;
            this.ButtonExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonExit.OnDisabledState.BorderThickness = 1;
            this.ButtonExit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonExit.OnDisabledState.IconLeftImage = null;
            this.ButtonExit.OnDisabledState.IconRightImage = null;
            this.ButtonExit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.ButtonExit.onHoverState.BorderRadius = 15;
            this.ButtonExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonExit.onHoverState.BorderThickness = 1;
            this.ButtonExit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.ButtonExit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.onHoverState.IconLeftImage = null;
            this.ButtonExit.onHoverState.IconRightImage = null;
            this.ButtonExit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ButtonExit.OnIdleState.BorderRadius = 15;
            this.ButtonExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonExit.OnIdleState.BorderThickness = 1;
            this.ButtonExit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ButtonExit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.OnIdleState.IconLeftImage = null;
            this.ButtonExit.OnIdleState.IconRightImage = null;
            this.ButtonExit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.ButtonExit.OnPressedState.BorderRadius = 15;
            this.ButtonExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonExit.OnPressedState.BorderThickness = 1;
            this.ButtonExit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.ButtonExit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.OnPressedState.IconLeftImage = null;
            this.ButtonExit.OnPressedState.IconRightImage = null;
            this.ButtonExit.Size = new System.Drawing.Size(15, 15);
            this.ButtonExit.TabIndex = 33;
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonExit.TextMarginLeft = 0;
            this.ButtonExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonExit.UseDefaultRadiusAndThickness = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Label_AppName
            // 
            this.Label_AppName.AutoSize = true;
            this.Label_AppName.BackColor = System.Drawing.Color.Transparent;
            this.Label_AppName.ContextMenuStrip = this.CalculatorMenu;
            this.Label_AppName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.Label_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_AppName.Location = new System.Drawing.Point(6, 6);
            this.Label_AppName.Name = "Label_AppName";
            this.Label_AppName.Size = new System.Drawing.Size(111, 31);
            this.Label_AppName.TabIndex = 16;
            this.Label_AppName.Text = "Calculator";
            this.Label_AppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            // 
            // PanelInput
            // 
            this.PanelInput.BackgroundColor = System.Drawing.Color.White;
            this.PanelInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelInput.BackgroundImage")));
            this.PanelInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelInput.BorderColor = System.Drawing.Color.Transparent;
            this.PanelInput.BorderRadius = 20;
            this.PanelInput.BorderThickness = 1;
            this.PanelInput.Controls.Add(this.ButtonLoad);
            this.PanelInput.Controls.Add(this.DropDownCalculation);
            this.PanelInput.Controls.Add(this.LabelMode);
            this.PanelInput.Controls.Add(this.LabelEnter);
            this.PanelInput.Controls.Add(this.Textbox);
            this.PanelInput.Location = new System.Drawing.Point(12, 57);
            this.PanelInput.Name = "PanelInput";
            this.PanelInput.ShowBorders = true;
            this.PanelInput.Size = new System.Drawing.Size(322, 115);
            this.PanelInput.TabIndex = 2;
            // 
            // DropDownCalculation
            // 
            this.DropDownCalculation.BackColor = System.Drawing.Color.Transparent;
            this.DropDownCalculation.BackgroundColor = System.Drawing.Color.White;
            this.DropDownCalculation.BorderColor = System.Drawing.Color.Silver;
            this.DropDownCalculation.BorderRadius = 1;
            this.DropDownCalculation.Color = System.Drawing.Color.Silver;
            this.DropDownCalculation.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownCalculation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownCalculation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownCalculation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownCalculation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownCalculation.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownCalculation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownCalculation.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownCalculation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownCalculation.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownCalculation.FillDropDown = true;
            this.DropDownCalculation.FillIndicator = false;
            this.DropDownCalculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownCalculation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DropDownCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DropDownCalculation.FormattingEnabled = true;
            this.DropDownCalculation.Icon = null;
            this.DropDownCalculation.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownCalculation.IndicatorColor = System.Drawing.Color.Gray;
            this.DropDownCalculation.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownCalculation.ItemBackColor = System.Drawing.Color.White;
            this.DropDownCalculation.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownCalculation.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DropDownCalculation.ItemHeight = 26;
            this.DropDownCalculation.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownCalculation.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownCalculation.Items.AddRange(new object[] {
            "Wallet => Item",
            "Key => Wallet",
            "Ticket => Wallet",
            "Selling Fee"});
            this.DropDownCalculation.ItemTopMargin = 3;
            this.DropDownCalculation.Location = new System.Drawing.Point(66, 66);
            this.DropDownCalculation.Name = "DropDownCalculation";
            this.DropDownCalculation.Size = new System.Drawing.Size(239, 32);
            this.DropDownCalculation.TabIndex = 35;
            this.DropDownCalculation.Text = null;
            this.DropDownCalculation.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownCalculation.TextLeftMargin = 5;
            this.DropDownCalculation.SelectedIndexChanged += new System.EventHandler(this.BunifuDropdown1_SelectedIndexChanged);
            // 
            // LabelMode
            // 
            this.LabelMode.AllowParentOverrides = false;
            this.LabelMode.AutoEllipsis = false;
            this.LabelMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMode.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelMode.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelMode.Location = new System.Drawing.Point(14, 69);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMode.Size = new System.Drawing.Size(45, 28);
            this.LabelMode.TabIndex = 34;
            this.LabelMode.Text = "Mode ";
            this.LabelMode.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelMode.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelEnter
            // 
            this.LabelEnter.AllowParentOverrides = false;
            this.LabelEnter.AutoEllipsis = false;
            this.LabelEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelEnter.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelEnter.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelEnter.Location = new System.Drawing.Point(14, 15);
            this.LabelEnter.Name = "LabelEnter";
            this.LabelEnter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelEnter.Size = new System.Drawing.Size(113, 28);
            this.LabelEnter.TabIndex = 6;
            this.LabelEnter.Text = "Enter Number";
            this.LabelEnter.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelEnter.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Textbox
            // 
            this.Textbox.AcceptsReturn = false;
            this.Textbox.AcceptsTab = false;
            this.Textbox.AnimationSpeed = 200;
            this.Textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Textbox.BackColor = System.Drawing.Color.Transparent;
            this.Textbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Textbox.BackgroundImage")));
            this.Textbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Textbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Textbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Textbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.Textbox.BorderRadius = 1;
            this.Textbox.BorderThickness = 1;
            this.Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Textbox.DefaultText = "";
            this.Textbox.FillColor = System.Drawing.Color.White;
            this.Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Textbox.HideSelection = true;
            this.Textbox.IconLeft = null;
            this.Textbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox.IconPadding = 10;
            this.Textbox.IconRight = null;
            this.Textbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox.Lines = new string[0];
            this.Textbox.Location = new System.Drawing.Point(131, 15);
            this.Textbox.MaxLength = 32767;
            this.Textbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.Textbox.Modified = false;
            this.Textbox.Multiline = false;
            this.Textbox.Name = "Textbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Textbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Textbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Textbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Textbox.OnIdleState = stateProperties4;
            this.Textbox.Padding = new System.Windows.Forms.Padding(3);
            this.Textbox.PasswordChar = '\0';
            this.Textbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Textbox.PlaceholderText = "Enter Wallet Count";
            this.Textbox.ReadOnly = false;
            this.Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox.SelectedText = "";
            this.Textbox.SelectionLength = 0;
            this.Textbox.SelectionStart = 0;
            this.Textbox.ShortcutsEnabled = true;
            this.Textbox.Size = new System.Drawing.Size(137, 31);
            this.Textbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Textbox.TabIndex = 1;
            this.Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox.TextMarginBottom = 0;
            this.Textbox.TextMarginLeft = 3;
            this.Textbox.TextMarginTop = 0;
            this.Textbox.TextPlaceholder = "Enter Wallet Count";
            this.Textbox.UseSystemPasswordChar = false;
            this.Textbox.WordWrap = true;
            this.Textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            this.Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_KeyPress);
            this.Textbox.Click += new System.EventHandler(this.Textbox_Click);
            this.Textbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Textbox_MouseDown);
            // 
            // Calculator
            // 
            this.AcceptButton = this.ButtonLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(344, 251);
            this.ContextMenuStrip = this.CalculatorMenu;
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.Activated += new System.EventHandler(this.Calculator_Activated);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            this.CalculatorMenu.ResumeLayout(false);
            this.PanelResult.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelInput.ResumeLayout(false);
            this.PanelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonExit;
        private Bunifu.UI.WinForms.BunifuPanel PanelInput;
        private Bunifu.UI.WinForms.BunifuTextBox Textbox;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel LabelEnter;
        private System.Windows.Forms.ContextMenuStrip CalculatorMenu;
        private System.Windows.Forms.ToolStripMenuItem liveMarketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownCalculation;
        private Bunifu.UI.WinForms.BunifuLabel LabelMode;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonLoad;
        private Bunifu.UI.WinForms.BunifuPanel PanelResult;
        private System.Windows.Forms.Label LabelResult;
    }
}