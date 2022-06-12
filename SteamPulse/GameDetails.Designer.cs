namespace SteamPulse
{
    partial class GameDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDetails));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.OpenPCGWIcon = new System.Windows.Forms.PictureBox();
            this.OpenPCGW = new System.Windows.Forms.Label();
            this.OpenSteamDBIcon = new System.Windows.Forms.PictureBox();
            this.OpenSteamDB = new System.Windows.Forms.Label();
            this.OpenSteamIcon = new System.Windows.Forms.PictureBox();
            this.OpenSteam = new System.Windows.Forms.Label();
            this.PictureBoxOwned = new System.Windows.Forms.PictureBox();
            this.LabelOwned = new System.Windows.Forms.Label();
            this.LabelPlayTime = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.LabelPublisher = new System.Windows.Forms.Label();
            this.LabelDev = new System.Windows.Forms.Label();
            this.LabelRelease = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.Label_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPCGWIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamDBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOwned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Panel
            // 
            this.Panel.BackgroundColor = System.Drawing.Color.White;
            this.Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel.BackgroundImage")));
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 20;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.OpenPCGWIcon);
            this.Panel.Controls.Add(this.OpenPCGW);
            this.Panel.Controls.Add(this.OpenSteamDBIcon);
            this.Panel.Controls.Add(this.OpenSteamDB);
            this.Panel.Controls.Add(this.OpenSteamIcon);
            this.Panel.Controls.Add(this.OpenSteam);
            this.Panel.Controls.Add(this.PictureBoxOwned);
            this.Panel.Controls.Add(this.LabelOwned);
            this.Panel.Controls.Add(this.LabelPlayTime);
            this.Panel.Controls.Add(this.bunifuSeparator1);
            this.Panel.Controls.Add(this.LabelPublisher);
            this.Panel.Controls.Add(this.LabelDev);
            this.Panel.Controls.Add(this.LabelRelease);
            this.Panel.Controls.Add(this.LabelCount);
            this.Panel.Controls.Add(this.LabelName);
            this.Panel.Controls.Add(this.PictureBox);
            this.Panel.Location = new System.Drawing.Point(13, 48);
            this.Panel.Name = "Panel";
            this.Panel.ShowBorders = true;
            this.Panel.Size = new System.Drawing.Size(746, 363);
            this.Panel.TabIndex = 0;
            // 
            // OpenPCGWIcon
            // 
            this.OpenPCGWIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenPCGWIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPCGWIcon.Image = global::SteamPulse.Properties.Resources.OpenExternalBlack;
            this.OpenPCGWIcon.Location = new System.Drawing.Point(621, 292);
            this.OpenPCGWIcon.Name = "OpenPCGWIcon";
            this.OpenPCGWIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenPCGWIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenPCGWIcon.TabIndex = 53;
            this.OpenPCGWIcon.TabStop = false;
            this.OpenPCGWIcon.Click += new System.EventHandler(this.OpenPCGW_Click);
            // 
            // OpenPCGW
            // 
            this.OpenPCGW.AutoSize = true;
            this.OpenPCGW.BackColor = System.Drawing.Color.Transparent;
            this.OpenPCGW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPCGW.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.OpenPCGW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.OpenPCGW.Location = new System.Drawing.Point(649, 292);
            this.OpenPCGW.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPCGW.Name = "OpenPCGW";
            this.OpenPCGW.Size = new System.Drawing.Size(72, 31);
            this.OpenPCGW.TabIndex = 52;
            this.OpenPCGW.Text = "PCGW";
            this.OpenPCGW.Click += new System.EventHandler(this.OpenPCGW_Click);
            // 
            // OpenSteamDBIcon
            // 
            this.OpenSteamDBIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteamDBIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteamDBIcon.Image = global::SteamPulse.Properties.Resources.OpenExternalBlack;
            this.OpenSteamDBIcon.Location = new System.Drawing.Point(425, 293);
            this.OpenSteamDBIcon.Name = "OpenSteamDBIcon";
            this.OpenSteamDBIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenSteamDBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenSteamDBIcon.TabIndex = 51;
            this.OpenSteamDBIcon.TabStop = false;
            this.OpenSteamDBIcon.Click += new System.EventHandler(this.OpenSteamDB_Click);
            // 
            // OpenSteamDB
            // 
            this.OpenSteamDB.AutoSize = true;
            this.OpenSteamDB.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteamDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteamDB.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.OpenSteamDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.OpenSteamDB.Location = new System.Drawing.Point(453, 293);
            this.OpenSteamDB.Margin = new System.Windows.Forms.Padding(0);
            this.OpenSteamDB.Name = "OpenSteamDB";
            this.OpenSteamDB.Size = new System.Drawing.Size(99, 31);
            this.OpenSteamDB.TabIndex = 50;
            this.OpenSteamDB.Text = "SteamDB";
            this.OpenSteamDB.Click += new System.EventHandler(this.OpenSteamDB_Click);
            // 
            // OpenSteamIcon
            // 
            this.OpenSteamIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteamIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteamIcon.Image = global::SteamPulse.Properties.Resources.OpenExternalBlack;
            this.OpenSteamIcon.Location = new System.Drawing.Point(242, 293);
            this.OpenSteamIcon.Name = "OpenSteamIcon";
            this.OpenSteamIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenSteamIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenSteamIcon.TabIndex = 49;
            this.OpenSteamIcon.TabStop = false;
            this.OpenSteamIcon.Click += new System.EventHandler(this.OpenSteam_Click);
            // 
            // OpenSteam
            // 
            this.OpenSteam.AutoSize = true;
            this.OpenSteam.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteam.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.OpenSteam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.OpenSteam.Location = new System.Drawing.Point(270, 293);
            this.OpenSteam.Margin = new System.Windows.Forms.Padding(0);
            this.OpenSteam.Name = "OpenSteam";
            this.OpenSteam.Size = new System.Drawing.Size(74, 31);
            this.OpenSteam.TabIndex = 48;
            this.OpenSteam.Text = "Steam";
            this.OpenSteam.Click += new System.EventHandler(this.OpenSteam_Click);
            // 
            // PictureBoxOwned
            // 
            this.PictureBoxOwned.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxOwned.Image = global::SteamPulse.Properties.Resources.check_solid;
            this.PictureBoxOwned.Location = new System.Drawing.Point(19, 329);
            this.PictureBoxOwned.Name = "PictureBoxOwned";
            this.PictureBoxOwned.Size = new System.Drawing.Size(22, 22);
            this.PictureBoxOwned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxOwned.TabIndex = 47;
            this.PictureBoxOwned.TabStop = false;
            // 
            // LabelOwned
            // 
            this.LabelOwned.AutoSize = true;
            this.LabelOwned.BackColor = System.Drawing.Color.Transparent;
            this.LabelOwned.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.LabelOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelOwned.Image = global::SteamPulse.Properties.Resources.check_solid;
            this.LabelOwned.Location = new System.Drawing.Point(47, 329);
            this.LabelOwned.Name = "LabelOwned";
            this.LabelOwned.Size = new System.Drawing.Size(99, 26);
            this.LabelOwned.TabIndex = 46;
            this.LabelOwned.Text = "{UI.Owned}";
            this.LabelOwned.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPlayTime
            // 
            this.LabelPlayTime.AutoSize = true;
            this.LabelPlayTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelPlayTime.Font = new System.Drawing.Font("Poppins Light", 12.75F);
            this.LabelPlayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelPlayTime.Location = new System.Drawing.Point(237, 69);
            this.LabelPlayTime.Name = "LabelPlayTime";
            this.LabelPlayTime.Size = new System.Drawing.Size(120, 30);
            this.LabelPlayTime.TabIndex = 42;
            this.LabelPlayTime.Text = "{UI.PlayTime}";
            this.LabelPlayTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(242, 266);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(481, 14);
            this.bunifuSeparator1.TabIndex = 44;
            // 
            // LabelPublisher
            // 
            this.LabelPublisher.AutoSize = true;
            this.LabelPublisher.BackColor = System.Drawing.Color.Transparent;
            this.LabelPublisher.Font = new System.Drawing.Font("Poppins Light", 12.75F);
            this.LabelPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelPublisher.Location = new System.Drawing.Point(237, 229);
            this.LabelPublisher.Name = "LabelPublisher";
            this.LabelPublisher.Size = new System.Drawing.Size(122, 30);
            this.LabelPublisher.TabIndex = 41;
            this.LabelPublisher.Text = "{UI.Publisher}";
            // 
            // LabelDev
            // 
            this.LabelDev.AutoSize = true;
            this.LabelDev.BackColor = System.Drawing.Color.Transparent;
            this.LabelDev.Font = new System.Drawing.Font("Poppins Light", 12.75F);
            this.LabelDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelDev.Location = new System.Drawing.Point(237, 189);
            this.LabelDev.Name = "LabelDev";
            this.LabelDev.Size = new System.Drawing.Size(120, 30);
            this.LabelDev.TabIndex = 40;
            this.LabelDev.Text = "{UI.Develoer}";
            // 
            // LabelRelease
            // 
            this.LabelRelease.AutoSize = true;
            this.LabelRelease.BackColor = System.Drawing.Color.Transparent;
            this.LabelRelease.Font = new System.Drawing.Font("Poppins Light", 12.75F);
            this.LabelRelease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelRelease.Location = new System.Drawing.Point(237, 109);
            this.LabelRelease.Name = "LabelRelease";
            this.LabelRelease.Size = new System.Drawing.Size(152, 30);
            this.LabelRelease.TabIndex = 39;
            this.LabelRelease.Text = "{UI.ReleaseDate}";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelCount.Font = new System.Drawing.Font("Poppins Light", 12.75F);
            this.LabelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelCount.Location = new System.Drawing.Point(237, 149);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(148, 30);
            this.LabelCount.TabIndex = 38;
            this.LabelCount.Text = "{UI.PlayerCount}";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelName.Location = new System.Drawing.Point(236, 29);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(111, 31);
            this.LabelName.TabIndex = 37;
            this.LabelName.Text = "{UI.Name}";
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox.Location = new System.Drawing.Point(19, 23);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(200, 300);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 34;
            this.PictureBox.TabStop = false;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundColor = System.Drawing.Color.White;
            this.PanelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeader.BackgroundImage")));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderRadius = 3;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.Label_AppName);
            this.PanelHeader.Controls.Add(this.Label_Exit);
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(1021, 35);
            this.PanelHeader.TabIndex = 36;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // Label_AppName
            // 
            this.Label_AppName.AutoSize = true;
            this.Label_AppName.BackColor = System.Drawing.Color.White;
            this.Label_AppName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.Label_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_AppName.Location = new System.Drawing.Point(7, 2);
            this.Label_AppName.Name = "Label_AppName";
            this.Label_AppName.Size = new System.Drawing.Size(137, 31);
            this.Label_AppName.TabIndex = 15;
            this.Label_AppName.Text = "Game Details";
            // 
            // Label_Exit
            // 
            this.Label_Exit.AllowAnimations = true;
            this.Label_Exit.AllowMouseEffects = true;
            this.Label_Exit.AllowToggling = false;
            this.Label_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.Label_Exit.Location = new System.Drawing.Point(744, 12);
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
            this.Label_Exit.Click += new System.EventHandler(this.Label_Exit_Click);
            // 
            // GameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(776, 436);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Details";
            this.Load += new System.EventHandler(this.In_Game_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPCGWIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamDBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOwned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel Panel;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Label_Exit;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label LabelPlayTime;
        private System.Windows.Forms.Label LabelPublisher;
        private System.Windows.Forms.Label LabelDev;
        private System.Windows.Forms.Label LabelRelease;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label LabelOwned;
        private System.Windows.Forms.PictureBox PictureBoxOwned;
        private System.Windows.Forms.PictureBox OpenSteamIcon;
        private System.Windows.Forms.Label OpenSteam;
        private System.Windows.Forms.PictureBox OpenPCGWIcon;
        private System.Windows.Forms.Label OpenPCGW;
        private System.Windows.Forms.PictureBox OpenSteamDBIcon;
        private System.Windows.Forms.Label OpenSteamDB;
    }
}