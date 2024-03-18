namespace SteamPulse
{
    partial class DiscountCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountCalculator));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Label_AppName = new System.Windows.Forms.Label();
            this.PanelInput = new Bunifu.UI.WinForms.BunifuPanel();
            this.Separator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.LabelDiscountValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelResult = new Bunifu.UI.WinForms.BunifuLabel();
            this.PercentSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.LabelPercent = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelName = new Bunifu.UI.WinForms.BunifuLabel();
            this.PanelHeader.SuspendLayout();
            this.PanelInput.SuspendLayout();
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
            this.PanelHeader.Controls.Add(this.ButtonExit);
            this.PanelHeader.Controls.Add(this.Label_AppName);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.ShowBorders = true;
            this.PanelHeader.Size = new System.Drawing.Size(484, 39);
            this.PanelHeader.TabIndex = 2;
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
            this.ButtonExit.Location = new System.Drawing.Point(457, 12);
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
            this.ButtonExit.TabIndex = 33;
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonExit.TextMarginLeft = 0;
            this.ButtonExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonExit.UseDefaultRadiusAndThickness = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Label_AppName
            // 
            this.Label_AppName.AutoSize = true;
            this.Label_AppName.BackColor = System.Drawing.Color.Transparent;
            this.Label_AppName.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Bold);
            this.Label_AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_AppName.Location = new System.Drawing.Point(6, 6);
            this.Label_AppName.Name = "Label_AppName";
            this.Label_AppName.Size = new System.Drawing.Size(196, 31);
            this.Label_AppName.TabIndex = 16;
            this.Label_AppName.Text = "Discount Calculator";
            // 
            // PanelInput
            // 
            this.PanelInput.BackgroundColor = System.Drawing.Color.White;
            this.PanelInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelInput.BackgroundImage")));
            this.PanelInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelInput.BorderColor = System.Drawing.Color.Transparent;
            this.PanelInput.BorderRadius = 20;
            this.PanelInput.BorderThickness = 1;
            this.PanelInput.Controls.Add(this.Separator);
            this.PanelInput.Controls.Add(this.LabelDiscountValue);
            this.PanelInput.Controls.Add(this.LabelResult);
            this.PanelInput.Controls.Add(this.PercentSlider);
            this.PanelInput.Controls.Add(this.LabelPercent);
            this.PanelInput.Controls.Add(this.LabelPrice);
            this.PanelInput.Controls.Add(this.LabelName);
            this.PanelInput.Location = new System.Drawing.Point(12, 56);
            this.PanelInput.Name = "PanelInput";
            this.PanelInput.ShowBorders = true;
            this.PanelInput.Size = new System.Drawing.Size(454, 210);
            this.PanelInput.TabIndex = 3;
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
            this.Separator.Location = new System.Drawing.Point(14, 135);
            this.Separator.Name = "Separator";
            this.Separator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator.Size = new System.Drawing.Size(426, 14);
            this.Separator.TabIndex = 12;
            // 
            // LabelDiscountValue
            // 
            this.LabelDiscountValue.AllowParentOverrides = false;
            this.LabelDiscountValue.AutoEllipsis = false;
            this.LabelDiscountValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDiscountValue.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelDiscountValue.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDiscountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelDiscountValue.Location = new System.Drawing.Point(401, 98);
            this.LabelDiscountValue.Name = "LabelDiscountValue";
            this.LabelDiscountValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDiscountValue.Size = new System.Drawing.Size(39, 28);
            this.LabelDiscountValue.TabIndex = 11;
            this.LabelDiscountValue.Text = "100%";
            this.LabelDiscountValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelDiscountValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelResult
            // 
            this.LabelResult.AllowParentOverrides = false;
            this.LabelResult.AutoEllipsis = false;
            this.LabelResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResult.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelResult.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelResult.Location = new System.Drawing.Point(14, 165);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelResult.Size = new System.Drawing.Size(58, 28);
            this.LabelResult.TabIndex = 10;
            this.LabelResult.Text = "Result : ";
            this.LabelResult.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelResult.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PercentSlider
            // 
            this.PercentSlider.AllowCursorChanges = true;
            this.PercentSlider.AllowHomeEndKeysDetection = false;
            this.PercentSlider.AllowIncrementalClickMoves = true;
            this.PercentSlider.AllowMouseDownEffects = false;
            this.PercentSlider.AllowMouseHoverEffects = false;
            this.PercentSlider.AllowScrollingAnimations = true;
            this.PercentSlider.AllowScrollKeysDetection = true;
            this.PercentSlider.AllowScrollOptionsMenu = true;
            this.PercentSlider.AllowShrinkingOnFocusLost = false;
            this.PercentSlider.BackColor = System.Drawing.Color.Transparent;
            this.PercentSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PercentSlider.BackgroundImage")));
            this.PercentSlider.BindingContainer = null;
            this.PercentSlider.BorderRadius = 2;
            this.PercentSlider.BorderThickness = 1;
            this.PercentSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PercentSlider.DrawThickBorder = false;
            this.PercentSlider.DurationBeforeShrink = 2000;
            this.PercentSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.PercentSlider.LargeChange = 10;
            this.PercentSlider.Location = new System.Drawing.Point(97, 98);
            this.PercentSlider.Maximum = 100;
            this.PercentSlider.Minimum = 0;
            this.PercentSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.PercentSlider.MinimumThumbLength = 18;
            this.PercentSlider.Name = "PercentSlider";
            this.PercentSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.PercentSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.PercentSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.PercentSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.PercentSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.PercentSlider.ShrinkSizeLimit = 3;
            this.PercentSlider.Size = new System.Drawing.Size(298, 31);
            this.PercentSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.PercentSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.PercentSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.PercentSlider.SmallChange = 5;
            this.PercentSlider.TabIndex = 9;
            this.PercentSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.PercentSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.PercentSlider.ThumbLength = 29;
            this.PercentSlider.ThumbMargin = 1;
            this.PercentSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.PercentSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.PercentSlider.Value = 100;
            this.PercentSlider.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.PercentSlider_ValueChanged);
            // 
            // LabelPercent
            // 
            this.LabelPercent.AllowParentOverrides = false;
            this.LabelPercent.AutoEllipsis = false;
            this.LabelPercent.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPercent.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelPercent.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelPercent.Location = new System.Drawing.Point(14, 98);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelPercent.Size = new System.Drawing.Size(63, 28);
            this.LabelPercent.TabIndex = 8;
            this.LabelPercent.Text = "Percent ";
            this.LabelPercent.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelPercent.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AllowParentOverrides = false;
            this.LabelPrice.AutoEllipsis = false;
            this.LabelPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelPrice.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelPrice.Location = new System.Drawing.Point(14, 57);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelPrice.Size = new System.Drawing.Size(116, 28);
            this.LabelPrice.TabIndex = 7;
            this.LabelPrice.Text = "Original Price : ";
            this.LabelPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LabelName
            // 
            this.LabelName.AllowParentOverrides = false;
            this.LabelName.AutoEllipsis = false;
            this.LabelName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelName.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelName.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelName.Location = new System.Drawing.Point(14, 15);
            this.LabelName.Name = "LabelName";
            this.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelName.Size = new System.Drawing.Size(54, 28);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Name: ";
            this.LabelName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DiscountCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 279);
            this.Controls.Add(this.PanelInput);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscountCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Percent Calculator";
            this.Load += new System.EventHandler(this.PercentCalculator_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelInput.ResumeLayout(false);
            this.PanelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuPanel PanelHeader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonExit;
        private System.Windows.Forms.Label Label_AppName;
        private Bunifu.UI.WinForms.BunifuPanel PanelInput;
        private Bunifu.UI.WinForms.BunifuLabel LabelPercent;
        private Bunifu.UI.WinForms.BunifuLabel LabelPrice;
        private Bunifu.UI.WinForms.BunifuLabel LabelName;
        private Bunifu.UI.WinForms.BunifuHSlider PercentSlider;
        private Bunifu.UI.WinForms.BunifuSeparator Separator;
        private Bunifu.UI.WinForms.BunifuLabel LabelDiscountValue;
        private Bunifu.UI.WinForms.BunifuLabel LabelResult;
    }
}