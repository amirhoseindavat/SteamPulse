namespace SteamPulse
{
    partial class Giveaway
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giveaway));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelAppName = new System.Windows.Forms.Label();
            this.Label_Exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelGiveaway = new Bunifu.UI.WinForms.BunifuPanel();
            this.PanelStatus = new Bunifu.UI.WinForms.BunifuPanel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.Label_Remaining = new System.Windows.Forms.Label();
            this.GroupBoxInformation = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.OpenRulesIcon = new System.Windows.Forms.PictureBox();
            this.ButtonSubmit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LabelRules = new System.Windows.Forms.Label();
            this.CheckBoxRules = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.TextBoxTelegram = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LabelTelegram = new System.Windows.Forms.Label();
            this.TextBoxLastName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TextBoxName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelHeader.SuspendLayout();
            this.PanelGiveaway.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            this.GroupBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenRulesIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
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
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(384, 35);
            this.PanelHeader.TabIndex = 40;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // LabelAppName
            // 
            this.LabelAppName.AutoSize = true;
            this.LabelAppName.BackColor = System.Drawing.Color.Transparent;
            this.LabelAppName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.LabelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelAppName.Location = new System.Drawing.Point(7, 3);
            this.LabelAppName.Name = "LabelAppName";
            this.LabelAppName.Size = new System.Drawing.Size(138, 31);
            this.LabelAppName.TabIndex = 15;
            this.LabelAppName.Text = "GiveAway 🎉";
            this.LabelAppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // Label_Exit
            // 
            this.Label_Exit.AllowAnimations = true;
            this.Label_Exit.AllowMouseEffects = true;
            this.Label_Exit.AllowToggling = false;
            this.Label_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Label_Exit.CustomizableEdges = borderEdges2;
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
            this.Label_Exit.Location = new System.Drawing.Point(357, 9);
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
            // PanelGiveaway
            // 
            this.PanelGiveaway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGiveaway.BackgroundColor = System.Drawing.Color.White;
            this.PanelGiveaway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelGiveaway.BackgroundImage")));
            this.PanelGiveaway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelGiveaway.BorderColor = System.Drawing.Color.Transparent;
            this.PanelGiveaway.BorderRadius = 20;
            this.PanelGiveaway.BorderThickness = 1;
            this.PanelGiveaway.Controls.Add(this.PanelStatus);
            this.PanelGiveaway.Controls.Add(this.Label_Remaining);
            this.PanelGiveaway.Controls.Add(this.GroupBoxInformation);
            this.PanelGiveaway.Location = new System.Drawing.Point(13, 51);
            this.PanelGiveaway.Name = "PanelGiveaway";
            this.PanelGiveaway.ShowBorders = true;
            this.PanelGiveaway.Size = new System.Drawing.Size(360, 432);
            this.PanelGiveaway.TabIndex = 41;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackgroundColor = System.Drawing.Color.White;
            this.PanelStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelStatus.BackgroundImage")));
            this.PanelStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelStatus.BorderColor = System.Drawing.Color.Transparent;
            this.PanelStatus.BorderRadius = 20;
            this.PanelStatus.BorderThickness = 1;
            this.PanelStatus.Controls.Add(this.LabelStatus);
            this.PanelStatus.Location = new System.Drawing.Point(0, 0);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.ShowBorders = true;
            this.PanelStatus.Size = new System.Drawing.Size(1, 1);
            this.PanelStatus.TabIndex = 58;
            // 
            // LabelStatus
            // 
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStatus.Font = new System.Drawing.Font("Poppins Black", 15F, System.Drawing.FontStyle.Bold);
            this.LabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelStatus.Location = new System.Drawing.Point(0, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(1, 1);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "You Already Have 1 Entry in this Giveaway";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Remaining
            // 
            this.Label_Remaining.BackColor = System.Drawing.Color.Transparent;
            this.Label_Remaining.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Remaining.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Remaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Remaining.Location = new System.Drawing.Point(0, 0);
            this.Label_Remaining.Name = "Label_Remaining";
            this.Label_Remaining.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Label_Remaining.Size = new System.Drawing.Size(360, 30);
            this.Label_Remaining.TabIndex = 57;
            this.Label_Remaining.Text = "Remaining:";
            this.Label_Remaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxInformation
            // 
            this.GroupBoxInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxInformation.BackColor = System.Drawing.Color.White;
            this.GroupBoxInformation.BorderColor = System.Drawing.Color.LightGray;
            this.GroupBoxInformation.BorderRadius = 1;
            this.GroupBoxInformation.BorderThickness = 1;
            this.GroupBoxInformation.Controls.Add(this.OpenRulesIcon);
            this.GroupBoxInformation.Controls.Add(this.ButtonSubmit);
            this.GroupBoxInformation.Controls.Add(this.LabelRules);
            this.GroupBoxInformation.Controls.Add(this.CheckBoxRules);
            this.GroupBoxInformation.Controls.Add(this.TextBoxTelegram);
            this.GroupBoxInformation.Controls.Add(this.LabelTelegram);
            this.GroupBoxInformation.Controls.Add(this.TextBoxLastName);
            this.GroupBoxInformation.Controls.Add(this.LabelLastName);
            this.GroupBoxInformation.Controls.Add(this.TextBoxName);
            this.GroupBoxInformation.Controls.Add(this.LabelName);
            this.GroupBoxInformation.Font = new System.Drawing.Font("Poppins Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.GroupBoxInformation.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupBoxInformation.LabelIndent = 10;
            this.GroupBoxInformation.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.GroupBoxInformation.Location = new System.Drawing.Point(10, 47);
            this.GroupBoxInformation.Name = "GroupBoxInformation";
            this.GroupBoxInformation.Size = new System.Drawing.Size(339, 368);
            this.GroupBoxInformation.TabIndex = 1;
            this.GroupBoxInformation.TabStop = false;
            this.GroupBoxInformation.Text = "Your Information";
            // 
            // OpenRulesIcon
            // 
            this.OpenRulesIcon.BackColor = System.Drawing.Color.Transparent;
            this.OpenRulesIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenRulesIcon.Image = global::SteamPulse.Properties.Resources.OpenExternalBlack;
            this.OpenRulesIcon.Location = new System.Drawing.Point(203, 266);
            this.OpenRulesIcon.Name = "OpenRulesIcon";
            this.OpenRulesIcon.Size = new System.Drawing.Size(25, 25);
            this.OpenRulesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenRulesIcon.TabIndex = 56;
            this.OpenRulesIcon.TabStop = false;
            this.OpenRulesIcon.Click += new System.EventHandler(this.OpenRulesIcon_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.AllowAnimations = true;
            this.ButtonSubmit.AllowMouseEffects = true;
            this.ButtonSubmit.AllowToggling = false;
            this.ButtonSubmit.AnimationSpeed = 200;
            this.ButtonSubmit.AutoGenerateColors = false;
            this.ButtonSubmit.AutoRoundBorders = false;
            this.ButtonSubmit.AutoSizeLeftIcon = true;
            this.ButtonSubmit.AutoSizeRightIcon = true;
            this.ButtonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSubmit.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ButtonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSubmit.BackgroundImage")));
            this.ButtonSubmit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonSubmit.ButtonText = "Submit";
            this.ButtonSubmit.ButtonTextMarginLeft = 0;
            this.ButtonSubmit.ColorContrastOnClick = 45;
            this.ButtonSubmit.ColorContrastOnHover = 45;
            this.ButtonSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonSubmit.CustomizableEdges = borderEdges1;
            this.ButtonSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonSubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonSubmit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonSubmit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonSubmit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSubmit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonSubmit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonSubmit.IconMarginLeft = 11;
            this.ButtonSubmit.IconPadding = 10;
            this.ButtonSubmit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSubmit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonSubmit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonSubmit.IconSize = 25;
            this.ButtonSubmit.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonSubmit.IdleBorderRadius = 5;
            this.ButtonSubmit.IdleBorderThickness = 1;
            this.ButtonSubmit.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonSubmit.IdleIconLeftImage = null;
            this.ButtonSubmit.IdleIconRightImage = null;
            this.ButtonSubmit.IndicateFocus = false;
            this.ButtonSubmit.Location = new System.Drawing.Point(75, 314);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ButtonSubmit.OnDisabledState.BorderRadius = 5;
            this.ButtonSubmit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonSubmit.OnDisabledState.BorderThickness = 1;
            this.ButtonSubmit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonSubmit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonSubmit.OnDisabledState.IconLeftImage = null;
            this.ButtonSubmit.OnDisabledState.IconRightImage = null;
            this.ButtonSubmit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonSubmit.onHoverState.BorderRadius = 5;
            this.ButtonSubmit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonSubmit.onHoverState.BorderThickness = 1;
            this.ButtonSubmit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonSubmit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmit.onHoverState.IconLeftImage = null;
            this.ButtonSubmit.onHoverState.IconRightImage = null;
            this.ButtonSubmit.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonSubmit.OnIdleState.BorderRadius = 5;
            this.ButtonSubmit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonSubmit.OnIdleState.BorderThickness = 1;
            this.ButtonSubmit.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonSubmit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmit.OnIdleState.IconLeftImage = null;
            this.ButtonSubmit.OnIdleState.IconRightImage = null;
            this.ButtonSubmit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonSubmit.OnPressedState.BorderRadius = 5;
            this.ButtonSubmit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonSubmit.OnPressedState.BorderThickness = 1;
            this.ButtonSubmit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonSubmit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonSubmit.OnPressedState.IconLeftImage = null;
            this.ButtonSubmit.OnPressedState.IconRightImage = null;
            this.ButtonSubmit.Size = new System.Drawing.Size(189, 39);
            this.ButtonSubmit.TabIndex = 8;
            this.ButtonSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSubmit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonSubmit.TextMarginLeft = 0;
            this.ButtonSubmit.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonSubmit.UseDefaultRadiusAndThickness = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelRules
            // 
            this.LabelRules.AutoSize = true;
            this.LabelRules.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRules.Location = new System.Drawing.Point(44, 266);
            this.LabelRules.Name = "LabelRules";
            this.LabelRules.Size = new System.Drawing.Size(160, 30);
            this.LabelRules.TabIndex = 7;
            this.LabelRules.Text = "I accept the rules";
            this.LabelRules.Click += new System.EventHandler(this.LabelRules_Click);
            // 
            // CheckBoxRules
            // 
            this.CheckBoxRules.AllowBindingControlAnimation = true;
            this.CheckBoxRules.AllowBindingControlColorChanges = false;
            this.CheckBoxRules.AllowBindingControlLocation = true;
            this.CheckBoxRules.AllowCheckBoxAnimation = false;
            this.CheckBoxRules.AllowCheckmarkAnimation = true;
            this.CheckBoxRules.AllowOnHoverStates = true;
            this.CheckBoxRules.AutoCheck = true;
            this.CheckBoxRules.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckBoxRules.BackgroundImage")));
            this.CheckBoxRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckBoxRules.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.CheckBoxRules.BorderRadius = 12;
            this.CheckBoxRules.Checked = false;
            this.CheckBoxRules.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.CheckBoxRules.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckBoxRules.CustomCheckmarkImage = null;
            this.CheckBoxRules.Location = new System.Drawing.Point(18, 267);
            this.CheckBoxRules.MinimumSize = new System.Drawing.Size(17, 17);
            this.CheckBoxRules.Name = "CheckBoxRules";
            this.CheckBoxRules.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckBoxRules.OnCheck.BorderRadius = 12;
            this.CheckBoxRules.OnCheck.BorderThickness = 2;
            this.CheckBoxRules.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.CheckBoxRules.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.CheckBoxRules.OnCheck.CheckmarkThickness = 2;
            this.CheckBoxRules.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.CheckBoxRules.OnDisable.BorderRadius = 12;
            this.CheckBoxRules.OnDisable.BorderThickness = 2;
            this.CheckBoxRules.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckBoxRules.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.CheckBoxRules.OnDisable.CheckmarkThickness = 2;
            this.CheckBoxRules.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckBoxRules.OnHoverChecked.BorderRadius = 12;
            this.CheckBoxRules.OnHoverChecked.BorderThickness = 2;
            this.CheckBoxRules.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckBoxRules.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.CheckBoxRules.OnHoverChecked.CheckmarkThickness = 2;
            this.CheckBoxRules.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CheckBoxRules.OnHoverUnchecked.BorderRadius = 12;
            this.CheckBoxRules.OnHoverUnchecked.BorderThickness = 1;
            this.CheckBoxRules.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckBoxRules.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckBoxRules.OnUncheck.BorderRadius = 12;
            this.CheckBoxRules.OnUncheck.BorderThickness = 1;
            this.CheckBoxRules.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.CheckBoxRules.Size = new System.Drawing.Size(21, 21);
            this.CheckBoxRules.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.CheckBoxRules.TabIndex = 6;
            this.CheckBoxRules.ThreeState = false;
            this.CheckBoxRules.ToolTipText = null;
            // 
            // TextBoxTelegram
            // 
            this.TextBoxTelegram.AcceptsReturn = false;
            this.TextBoxTelegram.AcceptsTab = false;
            this.TextBoxTelegram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTelegram.AnimationSpeed = 200;
            this.TextBoxTelegram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxTelegram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxTelegram.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxTelegram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxTelegram.BackgroundImage")));
            this.TextBoxTelegram.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBoxTelegram.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxTelegram.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBoxTelegram.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxTelegram.BorderRadius = 1;
            this.TextBoxTelegram.BorderThickness = 1;
            this.TextBoxTelegram.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxTelegram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTelegram.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxTelegram.DefaultText = "";
            this.TextBoxTelegram.FillColor = System.Drawing.Color.White;
            this.TextBoxTelegram.HideSelection = true;
            this.TextBoxTelegram.IconLeft = null;
            this.TextBoxTelegram.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTelegram.IconPadding = 10;
            this.TextBoxTelegram.IconRight = null;
            this.TextBoxTelegram.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTelegram.Lines = new string[0];
            this.TextBoxTelegram.Location = new System.Drawing.Point(18, 217);
            this.TextBoxTelegram.MaxLength = 32767;
            this.TextBoxTelegram.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxTelegram.Modified = false;
            this.TextBoxTelegram.Multiline = false;
            this.TextBoxTelegram.Name = "TextBoxTelegram";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxTelegram.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxTelegram.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxTelegram.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxTelegram.OnIdleState = stateProperties4;
            this.TextBoxTelegram.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxTelegram.PasswordChar = '\0';
            this.TextBoxTelegram.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxTelegram.PlaceholderText = "Enter Telegram Username";
            this.TextBoxTelegram.ReadOnly = false;
            this.TextBoxTelegram.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxTelegram.SelectedText = "";
            this.TextBoxTelegram.SelectionLength = 0;
            this.TextBoxTelegram.SelectionStart = 0;
            this.TextBoxTelegram.ShortcutsEnabled = true;
            this.TextBoxTelegram.Size = new System.Drawing.Size(305, 37);
            this.TextBoxTelegram.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxTelegram.TabIndex = 5;
            this.TextBoxTelegram.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxTelegram.TextMarginBottom = 0;
            this.TextBoxTelegram.TextMarginLeft = 3;
            this.TextBoxTelegram.TextMarginTop = 0;
            this.TextBoxTelegram.TextPlaceholder = "Enter Telegram Username";
            this.TextBoxTelegram.UseSystemPasswordChar = false;
            this.TextBoxTelegram.WordWrap = true;
            // 
            // LabelTelegram
            // 
            this.LabelTelegram.AutoSize = true;
            this.LabelTelegram.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTelegram.Location = new System.Drawing.Point(13, 184);
            this.LabelTelegram.Name = "LabelTelegram";
            this.LabelTelegram.Size = new System.Drawing.Size(114, 30);
            this.LabelTelegram.TabIndex = 4;
            this.LabelTelegram.Text = "Telegram: ";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.AcceptsReturn = false;
            this.TextBoxLastName.AcceptsTab = false;
            this.TextBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLastName.AnimationSpeed = 200;
            this.TextBoxLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxLastName.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxLastName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxLastName.BackgroundImage")));
            this.TextBoxLastName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBoxLastName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxLastName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBoxLastName.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxLastName.BorderRadius = 1;
            this.TextBoxLastName.BorderThickness = 1;
            this.TextBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLastName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxLastName.DefaultText = "";
            this.TextBoxLastName.FillColor = System.Drawing.Color.White;
            this.TextBoxLastName.HideSelection = true;
            this.TextBoxLastName.IconLeft = null;
            this.TextBoxLastName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLastName.IconPadding = 10;
            this.TextBoxLastName.IconRight = null;
            this.TextBoxLastName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLastName.Lines = new string[0];
            this.TextBoxLastName.Location = new System.Drawing.Point(18, 141);
            this.TextBoxLastName.MaxLength = 32767;
            this.TextBoxLastName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxLastName.Modified = false;
            this.TextBoxLastName.Multiline = false;
            this.TextBoxLastName.Name = "TextBoxLastName";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxLastName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxLastName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxLastName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxLastName.OnIdleState = stateProperties8;
            this.TextBoxLastName.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxLastName.PasswordChar = '\0';
            this.TextBoxLastName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxLastName.PlaceholderText = "Enter Last Name";
            this.TextBoxLastName.ReadOnly = false;
            this.TextBoxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxLastName.SelectedText = "";
            this.TextBoxLastName.SelectionLength = 0;
            this.TextBoxLastName.SelectionStart = 0;
            this.TextBoxLastName.ShortcutsEnabled = true;
            this.TextBoxLastName.Size = new System.Drawing.Size(305, 37);
            this.TextBoxLastName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxLastName.TabIndex = 3;
            this.TextBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxLastName.TextMarginBottom = 0;
            this.TextBoxLastName.TextMarginLeft = 3;
            this.TextBoxLastName.TextMarginTop = 0;
            this.TextBoxLastName.TextPlaceholder = "Enter Last Name";
            this.TextBoxLastName.UseSystemPasswordChar = false;
            this.TextBoxLastName.WordWrap = true;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(13, 108);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(118, 30);
            this.LabelLastName.TabIndex = 2;
            this.LabelLastName.Text = "Last Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.AcceptsReturn = false;
            this.TextBoxName.AcceptsTab = false;
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.AnimationSpeed = 200;
            this.TextBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxName.BackgroundImage")));
            this.TextBoxName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBoxName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.TextBoxName.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxName.BorderRadius = 1;
            this.TextBoxName.BorderThickness = 1;
            this.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxName.DefaultText = "";
            this.TextBoxName.FillColor = System.Drawing.Color.White;
            this.TextBoxName.HideSelection = true;
            this.TextBoxName.IconLeft = null;
            this.TextBoxName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.IconPadding = 10;
            this.TextBoxName.IconRight = null;
            this.TextBoxName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Lines = new string[0];
            this.TextBoxName.Location = new System.Drawing.Point(18, 66);
            this.TextBoxName.MaxLength = 32767;
            this.TextBoxName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxName.Modified = false;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxName.OnIdleState = stateProperties12;
            this.TextBoxName.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxName.PlaceholderText = "Enter Name";
            this.TextBoxName.ReadOnly = false;
            this.TextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.SelectionLength = 0;
            this.TextBoxName.SelectionStart = 0;
            this.TextBoxName.ShortcutsEnabled = true;
            this.TextBoxName.Size = new System.Drawing.Size(305, 37);
            this.TextBoxName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxName.TextMarginBottom = 0;
            this.TextBoxName.TextMarginLeft = 3;
            this.TextBoxName.TextMarginTop = 0;
            this.TextBoxName.TextPlaceholder = "Enter Name";
            this.TextBoxName.UseSystemPasswordChar = false;
            this.TextBoxName.WordWrap = true;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(13, 33);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(74, 30);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // Giveaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 495);
            this.Controls.Add(this.PanelGiveaway);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giveaway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giveaway";
            this.Load += new System.EventHandler(this.Giveaway_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelGiveaway.ResumeLayout(false);
            this.PanelStatus.ResumeLayout(false);
            this.GroupBoxInformation.ResumeLayout(false);
            this.GroupBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenRulesIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private System.Windows.Forms.Label LabelAppName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Label_Exit;
        private Bunifu.UI.WinForms.BunifuPanel PanelGiveaway;
        private Bunifu.UI.WinForms.BunifuGroupBox GroupBoxInformation;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonSubmit;
        private System.Windows.Forms.Label LabelRules;
        private Bunifu.UI.WinForms.BunifuCheckBox CheckBoxRules;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxTelegram;
        private System.Windows.Forms.Label LabelTelegram;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelLastName;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label Label_Remaining;
        private System.Windows.Forms.PictureBox OpenRulesIcon;
        private System.Windows.Forms.Timer Timer;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private Bunifu.UI.WinForms.BunifuPanel PanelStatus;
        private System.Windows.Forms.Label LabelStatus;
    }
}