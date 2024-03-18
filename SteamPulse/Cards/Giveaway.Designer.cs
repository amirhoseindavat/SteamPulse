namespace SteamPulse.Cards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giveaway));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Label_Remaining = new System.Windows.Forms.Label();
            this.LabelGiveaway = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PictureBoxRight = new System.Windows.Forms.PictureBox();
            this.PictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.ButtonGiveaway = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Remaining
            // 
            this.Label_Remaining.BackColor = System.Drawing.Color.Transparent;
            this.Label_Remaining.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label_Remaining.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Remaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.Label_Remaining.Location = new System.Drawing.Point(0, 77);
            this.Label_Remaining.Name = "Label_Remaining";
            this.Label_Remaining.Size = new System.Drawing.Size(909, 93);
            this.Label_Remaining.TabIndex = 65;
            this.Label_Remaining.Text = "Begin in:";
            this.Label_Remaining.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelGiveaway
            // 
            this.LabelGiveaway.BackColor = System.Drawing.Color.Transparent;
            this.LabelGiveaway.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelGiveaway.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.LabelGiveaway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.LabelGiveaway.Location = new System.Drawing.Point(0, 0);
            this.LabelGiveaway.Name = "LabelGiveaway";
            this.LabelGiveaway.Size = new System.Drawing.Size(909, 26);
            this.LabelGiveaway.TabIndex = 64;
            this.LabelGiveaway.Text = "{UI.Giveaway_Tilte}";
            this.LabelGiveaway.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PictureBoxRight
            // 
            this.PictureBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxRight.Location = new System.Drawing.Point(811, 51);
            this.PictureBoxRight.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.PictureBoxRight.Name = "PictureBoxRight";
            this.PictureBoxRight.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PictureBoxRight.Size = new System.Drawing.Size(85, 85);
            this.PictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRight.TabIndex = 68;
            this.PictureBoxRight.TabStop = false;
            // 
            // PictureBoxLeft
            // 
            this.PictureBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxLeft.Location = new System.Drawing.Point(20, 51);
            this.PictureBoxLeft.Name = "PictureBoxLeft";
            this.PictureBoxLeft.Size = new System.Drawing.Size(85, 85);
            this.PictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLeft.TabIndex = 67;
            this.PictureBoxLeft.TabStop = false;
            // 
            // ButtonGiveaway
            // 
            this.ButtonGiveaway.AllowAnimations = true;
            this.ButtonGiveaway.AllowMouseEffects = true;
            this.ButtonGiveaway.AllowToggling = false;
            this.ButtonGiveaway.AnimationSpeed = 200;
            this.ButtonGiveaway.AutoGenerateColors = false;
            this.ButtonGiveaway.AutoRoundBorders = false;
            this.ButtonGiveaway.AutoSizeLeftIcon = true;
            this.ButtonGiveaway.AutoSizeRightIcon = true;
            this.ButtonGiveaway.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGiveaway.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGiveaway.BackgroundImage")));
            this.ButtonGiveaway.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonGiveaway.ButtonText = "Enter Giveaway";
            this.ButtonGiveaway.ButtonTextMarginLeft = 0;
            this.ButtonGiveaway.ColorContrastOnClick = 45;
            this.ButtonGiveaway.ColorContrastOnHover = 45;
            this.ButtonGiveaway.Cursor = System.Windows.Forms.Cursors.No;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonGiveaway.CustomizableEdges = borderEdges1;
            this.ButtonGiveaway.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonGiveaway.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonGiveaway.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonGiveaway.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonGiveaway.Enabled = false;
            this.ButtonGiveaway.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonGiveaway.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonGiveaway.ForeColor = System.Drawing.Color.White;
            this.ButtonGiveaway.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGiveaway.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonGiveaway.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonGiveaway.IconMarginLeft = 11;
            this.ButtonGiveaway.IconPadding = 10;
            this.ButtonGiveaway.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGiveaway.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonGiveaway.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonGiveaway.IconSize = 25;
            this.ButtonGiveaway.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.IdleBorderRadius = 10;
            this.ButtonGiveaway.IdleBorderThickness = 1;
            this.ButtonGiveaway.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.IdleIconLeftImage = null;
            this.ButtonGiveaway.IdleIconRightImage = null;
            this.ButtonGiveaway.IndicateFocus = false;
            this.ButtonGiveaway.Location = new System.Drawing.Point(378, 119);
            this.ButtonGiveaway.Name = "ButtonGiveaway";
            this.ButtonGiveaway.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonGiveaway.OnDisabledState.BorderRadius = 10;
            this.ButtonGiveaway.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonGiveaway.OnDisabledState.BorderThickness = 1;
            this.ButtonGiveaway.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonGiveaway.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonGiveaway.OnDisabledState.IconLeftImage = null;
            this.ButtonGiveaway.OnDisabledState.IconRightImage = null;
            this.ButtonGiveaway.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonGiveaway.onHoverState.BorderRadius = 10;
            this.ButtonGiveaway.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonGiveaway.onHoverState.BorderThickness = 1;
            this.ButtonGiveaway.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonGiveaway.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonGiveaway.onHoverState.IconLeftImage = null;
            this.ButtonGiveaway.onHoverState.IconRightImage = null;
            this.ButtonGiveaway.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.OnIdleState.BorderRadius = 10;
            this.ButtonGiveaway.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonGiveaway.OnIdleState.BorderThickness = 1;
            this.ButtonGiveaway.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonGiveaway.OnIdleState.IconLeftImage = null;
            this.ButtonGiveaway.OnIdleState.IconRightImage = null;
            this.ButtonGiveaway.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.OnPressedState.BorderRadius = 10;
            this.ButtonGiveaway.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonGiveaway.OnPressedState.BorderThickness = 1;
            this.ButtonGiveaway.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonGiveaway.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonGiveaway.OnPressedState.IconLeftImage = null;
            this.ButtonGiveaway.OnPressedState.IconRightImage = null;
            this.ButtonGiveaway.Size = new System.Drawing.Size(150, 39);
            this.ButtonGiveaway.TabIndex = 66;
            this.ButtonGiveaway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGiveaway.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonGiveaway.TextMarginLeft = 0;
            this.ButtonGiveaway.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonGiveaway.UseDefaultRadiusAndThickness = true;
            this.ButtonGiveaway.Click += new System.EventHandler(this.ButtonGiveaway_Click);
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Giveaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureBoxRight);
            this.Controls.Add(this.PictureBoxLeft);
            this.Controls.Add(this.ButtonGiveaway);
            this.Controls.Add(this.Label_Remaining);
            this.Controls.Add(this.LabelGiveaway);
            this.Name = "Giveaway";
            this.Size = new System.Drawing.Size(909, 170);
            this.Load += new System.EventHandler(this.Giveaway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxRight;
        private System.Windows.Forms.PictureBox PictureBoxLeft;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonGiveaway;
        private System.Windows.Forms.Label Label_Remaining;
        private System.Windows.Forms.Label LabelGiveaway;
        private System.Windows.Forms.Timer Timer;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
    }
}
