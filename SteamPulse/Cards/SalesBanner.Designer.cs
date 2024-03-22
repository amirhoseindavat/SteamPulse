namespace SteamPulse.Cards
{
    partial class SalesBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBanner));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_Remaining = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonViewSale = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PictureBox_IMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_IMG)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Label_Remaining
            // 
            this.Label_Remaining.AutoSize = true;
            this.Label_Remaining.BackColor = System.Drawing.Color.Black;
            this.Label_Remaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Remaining.Font = new System.Drawing.Font("Motiva Sans", 11F);
            this.Label_Remaining.ForeColor = System.Drawing.Color.White;
            this.Label_Remaining.Location = new System.Drawing.Point(11, 134);
            this.Label_Remaining.Name = "Label_Remaining";
            this.Label_Remaining.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Label_Remaining.Size = new System.Drawing.Size(93, 25);
            this.Label_Remaining.TabIndex = 52;
            this.Label_Remaining.Text = "Remaining: ";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ButtonViewSale
            // 
            this.ButtonViewSale.AllowAnimations = true;
            this.ButtonViewSale.AllowMouseEffects = true;
            this.ButtonViewSale.AllowToggling = false;
            this.ButtonViewSale.AnimationSpeed = 200;
            this.ButtonViewSale.AutoGenerateColors = false;
            this.ButtonViewSale.AutoRoundBorders = false;
            this.ButtonViewSale.AutoSizeLeftIcon = true;
            this.ButtonViewSale.AutoSizeRightIcon = true;
            this.ButtonViewSale.BackColor = System.Drawing.Color.Transparent;
            this.ButtonViewSale.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonViewSale.BackgroundImage")));
            this.ButtonViewSale.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonViewSale.ButtonText = "View ";
            this.ButtonViewSale.ButtonTextMarginLeft = 0;
            this.ButtonViewSale.ColorContrastOnClick = 45;
            this.ButtonViewSale.ColorContrastOnHover = 45;
            this.ButtonViewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonViewSale.CustomizableEdges = borderEdges1;
            this.ButtonViewSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonViewSale.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.DisabledForecolor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonViewSale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonViewSale.ForeColor = System.Drawing.Color.White;
            this.ButtonViewSale.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonViewSale.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonViewSale.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonViewSale.IconMarginLeft = 11;
            this.ButtonViewSale.IconPadding = 10;
            this.ButtonViewSale.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonViewSale.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonViewSale.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonViewSale.IconSize = 0;
            this.ButtonViewSale.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.IdleBorderRadius = 1;
            this.ButtonViewSale.IdleBorderThickness = 1;
            this.ButtonViewSale.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.IdleIconLeftImage = null;
            this.ButtonViewSale.IdleIconRightImage = null;
            this.ButtonViewSale.IndicateFocus = false;
            this.ButtonViewSale.Location = new System.Drawing.Point(800, 128);
            this.ButtonViewSale.Name = "ButtonViewSale";
            this.ButtonViewSale.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnDisabledState.BorderRadius = 1;
            this.ButtonViewSale.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonViewSale.OnDisabledState.BorderThickness = 1;
            this.ButtonViewSale.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnDisabledState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnDisabledState.IconLeftImage = null;
            this.ButtonViewSale.OnDisabledState.IconRightImage = null;
            this.ButtonViewSale.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.onHoverState.BorderRadius = 1;
            this.ButtonViewSale.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonViewSale.onHoverState.BorderThickness = 1;
            this.ButtonViewSale.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ButtonViewSale.onHoverState.IconLeftImage = null;
            this.ButtonViewSale.onHoverState.IconRightImage = null;
            this.ButtonViewSale.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnIdleState.BorderRadius = 1;
            this.ButtonViewSale.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonViewSale.OnIdleState.BorderThickness = 1;
            this.ButtonViewSale.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonViewSale.OnIdleState.IconLeftImage = null;
            this.ButtonViewSale.OnIdleState.IconRightImage = null;
            this.ButtonViewSale.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnPressedState.BorderRadius = 1;
            this.ButtonViewSale.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonViewSale.OnPressedState.BorderThickness = 1;
            this.ButtonViewSale.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonViewSale.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonViewSale.OnPressedState.IconLeftImage = null;
            this.ButtonViewSale.OnPressedState.IconRightImage = null;
            this.ButtonViewSale.Size = new System.Drawing.Size(92, 31);
            this.ButtonViewSale.TabIndex = 53;
            this.ButtonViewSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonViewSale.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonViewSale.TextMarginLeft = 0;
            this.ButtonViewSale.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonViewSale.UseDefaultRadiusAndThickness = true;
            this.ButtonViewSale.Click += new System.EventHandler(this.ButtonViewSale_Click);
            // 
            // PictureBox_IMG
            // 
            this.PictureBox_IMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_IMG.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_IMG.Name = "PictureBox_IMG";
            this.PictureBox_IMG.Size = new System.Drawing.Size(909, 170);
            this.PictureBox_IMG.TabIndex = 0;
            this.PictureBox_IMG.TabStop = false;
            // 
            // SalesBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonViewSale);
            this.Controls.Add(this.Label_Remaining);
            this.Controls.Add(this.PictureBox_IMG);
            this.Name = "SalesBanner";
            this.Size = new System.Drawing.Size(909, 170);
            this.Load += new System.EventHandler(this.SalesBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_IMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_IMG;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label Label_Remaining;
        private System.Windows.Forms.Timer Timer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonViewSale;
    }
}
