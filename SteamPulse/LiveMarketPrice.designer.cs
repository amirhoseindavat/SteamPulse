namespace SteamPulse
{
    partial class LiveMarketPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveMarketPrice));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.updater_label = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MarketMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTicketIRT = new Bunifu.UI.WinForms.BunifuPanel();
            this.TicketIRT = new System.Windows.Forms.Label();
            this.PanelKeyIRT = new Bunifu.UI.WinForms.BunifuPanel();
            this.KeyIRT = new System.Windows.Forms.Label();
            this.PanelTicket = new Bunifu.UI.WinForms.BunifuPanel();
            this.PictureBoxTIcket = new System.Windows.Forms.PictureBox();
            this.LabelTicket = new System.Windows.Forms.Label();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelAppName = new System.Windows.Forms.Label();
            this.Label_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelKey = new Bunifu.UI.WinForms.BunifuPanel();
            this.PictureBoxKey = new System.Windows.Forms.PictureBox();
            this.LabelKey = new System.Windows.Forms.Label();
            this.PanelKeyPrice = new Bunifu.UI.WinForms.BunifuPanel();
            this.Key_indicator = new System.Windows.Forms.PictureBox();
            this.KeyYou = new System.Windows.Forms.Label();
            this.KeySeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.KeyMarket = new System.Windows.Forms.Label();
            this.PanelTicketPRice = new Bunifu.UI.WinForms.BunifuPanel();
            this.Ticket_indicator = new System.Windows.Forms.PictureBox();
            this.TicketMarket = new System.Windows.Forms.Label();
            this.TicketYou = new System.Windows.Forms.Label();
            this.TicketSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.MarketMenu.SuspendLayout();
            this.PanelTicketIRT.SuspendLayout();
            this.PanelKeyIRT.SuspendLayout();
            this.PanelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTIcket)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKey)).BeginInit();
            this.PanelKeyPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Key_indicator)).BeginInit();
            this.PanelTicketPRice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_indicator)).BeginInit();
            this.SuspendLayout();
            // 
            // updater_label
            // 
            this.updater_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updater_label.AutoSize = true;
            this.updater_label.BackColor = System.Drawing.Color.Transparent;
            this.updater_label.Font = new System.Drawing.Font("Nexa Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updater_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.updater_label.Location = new System.Drawing.Point(14, 342);
            this.updater_label.Name = "updater_label";
            this.updater_label.Size = new System.Drawing.Size(68, 20);
            this.updater_label.TabIndex = 0;
            this.updater_label.Text = "{Status}";
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
            // MarketMenu
            // 
            this.MarketMenu.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.MarketMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MarketMenu.Name = "TrayMenu";
            this.MarketMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MarketMenu.ShowImageMargin = false;
            this.MarketMenu.Size = new System.Drawing.Size(114, 88);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.ShowShortcutKeys = false;
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PanelTicketIRT
            // 
            this.PanelTicketIRT.BackgroundColor = System.Drawing.Color.White;
            this.PanelTicketIRT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTicketIRT.BackgroundImage")));
            this.PanelTicketIRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTicketIRT.BorderColor = System.Drawing.Color.Transparent;
            this.PanelTicketIRT.BorderRadius = 20;
            this.PanelTicketIRT.BorderThickness = 1;
            this.PanelTicketIRT.Controls.Add(this.TicketIRT);
            this.PanelTicketIRT.Location = new System.Drawing.Point(239, 346);
            this.PanelTicketIRT.Name = "PanelTicketIRT";
            this.PanelTicketIRT.ShowBorders = true;
            this.PanelTicketIRT.Size = new System.Drawing.Size(200, 35);
            this.PanelTicketIRT.TabIndex = 41;
            // 
            // TicketIRT
            // 
            this.TicketIRT.BackColor = System.Drawing.Color.Transparent;
            this.TicketIRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketIRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketIRT.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketIRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TicketIRT.Location = new System.Drawing.Point(0, 0);
            this.TicketIRT.Name = "TicketIRT";
            this.TicketIRT.Size = new System.Drawing.Size(200, 35);
            this.TicketIRT.TabIndex = 32;
            this.TicketIRT.Text = "{Price}";
            this.TicketIRT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicketIRT.Click += new System.EventHandler(this.TicketIRT_Click);
            // 
            // PanelKeyIRT
            // 
            this.PanelKeyIRT.BackgroundColor = System.Drawing.Color.White;
            this.PanelKeyIRT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelKeyIRT.BackgroundImage")));
            this.PanelKeyIRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelKeyIRT.BorderColor = System.Drawing.Color.Transparent;
            this.PanelKeyIRT.BorderRadius = 20;
            this.PanelKeyIRT.BorderThickness = 1;
            this.PanelKeyIRT.Controls.Add(this.KeyIRT);
            this.PanelKeyIRT.Location = new System.Drawing.Point(18, 346);
            this.PanelKeyIRT.Name = "PanelKeyIRT";
            this.PanelKeyIRT.ShowBorders = true;
            this.PanelKeyIRT.Size = new System.Drawing.Size(200, 35);
            this.PanelKeyIRT.TabIndex = 40;
            // 
            // KeyIRT
            // 
            this.KeyIRT.BackColor = System.Drawing.Color.Transparent;
            this.KeyIRT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyIRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyIRT.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyIRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.KeyIRT.Location = new System.Drawing.Point(0, 0);
            this.KeyIRT.Name = "KeyIRT";
            this.KeyIRT.Size = new System.Drawing.Size(200, 35);
            this.KeyIRT.TabIndex = 18;
            this.KeyIRT.Text = "{Price}";
            this.KeyIRT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KeyIRT.Click += new System.EventHandler(this.KeyIRT_Click);
            // 
            // PanelTicket
            // 
            this.PanelTicket.BackgroundColor = System.Drawing.Color.White;
            this.PanelTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTicket.BackgroundImage")));
            this.PanelTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTicket.BorderColor = System.Drawing.Color.Transparent;
            this.PanelTicket.BorderRadius = 20;
            this.PanelTicket.BorderThickness = 1;
            this.PanelTicket.Controls.Add(this.PictureBoxTIcket);
            this.PanelTicket.Controls.Add(this.LabelTicket);
            this.PanelTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTicket.Location = new System.Drawing.Point(239, 52);
            this.PanelTicket.Name = "PanelTicket";
            this.PanelTicket.ShowBorders = true;
            this.PanelTicket.Size = new System.Drawing.Size(200, 202);
            this.PanelTicket.TabIndex = 38;
            this.PanelTicket.Click += new System.EventHandler(this.PictureBoxTIcket_Click);
            // 
            // PictureBoxTIcket
            // 
            this.PictureBoxTIcket.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxTIcket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxTIcket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTIcket.Image = global::SteamPulse.Properties.Resources.ticket;
            this.PictureBoxTIcket.Location = new System.Drawing.Point(27, 34);
            this.PictureBoxTIcket.Name = "PictureBoxTIcket";
            this.PictureBoxTIcket.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxTIcket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTIcket.TabIndex = 43;
            this.PictureBoxTIcket.TabStop = false;
            this.PictureBoxTIcket.Click += new System.EventHandler(this.PictureBoxTIcket_Click);
            // 
            // LabelTicket
            // 
            this.LabelTicket.BackColor = System.Drawing.Color.Transparent;
            this.LabelTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTicket.Font = new System.Drawing.Font("Nexa Bold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelTicket.Location = new System.Drawing.Point(0, 4);
            this.LabelTicket.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LabelTicket.Name = "LabelTicket";
            this.LabelTicket.Size = new System.Drawing.Size(200, 20);
            this.LabelTicket.TabIndex = 43;
            this.LabelTicket.Text = "Tour of Duty Ticket";
            this.LabelTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTicket.Click += new System.EventHandler(this.PictureBoxTIcket_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundColor = System.Drawing.Color.White;
            this.PanelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeader.BackgroundImage")));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderRadius = 3;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.LabelAppName);
            this.PanelHeader.Controls.Add(this.Label_Exit);
            this.PanelHeader.Location = new System.Drawing.Point(-8, -6);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(485, 43);
            this.PanelHeader.TabIndex = 39;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LiveMarketPrice_MouseDown);
            // 
            // LabelAppName
            // 
            this.LabelAppName.AutoSize = true;
            this.LabelAppName.BackColor = System.Drawing.Color.White;
            this.LabelAppName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelAppName.Location = new System.Drawing.Point(16, 9);
            this.LabelAppName.Name = "LabelAppName";
            this.LabelAppName.Size = new System.Drawing.Size(120, 31);
            this.LabelAppName.TabIndex = 15;
            this.LabelAppName.Text = "Live Market";
            // 
            // Label_Exit
            // 
            this.Label_Exit.AllowAnimations = true;
            this.Label_Exit.AllowMouseEffects = true;
            this.Label_Exit.AllowToggling = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Label_Exit.CustomizableEdges = borderEdges1;
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
            this.Label_Exit.Location = new System.Drawing.Point(437, 18);
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
            this.Label_Exit.TabIndex = 34;
            this.Label_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Label_Exit.TextMarginLeft = 0;
            this.Label_Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Label_Exit.UseDefaultRadiusAndThickness = true;
            this.Label_Exit.Click += new System.EventHandler(this.Label_Exit_Click);
            // 
            // PanelKey
            // 
            this.PanelKey.BackgroundColor = System.Drawing.Color.White;
            this.PanelKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelKey.BackgroundImage")));
            this.PanelKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelKey.BorderColor = System.Drawing.Color.Transparent;
            this.PanelKey.BorderRadius = 20;
            this.PanelKey.BorderThickness = 1;
            this.PanelKey.Controls.Add(this.PictureBoxKey);
            this.PanelKey.Controls.Add(this.LabelKey);
            this.PanelKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelKey.Location = new System.Drawing.Point(18, 52);
            this.PanelKey.Name = "PanelKey";
            this.PanelKey.ShowBorders = true;
            this.PanelKey.Size = new System.Drawing.Size(200, 202);
            this.PanelKey.TabIndex = 37;
            this.PanelKey.Click += new System.EventHandler(this.PictureBoxKey_Click);
            // 
            // PictureBoxKey
            // 
            this.PictureBoxKey.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxKey.Image = global::SteamPulse.Properties.Resources.key;
            this.PictureBoxKey.Location = new System.Drawing.Point(21, 34);
            this.PictureBoxKey.Name = "PictureBoxKey";
            this.PictureBoxKey.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxKey.TabIndex = 42;
            this.PictureBoxKey.TabStop = false;
            this.PictureBoxKey.Click += new System.EventHandler(this.PictureBoxKey_Click);
            // 
            // LabelKey
            // 
            this.LabelKey.BackColor = System.Drawing.Color.Transparent;
            this.LabelKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelKey.Font = new System.Drawing.Font("Nexa Bold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelKey.Location = new System.Drawing.Point(0, 4);
            this.LabelKey.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LabelKey.Name = "LabelKey";
            this.LabelKey.Size = new System.Drawing.Size(200, 23);
            this.LabelKey.TabIndex = 42;
            this.LabelKey.Text = "Mann Co. Supply Crate Key";
            this.LabelKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelKey.Click += new System.EventHandler(this.PictureBoxKey_Click);
            // 
            // PanelKeyPrice
            // 
            this.PanelKeyPrice.BackgroundColor = System.Drawing.Color.White;
            this.PanelKeyPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelKeyPrice.BackgroundImage")));
            this.PanelKeyPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelKeyPrice.BorderColor = System.Drawing.Color.Transparent;
            this.PanelKeyPrice.BorderRadius = 20;
            this.PanelKeyPrice.BorderThickness = 1;
            this.PanelKeyPrice.Controls.Add(this.Key_indicator);
            this.PanelKeyPrice.Controls.Add(this.KeyYou);
            this.PanelKeyPrice.Controls.Add(this.KeySeparator);
            this.PanelKeyPrice.Controls.Add(this.KeyMarket);
            this.PanelKeyPrice.Location = new System.Drawing.Point(18, 265);
            this.PanelKeyPrice.Name = "PanelKeyPrice";
            this.PanelKeyPrice.ShowBorders = true;
            this.PanelKeyPrice.Size = new System.Drawing.Size(200, 69);
            this.PanelKeyPrice.TabIndex = 38;
            // 
            // Key_indicator
            // 
            this.Key_indicator.BackColor = System.Drawing.Color.Transparent;
            this.Key_indicator.Image = global::SteamPulse.Properties.Resources.NoChangeLight;
            this.Key_indicator.Location = new System.Drawing.Point(155, 26);
            this.Key_indicator.Name = "Key_indicator";
            this.Key_indicator.Size = new System.Drawing.Size(33, 16);
            this.Key_indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Key_indicator.TabIndex = 45;
            this.Key_indicator.TabStop = false;
            // 
            // KeyYou
            // 
            this.KeyYou.AutoSize = true;
            this.KeyYou.BackColor = System.Drawing.Color.Transparent;
            this.KeyYou.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyYou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.KeyYou.Location = new System.Drawing.Point(13, 42);
            this.KeyYou.Name = "KeyYou";
            this.KeyYou.Size = new System.Drawing.Size(58, 20);
            this.KeyYou.TabIndex = 2;
            this.KeyYou.Text = "{Price}";
            // 
            // KeySeparator
            // 
            this.KeySeparator.BackColor = System.Drawing.Color.Transparent;
            this.KeySeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KeySeparator.BackgroundImage")));
            this.KeySeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KeySeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.KeySeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.KeySeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.KeySeparator.LineThickness = 1;
            this.KeySeparator.Location = new System.Drawing.Point(17, 26);
            this.KeySeparator.Name = "KeySeparator";
            this.KeySeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.KeySeparator.Size = new System.Drawing.Size(123, 19);
            this.KeySeparator.TabIndex = 42;
            // 
            // KeyMarket
            // 
            this.KeyMarket.AutoSize = true;
            this.KeyMarket.BackColor = System.Drawing.Color.Transparent;
            this.KeyMarket.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyMarket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.KeyMarket.Location = new System.Drawing.Point(13, 7);
            this.KeyMarket.Name = "KeyMarket";
            this.KeyMarket.Size = new System.Drawing.Size(58, 20);
            this.KeyMarket.TabIndex = 1;
            this.KeyMarket.Text = "{Price}";
            // 
            // PanelTicketPRice
            // 
            this.PanelTicketPRice.BackgroundColor = System.Drawing.Color.White;
            this.PanelTicketPRice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelTicketPRice.BackgroundImage")));
            this.PanelTicketPRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTicketPRice.BorderColor = System.Drawing.Color.Transparent;
            this.PanelTicketPRice.BorderRadius = 20;
            this.PanelTicketPRice.BorderThickness = 1;
            this.PanelTicketPRice.Controls.Add(this.Ticket_indicator);
            this.PanelTicketPRice.Controls.Add(this.TicketMarket);
            this.PanelTicketPRice.Controls.Add(this.TicketYou);
            this.PanelTicketPRice.Controls.Add(this.TicketSeparator);
            this.PanelTicketPRice.Location = new System.Drawing.Point(239, 265);
            this.PanelTicketPRice.Name = "PanelTicketPRice";
            this.PanelTicketPRice.ShowBorders = true;
            this.PanelTicketPRice.Size = new System.Drawing.Size(200, 69);
            this.PanelTicketPRice.TabIndex = 39;
            // 
            // Ticket_indicator
            // 
            this.Ticket_indicator.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_indicator.Image = global::SteamPulse.Properties.Resources.NoChangeLight;
            this.Ticket_indicator.Location = new System.Drawing.Point(152, 26);
            this.Ticket_indicator.Name = "Ticket_indicator";
            this.Ticket_indicator.Size = new System.Drawing.Size(33, 16);
            this.Ticket_indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ticket_indicator.TabIndex = 44;
            this.Ticket_indicator.TabStop = false;
            // 
            // TicketMarket
            // 
            this.TicketMarket.AutoSize = true;
            this.TicketMarket.BackColor = System.Drawing.Color.Transparent;
            this.TicketMarket.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketMarket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TicketMarket.Location = new System.Drawing.Point(13, 7);
            this.TicketMarket.Name = "TicketMarket";
            this.TicketMarket.Size = new System.Drawing.Size(58, 20);
            this.TicketMarket.TabIndex = 29;
            this.TicketMarket.Text = "{Price}";
            // 
            // TicketYou
            // 
            this.TicketYou.AutoSize = true;
            this.TicketYou.BackColor = System.Drawing.Color.Transparent;
            this.TicketYou.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketYou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TicketYou.Location = new System.Drawing.Point(13, 42);
            this.TicketYou.Name = "TicketYou";
            this.TicketYou.Size = new System.Drawing.Size(58, 20);
            this.TicketYou.TabIndex = 30;
            this.TicketYou.Text = "{Price}";
            // 
            // TicketSeparator
            // 
            this.TicketSeparator.BackColor = System.Drawing.Color.Transparent;
            this.TicketSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TicketSeparator.BackgroundImage")));
            this.TicketSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TicketSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.TicketSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TicketSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.TicketSeparator.LineThickness = 1;
            this.TicketSeparator.Location = new System.Drawing.Point(17, 26);
            this.TicketSeparator.Name = "TicketSeparator";
            this.TicketSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.TicketSeparator.Size = new System.Drawing.Size(123, 19);
            this.TicketSeparator.TabIndex = 43;
            // 
            // LiveMarketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(456, 371);
            this.ContextMenuStrip = this.MarketMenu;
            this.Controls.Add(this.PanelTicketIRT);
            this.Controls.Add(this.PanelKeyIRT);
            this.Controls.Add(this.PanelTicket);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelKey);
            this.Controls.Add(this.updater_label);
            this.Controls.Add(this.PanelKeyPrice);
            this.Controls.Add(this.PanelTicketPRice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LiveMarketPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Steam Market Helper";
            this.Activated += new System.EventHandler(this.LiveMarketPrice_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LiveMarketPrice_MouseDown);
            this.MarketMenu.ResumeLayout(false);
            this.PanelTicketIRT.ResumeLayout(false);
            this.PanelKeyIRT.ResumeLayout(false);
            this.PanelTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTIcket)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelKey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxKey)).EndInit();
            this.PanelKeyPrice.ResumeLayout(false);
            this.PanelKeyPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Key_indicator)).EndInit();
            this.PanelTicketPRice.ResumeLayout(false);
            this.PanelTicketPRice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ticket_indicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updater_label;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label KeyMarket;
        private System.Windows.Forms.Label KeyYou;
        private System.Windows.Forms.Label TicketYou;
        private System.Windows.Forms.Label TicketMarket;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Label_Exit;
        private Bunifu.UI.WinForms.BunifuPanel PanelKey;
        private Bunifu.UI.WinForms.BunifuPanel PanelKeyPrice;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label LabelAppName;
        private Bunifu.UI.WinForms.BunifuPanel PanelTicketPRice;
        private Bunifu.UI.WinForms.BunifuPanel PanelTicket;
        private Bunifu.UI.WinForms.BunifuPanel PanelKeyIRT;
        private Bunifu.UI.WinForms.BunifuPanel PanelTicketIRT;
        private Bunifu.UI.WinForms.BunifuSeparator KeySeparator;
        private Bunifu.UI.WinForms.BunifuSeparator TicketSeparator;
        private System.Windows.Forms.Label KeyIRT;
        private System.Windows.Forms.Label TicketIRT;
        private System.Windows.Forms.PictureBox PictureBoxKey;
        private System.Windows.Forms.Label LabelKey;
        private System.Windows.Forms.PictureBox PictureBoxTIcket;
        private System.Windows.Forms.Label LabelTicket;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.ContextMenuStrip MarketMenu;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox Ticket_indicator;
        private System.Windows.Forms.PictureBox Key_indicator;
    }
}

