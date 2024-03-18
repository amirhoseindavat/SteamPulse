namespace SteamPulse.Cards
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.Label_KeyCount_Title = new System.Windows.Forms.Label();
            this.OpenPCGW = new System.Windows.Forms.Label();
            this.OpenSteamDB = new System.Windows.Forms.Label();
            this.OpenSteam = new System.Windows.Forms.Label();
            this.Label_Price_Title = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Player_Count_Title = new System.Windows.Forms.Label();
            this.Label_Release_Title = new System.Windows.Forms.Label();
            this.Label_IRT_Title = new System.Windows.Forms.Label();
            this.ComboBox_Editions = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_DLC_TItle = new System.Windows.Forms.Label();
            this.Label_Edition_Title = new System.Windows.Forms.Label();
            this.DropDownRegion = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Label_DLC = new System.Windows.Forms.Label();
            this.Label_Release = new System.Windows.Forms.Label();
            this.Label_Player_Count = new System.Windows.Forms.Label();
            this.Label_IRT = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_KeyCount = new System.Windows.Forms.Label();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.LabelOwned = new System.Windows.Forms.Label();
            this.Elipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelPrice = new System.Windows.Forms.Panel();
            this.Label_Dev_Title = new System.Windows.Forms.Label();
            this.Label_Publisher_Title = new System.Windows.Forms.Label();
            this.Label_PlayTime_Title = new System.Windows.Forms.Label();
            this.Label_Dev = new System.Windows.Forms.Label();
            this.Label_Publisher = new System.Windows.Forms.Label();
            this.Label_PlayTime = new System.Windows.Forms.Label();
            this.Panel_BaseGame = new System.Windows.Forms.Panel();
            this.Label_BaseGame = new System.Windows.Forms.Label();
            this.PictureBoxBaseGame = new System.Windows.Forms.PictureBox();
            this.PanelStatus = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_Status = new System.Windows.Forms.Label();
            this.PictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.OpenPCGWIcon = new System.Windows.Forms.PictureBox();
            this.OpenSteamDBIcon = new System.Windows.Forms.PictureBox();
            this.OpenSteamIcon = new System.Windows.Forms.PictureBox();
            this.PictureBoxOwned = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.PanelPrice.SuspendLayout();
            this.Panel_BaseGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBaseGame)).BeginInit();
            this.PanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPCGWIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamDBIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOwned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_KeyCount_Title
            // 
            this.Label_KeyCount_Title.AutoSize = true;
            this.Label_KeyCount_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_KeyCount_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_KeyCount_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold);
            this.Label_KeyCount_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_KeyCount_Title.Location = new System.Drawing.Point(13, 85);
            this.Label_KeyCount_Title.Name = "Label_KeyCount_Title";
            this.Label_KeyCount_Title.Size = new System.Drawing.Size(100, 22);
            this.Label_KeyCount_Title.TabIndex = 63;
            this.Label_KeyCount_Title.Text = "Item Count:";
            // 
            // OpenPCGW
            // 
            this.OpenPCGW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenPCGW.AutoSize = true;
            this.OpenPCGW.BackColor = System.Drawing.Color.Transparent;
            this.OpenPCGW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPCGW.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.OpenPCGW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.OpenPCGW.Location = new System.Drawing.Point(556, 423);
            this.OpenPCGW.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPCGW.Name = "OpenPCGW";
            this.OpenPCGW.Size = new System.Drawing.Size(66, 26);
            this.OpenPCGW.TabIndex = 80;
            this.OpenPCGW.Text = "PCGW";
            this.OpenPCGW.Click += new System.EventHandler(this.OpenPCGW_Click);
            // 
            // OpenSteamDB
            // 
            this.OpenSteamDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenSteamDB.AutoSize = true;
            this.OpenSteamDB.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteamDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteamDB.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.OpenSteamDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.OpenSteamDB.Location = new System.Drawing.Point(306, 422);
            this.OpenSteamDB.Margin = new System.Windows.Forms.Padding(0);
            this.OpenSteamDB.Name = "OpenSteamDB";
            this.OpenSteamDB.Size = new System.Drawing.Size(91, 26);
            this.OpenSteamDB.TabIndex = 78;
            this.OpenSteamDB.Text = "SteamDB";
            this.OpenSteamDB.Click += new System.EventHandler(this.OpenSteamDB_Click);
            // 
            // OpenSteam
            // 
            this.OpenSteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenSteam.AutoSize = true;
            this.OpenSteam.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteam.Font = new System.Drawing.Font("Motiva Sans", 13F, System.Drawing.FontStyle.Bold);
            this.OpenSteam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.OpenSteam.Location = new System.Drawing.Point(43, 422);
            this.OpenSteam.Margin = new System.Windows.Forms.Padding(0);
            this.OpenSteam.Name = "OpenSteam";
            this.OpenSteam.Size = new System.Drawing.Size(66, 26);
            this.OpenSteam.TabIndex = 76;
            this.OpenSteam.Text = "Steam";
            this.OpenSteam.Click += new System.EventHandler(this.OpenSteam_Click);
            // 
            // Label_Price_Title
            // 
            this.Label_Price_Title.AutoSize = true;
            this.Label_Price_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Price_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Price_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Price_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Price_Title.Location = new System.Drawing.Point(13, 57);
            this.Label_Price_Title.Name = "Label_Price_Title";
            this.Label_Price_Title.Size = new System.Drawing.Size(52, 22);
            this.Label_Price_Title.TabIndex = 62;
            this.Label_Price_Title.Text = "Price:";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoEllipsis = true;
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Name.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Name.Location = new System.Drawing.Point(265, 10);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(368, 22);
            this.Label_Name.TabIndex = 61;
            this.Label_Name.Text = "{UI.Name}";
            // 
            // Label_Player_Count_Title
            // 
            this.Label_Player_Count_Title.AutoSize = true;
            this.Label_Player_Count_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Player_Count_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Player_Count_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Player_Count_Title.Location = new System.Drawing.Point(274, 97);
            this.Label_Player_Count_Title.Name = "Label_Player_Count_Title";
            this.Label_Player_Count_Title.Size = new System.Drawing.Size(117, 22);
            this.Label_Player_Count_Title.TabIndex = 82;
            this.Label_Player_Count_Title.Text = "Player Count: ";
            // 
            // Label_Release_Title
            // 
            this.Label_Release_Title.AutoSize = true;
            this.Label_Release_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Release_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Release_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Release_Title.Location = new System.Drawing.Point(274, 67);
            this.Label_Release_Title.Name = "Label_Release_Title";
            this.Label_Release_Title.Size = new System.Drawing.Size(113, 22);
            this.Label_Release_Title.TabIndex = 83;
            this.Label_Release_Title.Text = "Release Date:";
            // 
            // Label_IRT_Title
            // 
            this.Label_IRT_Title.AutoSize = true;
            this.Label_IRT_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_IRT_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_IRT_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold);
            this.Label_IRT_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_IRT_Title.Location = new System.Drawing.Point(13, 115);
            this.Label_IRT_Title.Name = "Label_IRT_Title";
            this.Label_IRT_Title.Size = new System.Drawing.Size(86, 22);
            this.Label_IRT_Title.TabIndex = 87;
            this.Label_IRT_Title.Text = "IRT Price: ";
            // 
            // ComboBox_Editions
            // 
            this.ComboBox_Editions.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Editions.BackgroundColor = System.Drawing.Color.White;
            this.ComboBox_Editions.BorderColor = System.Drawing.Color.White;
            this.ComboBox_Editions.BorderRadius = 0;
            this.ComboBox_Editions.Color = System.Drawing.Color.White;
            this.ComboBox_Editions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_Editions.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ComboBox_Editions.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboBox_Editions.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ComboBox_Editions.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboBox_Editions.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ComboBox_Editions.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ComboBox_Editions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Editions.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ComboBox_Editions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Editions.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ComboBox_Editions.DropDownWidth = 250;
            this.ComboBox_Editions.FillDropDown = true;
            this.ComboBox_Editions.FillIndicator = false;
            this.ComboBox_Editions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Editions.Font = new System.Drawing.Font("Motiva Sans", 11.25F);
            this.ComboBox_Editions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ComboBox_Editions.FormattingEnabled = true;
            this.ComboBox_Editions.Icon = null;
            this.ComboBox_Editions.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ComboBox_Editions.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.ComboBox_Editions.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ComboBox_Editions.ItemBackColor = System.Drawing.Color.White;
            this.ComboBox_Editions.ItemBorderColor = System.Drawing.Color.White;
            this.ComboBox_Editions.ItemForeColor = System.Drawing.Color.Black;
            this.ComboBox_Editions.ItemHeight = 26;
            this.ComboBox_Editions.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ComboBox_Editions.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ComboBox_Editions.ItemTopMargin = 3;
            this.ComboBox_Editions.Location = new System.Drawing.Point(70, 22);
            this.ComboBox_Editions.MaxLength = 15;
            this.ComboBox_Editions.Name = "ComboBox_Editions";
            this.ComboBox_Editions.Size = new System.Drawing.Size(302, 32);
            this.ComboBox_Editions.TabIndex = 88;
            this.ComboBox_Editions.Text = "Change Edition";
            this.ComboBox_Editions.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ComboBox_Editions.TextLeftMargin = 5;
            this.ComboBox_Editions.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Editions_SelectedIndexChanged);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Label_DLC_TItle
            // 
            this.Label_DLC_TItle.AutoSize = true;
            this.Label_DLC_TItle.BackColor = System.Drawing.Color.Transparent;
            this.Label_DLC_TItle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_DLC_TItle.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DLC_TItle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_DLC_TItle.Location = new System.Drawing.Point(274, 37);
            this.Label_DLC_TItle.Name = "Label_DLC_TItle";
            this.Label_DLC_TItle.Size = new System.Drawing.Size(50, 22);
            this.Label_DLC_TItle.TabIndex = 89;
            this.Label_DLC_TItle.Text = "DLC: ";
            // 
            // Label_Edition_Title
            // 
            this.Label_Edition_Title.AutoSize = true;
            this.Label_Edition_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Edition_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Edition_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Edition_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Edition_Title.Location = new System.Drawing.Point(4, 25);
            this.Label_Edition_Title.Name = "Label_Edition_Title";
            this.Label_Edition_Title.Size = new System.Drawing.Size(69, 22);
            this.Label_Edition_Title.TabIndex = 90;
            this.Label_Edition_Title.Text = "Edition:";
            // 
            // DropDownRegion
            // 
            this.DropDownRegion.BackColor = System.Drawing.Color.Transparent;
            this.DropDownRegion.BackgroundColor = System.Drawing.Color.White;
            this.DropDownRegion.BorderColor = System.Drawing.Color.White;
            this.DropDownRegion.BorderRadius = 0;
            this.DropDownRegion.Color = System.Drawing.Color.White;
            this.DropDownRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownRegion.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownRegion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownRegion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownRegion.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownRegion.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownRegion.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownRegion.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownRegion.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownRegion.FillDropDown = true;
            this.DropDownRegion.FillIndicator = false;
            this.DropDownRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownRegion.Font = new System.Drawing.Font("Motiva Sans", 11.25F);
            this.DropDownRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DropDownRegion.FormattingEnabled = true;
            this.DropDownRegion.Icon = null;
            this.DropDownRegion.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownRegion.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DropDownRegion.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownRegion.ItemBackColor = System.Drawing.Color.White;
            this.DropDownRegion.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownRegion.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownRegion.ItemHeight = 26;
            this.DropDownRegion.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownRegion.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownRegion.Items.AddRange(new object[] {
            "United States",
            "Britain",
            "Europe",
            "China",
            "Argentina (LATAM)",
            "Turkey (MENA)",
            "Russia ",
            "Brazil",
            "Ukraine",
            "India",
            "Kazakhstan",
            "Philippines",
            "CIS - USD",
            "South Asia - USD"});
            this.DropDownRegion.ItemTopMargin = 3;
            this.DropDownRegion.Location = new System.Drawing.Point(196, 54);
            this.DropDownRegion.Name = "DropDownRegion";
            this.DropDownRegion.Size = new System.Drawing.Size(176, 32);
            this.DropDownRegion.TabIndex = 91;
            this.DropDownRegion.Text = "Region";
            this.DropDownRegion.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownRegion.TextLeftMargin = 5;
            this.DropDownRegion.SelectedIndexChanged += new System.EventHandler(this.DropDownRegion_SelectedIndexChanged);
            // 
            // Label_DLC
            // 
            this.Label_DLC.AutoSize = true;
            this.Label_DLC.BackColor = System.Drawing.Color.Transparent;
            this.Label_DLC.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_DLC.Font = new System.Drawing.Font("Motiva Sans", 11.25F);
            this.Label_DLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_DLC.Location = new System.Drawing.Point(313, 37);
            this.Label_DLC.Name = "Label_DLC";
            this.Label_DLC.Size = new System.Drawing.Size(68, 21);
            this.Label_DLC.TabIndex = 97;
            this.Label_DLC.Text = "{UI.DLC}";
            this.Label_DLC.Click += new System.EventHandler(this.Label_DLC_Click);
            // 
            // Label_Release
            // 
            this.Label_Release.AutoSize = true;
            this.Label_Release.BackColor = System.Drawing.Color.Transparent;
            this.Label_Release.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Release.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Release.Location = new System.Drawing.Point(382, 67);
            this.Label_Release.Name = "Label_Release";
            this.Label_Release.Size = new System.Drawing.Size(130, 21);
            this.Label_Release.TabIndex = 93;
            this.Label_Release.Text = "{UI.ReleaseDate}";
            // 
            // Label_Player_Count
            // 
            this.Label_Player_Count.AutoSize = true;
            this.Label_Player_Count.BackColor = System.Drawing.Color.Transparent;
            this.Label_Player_Count.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Player_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Player_Count.Location = new System.Drawing.Point(381, 97);
            this.Label_Player_Count.Name = "Label_Player_Count";
            this.Label_Player_Count.Size = new System.Drawing.Size(128, 21);
            this.Label_Player_Count.TabIndex = 92;
            this.Label_Player_Count.Text = "{UI.PlayerCount}";
            // 
            // Label_IRT
            // 
            this.Label_IRT.AutoSize = true;
            this.Label_IRT.BackColor = System.Drawing.Color.Transparent;
            this.Label_IRT.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_IRT.Font = new System.Drawing.Font("Motiva Sans", 11.25F);
            this.Label_IRT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_IRT.Location = new System.Drawing.Point(92, 116);
            this.Label_IRT.Name = "Label_IRT";
            this.Label_IRT.Size = new System.Drawing.Size(64, 21);
            this.Label_IRT.TabIndex = 101;
            this.Label_IRT.Text = "{UI.IRT}";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.BackColor = System.Drawing.Color.Transparent;
            this.Label_Price.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Price.Font = new System.Drawing.Font("Motiva Sans", 11.25F);
            this.Label_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Price.Location = new System.Drawing.Point(59, 58);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(77, 21);
            this.Label_Price.TabIndex = 99;
            this.Label_Price.Text = "{UI.Price}";
            // 
            // Label_KeyCount
            // 
            this.Label_KeyCount.AutoSize = true;
            this.Label_KeyCount.BackColor = System.Drawing.Color.Transparent;
            this.Label_KeyCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_KeyCount.Font = new System.Drawing.Font("Motiva Sans", 11.25F);
            this.Label_KeyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_KeyCount.Location = new System.Drawing.Point(110, 86);
            this.Label_KeyCount.Name = "Label_KeyCount";
            this.Label_KeyCount.Size = new System.Drawing.Size(111, 21);
            this.Label_KeyCount.TabIndex = 100;
            this.Label_KeyCount.Text = "{UI.KeyCount}";
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // LabelOwned
            // 
            this.LabelOwned.AutoSize = true;
            this.LabelOwned.BackColor = System.Drawing.Color.Transparent;
            this.LabelOwned.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold);
            this.LabelOwned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.LabelOwned.Location = new System.Drawing.Point(302, 221);
            this.LabelOwned.Name = "LabelOwned";
            this.LabelOwned.Size = new System.Drawing.Size(99, 22);
            this.LabelOwned.TabIndex = 74;
            this.LabelOwned.Text = "{UI.Owned}";
            this.LabelOwned.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Elipse2
            // 
            this.Elipse2.ElipseRadius = 20;
            this.Elipse2.TargetControl = this.PictureBox_Image;
            // 
            // PanelPrice
            // 
            this.PanelPrice.Controls.Add(this.ComboBox_Editions);
            this.PanelPrice.Controls.Add(this.Label_IRT);
            this.PanelPrice.Controls.Add(this.Label_Edition_Title);
            this.PanelPrice.Controls.Add(this.Label_IRT_Title);
            this.PanelPrice.Controls.Add(this.Label_KeyCount_Title);
            this.PanelPrice.Controls.Add(this.Label_Price);
            this.PanelPrice.Controls.Add(this.Label_Price_Title);
            this.PanelPrice.Controls.Add(this.Label_KeyCount);
            this.PanelPrice.Controls.Add(this.bunifuSeparator1);
            this.PanelPrice.Controls.Add(this.DropDownRegion);
            this.PanelPrice.Location = new System.Drawing.Point(261, 241);
            this.PanelPrice.Name = "PanelPrice";
            this.PanelPrice.Size = new System.Drawing.Size(380, 150);
            this.PanelPrice.TabIndex = 103;
            // 
            // Label_Dev_Title
            // 
            this.Label_Dev_Title.AutoSize = true;
            this.Label_Dev_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Dev_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dev_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Dev_Title.Location = new System.Drawing.Point(274, 127);
            this.Label_Dev_Title.Name = "Label_Dev_Title";
            this.Label_Dev_Title.Size = new System.Drawing.Size(86, 22);
            this.Label_Dev_Title.TabIndex = 84;
            this.Label_Dev_Title.Text = "Develoer: ";
            // 
            // Label_Publisher_Title
            // 
            this.Label_Publisher_Title.AutoSize = true;
            this.Label_Publisher_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Publisher_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Publisher_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Publisher_Title.Location = new System.Drawing.Point(274, 157);
            this.Label_Publisher_Title.Name = "Label_Publisher_Title";
            this.Label_Publisher_Title.Size = new System.Drawing.Size(90, 22);
            this.Label_Publisher_Title.TabIndex = 85;
            this.Label_Publisher_Title.Text = "Publisher: ";
            // 
            // Label_PlayTime_Title
            // 
            this.Label_PlayTime_Title.AutoSize = true;
            this.Label_PlayTime_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_PlayTime_Title.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PlayTime_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_PlayTime_Title.Location = new System.Drawing.Point(274, 187);
            this.Label_PlayTime_Title.Name = "Label_PlayTime_Title";
            this.Label_PlayTime_Title.Size = new System.Drawing.Size(126, 22);
            this.Label_PlayTime_Title.TabIndex = 86;
            this.Label_PlayTime_Title.Text = "Your PlayTime: ";
            this.Label_PlayTime_Title.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label_Dev
            // 
            this.Label_Dev.AutoSize = true;
            this.Label_Dev.BackColor = System.Drawing.Color.Transparent;
            this.Label_Dev.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Dev.Location = new System.Drawing.Point(353, 127);
            this.Label_Dev.Name = "Label_Dev";
            this.Label_Dev.Size = new System.Drawing.Size(105, 21);
            this.Label_Dev.TabIndex = 94;
            this.Label_Dev.Text = "{UI.Develoer}";
            // 
            // Label_Publisher
            // 
            this.Label_Publisher.AutoSize = true;
            this.Label_Publisher.BackColor = System.Drawing.Color.Transparent;
            this.Label_Publisher.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Publisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Publisher.Location = new System.Drawing.Point(355, 157);
            this.Label_Publisher.Name = "Label_Publisher";
            this.Label_Publisher.Size = new System.Drawing.Size(107, 21);
            this.Label_Publisher.TabIndex = 95;
            this.Label_Publisher.Text = "{UI.Publisher}";
            // 
            // Label_PlayTime
            // 
            this.Label_PlayTime.AutoSize = true;
            this.Label_PlayTime.BackColor = System.Drawing.Color.Transparent;
            this.Label_PlayTime.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PlayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_PlayTime.Location = new System.Drawing.Point(390, 187);
            this.Label_PlayTime.Name = "Label_PlayTime";
            this.Label_PlayTime.Size = new System.Drawing.Size(104, 21);
            this.Label_PlayTime.TabIndex = 96;
            this.Label_PlayTime.Text = "{UI.PlayTime}";
            this.Label_PlayTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Panel_BaseGame
            // 
            this.Panel_BaseGame.Controls.Add(this.PictureBoxBaseGame);
            this.Panel_BaseGame.Controls.Add(this.Label_BaseGame);
            this.Panel_BaseGame.Location = new System.Drawing.Point(261, 127);
            this.Panel_BaseGame.Name = "Panel_BaseGame";
            this.Panel_BaseGame.Size = new System.Drawing.Size(1, 1);
            this.Panel_BaseGame.TabIndex = 104;
            this.Panel_BaseGame.Visible = false;
            // 
            // Label_BaseGame
            // 
            this.Label_BaseGame.AutoSize = true;
            this.Label_BaseGame.BackColor = System.Drawing.Color.Transparent;
            this.Label_BaseGame.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BaseGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_BaseGame.Location = new System.Drawing.Point(13, 30);
            this.Label_BaseGame.Name = "Label_BaseGame";
            this.Label_BaseGame.Size = new System.Drawing.Size(100, 22);
            this.Label_BaseGame.TabIndex = 105;
            this.Label_BaseGame.Text = "Base Game:";
            // 
            // PictureBoxBaseGame
            // 
            this.PictureBoxBaseGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBaseGame.Location = new System.Drawing.Point(125, 6);
            this.PictureBoxBaseGame.Name = "PictureBoxBaseGame";
            this.PictureBoxBaseGame.Size = new System.Drawing.Size(184, 69);
            this.PictureBoxBaseGame.TabIndex = 106;
            this.PictureBoxBaseGame.TabStop = false;
            this.PictureBoxBaseGame.Click += new System.EventHandler(this.PictureBoxBaseGame_Click);
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackgroundColor = System.Drawing.Color.Transparent;
            this.PanelStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelStatus.BackgroundImage")));
            this.PanelStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelStatus.BorderColor = System.Drawing.Color.Transparent;
            this.PanelStatus.BorderRadius = 3;
            this.PanelStatus.BorderThickness = 1;
            this.PanelStatus.Controls.Add(this.Label_Status);
            this.PanelStatus.Controls.Add(this.PictureBoxLoading);
            this.PanelStatus.Location = new System.Drawing.Point(15, 10);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.ShowBorders = true;
            this.PanelStatus.Size = new System.Drawing.Size(1, 1);
            this.PanelStatus.TabIndex = 102;
            // 
            // Label_Status
            // 
            this.Label_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label_Status.Font = new System.Drawing.Font("Motiva Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status.Location = new System.Drawing.Point(0, -26);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(1, 27);
            this.Label_Status.TabIndex = 4;
            this.Label_Status.Text = "{Status}";
            this.Label_Status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBoxLoading
            // 
            this.PictureBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLoading.Image")));
            this.PictureBoxLoading.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxLoading.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.PictureBoxLoading.Name = "PictureBoxLoading";
            this.PictureBoxLoading.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.PictureBoxLoading.Size = new System.Drawing.Size(1, 1);
            this.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxLoading.TabIndex = 3;
            this.PictureBoxLoading.TabStop = false;
            // 
            // OpenPCGWIcon
            // 
            this.OpenPCGWIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenPCGWIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenPCGWIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPCGWIcon.Image = global::SteamPulse.Properties.Resources.pcgw_logo;
            this.OpenPCGWIcon.Location = new System.Drawing.Point(528, 423);
            this.OpenPCGWIcon.Name = "OpenPCGWIcon";
            this.OpenPCGWIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenPCGWIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenPCGWIcon.TabIndex = 81;
            this.OpenPCGWIcon.TabStop = false;
            this.OpenPCGWIcon.Click += new System.EventHandler(this.OpenPCGW_Click);
            // 
            // OpenSteamDBIcon
            // 
            this.OpenSteamDBIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenSteamDBIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteamDBIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteamDBIcon.Image = global::SteamPulse.Properties.Resources.steamdb_logo;
            this.OpenSteamDBIcon.Location = new System.Drawing.Point(278, 423);
            this.OpenSteamDBIcon.Name = "OpenSteamDBIcon";
            this.OpenSteamDBIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenSteamDBIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenSteamDBIcon.TabIndex = 79;
            this.OpenSteamDBIcon.TabStop = false;
            this.OpenSteamDBIcon.Click += new System.EventHandler(this.OpenSteamDB_Click);
            // 
            // OpenSteamIcon
            // 
            this.OpenSteamIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenSteamIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenSteamIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSteamIcon.Image = global::SteamPulse.Properties.Resources.Steam_icon;
            this.OpenSteamIcon.Location = new System.Drawing.Point(15, 423);
            this.OpenSteamIcon.Name = "OpenSteamIcon";
            this.OpenSteamIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenSteamIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenSteamIcon.TabIndex = 77;
            this.OpenSteamIcon.TabStop = false;
            this.OpenSteamIcon.Click += new System.EventHandler(this.OpenSteam_Click);
            // 
            // PictureBoxOwned
            // 
            this.PictureBoxOwned.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxOwned.Image = global::SteamPulse.Properties.Resources.check_solid;
            this.PictureBoxOwned.Location = new System.Drawing.Point(274, 221);
            this.PictureBoxOwned.Name = "PictureBoxOwned";
            this.PictureBoxOwned.Size = new System.Drawing.Size(22, 22);
            this.PictureBoxOwned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxOwned.TabIndex = 75;
            this.PictureBoxOwned.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(15, 392);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(618, 14);
            this.bunifuSeparator2.TabIndex = 73;
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Location = new System.Drawing.Point(17, 11);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(243, 366);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 71;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.Click += new System.EventHandler(this.PictureBox_Image_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(348, 17);
            this.bunifuSeparator1.TabIndex = 72;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel_BaseGame);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.Label_DLC);
            this.Controls.Add(this.Label_PlayTime);
            this.Controls.Add(this.Label_Publisher);
            this.Controls.Add(this.Label_Dev);
            this.Controls.Add(this.Label_Release);
            this.Controls.Add(this.Label_Player_Count);
            this.Controls.Add(this.Label_DLC_TItle);
            this.Controls.Add(this.Label_PlayTime_Title);
            this.Controls.Add(this.Label_Publisher_Title);
            this.Controls.Add(this.Label_Dev_Title);
            this.Controls.Add(this.Label_Release_Title);
            this.Controls.Add(this.Label_Player_Count_Title);
            this.Controls.Add(this.OpenPCGWIcon);
            this.Controls.Add(this.OpenPCGW);
            this.Controls.Add(this.OpenSteamDBIcon);
            this.Controls.Add(this.OpenSteamDB);
            this.Controls.Add(this.OpenSteamIcon);
            this.Controls.Add(this.OpenSteam);
            this.Controls.Add(this.PictureBoxOwned);
            this.Controls.Add(this.LabelOwned);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.PictureBox_Image);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PanelPrice);
            this.Name = "Data";
            this.Size = new System.Drawing.Size(644, 468);
            this.Load += new System.EventHandler(this.Data_Load);
            this.PanelPrice.ResumeLayout(false);
            this.PanelPrice.PerformLayout();
            this.Panel_BaseGame.ResumeLayout(false);
            this.Panel_BaseGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBaseGame)).EndInit();
            this.PanelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenPCGWIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamDBIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSteamIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOwned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_KeyCount_Title;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox PictureBoxOwned;
        private System.Windows.Forms.Label LabelOwned;
        private System.Windows.Forms.PictureBox OpenPCGWIcon;
        private System.Windows.Forms.Label OpenPCGW;
        private System.Windows.Forms.PictureBox OpenSteamDBIcon;
        private System.Windows.Forms.Label OpenSteamDB;
        private System.Windows.Forms.PictureBox OpenSteamIcon;
        private System.Windows.Forms.Label OpenSteam;
        private System.Windows.Forms.Label Label_Price_Title;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label Label_Player_Count_Title;
        private System.Windows.Forms.Label Label_Release_Title;
        private System.Windows.Forms.Label Label_IRT_Title;
        private Bunifu.UI.WinForms.BunifuDropdown ComboBox_Editions;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label Label_DLC_TItle;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownRegion;
        private System.Windows.Forms.Label Label_Edition_Title;
        private System.Windows.Forms.Label Label_DLC;
        private System.Windows.Forms.Label Label_Release;
        private System.Windows.Forms.Label Label_Player_Count;
        private System.Windows.Forms.Label Label_IRT;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_KeyCount;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Bunifu.UI.WinForms.BunifuPanel PanelStatus;
        private System.Windows.Forms.PictureBox PictureBoxLoading;
        private Bunifu.Framework.UI.BunifuElipse Elipse2;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Panel PanelPrice;
        private System.Windows.Forms.Panel Panel_BaseGame;
        private System.Windows.Forms.PictureBox PictureBoxBaseGame;
        private System.Windows.Forms.Label Label_BaseGame;
        private System.Windows.Forms.Label Label_PlayTime;
        private System.Windows.Forms.Label Label_Publisher;
        private System.Windows.Forms.Label Label_Dev;
        private System.Windows.Forms.Label Label_PlayTime_Title;
        private System.Windows.Forms.Label Label_Publisher_Title;
        private System.Windows.Forms.Label Label_Dev_Title;
    }
}
