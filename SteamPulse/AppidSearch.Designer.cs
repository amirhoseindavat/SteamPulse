namespace SteamPulse
{
    partial class AppidSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppidSearch));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ButtonLoad = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Separator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.ComboBoxResult = new Bunifu.UI.WinForms.BunifuDropdown();
            this.TextBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.Label_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelMain.SuspendLayout();
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
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.BackgroundColor = System.Drawing.Color.White;
            this.PanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMain.BackgroundImage")));
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMain.BorderColor = System.Drawing.Color.Transparent;
            this.PanelMain.BorderRadius = 20;
            this.PanelMain.BorderThickness = 1;
            this.PanelMain.Controls.Add(this.ButtonSearch);
            this.PanelMain.Controls.Add(this.ButtonLoad);
            this.PanelMain.Controls.Add(this.Separator);
            this.PanelMain.Controls.Add(this.ComboBoxResult);
            this.PanelMain.Controls.Add(this.TextBoxSearch);
            this.PanelMain.Location = new System.Drawing.Point(10, 47);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.ShowBorders = true;
            this.PanelMain.Size = new System.Drawing.Size(504, 140);
            this.PanelMain.TabIndex = 37;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.ActiveImage = null;
            this.ButtonSearch.AllowAnimations = true;
            this.ButtonSearch.AllowBuffering = false;
            this.ButtonSearch.AllowToggling = false;
            this.ButtonSearch.AllowZooming = true;
            this.ButtonSearch.AllowZoomingOnFocus = false;
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.BackColor = System.Drawing.Color.White;
            this.ButtonSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.ErrorImage")));
            this.ButtonSearch.FadeWhenInactive = false;
            this.ButtonSearch.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonSearch.Image = global::SteamPulse.Properties.Resources.SearchBlack;
            this.ButtonSearch.ImageActive = null;
            this.ButtonSearch.ImageLocation = null;
            this.ButtonSearch.ImageMargin = 0;
            this.ButtonSearch.ImageSize = new System.Drawing.Size(31, 31);
            this.ButtonSearch.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.ButtonSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.InitialImage")));
            this.ButtonSearch.Location = new System.Drawing.Point(460, 20);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Rotation = 0;
            this.ButtonSearch.ShowActiveImage = true;
            this.ButtonSearch.ShowCursorChanges = true;
            this.ButtonSearch.ShowImageBorders = true;
            this.ButtonSearch.ShowSizeMarkers = false;
            this.ButtonSearch.Size = new System.Drawing.Size(32, 32);
            this.ButtonSearch.TabIndex = 40;
            this.ButtonSearch.ToolTipText = "";
            this.ButtonSearch.WaitOnLoad = false;
            this.ButtonSearch.Zoom = 0;
            this.ButtonSearch.ZoomSpeed = 10;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.ActiveImage = null;
            this.ButtonLoad.AllowAnimations = true;
            this.ButtonLoad.AllowBuffering = false;
            this.ButtonLoad.AllowToggling = false;
            this.ButtonLoad.AllowZooming = true;
            this.ButtonLoad.AllowZoomingOnFocus = false;
            this.ButtonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLoad.BackColor = System.Drawing.Color.White;
            this.ButtonLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonLoad.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.ErrorImage")));
            this.ButtonLoad.FadeWhenInactive = false;
            this.ButtonLoad.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonLoad.Image = global::SteamPulse.Properties.Resources.BTNLoadDark;
            this.ButtonLoad.ImageActive = null;
            this.ButtonLoad.ImageLocation = null;
            this.ButtonLoad.ImageMargin = 0;
            this.ButtonLoad.ImageSize = new System.Drawing.Size(31, 31);
            this.ButtonLoad.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.ButtonLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.InitialImage")));
            this.ButtonLoad.Location = new System.Drawing.Point(460, 92);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Rotation = 0;
            this.ButtonLoad.ShowActiveImage = true;
            this.ButtonLoad.ShowCursorChanges = true;
            this.ButtonLoad.ShowImageBorders = true;
            this.ButtonLoad.ShowSizeMarkers = false;
            this.ButtonLoad.Size = new System.Drawing.Size(32, 32);
            this.ButtonLoad.TabIndex = 39;
            this.ButtonLoad.ToolTipText = "";
            this.ButtonLoad.WaitOnLoad = false;
            this.ButtonLoad.Zoom = 0;
            this.ButtonLoad.ZoomSpeed = 10;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
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
            this.Separator.Location = new System.Drawing.Point(11, 66);
            this.Separator.Name = "Separator";
            this.Separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator.Size = new System.Drawing.Size(481, 17);
            this.Separator.TabIndex = 4;
            // 
            // ComboBoxResult
            // 
            this.ComboBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxResult.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxResult.BackgroundColor = System.Drawing.Color.White;
            this.ComboBoxResult.BorderColor = System.Drawing.Color.Silver;
            this.ComboBoxResult.BorderRadius = 1;
            this.ComboBoxResult.Color = System.Drawing.Color.Silver;
            this.ComboBoxResult.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ComboBoxResult.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboBoxResult.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ComboBoxResult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboBoxResult.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ComboBoxResult.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ComboBoxResult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxResult.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ComboBoxResult.DropDownHeight = 200;
            this.ComboBoxResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxResult.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ComboBoxResult.FillDropDown = true;
            this.ComboBoxResult.FillIndicator = false;
            this.ComboBoxResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxResult.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.ComboBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ComboBoxResult.FormattingEnabled = true;
            this.ComboBoxResult.Icon = null;
            this.ComboBoxResult.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ComboBoxResult.IndicatorColor = System.Drawing.Color.Gray;
            this.ComboBoxResult.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ComboBoxResult.IntegralHeight = false;
            this.ComboBoxResult.ItemBackColor = System.Drawing.Color.White;
            this.ComboBoxResult.ItemBorderColor = System.Drawing.Color.White;
            this.ComboBoxResult.ItemForeColor = System.Drawing.Color.Black;
            this.ComboBoxResult.ItemHeight = 26;
            this.ComboBoxResult.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ComboBoxResult.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ComboBoxResult.ItemTopMargin = 3;
            this.ComboBoxResult.Location = new System.Drawing.Point(11, 92);
            this.ComboBoxResult.Name = "ComboBoxResult";
            this.ComboBoxResult.Size = new System.Drawing.Size(434, 32);
            this.ComboBoxResult.TabIndex = 3;
            this.ComboBoxResult.Text = "Waiting";
            this.ComboBoxResult.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ComboBoxResult.TextLeftMargin = 5;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AcceptsReturn = false;
            this.TextBoxSearch.AcceptsTab = false;
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.AnimationSpeed = 200;
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxSearch.BackgroundImage")));
            this.TextBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxSearch.BorderRadius = 1;
            this.TextBoxSearch.BorderThickness = 1;
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultFont = new System.Drawing.Font("Poppins Light", 9.75F);
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.FillColor = System.Drawing.Color.White;
            this.TextBoxSearch.HideSelection = true;
            this.TextBoxSearch.IconLeft = null;
            this.TextBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.IconPadding = 10;
            this.TextBoxSearch.IconRight = null;
            this.TextBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.Lines = new string[0];
            this.TextBoxSearch.Location = new System.Drawing.Point(11, 20);
            this.TextBoxSearch.MaxLength = 32767;
            this.TextBoxSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxSearch.Modified = false;
            this.TextBoxSearch.Multiline = false;
            this.TextBoxSearch.Name = "TextBoxSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxSearch.OnIdleState = stateProperties4;
            this.TextBoxSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxSearch.PlaceholderText = "Please Enter 3 or more characters to search";
            this.TextBoxSearch.ReadOnly = false;
            this.TextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.SelectionLength = 0;
            this.TextBoxSearch.SelectionStart = 0;
            this.TextBoxSearch.ShortcutsEnabled = true;
            this.TextBoxSearch.Size = new System.Drawing.Size(434, 40);
            this.TextBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxSearch.TextMarginBottom = 0;
            this.TextBoxSearch.TextMarginLeft = 3;
            this.TextBoxSearch.TextMarginTop = 0;
            this.TextBoxSearch.TextPlaceholder = "Please Enter 3 or more characters to search";
            this.TextBoxSearch.UseSystemPasswordChar = false;
            this.TextBoxSearch.WordWrap = true;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
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
            this.PanelHeader.Size = new System.Drawing.Size(526, 35);
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
            this.Label_AppName.Size = new System.Drawing.Size(83, 31);
            this.Label_AppName.TabIndex = 15;
            this.Label_AppName.Text = "Search ";
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
            this.Label_Exit.Location = new System.Drawing.Point(501, 9);
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
            // AppidSearch
            // 
            this.AcceptButton = this.ButtonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(526, 197);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppidSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppidSearch";
            this.Load += new System.EventHandler(this.AppidSearch_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Label_Exit;
        private Bunifu.UI.WinForms.BunifuPanel PanelMain;
        private Bunifu.UI.WinForms.BunifuDropdown ComboBoxResult;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxSearch;
        private Bunifu.UI.WinForms.BunifuSeparator Separator;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonLoad;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonSearch;
    }
}