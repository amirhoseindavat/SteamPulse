namespace SteamPulse
{
    partial class DLCBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLCBrowser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelLowded = new System.Windows.Forms.Label();
            this.LabelSum = new System.Windows.Forms.Label();
            this.DataTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irtprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PanelMain.BackgroundColor = System.Drawing.Color.White;
            this.PanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMain.BackgroundImage")));
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMain.BorderColor = System.Drawing.Color.Transparent;
            this.PanelMain.BorderRadius = 20;
            this.PanelMain.BorderThickness = 1;
            this.PanelMain.Controls.Add(this.LabelLowded);
            this.PanelMain.Controls.Add(this.LabelSum);
            this.PanelMain.Controls.Add(this.DataTable);
            this.PanelMain.Controls.Add(this.LabelName);
            this.PanelMain.Location = new System.Drawing.Point(13, 51);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.ShowBorders = true;
            this.PanelMain.Size = new System.Drawing.Size(860, 396);
            this.PanelMain.TabIndex = 33;
            // 
            // LabelLowded
            // 
            this.LabelLowded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLowded.AutoSize = true;
            this.LabelLowded.BackColor = System.Drawing.Color.Transparent;
            this.LabelLowded.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.LabelLowded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelLowded.Location = new System.Drawing.Point(747, 350);
            this.LabelLowded.Name = "LabelLowded";
            this.LabelLowded.Size = new System.Drawing.Size(89, 28);
            this.LabelLowded.TabIndex = 4;
            this.LabelLowded.Text = "{UI.Load}";
            this.LabelLowded.Visible = false;
            // 
            // LabelSum
            // 
            this.LabelSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelSum.AutoSize = true;
            this.LabelSum.BackColor = System.Drawing.Color.Transparent;
            this.LabelSum.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.LabelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelSum.Location = new System.Drawing.Point(13, 350);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(87, 28);
            this.LabelSum.TabIndex = 3;
            this.LabelSum.Text = "{UI.Sum}";
            this.LabelSum.Visible = false;
            // 
            // DataTable
            // 
            this.DataTable.AllowCustomTheming = true;
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToResizeColumns = false;
            this.DataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeight = 40;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.name,
            this.price,
            this.irtprice});
            this.DataTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(56)))), ((int)(((byte)(94)))));
            this.DataTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.DataTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataTable.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DataTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DataTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.DataTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DataTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataTable.CurrentTheme.Name = null;
            this.DataTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(99)))));
            this.DataTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.DataTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DataTable.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.DataTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataTable.HeaderForeColor = System.Drawing.Color.White;
            this.DataTable.Location = new System.Drawing.Point(18, 45);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            this.DataTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataTable.RowTemplate.DividerHeight = 1;
            this.DataTable.RowTemplate.Height = 40;
            this.DataTable.RowTemplate.ReadOnly = true;
            this.DataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(818, 302);
            this.DataTable.TabIndex = 0;
            this.DataTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.Image = global::SteamPulse.Properties.Resources.header2;
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // irtprice
            // 
            this.irtprice.HeaderText = "Price IRT";
            this.irtprice.Name = "irtprice";
            this.irtprice.ReadOnly = true;
            this.irtprice.Visible = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelName.Location = new System.Drawing.Point(13, 14);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(99, 28);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "{UI.Name}";
            this.LabelName.Visible = false;
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
            this.PanelHeader.Controls.Add(this.Exit);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(898, 35);
            this.PanelHeader.TabIndex = 37;
            this.PanelHeader.Click += new System.EventHandler(this.PanelHeader_Click);
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // Label_AppName
            // 
            this.Label_AppName.AutoSize = true;
            this.Label_AppName.BackColor = System.Drawing.Color.Transparent;
            this.Label_AppName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.Label_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_AppName.Location = new System.Drawing.Point(7, 2);
            this.Label_AppName.Name = "Label_AppName";
            this.Label_AppName.Size = new System.Drawing.Size(130, 31);
            this.Label_AppName.TabIndex = 15;
            this.Label_AppName.Text = "DLC Browser";
            // 
            // Exit
            // 
            this.Exit.AllowAnimations = true;
            this.Exit.AllowMouseEffects = true;
            this.Exit.AllowToggling = false;
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exit.AnimationSpeed = 200;
            this.Exit.AutoGenerateColors = false;
            this.Exit.AutoRoundBorders = false;
            this.Exit.AutoSizeLeftIcon = true;
            this.Exit.AutoSizeRightIcon = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.ButtonText = "";
            this.Exit.ButtonTextMarginLeft = 0;
            this.Exit.ColorContrastOnClick = 45;
            this.Exit.ColorContrastOnHover = 45;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Exit.CustomizableEdges = borderEdges1;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Exit.IconMarginLeft = 11;
            this.Exit.IconPadding = 10;
            this.Exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Exit.IconSize = 25;
            this.Exit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.IdleBorderRadius = 15;
            this.Exit.IdleBorderThickness = 1;
            this.Exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.IdleIconLeftImage = null;
            this.Exit.IdleIconRightImage = null;
            this.Exit.IndicateFocus = false;
            this.Exit.Location = new System.Drawing.Point(871, 9);
            this.Exit.Name = "Exit";
            this.Exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Exit.OnDisabledState.BorderRadius = 15;
            this.Exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.OnDisabledState.BorderThickness = 1;
            this.Exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Exit.OnDisabledState.IconLeftImage = null;
            this.Exit.OnDisabledState.IconRightImage = null;
            this.Exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Exit.onHoverState.BorderRadius = 15;
            this.Exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.onHoverState.BorderThickness = 1;
            this.Exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.Exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Exit.onHoverState.IconLeftImage = null;
            this.Exit.onHoverState.IconRightImage = null;
            this.Exit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.OnIdleState.BorderRadius = 15;
            this.Exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.OnIdleState.BorderThickness = 1;
            this.Exit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.Exit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Exit.OnIdleState.IconLeftImage = null;
            this.Exit.OnIdleState.IconRightImage = null;
            this.Exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Exit.OnPressedState.BorderRadius = 15;
            this.Exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit.OnPressedState.BorderThickness = 1;
            this.Exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.Exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Exit.OnPressedState.IconLeftImage = null;
            this.Exit.OnPressedState.IconRightImage = null;
            this.Exit.Size = new System.Drawing.Size(15, 15);
            this.Exit.TabIndex = 32;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit.TextMarginLeft = 0;
            this.Exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exit.UseDefaultRadiusAndThickness = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // DLCBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(898, 465);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DLCBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DLC";
            this.Load += new System.EventHandler(this.DLC_Load);
            this.Resize += new System.EventHandler(this.DLC_Resize);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuDataGridView DataTable;
        private System.Windows.Forms.Label LabelName;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exit;
        private Bunifu.UI.WinForms.BunifuPanel PanelMain;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Label LabelLowded;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn irtprice;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
    }
}