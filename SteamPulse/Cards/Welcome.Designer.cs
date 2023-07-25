namespace SteamPulse.Cards
{
    partial class Welcome
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
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Motiva Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Need Help? Open Help";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Help
            // 
            this.Label_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Help.Font = new System.Drawing.Font("Motiva Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Help.Location = new System.Drawing.Point(0, 0);
            this.Label_Help.Name = "Label_Help";
            this.Label_Help.Size = new System.Drawing.Size(644, 441);
            this.Label_Help.TabIndex = 1;
            this.Label_Help.Text = "SteamPulse";
            this.Label_Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Help);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(644, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label Label_Help;
        private System.Windows.Forms.Label label1;
    }
}
