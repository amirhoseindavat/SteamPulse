namespace SteamPulse
{
    partial class Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelMail = new Bunifu.UI.WinForms.BunifuPanel();
            this.IndicatorGamingClub = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.IndicatorCodeMage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.IndicatorSteamCommunity = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.IndicatorSteamStore = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LabelAresGame = new System.Windows.Forms.Label();
            this.LabelCodeMage = new System.Windows.Forms.Label();
            this.LabelSteamCommunity = new System.Windows.Forms.Label();
            this.LabelSteamStore = new System.Windows.Forms.Label();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.Label_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelMail.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // PanelMail
            // 
            this.PanelMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMail.BackgroundColor = System.Drawing.Color.White;
            this.PanelMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMail.BackgroundImage")));
            this.PanelMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMail.BorderColor = System.Drawing.Color.Transparent;
            this.PanelMail.BorderRadius = 20;
            this.PanelMail.BorderThickness = 1;
            this.PanelMail.Controls.Add(this.IndicatorGamingClub);
            this.PanelMail.Controls.Add(this.IndicatorCodeMage);
            this.PanelMail.Controls.Add(this.IndicatorSteamCommunity);
            this.PanelMail.Controls.Add(this.IndicatorSteamStore);
            this.PanelMail.Controls.Add(this.LabelAresGame);
            this.PanelMail.Controls.Add(this.LabelCodeMage);
            this.PanelMail.Controls.Add(this.LabelSteamCommunity);
            this.PanelMail.Controls.Add(this.LabelSteamStore);
            this.PanelMail.Location = new System.Drawing.Point(12, 41);
            this.PanelMail.Name = "PanelMail";
            this.PanelMail.ShowBorders = true;
            this.PanelMail.Size = new System.Drawing.Size(218, 140);
            this.PanelMail.TabIndex = 33;
            // 
            // IndicatorGamingClub
            // 
            this.IndicatorGamingClub.AllowAnimations = false;
            this.IndicatorGamingClub.AllowMouseEffects = false;
            this.IndicatorGamingClub.AllowToggling = false;
            this.IndicatorGamingClub.AnimationSpeed = 200;
            this.IndicatorGamingClub.AutoGenerateColors = false;
            this.IndicatorGamingClub.AutoRoundBorders = false;
            this.IndicatorGamingClub.AutoSizeLeftIcon = true;
            this.IndicatorGamingClub.AutoSizeRightIcon = true;
            this.IndicatorGamingClub.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorGamingClub.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IndicatorGamingClub.BackgroundImage")));
            this.IndicatorGamingClub.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorGamingClub.ButtonText = "";
            this.IndicatorGamingClub.ButtonTextMarginLeft = 0;
            this.IndicatorGamingClub.ColorContrastOnClick = 45;
            this.IndicatorGamingClub.ColorContrastOnHover = 45;
            this.IndicatorGamingClub.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.IndicatorGamingClub.CustomizableEdges = borderEdges1;
            this.IndicatorGamingClub.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IndicatorGamingClub.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorGamingClub.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorGamingClub.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.IndicatorGamingClub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IndicatorGamingClub.ForeColor = System.Drawing.Color.White;
            this.IndicatorGamingClub.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IndicatorGamingClub.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorGamingClub.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.IndicatorGamingClub.IconMarginLeft = 11;
            this.IndicatorGamingClub.IconPadding = 10;
            this.IndicatorGamingClub.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IndicatorGamingClub.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorGamingClub.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.IndicatorGamingClub.IconSize = 25;
            this.IndicatorGamingClub.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.IdleBorderRadius = 15;
            this.IndicatorGamingClub.IdleBorderThickness = 1;
            this.IndicatorGamingClub.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.IdleIconLeftImage = null;
            this.IndicatorGamingClub.IdleIconRightImage = null;
            this.IndicatorGamingClub.IndicateFocus = false;
            this.IndicatorGamingClub.Location = new System.Drawing.Point(10, 110);
            this.IndicatorGamingClub.Name = "IndicatorGamingClub";
            this.IndicatorGamingClub.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.OnDisabledState.BorderRadius = 15;
            this.IndicatorGamingClub.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorGamingClub.OnDisabledState.BorderThickness = 1;
            this.IndicatorGamingClub.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorGamingClub.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorGamingClub.OnDisabledState.IconLeftImage = null;
            this.IndicatorGamingClub.OnDisabledState.IconRightImage = null;
            this.IndicatorGamingClub.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.onHoverState.BorderRadius = 15;
            this.IndicatorGamingClub.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorGamingClub.onHoverState.BorderThickness = 1;
            this.IndicatorGamingClub.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.onHoverState.ForeColor = System.Drawing.Color.White;
            this.IndicatorGamingClub.onHoverState.IconLeftImage = null;
            this.IndicatorGamingClub.onHoverState.IconRightImage = null;
            this.IndicatorGamingClub.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.OnIdleState.BorderRadius = 15;
            this.IndicatorGamingClub.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorGamingClub.OnIdleState.BorderThickness = 1;
            this.IndicatorGamingClub.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.IndicatorGamingClub.OnIdleState.IconLeftImage = null;
            this.IndicatorGamingClub.OnIdleState.IconRightImage = null;
            this.IndicatorGamingClub.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.OnPressedState.BorderRadius = 15;
            this.IndicatorGamingClub.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorGamingClub.OnPressedState.BorderThickness = 1;
            this.IndicatorGamingClub.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorGamingClub.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.IndicatorGamingClub.OnPressedState.IconLeftImage = null;
            this.IndicatorGamingClub.OnPressedState.IconRightImage = null;
            this.IndicatorGamingClub.Size = new System.Drawing.Size(15, 15);
            this.IndicatorGamingClub.TabIndex = 44;
            this.IndicatorGamingClub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IndicatorGamingClub.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndicatorGamingClub.TextMarginLeft = 0;
            this.IndicatorGamingClub.TextPadding = new System.Windows.Forms.Padding(0);
            this.IndicatorGamingClub.UseDefaultRadiusAndThickness = true;
            // 
            // IndicatorCodeMage
            // 
            this.IndicatorCodeMage.AllowAnimations = false;
            this.IndicatorCodeMage.AllowMouseEffects = false;
            this.IndicatorCodeMage.AllowToggling = false;
            this.IndicatorCodeMage.AnimationSpeed = 200;
            this.IndicatorCodeMage.AutoGenerateColors = false;
            this.IndicatorCodeMage.AutoRoundBorders = false;
            this.IndicatorCodeMage.AutoSizeLeftIcon = true;
            this.IndicatorCodeMage.AutoSizeRightIcon = true;
            this.IndicatorCodeMage.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorCodeMage.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IndicatorCodeMage.BackgroundImage")));
            this.IndicatorCodeMage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorCodeMage.ButtonText = "";
            this.IndicatorCodeMage.ButtonTextMarginLeft = 0;
            this.IndicatorCodeMage.ColorContrastOnClick = 45;
            this.IndicatorCodeMage.ColorContrastOnHover = 45;
            this.IndicatorCodeMage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.IndicatorCodeMage.CustomizableEdges = borderEdges2;
            this.IndicatorCodeMage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IndicatorCodeMage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorCodeMage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorCodeMage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.IndicatorCodeMage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IndicatorCodeMage.ForeColor = System.Drawing.Color.White;
            this.IndicatorCodeMage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IndicatorCodeMage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorCodeMage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.IndicatorCodeMage.IconMarginLeft = 11;
            this.IndicatorCodeMage.IconPadding = 10;
            this.IndicatorCodeMage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IndicatorCodeMage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorCodeMage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.IndicatorCodeMage.IconSize = 25;
            this.IndicatorCodeMage.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.IdleBorderRadius = 15;
            this.IndicatorCodeMage.IdleBorderThickness = 1;
            this.IndicatorCodeMage.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.IdleIconLeftImage = null;
            this.IndicatorCodeMage.IdleIconRightImage = null;
            this.IndicatorCodeMage.IndicateFocus = false;
            this.IndicatorCodeMage.Location = new System.Drawing.Point(10, 80);
            this.IndicatorCodeMage.Name = "IndicatorCodeMage";
            this.IndicatorCodeMage.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.OnDisabledState.BorderRadius = 15;
            this.IndicatorCodeMage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorCodeMage.OnDisabledState.BorderThickness = 1;
            this.IndicatorCodeMage.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorCodeMage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorCodeMage.OnDisabledState.IconLeftImage = null;
            this.IndicatorCodeMage.OnDisabledState.IconRightImage = null;
            this.IndicatorCodeMage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.onHoverState.BorderRadius = 15;
            this.IndicatorCodeMage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorCodeMage.onHoverState.BorderThickness = 1;
            this.IndicatorCodeMage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.onHoverState.ForeColor = System.Drawing.Color.White;
            this.IndicatorCodeMage.onHoverState.IconLeftImage = null;
            this.IndicatorCodeMage.onHoverState.IconRightImage = null;
            this.IndicatorCodeMage.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.OnIdleState.BorderRadius = 15;
            this.IndicatorCodeMage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorCodeMage.OnIdleState.BorderThickness = 1;
            this.IndicatorCodeMage.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.IndicatorCodeMage.OnIdleState.IconLeftImage = null;
            this.IndicatorCodeMage.OnIdleState.IconRightImage = null;
            this.IndicatorCodeMage.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.OnPressedState.BorderRadius = 15;
            this.IndicatorCodeMage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorCodeMage.OnPressedState.BorderThickness = 1;
            this.IndicatorCodeMage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorCodeMage.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.IndicatorCodeMage.OnPressedState.IconLeftImage = null;
            this.IndicatorCodeMage.OnPressedState.IconRightImage = null;
            this.IndicatorCodeMage.Size = new System.Drawing.Size(15, 15);
            this.IndicatorCodeMage.TabIndex = 43;
            this.IndicatorCodeMage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IndicatorCodeMage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndicatorCodeMage.TextMarginLeft = 0;
            this.IndicatorCodeMage.TextPadding = new System.Windows.Forms.Padding(0);
            this.IndicatorCodeMage.UseDefaultRadiusAndThickness = true;
            // 
            // IndicatorSteamCommunity
            // 
            this.IndicatorSteamCommunity.AllowAnimations = false;
            this.IndicatorSteamCommunity.AllowMouseEffects = false;
            this.IndicatorSteamCommunity.AllowToggling = false;
            this.IndicatorSteamCommunity.AnimationSpeed = 200;
            this.IndicatorSteamCommunity.AutoGenerateColors = false;
            this.IndicatorSteamCommunity.AutoRoundBorders = false;
            this.IndicatorSteamCommunity.AutoSizeLeftIcon = true;
            this.IndicatorSteamCommunity.AutoSizeRightIcon = true;
            this.IndicatorSteamCommunity.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorSteamCommunity.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IndicatorSteamCommunity.BackgroundImage")));
            this.IndicatorSteamCommunity.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamCommunity.ButtonText = "";
            this.IndicatorSteamCommunity.ButtonTextMarginLeft = 0;
            this.IndicatorSteamCommunity.ColorContrastOnClick = 45;
            this.IndicatorSteamCommunity.ColorContrastOnHover = 45;
            this.IndicatorSteamCommunity.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.IndicatorSteamCommunity.CustomizableEdges = borderEdges3;
            this.IndicatorSteamCommunity.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IndicatorSteamCommunity.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorSteamCommunity.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorSteamCommunity.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.IndicatorSteamCommunity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IndicatorSteamCommunity.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamCommunity.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IndicatorSteamCommunity.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorSteamCommunity.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.IndicatorSteamCommunity.IconMarginLeft = 11;
            this.IndicatorSteamCommunity.IconPadding = 10;
            this.IndicatorSteamCommunity.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IndicatorSteamCommunity.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorSteamCommunity.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.IndicatorSteamCommunity.IconSize = 25;
            this.IndicatorSteamCommunity.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.IdleBorderRadius = 15;
            this.IndicatorSteamCommunity.IdleBorderThickness = 1;
            this.IndicatorSteamCommunity.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.IdleIconLeftImage = null;
            this.IndicatorSteamCommunity.IdleIconRightImage = null;
            this.IndicatorSteamCommunity.IndicateFocus = false;
            this.IndicatorSteamCommunity.Location = new System.Drawing.Point(10, 50);
            this.IndicatorSteamCommunity.Name = "IndicatorSteamCommunity";
            this.IndicatorSteamCommunity.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.OnDisabledState.BorderRadius = 15;
            this.IndicatorSteamCommunity.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamCommunity.OnDisabledState.BorderThickness = 1;
            this.IndicatorSteamCommunity.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorSteamCommunity.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorSteamCommunity.OnDisabledState.IconLeftImage = null;
            this.IndicatorSteamCommunity.OnDisabledState.IconRightImage = null;
            this.IndicatorSteamCommunity.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.onHoverState.BorderRadius = 15;
            this.IndicatorSteamCommunity.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamCommunity.onHoverState.BorderThickness = 1;
            this.IndicatorSteamCommunity.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.onHoverState.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamCommunity.onHoverState.IconLeftImage = null;
            this.IndicatorSteamCommunity.onHoverState.IconRightImage = null;
            this.IndicatorSteamCommunity.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.OnIdleState.BorderRadius = 15;
            this.IndicatorSteamCommunity.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamCommunity.OnIdleState.BorderThickness = 1;
            this.IndicatorSteamCommunity.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamCommunity.OnIdleState.IconLeftImage = null;
            this.IndicatorSteamCommunity.OnIdleState.IconRightImage = null;
            this.IndicatorSteamCommunity.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.OnPressedState.BorderRadius = 15;
            this.IndicatorSteamCommunity.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamCommunity.OnPressedState.BorderThickness = 1;
            this.IndicatorSteamCommunity.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamCommunity.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamCommunity.OnPressedState.IconLeftImage = null;
            this.IndicatorSteamCommunity.OnPressedState.IconRightImage = null;
            this.IndicatorSteamCommunity.Size = new System.Drawing.Size(15, 15);
            this.IndicatorSteamCommunity.TabIndex = 42;
            this.IndicatorSteamCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IndicatorSteamCommunity.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndicatorSteamCommunity.TextMarginLeft = 0;
            this.IndicatorSteamCommunity.TextPadding = new System.Windows.Forms.Padding(0);
            this.IndicatorSteamCommunity.UseDefaultRadiusAndThickness = true;
            // 
            // IndicatorSteamStore
            // 
            this.IndicatorSteamStore.AllowAnimations = false;
            this.IndicatorSteamStore.AllowMouseEffects = false;
            this.IndicatorSteamStore.AllowToggling = false;
            this.IndicatorSteamStore.AnimationSpeed = 200;
            this.IndicatorSteamStore.AutoGenerateColors = false;
            this.IndicatorSteamStore.AutoRoundBorders = false;
            this.IndicatorSteamStore.AutoSizeLeftIcon = true;
            this.IndicatorSteamStore.AutoSizeRightIcon = true;
            this.IndicatorSteamStore.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorSteamStore.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IndicatorSteamStore.BackgroundImage")));
            this.IndicatorSteamStore.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamStore.ButtonText = "";
            this.IndicatorSteamStore.ButtonTextMarginLeft = 0;
            this.IndicatorSteamStore.ColorContrastOnClick = 45;
            this.IndicatorSteamStore.ColorContrastOnHover = 45;
            this.IndicatorSteamStore.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.IndicatorSteamStore.CustomizableEdges = borderEdges4;
            this.IndicatorSteamStore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IndicatorSteamStore.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorSteamStore.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorSteamStore.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.IndicatorSteamStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IndicatorSteamStore.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamStore.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IndicatorSteamStore.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorSteamStore.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.IndicatorSteamStore.IconMarginLeft = 11;
            this.IndicatorSteamStore.IconPadding = 10;
            this.IndicatorSteamStore.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IndicatorSteamStore.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.IndicatorSteamStore.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.IndicatorSteamStore.IconSize = 25;
            this.IndicatorSteamStore.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.IdleBorderRadius = 15;
            this.IndicatorSteamStore.IdleBorderThickness = 1;
            this.IndicatorSteamStore.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.IdleIconLeftImage = null;
            this.IndicatorSteamStore.IdleIconRightImage = null;
            this.IndicatorSteamStore.IndicateFocus = false;
            this.IndicatorSteamStore.Location = new System.Drawing.Point(10, 20);
            this.IndicatorSteamStore.Name = "IndicatorSteamStore";
            this.IndicatorSteamStore.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.OnDisabledState.BorderRadius = 15;
            this.IndicatorSteamStore.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamStore.OnDisabledState.BorderThickness = 1;
            this.IndicatorSteamStore.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IndicatorSteamStore.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.IndicatorSteamStore.OnDisabledState.IconLeftImage = null;
            this.IndicatorSteamStore.OnDisabledState.IconRightImage = null;
            this.IndicatorSteamStore.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.onHoverState.BorderRadius = 15;
            this.IndicatorSteamStore.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamStore.onHoverState.BorderThickness = 1;
            this.IndicatorSteamStore.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.onHoverState.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamStore.onHoverState.IconLeftImage = null;
            this.IndicatorSteamStore.onHoverState.IconRightImage = null;
            this.IndicatorSteamStore.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.OnIdleState.BorderRadius = 15;
            this.IndicatorSteamStore.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamStore.OnIdleState.BorderThickness = 1;
            this.IndicatorSteamStore.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamStore.OnIdleState.IconLeftImage = null;
            this.IndicatorSteamStore.OnIdleState.IconRightImage = null;
            this.IndicatorSteamStore.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.OnPressedState.BorderRadius = 15;
            this.IndicatorSteamStore.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.IndicatorSteamStore.OnPressedState.BorderThickness = 1;
            this.IndicatorSteamStore.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.IndicatorSteamStore.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.IndicatorSteamStore.OnPressedState.IconLeftImage = null;
            this.IndicatorSteamStore.OnPressedState.IconRightImage = null;
            this.IndicatorSteamStore.Size = new System.Drawing.Size(15, 15);
            this.IndicatorSteamStore.TabIndex = 41;
            this.IndicatorSteamStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IndicatorSteamStore.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndicatorSteamStore.TextMarginLeft = 0;
            this.IndicatorSteamStore.TextPadding = new System.Windows.Forms.Padding(0);
            this.IndicatorSteamStore.UseDefaultRadiusAndThickness = true;
            // 
            // LabelAresGame
            // 
            this.LabelAresGame.AutoSize = true;
            this.LabelAresGame.BackColor = System.Drawing.Color.Transparent;
            this.LabelAresGame.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelAresGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelAresGame.Location = new System.Drawing.Point(27, 105);
            this.LabelAresGame.Name = "LabelAresGame";
            this.LabelAresGame.Size = new System.Drawing.Size(112, 31);
            this.LabelAresGame.TabIndex = 40;
            this.LabelAresGame.Text = "AresGame";
            // 
            // LabelCodeMage
            // 
            this.LabelCodeMage.AutoSize = true;
            this.LabelCodeMage.BackColor = System.Drawing.Color.Transparent;
            this.LabelCodeMage.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelCodeMage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelCodeMage.Location = new System.Drawing.Point(27, 75);
            this.LabelCodeMage.Name = "LabelCodeMage";
            this.LabelCodeMage.Size = new System.Drawing.Size(114, 31);
            this.LabelCodeMage.TabIndex = 38;
            this.LabelCodeMage.Text = "CodeMage";
            // 
            // LabelSteamCommunity
            // 
            this.LabelSteamCommunity.AutoSize = true;
            this.LabelSteamCommunity.BackColor = System.Drawing.Color.Transparent;
            this.LabelSteamCommunity.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelSteamCommunity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelSteamCommunity.Location = new System.Drawing.Point(27, 46);
            this.LabelSteamCommunity.Name = "LabelSteamCommunity";
            this.LabelSteamCommunity.Size = new System.Drawing.Size(188, 31);
            this.LabelSteamCommunity.TabIndex = 36;
            this.LabelSteamCommunity.Text = "Steam Community";
            // 
            // LabelSteamStore
            // 
            this.LabelSteamStore.AutoSize = true;
            this.LabelSteamStore.BackColor = System.Drawing.Color.Transparent;
            this.LabelSteamStore.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelSteamStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelSteamStore.Location = new System.Drawing.Point(27, 15);
            this.LabelSteamStore.Name = "LabelSteamStore";
            this.LabelSteamStore.Size = new System.Drawing.Size(126, 31);
            this.LabelSteamStore.TabIndex = 34;
            this.LabelSteamStore.Text = "Steam Store";
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
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(242, 35);
            this.PanelHeader.TabIndex = 37;
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
            this.Label_AppName.Size = new System.Drawing.Size(73, 31);
            this.Label_AppName.TabIndex = 15;
            this.Label_AppName.Text = "Status";
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Label_Exit.CustomizableEdges = borderEdges5;
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
            this.Label_Exit.Location = new System.Drawing.Point(217, 9);
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
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 193);
            this.Controls.Add(this.PanelMail);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            this.PanelMail.ResumeLayout(false);
            this.PanelMail.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Label_Exit;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelMail;
        private System.Windows.Forms.Label LabelAresGame;
        private System.Windows.Forms.Label LabelCodeMage;
        private System.Windows.Forms.Label LabelSteamCommunity;
        private System.Windows.Forms.Label LabelSteamStore;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton IndicatorSteamStore;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton IndicatorSteamCommunity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton IndicatorCodeMage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton IndicatorGamingClub;
    }
}