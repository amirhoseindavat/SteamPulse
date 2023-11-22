namespace SteamPulse.Cards
{
    partial class Search
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelURL = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ButtonLoad = new Bunifu.UI.WinForms.BunifuImageButton();
            this.TextBox_URL = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Label_URL = new System.Windows.Forms.Label();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelURL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // PanelURL
            // 
            this.PanelURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelURL.BackgroundColor = System.Drawing.Color.LightGray;
            this.PanelURL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelURL.BackgroundImage")));
            this.PanelURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelURL.BorderColor = System.Drawing.Color.Transparent;
            this.PanelURL.BorderRadius = 20;
            this.PanelURL.BorderThickness = 1;
            this.PanelURL.Controls.Add(this.LabelSearch);
            this.PanelURL.Controls.Add(this.ButtonLoad);
            this.PanelURL.Controls.Add(this.TextBox_URL);
            this.PanelURL.Controls.Add(this.Label_URL);
            this.PanelURL.Location = new System.Drawing.Point(388, 333);
            this.PanelURL.Name = "PanelURL";
            this.PanelURL.ShowBorders = true;
            this.PanelURL.Size = new System.Drawing.Size(241, 120);
            this.PanelURL.TabIndex = 22;
            // 
            // LabelSearch
            // 
            this.LabelSearch.BackColor = System.Drawing.Color.Transparent;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelSearch.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.LabelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelSearch.Image = global::SteamPulse.Properties.Resources.SearchBlack;
            this.LabelSearch.Location = new System.Drawing.Point(0, 89);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LabelSearch.Size = new System.Drawing.Size(241, 31);
            this.LabelSearch.TabIndex = 39;
            this.LabelSearch.Text = "🔍 Search ";
            this.LabelSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.ButtonLoad.ImageSize = new System.Drawing.Size(36, 36);
            this.ButtonLoad.ImageZoomSize = new System.Drawing.Size(37, 37);
            this.ButtonLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.InitialImage")));
            this.ButtonLoad.Location = new System.Drawing.Point(191, 43);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Rotation = 0;
            this.ButtonLoad.ShowActiveImage = true;
            this.ButtonLoad.ShowCursorChanges = true;
            this.ButtonLoad.ShowImageBorders = true;
            this.ButtonLoad.ShowSizeMarkers = false;
            this.ButtonLoad.Size = new System.Drawing.Size(37, 37);
            this.ButtonLoad.TabIndex = 38;
            this.ButtonLoad.ToolTipText = "";
            this.ButtonLoad.WaitOnLoad = false;
            this.ButtonLoad.Zoom = 0;
            this.ButtonLoad.ZoomSpeed = 10;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // TextBox_URL
            // 
            this.TextBox_URL.AcceptsReturn = false;
            this.TextBox_URL.AcceptsTab = false;
            this.TextBox_URL.AnimationSpeed = 200;
            this.TextBox_URL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBox_URL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBox_URL.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_URL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBox_URL.BackgroundImage")));
            this.TextBox_URL.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBox_URL.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBox_URL.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBox_URL.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TextBox_URL.BorderRadius = 1;
            this.TextBox_URL.BorderThickness = 1;
            this.TextBox_URL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBox_URL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_URL.DefaultFont = new System.Drawing.Font("Poppins Light", 9.75F);
            this.TextBox_URL.DefaultText = "";
            this.TextBox_URL.FillColor = System.Drawing.Color.White;
            this.TextBox_URL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TextBox_URL.HideSelection = true;
            this.TextBox_URL.IconLeft = null;
            this.TextBox_URL.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_URL.IconPadding = 10;
            this.TextBox_URL.IconRight = null;
            this.TextBox_URL.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_URL.Lines = new string[0];
            this.TextBox_URL.Location = new System.Drawing.Point(16, 43);
            this.TextBox_URL.MaxLength = 32767;
            this.TextBox_URL.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBox_URL.Modified = false;
            this.TextBox_URL.Multiline = false;
            this.TextBox_URL.Name = "TextBox_URL";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBox_URL.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnIdleState = stateProperties8;
            this.TextBox_URL.Padding = new System.Windows.Forms.Padding(3);
            this.TextBox_URL.PasswordChar = '\0';
            this.TextBox_URL.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TextBox_URL.PlaceholderText = "AppID or URL";
            this.TextBox_URL.ReadOnly = false;
            this.TextBox_URL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_URL.SelectedText = "";
            this.TextBox_URL.SelectionLength = 0;
            this.TextBox_URL.SelectionStart = 0;
            this.TextBox_URL.ShortcutsEnabled = true;
            this.TextBox_URL.Size = new System.Drawing.Size(169, 37);
            this.TextBox_URL.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBox_URL.TabIndex = 32;
            this.TextBox_URL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_URL.TextMarginBottom = 0;
            this.TextBox_URL.TextMarginLeft = 3;
            this.TextBox_URL.TextMarginTop = 0;
            this.TextBox_URL.TextPlaceholder = "AppID or URL";
            this.TextBox_URL.UseSystemPasswordChar = false;
            this.TextBox_URL.WordWrap = true;
            this.TextBox_URL.TextChanged += new System.EventHandler(this.TextBox_URL_TextChanged);
            // 
            // Label_URL
            // 
            this.Label_URL.BackColor = System.Drawing.Color.Transparent;
            this.Label_URL.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_URL.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.Label_URL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_URL.Location = new System.Drawing.Point(0, 0);
            this.Label_URL.Margin = new System.Windows.Forms.Padding(0);
            this.Label_URL.Name = "Label_URL";
            this.Label_URL.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.Label_URL.Size = new System.Drawing.Size(241, 26);
            this.Label_URL.TabIndex = 12;
            this.Label_URL.Text = "URL or AppID:";
            this.Label_URL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "By Appid or URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(19, 76);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Enter URL or ID";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(597, 37);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 41;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Enter URL or ID";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::SteamPulse.Properties.Resources.SearchBlack;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(21, 21);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(22, 22);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(588, 84);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 22);
            this.bunifuImageButton1.TabIndex = 42;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label2.Size = new System.Drawing.Size(644, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(216, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Click here to search by name 🔎";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Your recent searches";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list,
            this.list2});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(19, 187);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(610, 128);
            this.bunifuDataGridView1.TabIndex = 48;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // list
            // 
            this.list.HeaderText = "";
            this.list.Name = "list";
            this.list.ReadOnly = true;
            // 
            // list2
            // 
            this.list2.HeaderText = "";
            this.list2.Name = "list2";
            this.list2.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelURL);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(644, 468);
            this.PanelURL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelURL;
        private System.Windows.Forms.Label LabelSearch;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonLoad;
        private Bunifu.UI.WinForms.BunifuTextBox TextBox_URL;
        private System.Windows.Forms.Label Label_URL;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn list;
        private System.Windows.Forms.DataGridViewTextBoxColumn list2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
