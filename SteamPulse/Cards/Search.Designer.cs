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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelURL = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ButtonLoad = new Bunifu.UI.WinForms.BunifuImageButton();
            this.TextBox_URL = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Label_URL = new System.Windows.Forms.Label();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelURL.SuspendLayout();
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
            this.PanelURL.Location = new System.Drawing.Point(202, 174);
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
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBox_URL.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnIdleState = stateProperties4;
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
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelURL);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(644, 468);
            this.PanelURL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelURL;
        private System.Windows.Forms.Label LabelSearch;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonLoad;
        private Bunifu.UI.WinForms.BunifuTextBox TextBox_URL;
        private System.Windows.Forms.Label Label_URL;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
    }
}
