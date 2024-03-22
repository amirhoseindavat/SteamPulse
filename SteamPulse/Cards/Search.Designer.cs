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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.LabelSearchByName = new System.Windows.Forms.Label();
            this.GroupBoxCalculator = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.PanelCalculatorLoading = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelCalculatorLoading = new System.Windows.Forms.Label();
            this.PictureBoxCalculatorLoading = new System.Windows.Forms.PictureBox();
            this.TextBoxSource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureBoxExchange = new System.Windows.Forms.PictureBox();
            this.LabelDestination = new System.Windows.Forms.Label();
            this.DropDownDestination = new Bunifu.UI.WinForms.BunifuDropdown();
            this.DropDownSource = new Bunifu.UI.WinForms.BunifuDropdown();
            this.TextBoxDestination = new System.Windows.Forms.TextBox();
            this.GroupBoxSearch = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.TextBox_URL = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ButtonLoadData = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PixelArtCopyRight = new System.Windows.Forms.Label();
            this.Elipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PictureBoxPixelArt = new System.Windows.Forms.PictureBox();
            this.GroupBoxAppidSearch = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.TextBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ButtonSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ButtonLoad = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ComboBoxResult = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Separator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.GroupBoxCalculator.SuspendLayout();
            this.PanelCalculatorLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCalculatorLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExchange)).BeginInit();
            this.GroupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPixelArt)).BeginInit();
            this.GroupBoxAppidSearch.SuspendLayout();
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
            // LabelSearchByName
            // 
            this.LabelSearchByName.BackColor = System.Drawing.Color.Transparent;
            this.LabelSearchByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSearchByName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelSearchByName.Font = new System.Drawing.Font("Poppins", 12F);
            this.LabelSearchByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelSearchByName.Location = new System.Drawing.Point(3, 72);
            this.LabelSearchByName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelSearchByName.Name = "LabelSearchByName";
            this.LabelSearchByName.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.LabelSearchByName.Size = new System.Drawing.Size(604, 36);
            this.LabelSearchByName.TabIndex = 46;
            this.LabelSearchByName.Text = "Click here to search by name 🔎";
            this.LabelSearchByName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelSearchByName.Click += new System.EventHandler(this.LabelSearchByName_Click);
            // 
            // GroupBoxCalculator
            // 
            this.GroupBoxCalculator.BorderColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxCalculator.BorderRadius = 15;
            this.GroupBoxCalculator.BorderThickness = 1;
            this.GroupBoxCalculator.Controls.Add(this.PanelCalculatorLoading);
            this.GroupBoxCalculator.Controls.Add(this.TextBoxSource);
            this.GroupBoxCalculator.Controls.Add(this.label4);
            this.GroupBoxCalculator.Controls.Add(this.PictureBoxExchange);
            this.GroupBoxCalculator.Controls.Add(this.LabelDestination);
            this.GroupBoxCalculator.Controls.Add(this.DropDownDestination);
            this.GroupBoxCalculator.Controls.Add(this.DropDownSource);
            this.GroupBoxCalculator.Controls.Add(this.TextBoxDestination);
            this.GroupBoxCalculator.Font = new System.Drawing.Font("Motiva Sans", 12F);
            this.GroupBoxCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.GroupBoxCalculator.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupBoxCalculator.LabelIndent = 10;
            this.GroupBoxCalculator.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.GroupBoxCalculator.Location = new System.Drawing.Point(17, 137);
            this.GroupBoxCalculator.Name = "GroupBoxCalculator";
            this.GroupBoxCalculator.Size = new System.Drawing.Size(610, 161);
            this.GroupBoxCalculator.TabIndex = 48;
            this.GroupBoxCalculator.TabStop = false;
            this.GroupBoxCalculator.Text = "Calculator";
            // 
            // PanelCalculatorLoading
            // 
            this.PanelCalculatorLoading.BackgroundColor = System.Drawing.Color.Transparent;
            this.PanelCalculatorLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCalculatorLoading.BackgroundImage")));
            this.PanelCalculatorLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCalculatorLoading.BorderColor = System.Drawing.Color.Transparent;
            this.PanelCalculatorLoading.BorderRadius = 25;
            this.PanelCalculatorLoading.BorderThickness = 1;
            this.PanelCalculatorLoading.Controls.Add(this.LabelCalculatorLoading);
            this.PanelCalculatorLoading.Controls.Add(this.PictureBoxCalculatorLoading);
            this.PanelCalculatorLoading.Location = new System.Drawing.Point(0, 0);
            this.PanelCalculatorLoading.Name = "PanelCalculatorLoading";
            this.PanelCalculatorLoading.ShowBorders = true;
            this.PanelCalculatorLoading.Size = new System.Drawing.Size(1, 1);
            this.PanelCalculatorLoading.TabIndex = 52;
            // 
            // LabelCalculatorLoading
            // 
            this.LabelCalculatorLoading.BackColor = System.Drawing.Color.Transparent;
            this.LabelCalculatorLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelCalculatorLoading.Font = new System.Drawing.Font("Motiva Sans", 10F);
            this.LabelCalculatorLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelCalculatorLoading.Location = new System.Drawing.Point(0, -19);
            this.LabelCalculatorLoading.Name = "LabelCalculatorLoading";
            this.LabelCalculatorLoading.Size = new System.Drawing.Size(1, 20);
            this.LabelCalculatorLoading.TabIndex = 1;
            this.LabelCalculatorLoading.Text = "Loading Calculator ...";
            this.LabelCalculatorLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBoxCalculatorLoading
            // 
            this.PictureBoxCalculatorLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxCalculatorLoading.Image = global::SteamPulse.Properties.Resources.SteamPulse_Logo;
            this.PictureBoxCalculatorLoading.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxCalculatorLoading.Name = "PictureBoxCalculatorLoading";
            this.PictureBoxCalculatorLoading.Size = new System.Drawing.Size(1, 1);
            this.PictureBoxCalculatorLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCalculatorLoading.TabIndex = 0;
            this.PictureBoxCalculatorLoading.TabStop = false;
            // 
            // TextBoxSource
            // 
            this.TextBoxSource.BackColor = System.Drawing.Color.White;
            this.TextBoxSource.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TextBoxSource.Location = new System.Drawing.Point(12, 114);
            this.TextBoxSource.MinimumSize = new System.Drawing.Size(260, 30);
            this.TextBoxSource.Name = "TextBoxSource";
            this.TextBoxSource.Size = new System.Drawing.Size(260, 29);
            this.TextBoxSource.TabIndex = 9;
            this.TextBoxSource.Text = "1";
            this.TextBoxSource.TextChanged += new System.EventHandler(this.TextBoxSource_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Source";
            // 
            // PictureBoxExchange
            // 
            this.PictureBoxExchange.Image = global::SteamPulse.Properties.Resources.exchange;
            this.PictureBoxExchange.Location = new System.Drawing.Point(288, 84);
            this.PictureBoxExchange.Name = "PictureBoxExchange";
            this.PictureBoxExchange.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxExchange.TabIndex = 4;
            this.PictureBoxExchange.TabStop = false;
            // 
            // LabelDestination
            // 
            this.LabelDestination.AutoSize = true;
            this.LabelDestination.Location = new System.Drawing.Point(329, 31);
            this.LabelDestination.Name = "LabelDestination";
            this.LabelDestination.Size = new System.Drawing.Size(95, 22);
            this.LabelDestination.TabIndex = 3;
            this.LabelDestination.Text = "Destination";
            // 
            // DropDownDestination
            // 
            this.DropDownDestination.BackColor = System.Drawing.Color.Transparent;
            this.DropDownDestination.BackgroundColor = System.Drawing.Color.White;
            this.DropDownDestination.BorderColor = System.Drawing.Color.Silver;
            this.DropDownDestination.BorderRadius = 7;
            this.DropDownDestination.Color = System.Drawing.Color.Silver;
            this.DropDownDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownDestination.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownDestination.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownDestination.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownDestination.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownDestination.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownDestination.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownDestination.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownDestination.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownDestination.FillDropDown = true;
            this.DropDownDestination.FillIndicator = false;
            this.DropDownDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownDestination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DropDownDestination.ForeColor = System.Drawing.Color.Black;
            this.DropDownDestination.FormattingEnabled = true;
            this.DropDownDestination.Icon = null;
            this.DropDownDestination.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownDestination.IndicatorColor = System.Drawing.Color.Gray;
            this.DropDownDestination.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownDestination.ItemBackColor = System.Drawing.Color.White;
            this.DropDownDestination.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownDestination.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownDestination.ItemHeight = 26;
            this.DropDownDestination.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownDestination.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownDestination.ItemTopMargin = 3;
            this.DropDownDestination.Location = new System.Drawing.Point(333, 60);
            this.DropDownDestination.Name = "DropDownDestination";
            this.DropDownDestination.Size = new System.Drawing.Size(260, 32);
            this.DropDownDestination.TabIndex = 1;
            this.DropDownDestination.Text = null;
            this.DropDownDestination.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownDestination.TextLeftMargin = 5;
            this.DropDownDestination.SelectedIndexChanged += new System.EventHandler(this.DropDownDestination_SelectedIndexChanged);
            // 
            // DropDownSource
            // 
            this.DropDownSource.BackColor = System.Drawing.Color.Transparent;
            this.DropDownSource.BackgroundColor = System.Drawing.Color.White;
            this.DropDownSource.BorderColor = System.Drawing.Color.Silver;
            this.DropDownSource.BorderRadius = 7;
            this.DropDownSource.Color = System.Drawing.Color.Silver;
            this.DropDownSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownSource.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownSource.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownSource.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownSource.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownSource.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownSource.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownSource.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownSource.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownSource.FillDropDown = true;
            this.DropDownSource.FillIndicator = false;
            this.DropDownSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DropDownSource.ForeColor = System.Drawing.Color.Black;
            this.DropDownSource.FormattingEnabled = true;
            this.DropDownSource.Icon = null;
            this.DropDownSource.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownSource.IndicatorColor = System.Drawing.Color.Gray;
            this.DropDownSource.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownSource.ItemBackColor = System.Drawing.Color.White;
            this.DropDownSource.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownSource.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownSource.ItemHeight = 26;
            this.DropDownSource.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownSource.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownSource.ItemTopMargin = 3;
            this.DropDownSource.Location = new System.Drawing.Point(12, 60);
            this.DropDownSource.Name = "DropDownSource";
            this.DropDownSource.Size = new System.Drawing.Size(260, 32);
            this.DropDownSource.TabIndex = 0;
            this.DropDownSource.Text = null;
            this.DropDownSource.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownSource.TextLeftMargin = 5;
            this.DropDownSource.SelectedIndexChanged += new System.EventHandler(this.DropDownSource_SelectedIndexChanged);
            // 
            // TextBoxDestination
            // 
            this.TextBoxDestination.BackColor = System.Drawing.Color.White;
            this.TextBoxDestination.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBoxDestination.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TextBoxDestination.Location = new System.Drawing.Point(333, 114);
            this.TextBoxDestination.MinimumSize = new System.Drawing.Size(260, 30);
            this.TextBoxDestination.Name = "TextBoxDestination";
            this.TextBoxDestination.ReadOnly = true;
            this.TextBoxDestination.Size = new System.Drawing.Size(260, 29);
            this.TextBoxDestination.TabIndex = 10;
            this.TextBoxDestination.Text = "1";
            this.TextBoxDestination.TextChanged += new System.EventHandler(this.TextBoxDestination_TextChanged);
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxSearch.BorderRadius = 15;
            this.GroupBoxSearch.BorderThickness = 1;
            this.GroupBoxSearch.Controls.Add(this.TextBox_URL);
            this.GroupBoxSearch.Controls.Add(this.ButtonLoadData);
            this.GroupBoxSearch.Controls.Add(this.LabelSearchByName);
            this.GroupBoxSearch.Font = new System.Drawing.Font("Motiva Sans", 12F);
            this.GroupBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.GroupBoxSearch.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupBoxSearch.LabelIndent = 10;
            this.GroupBoxSearch.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.GroupBoxSearch.Location = new System.Drawing.Point(17, 8);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(610, 111);
            this.GroupBoxSearch.TabIndex = 49;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Game";
            this.GroupBoxSearch.Enter += new System.EventHandler(this.bunifuGroupBox1_Enter);
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
            this.TextBox_URL.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBox_URL.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBox_URL.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBox_URL.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBox_URL.BorderRadius = 10;
            this.TextBox_URL.BorderThickness = 1;
            this.TextBox_URL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBox_URL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_URL.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBox_URL.DefaultText = "";
            this.TextBox_URL.FillColor = System.Drawing.Color.White;
            this.TextBox_URL.HideSelection = true;
            this.TextBox_URL.IconLeft = null;
            this.TextBox_URL.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_URL.IconPadding = 10;
            this.TextBox_URL.IconRight = null;
            this.TextBox_URL.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_URL.Lines = new string[0];
            this.TextBox_URL.Location = new System.Drawing.Point(12, 32);
            this.TextBox_URL.MaxLength = 32767;
            this.TextBox_URL.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBox_URL.Modified = false;
            this.TextBox_URL.Multiline = false;
            this.TextBox_URL.Name = "TextBox_URL";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBox_URL.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_URL.OnIdleState = stateProperties8;
            this.TextBox_URL.Padding = new System.Windows.Forms.Padding(3);
            this.TextBox_URL.PasswordChar = '\0';
            this.TextBox_URL.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBox_URL.PlaceholderText = "Enter appid or paste the URL";
            this.TextBox_URL.ReadOnly = false;
            this.TextBox_URL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_URL.SelectedText = "";
            this.TextBox_URL.SelectionLength = 0;
            this.TextBox_URL.SelectionStart = 0;
            this.TextBox_URL.ShortcutsEnabled = true;
            this.TextBox_URL.Size = new System.Drawing.Size(546, 37);
            this.TextBox_URL.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBox_URL.TabIndex = 41;
            this.TextBox_URL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_URL.TextMarginBottom = 0;
            this.TextBox_URL.TextMarginLeft = 3;
            this.TextBox_URL.TextMarginTop = 0;
            this.TextBox_URL.TextPlaceholder = "Enter appid or paste the URL";
            this.TextBox_URL.UseSystemPasswordChar = false;
            this.TextBox_URL.WordWrap = true;
            this.TextBox_URL.TextChanged += new System.EventHandler(this.TextBox_URL_TextChanged);
            this.TextBox_URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_URL_KeyDown);
            this.TextBox_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuTextBox1_KeyPress);
            // 
            // ButtonLoadData
            // 
            this.ButtonLoadData.ActiveImage = null;
            this.ButtonLoadData.AllowAnimations = true;
            this.ButtonLoadData.AllowBuffering = false;
            this.ButtonLoadData.AllowToggling = false;
            this.ButtonLoadData.AllowZooming = false;
            this.ButtonLoadData.AllowZoomingOnFocus = false;
            this.ButtonLoadData.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoadData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonLoadData.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoadData.ErrorImage")));
            this.ButtonLoadData.FadeWhenInactive = false;
            this.ButtonLoadData.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonLoadData.Image = global::SteamPulse.Properties.Resources.SearchBlack;
            this.ButtonLoadData.ImageActive = null;
            this.ButtonLoadData.ImageLocation = null;
            this.ButtonLoadData.ImageMargin = 0;
            this.ButtonLoadData.ImageSize = new System.Drawing.Size(22, 22);
            this.ButtonLoadData.ImageZoomSize = new System.Drawing.Size(22, 22);
            this.ButtonLoadData.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoadData.InitialImage")));
            this.ButtonLoadData.Location = new System.Drawing.Point(571, 40);
            this.ButtonLoadData.Name = "ButtonLoadData";
            this.ButtonLoadData.Rotation = 0;
            this.ButtonLoadData.ShowActiveImage = true;
            this.ButtonLoadData.ShowCursorChanges = true;
            this.ButtonLoadData.ShowImageBorders = true;
            this.ButtonLoadData.ShowSizeMarkers = false;
            this.ButtonLoadData.Size = new System.Drawing.Size(22, 22);
            this.ButtonLoadData.TabIndex = 42;
            this.ButtonLoadData.ToolTipText = "";
            this.ButtonLoadData.WaitOnLoad = false;
            this.ButtonLoadData.Zoom = 0;
            this.ButtonLoadData.ZoomSpeed = 10;
            this.ButtonLoadData.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PixelArtCopyRight
            // 
            this.PixelArtCopyRight.AutoSize = true;
            this.PixelArtCopyRight.BackColor = System.Drawing.Color.Black;
            this.PixelArtCopyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PixelArtCopyRight.Font = new System.Drawing.Font("Motiva Sans", 8F);
            this.PixelArtCopyRight.ForeColor = System.Drawing.Color.White;
            this.PixelArtCopyRight.Location = new System.Drawing.Point(518, 429);
            this.PixelArtCopyRight.Name = "PixelArtCopyRight";
            this.PixelArtCopyRight.Size = new System.Drawing.Size(100, 16);
            this.PixelArtCopyRight.TabIndex = 51;
            this.PixelArtCopyRight.Text = "© Art by Pixel Jeff";
            this.PixelArtCopyRight.Click += new System.EventHandler(this.PixelArtCopyRight_Click);
            // 
            // Elipse2
            // 
            this.Elipse2.ElipseRadius = 20;
            this.Elipse2.TargetControl = this.PictureBoxPixelArt;
            // 
            // PictureBoxPixelArt
            // 
            this.PictureBoxPixelArt.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPixelArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxPixelArt.Image = global::SteamPulse.Properties.Resources.SteamPulseSearchGif;
            this.PictureBoxPixelArt.Location = new System.Drawing.Point(17, 313);
            this.PictureBoxPixelArt.Name = "PictureBoxPixelArt";
            this.PictureBoxPixelArt.Size = new System.Drawing.Size(610, 139);
            this.PictureBoxPixelArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxPixelArt.TabIndex = 50;
            this.PictureBoxPixelArt.TabStop = false;
            // 
            // GroupBoxAppidSearch
            // 
            this.GroupBoxAppidSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxAppidSearch.BorderRadius = 15;
            this.GroupBoxAppidSearch.BorderThickness = 1;
            this.GroupBoxAppidSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxAppidSearch.Controls.Add(this.ButtonSearch);
            this.GroupBoxAppidSearch.Controls.Add(this.ButtonLoad);
            this.GroupBoxAppidSearch.Controls.Add(this.ComboBoxResult);
            this.GroupBoxAppidSearch.Controls.Add(this.Separator);
            this.GroupBoxAppidSearch.Font = new System.Drawing.Font("Motiva Sans", 12F);
            this.GroupBoxAppidSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.GroupBoxAppidSearch.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupBoxAppidSearch.LabelIndent = 10;
            this.GroupBoxAppidSearch.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.GroupBoxAppidSearch.Location = new System.Drawing.Point(17, 8);
            this.GroupBoxAppidSearch.Name = "GroupBoxAppidSearch";
            this.GroupBoxAppidSearch.Size = new System.Drawing.Size(1, 1);
            this.GroupBoxAppidSearch.TabIndex = 49;
            this.GroupBoxAppidSearch.TabStop = false;
            this.GroupBoxAppidSearch.Text = "Search Game";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AcceptsReturn = false;
            this.TextBoxSearch.AcceptsTab = false;
            this.TextBoxSearch.AnimationSpeed = 200;
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxSearch.BackgroundImage")));
            this.TextBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxSearch.BorderRadius = 10;
            this.TextBoxSearch.BorderThickness = 1;
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.FillColor = System.Drawing.Color.White;
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.TextBoxSearch.HideSelection = true;
            this.TextBoxSearch.IconLeft = null;
            this.TextBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.IconPadding = 10;
            this.TextBoxSearch.IconRight = null;
            this.TextBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.Lines = new string[0];
            this.TextBoxSearch.Location = new System.Drawing.Point(12, 24);
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
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
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
            this.TextBoxSearch.Size = new System.Drawing.Size(546, 37);
            this.TextBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxSearch.TabIndex = 46;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxSearch.TextMarginBottom = 0;
            this.TextBoxSearch.TextMarginLeft = 3;
            this.TextBoxSearch.TextMarginTop = 0;
            this.TextBoxSearch.TextPlaceholder = "Please Enter 3 or more characters to search";
            this.TextBoxSearch.UseSystemPasswordChar = false;
            this.TextBoxSearch.WordWrap = true;
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
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.ErrorImage")));
            this.ButtonSearch.FadeWhenInactive = false;
            this.ButtonSearch.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonSearch.Image = global::SteamPulse.Properties.Resources.SearchBlack;
            this.ButtonSearch.ImageActive = null;
            this.ButtonSearch.ImageLocation = null;
            this.ButtonSearch.ImageMargin = 0;
            this.ButtonSearch.ImageSize = new System.Drawing.Size(21, 21);
            this.ButtonSearch.ImageZoomSize = new System.Drawing.Size(22, 22);
            this.ButtonSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.InitialImage")));
            this.ButtonSearch.Location = new System.Drawing.Point(-33, 31);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Rotation = 0;
            this.ButtonSearch.ShowActiveImage = true;
            this.ButtonSearch.ShowCursorChanges = true;
            this.ButtonSearch.ShowImageBorders = true;
            this.ButtonSearch.ShowSizeMarkers = false;
            this.ButtonSearch.Size = new System.Drawing.Size(22, 22);
            this.ButtonSearch.TabIndex = 45;
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
            this.ButtonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonLoad.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.ErrorImage")));
            this.ButtonLoad.FadeWhenInactive = false;
            this.ButtonLoad.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ButtonLoad.Image = global::SteamPulse.Properties.Resources.BTNLoadDark;
            this.ButtonLoad.ImageActive = null;
            this.ButtonLoad.ImageLocation = null;
            this.ButtonLoad.ImageMargin = 0;
            this.ButtonLoad.ImageSize = new System.Drawing.Size(21, 21);
            this.ButtonLoad.ImageZoomSize = new System.Drawing.Size(22, 22);
            this.ButtonLoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoad.InitialImage")));
            this.ButtonLoad.Location = new System.Drawing.Point(-33, 88);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Rotation = 0;
            this.ButtonLoad.ShowActiveImage = true;
            this.ButtonLoad.ShowCursorChanges = true;
            this.ButtonLoad.ShowImageBorders = true;
            this.ButtonLoad.ShowSizeMarkers = false;
            this.ButtonLoad.Size = new System.Drawing.Size(22, 22);
            this.ButtonLoad.TabIndex = 44;
            this.ButtonLoad.ToolTipText = "";
            this.ButtonLoad.WaitOnLoad = false;
            this.ButtonLoad.Zoom = 0;
            this.ButtonLoad.ZoomSpeed = 10;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ComboBoxResult
            // 
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
            this.ComboBoxResult.Location = new System.Drawing.Point(12, 83);
            this.ComboBoxResult.Name = "ComboBoxResult";
            this.ComboBoxResult.Size = new System.Drawing.Size(546, 32);
            this.ComboBoxResult.TabIndex = 42;
            this.ComboBoxResult.Text = "Waiting";
            this.ComboBoxResult.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ComboBoxResult.TextLeftMargin = 5;
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
            this.Separator.Location = new System.Drawing.Point(12, 56);
            this.Separator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Separator.Name = "Separator";
            this.Separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator.Size = new System.Drawing.Size(581, 29);
            this.Separator.TabIndex = 43;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBoxAppidSearch);
            this.Controls.Add(this.PixelArtCopyRight);
            this.Controls.Add(this.PictureBoxPixelArt);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.GroupBoxCalculator);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(644, 468);
            this.Load += new System.EventHandler(this.Search_Load_1);
            this.GroupBoxCalculator.ResumeLayout(false);
            this.GroupBoxCalculator.PerformLayout();
            this.PanelCalculatorLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCalculatorLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExchange)).EndInit();
            this.GroupBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPixelArt)).EndInit();
            this.GroupBoxAppidSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonLoadData;
        private Bunifu.UI.WinForms.BunifuTextBox TextBox_URL;
        private System.Windows.Forms.Label LabelSearchByName;
        private Bunifu.UI.WinForms.BunifuGroupBox GroupBoxCalculator;
        private Bunifu.UI.WinForms.BunifuGroupBox GroupBoxSearch;
        private System.Windows.Forms.PictureBox PictureBoxExchange;
        private System.Windows.Forms.Label LabelDestination;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownDestination;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PictureBoxPixelArt;
        private System.Windows.Forms.Label PixelArtCopyRight;
        private Bunifu.Framework.UI.BunifuElipse Elipse2;
        private System.Windows.Forms.TextBox TextBoxSource;
        private System.Windows.Forms.TextBox TextBoxDestination;
        private Bunifu.UI.WinForms.BunifuPanel PanelCalculatorLoading;
        private System.Windows.Forms.Label LabelCalculatorLoading;
        private System.Windows.Forms.PictureBox PictureBoxCalculatorLoading;
        private Bunifu.UI.WinForms.BunifuGroupBox GroupBoxAppidSearch;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonSearch;
        private Bunifu.UI.WinForms.BunifuImageButton ButtonLoad;
        private Bunifu.UI.WinForms.BunifuSeparator Separator;
        private Bunifu.UI.WinForms.BunifuDropdown ComboBoxResult;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxSearch;
    }
}
