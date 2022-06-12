namespace SteamPulse
{
    partial class DevSetting
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState4 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState5 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState6 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevSetting));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LabelHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.PanelImprove = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelImprove = new Bunifu.UI.WinForms.BunifuLabel();
            this.ToggleImprove = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.PanelCalc = new Bunifu.UI.WinForms.BunifuPanel();
            this.DropDownCalc = new Bunifu.UI.WinForms.BunifuDropdown();
            this.LabelCalc = new Bunifu.UI.WinForms.BunifuLabel();
            this.PanelRemain = new Bunifu.UI.WinForms.BunifuPanel();
            this.CalcRemaining = new Bunifu.UI.WinForms.BunifuLabel();
            this.ToggleRemain = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.PanelDLC = new Bunifu.UI.WinForms.BunifuPanel();
            this.DropDownDLC = new Bunifu.UI.WinForms.BunifuDropdown();
            this.DLCCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.PanelItemCalc = new Bunifu.UI.WinForms.BunifuPanel();
            this.DropDownItemCalc = new Bunifu.UI.WinForms.BunifuDropdown();
            this.LabelItemCalc = new Bunifu.UI.WinForms.BunifuLabel();
            this.PanelHeader.SuspendLayout();
            this.PanelImprove.SuspendLayout();
            this.PanelCalc.SuspendLayout();
            this.PanelRemain.SuspendLayout();
            this.PanelDLC.SuspendLayout();
            this.PanelItemCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 20;
            this.bunifuElipse.TargetControl = this;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundColor = System.Drawing.Color.White;
            this.PanelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHeader.BackgroundImage")));
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderRadius = 3;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.ButtonExit);
            this.PanelHeader.Controls.Add(this.LabelHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(409, 35);
            this.PanelHeader.TabIndex = 10;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.AllowAnimations = true;
            this.ButtonExit.AllowMouseEffects = true;
            this.ButtonExit.AllowToggling = false;
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ButtonExit.Location = new System.Drawing.Point(383, 10);
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
            this.ButtonExit.TabIndex = 34;
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonExit.TextMarginLeft = 0;
            this.ButtonExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonExit.UseDefaultRadiusAndThickness = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.AllowParentOverrides = false;
            this.LabelHeader.AutoEllipsis = false;
            this.LabelHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHeader.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelHeader.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelHeader.Location = new System.Drawing.Point(12, 3);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelHeader.Size = new System.Drawing.Size(163, 30);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Developer Settings";
            this.LabelHeader.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelHeader.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.LabelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // PanelImprove
            // 
            this.PanelImprove.BackgroundColor = System.Drawing.Color.White;
            this.PanelImprove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelImprove.BackgroundImage")));
            this.PanelImprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelImprove.BorderColor = System.Drawing.Color.Transparent;
            this.PanelImprove.BorderRadius = 20;
            this.PanelImprove.BorderThickness = 1;
            this.PanelImprove.Controls.Add(this.LabelImprove);
            this.PanelImprove.Controls.Add(this.ToggleImprove);
            this.PanelImprove.Location = new System.Drawing.Point(14, 50);
            this.PanelImprove.Name = "PanelImprove";
            this.PanelImprove.ShowBorders = true;
            this.PanelImprove.Size = new System.Drawing.Size(378, 50);
            this.PanelImprove.TabIndex = 35;
            // 
            // LabelImprove
            // 
            this.LabelImprove.AllowParentOverrides = false;
            this.LabelImprove.AutoEllipsis = false;
            this.LabelImprove.CursorType = null;
            this.LabelImprove.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelImprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelImprove.Location = new System.Drawing.Point(15, 11);
            this.LabelImprove.Name = "LabelImprove";
            this.LabelImprove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelImprove.Size = new System.Drawing.Size(141, 30);
            this.LabelImprove.TabIndex = 5;
            this.LabelImprove.Text = "Load DLC Image";
            this.LabelImprove.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelImprove.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ToggleImprove
            // 
            this.ToggleImprove.Animation = 5;
            this.ToggleImprove.BackColor = System.Drawing.Color.Transparent;
            this.ToggleImprove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToggleImprove.BackgroundImage")));
            this.ToggleImprove.Checked = false;
            this.ToggleImprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleImprove.InnerCirclePadding = 3;
            this.ToggleImprove.Location = new System.Drawing.Point(329, 16);
            this.ToggleImprove.Name = "ToggleImprove";
            this.ToggleImprove.Size = new System.Drawing.Size(32, 18);
            this.ToggleImprove.TabIndex = 4;
            this.ToggleImprove.ThumbMargin = 3;
            toggleState4.BackColor = System.Drawing.Color.DarkGray;
            toggleState4.BackColorInner = System.Drawing.Color.White;
            toggleState4.BorderColor = System.Drawing.Color.DarkGray;
            toggleState4.BorderColorInner = System.Drawing.Color.White;
            toggleState4.BorderRadius = 17;
            toggleState4.BorderRadiusInner = 11;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.ToggleImprove.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 11;
            toggleState5.BorderThickness = 1;
            toggleState5.BorderThicknessInner = 1;
            this.ToggleImprove.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 11;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.ToggleImprove.ToggleStateOn = toggleState6;
            this.ToggleImprove.Value = false;
            this.ToggleImprove.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.ToggleImprove_CheckedChanged);
            // 
            // PanelCalc
            // 
            this.PanelCalc.BackgroundColor = System.Drawing.Color.White;
            this.PanelCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCalc.BackgroundImage")));
            this.PanelCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCalc.BorderColor = System.Drawing.Color.Transparent;
            this.PanelCalc.BorderRadius = 20;
            this.PanelCalc.BorderThickness = 1;
            this.PanelCalc.Controls.Add(this.DropDownCalc);
            this.PanelCalc.Controls.Add(this.LabelCalc);
            this.PanelCalc.Location = new System.Drawing.Point(12, 330);
            this.PanelCalc.Name = "PanelCalc";
            this.PanelCalc.ShowBorders = true;
            this.PanelCalc.Size = new System.Drawing.Size(378, 50);
            this.PanelCalc.TabIndex = 36;
            // 
            // DropDownCalc
            // 
            this.DropDownCalc.BackColor = System.Drawing.Color.Transparent;
            this.DropDownCalc.BackgroundColor = System.Drawing.Color.White;
            this.DropDownCalc.BorderColor = System.Drawing.Color.Silver;
            this.DropDownCalc.BorderRadius = 5;
            this.DropDownCalc.Color = System.Drawing.Color.Silver;
            this.DropDownCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownCalc.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownCalc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownCalc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownCalc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownCalc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownCalc.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownCalc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownCalc.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownCalc.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownCalc.FillDropDown = true;
            this.DropDownCalc.FillIndicator = false;
            this.DropDownCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownCalc.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.DropDownCalc.ForeColor = System.Drawing.Color.Black;
            this.DropDownCalc.FormattingEnabled = true;
            this.DropDownCalc.Icon = null;
            this.DropDownCalc.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownCalc.IndicatorColor = System.Drawing.Color.Gray;
            this.DropDownCalc.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownCalc.ItemBackColor = System.Drawing.Color.White;
            this.DropDownCalc.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownCalc.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownCalc.ItemHeight = 26;
            this.DropDownCalc.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownCalc.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownCalc.Items.AddRange(new object[] {
            "Rounded to Up",
            "Exact Value"});
            this.DropDownCalc.ItemTopMargin = 3;
            this.DropDownCalc.Location = new System.Drawing.Point(236, 10);
            this.DropDownCalc.Name = "DropDownCalc";
            this.DropDownCalc.Size = new System.Drawing.Size(125, 32);
            this.DropDownCalc.TabIndex = 6;
            this.DropDownCalc.Text = null;
            this.DropDownCalc.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownCalc.TextLeftMargin = 5;
            this.DropDownCalc.SelectedIndexChanged += new System.EventHandler(this.DropDownCalc_SelectedIndexChanged);
            // 
            // LabelCalc
            // 
            this.LabelCalc.AllowParentOverrides = false;
            this.LabelCalc.AutoEllipsis = false;
            this.LabelCalc.CursorType = null;
            this.LabelCalc.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelCalc.Location = new System.Drawing.Point(15, 11);
            this.LabelCalc.Name = "LabelCalc";
            this.LabelCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCalc.Size = new System.Drawing.Size(192, 30);
            this.LabelCalc.TabIndex = 5;
            this.LabelCalc.Text = "Key Calculation Mode ";
            this.LabelCalc.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelCalc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PanelRemain
            // 
            this.PanelRemain.BackgroundColor = System.Drawing.Color.White;
            this.PanelRemain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelRemain.BackgroundImage")));
            this.PanelRemain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelRemain.BorderColor = System.Drawing.Color.Transparent;
            this.PanelRemain.BorderRadius = 20;
            this.PanelRemain.BorderThickness = 1;
            this.PanelRemain.Controls.Add(this.CalcRemaining);
            this.PanelRemain.Controls.Add(this.ToggleRemain);
            this.PanelRemain.Location = new System.Drawing.Point(12, 120);
            this.PanelRemain.Name = "PanelRemain";
            this.PanelRemain.ShowBorders = true;
            this.PanelRemain.Size = new System.Drawing.Size(378, 50);
            this.PanelRemain.TabIndex = 36;
            // 
            // CalcRemaining
            // 
            this.CalcRemaining.AllowParentOverrides = false;
            this.CalcRemaining.AutoEllipsis = false;
            this.CalcRemaining.CursorType = null;
            this.CalcRemaining.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.CalcRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.CalcRemaining.Location = new System.Drawing.Point(15, 11);
            this.CalcRemaining.Name = "CalcRemaining";
            this.CalcRemaining.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CalcRemaining.Size = new System.Drawing.Size(245, 30);
            this.CalcRemaining.TabIndex = 5;
            this.CalcRemaining.Text = "Calculate Remaining Wallet";
            this.CalcRemaining.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CalcRemaining.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ToggleRemain
            // 
            this.ToggleRemain.Animation = 5;
            this.ToggleRemain.BackColor = System.Drawing.Color.Transparent;
            this.ToggleRemain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToggleRemain.BackgroundImage")));
            this.ToggleRemain.Checked = false;
            this.ToggleRemain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleRemain.InnerCirclePadding = 3;
            this.ToggleRemain.Location = new System.Drawing.Point(329, 16);
            this.ToggleRemain.Name = "ToggleRemain";
            this.ToggleRemain.Size = new System.Drawing.Size(32, 18);
            this.ToggleRemain.TabIndex = 4;
            this.ToggleRemain.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.ToggleRemain.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.ToggleRemain.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.ToggleRemain.ToggleStateOn = toggleState3;
            this.ToggleRemain.Value = false;
            this.ToggleRemain.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.ToggleRemain_CheckedChanged);
            // 
            // PanelDLC
            // 
            this.PanelDLC.BackgroundColor = System.Drawing.Color.White;
            this.PanelDLC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelDLC.BackgroundImage")));
            this.PanelDLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelDLC.BorderColor = System.Drawing.Color.Transparent;
            this.PanelDLC.BorderRadius = 20;
            this.PanelDLC.BorderThickness = 1;
            this.PanelDLC.Controls.Add(this.DropDownDLC);
            this.PanelDLC.Controls.Add(this.DLCCount);
            this.PanelDLC.Location = new System.Drawing.Point(12, 260);
            this.PanelDLC.Name = "PanelDLC";
            this.PanelDLC.ShowBorders = true;
            this.PanelDLC.Size = new System.Drawing.Size(378, 50);
            this.PanelDLC.TabIndex = 37;
            // 
            // DropDownDLC
            // 
            this.DropDownDLC.BackColor = System.Drawing.Color.Transparent;
            this.DropDownDLC.BackgroundColor = System.Drawing.Color.White;
            this.DropDownDLC.BorderColor = System.Drawing.Color.Silver;
            this.DropDownDLC.BorderRadius = 5;
            this.DropDownDLC.Color = System.Drawing.Color.Silver;
            this.DropDownDLC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownDLC.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownDLC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownDLC.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownDLC.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownDLC.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownDLC.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownDLC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownDLC.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownDLC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownDLC.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownDLC.FillDropDown = true;
            this.DropDownDLC.FillIndicator = false;
            this.DropDownDLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownDLC.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.DropDownDLC.ForeColor = System.Drawing.Color.Black;
            this.DropDownDLC.FormattingEnabled = true;
            this.DropDownDLC.Icon = null;
            this.DropDownDLC.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownDLC.IndicatorColor = System.Drawing.Color.Gray;
            this.DropDownDLC.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownDLC.ItemBackColor = System.Drawing.Color.White;
            this.DropDownDLC.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownDLC.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownDLC.ItemHeight = 26;
            this.DropDownDLC.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownDLC.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownDLC.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100",
            "200",
            "500",
            "1000",
            "2000"});
            this.DropDownDLC.ItemTopMargin = 3;
            this.DropDownDLC.Location = new System.Drawing.Point(185, 10);
            this.DropDownDLC.Name = "DropDownDLC";
            this.DropDownDLC.Size = new System.Drawing.Size(176, 32);
            this.DropDownDLC.TabIndex = 6;
            this.DropDownDLC.Text = null;
            this.DropDownDLC.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownDLC.TextLeftMargin = 5;
            this.DropDownDLC.SelectedIndexChanged += new System.EventHandler(this.DropDownDLC_SelectedIndexChanged);
            // 
            // DLCCount
            // 
            this.DLCCount.AllowParentOverrides = false;
            this.DLCCount.AutoEllipsis = false;
            this.DLCCount.CursorType = null;
            this.DLCCount.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.DLCCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.DLCCount.Location = new System.Drawing.Point(15, 11);
            this.DLCCount.Name = "DLCCount";
            this.DLCCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DLCCount.Size = new System.Drawing.Size(155, 30);
            this.DLCCount.TabIndex = 5;
            this.DLCCount.Text = "DLC Loading Limit";
            this.DLCCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DLCCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PanelItemCalc
            // 
            this.PanelItemCalc.BackgroundColor = System.Drawing.Color.White;
            this.PanelItemCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelItemCalc.BackgroundImage")));
            this.PanelItemCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelItemCalc.BorderColor = System.Drawing.Color.Transparent;
            this.PanelItemCalc.BorderRadius = 20;
            this.PanelItemCalc.BorderThickness = 1;
            this.PanelItemCalc.Controls.Add(this.DropDownItemCalc);
            this.PanelItemCalc.Controls.Add(this.LabelItemCalc);
            this.PanelItemCalc.Location = new System.Drawing.Point(12, 190);
            this.PanelItemCalc.Name = "PanelItemCalc";
            this.PanelItemCalc.ShowBorders = true;
            this.PanelItemCalc.Size = new System.Drawing.Size(378, 50);
            this.PanelItemCalc.TabIndex = 37;
            // 
            // DropDownItemCalc
            // 
            this.DropDownItemCalc.BackColor = System.Drawing.Color.Transparent;
            this.DropDownItemCalc.BackgroundColor = System.Drawing.Color.White;
            this.DropDownItemCalc.BorderColor = System.Drawing.Color.Silver;
            this.DropDownItemCalc.BorderRadius = 5;
            this.DropDownItemCalc.Color = System.Drawing.Color.Silver;
            this.DropDownItemCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropDownItemCalc.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropDownItemCalc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownItemCalc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropDownItemCalc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropDownItemCalc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropDownItemCalc.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropDownItemCalc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDownItemCalc.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropDownItemCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownItemCalc.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownItemCalc.FillDropDown = true;
            this.DropDownItemCalc.FillIndicator = false;
            this.DropDownItemCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownItemCalc.Font = new System.Drawing.Font("Poppins Light", 9.75F);
            this.DropDownItemCalc.ForeColor = System.Drawing.Color.Black;
            this.DropDownItemCalc.FormattingEnabled = true;
            this.DropDownItemCalc.Icon = null;
            this.DropDownItemCalc.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownItemCalc.IndicatorColor = System.Drawing.Color.Gray;
            this.DropDownItemCalc.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropDownItemCalc.ItemBackColor = System.Drawing.Color.White;
            this.DropDownItemCalc.ItemBorderColor = System.Drawing.Color.White;
            this.DropDownItemCalc.ItemForeColor = System.Drawing.Color.Black;
            this.DropDownItemCalc.ItemHeight = 26;
            this.DropDownItemCalc.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropDownItemCalc.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropDownItemCalc.Items.AddRange(new object[] {
            "Smart",
            "Key Only"});
            this.DropDownItemCalc.ItemTopMargin = 3;
            this.DropDownItemCalc.Location = new System.Drawing.Point(236, 10);
            this.DropDownItemCalc.Name = "DropDownItemCalc";
            this.DropDownItemCalc.Size = new System.Drawing.Size(125, 32);
            this.DropDownItemCalc.TabIndex = 6;
            this.DropDownItemCalc.Text = null;
            this.DropDownItemCalc.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropDownItemCalc.TextLeftMargin = 5;
            this.DropDownItemCalc.SelectedIndexChanged += new System.EventHandler(this.DropDownItemCalc_SelectedIndexChanged);
            // 
            // LabelItemCalc
            // 
            this.LabelItemCalc.AllowParentOverrides = false;
            this.LabelItemCalc.AutoEllipsis = false;
            this.LabelItemCalc.CursorType = null;
            this.LabelItemCalc.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelItemCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelItemCalc.Location = new System.Drawing.Point(15, 11);
            this.LabelItemCalc.Name = "LabelItemCalc";
            this.LabelItemCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelItemCalc.Size = new System.Drawing.Size(199, 30);
            this.LabelItemCalc.TabIndex = 5;
            this.LabelItemCalc.Text = "Item Calculation Mode ";
            this.LabelItemCalc.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelItemCalc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DevSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(409, 324);
            this.Controls.Add(this.PanelItemCalc);
            this.Controls.Add(this.PanelDLC);
            this.Controls.Add(this.PanelRemain);
            this.Controls.Add(this.PanelCalc);
            this.Controls.Add(this.PanelImprove);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.DevSetting_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelImprove.ResumeLayout(false);
            this.PanelImprove.PerformLayout();
            this.PanelCalc.ResumeLayout(false);
            this.PanelCalc.PerformLayout();
            this.PanelRemain.ResumeLayout(false);
            this.PanelRemain.PerformLayout();
            this.PanelDLC.ResumeLayout(false);
            this.PanelDLC.PerformLayout();
            this.PanelItemCalc.ResumeLayout(false);
            this.PanelItemCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.UI.WinForms.BunifuLabel LabelHeader;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonExit;
        private Bunifu.UI.WinForms.BunifuPanel PanelCalc;
        private Bunifu.UI.WinForms.BunifuLabel LabelCalc;
        private Bunifu.UI.WinForms.BunifuPanel PanelImprove;
        private Bunifu.UI.WinForms.BunifuLabel LabelImprove;
        private Bunifu.UI.WinForms.BunifuToggleSwitch ToggleImprove;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownCalc;
        private Bunifu.UI.WinForms.BunifuPanel PanelRemain;
        private Bunifu.UI.WinForms.BunifuLabel CalcRemaining;
        private Bunifu.UI.WinForms.BunifuToggleSwitch ToggleRemain;
        private Bunifu.UI.WinForms.BunifuPanel PanelDLC;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownDLC;
        private Bunifu.UI.WinForms.BunifuLabel DLCCount;
        private Bunifu.UI.WinForms.BunifuPanel PanelItemCalc;
        private Bunifu.UI.WinForms.BunifuDropdown DropDownItemCalc;
        private Bunifu.UI.WinForms.BunifuLabel LabelItemCalc;
    }
}