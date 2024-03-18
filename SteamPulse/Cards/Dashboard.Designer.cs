namespace SteamPulse.Cards
{
    partial class Dashboard
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
            this.LabelHelp = new System.Windows.Forms.Label();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // LabelHelp
            // 
            this.LabelHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelHelp.Font = new System.Drawing.Font("Motiva Sans", 13F);
            this.LabelHelp.Location = new System.Drawing.Point(0, 431);
            this.LabelHelp.Name = "LabelHelp";
            this.LabelHelp.Size = new System.Drawing.Size(644, 37);
            this.LabelHelp.TabIndex = 0;
            this.LabelHelp.Text = "New Around Here? Click to Get Some Help :)";
            this.LabelHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelHelp.Click += new System.EventHandler(this.LabelHelp_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInfo.Font = new System.Drawing.Font("Motiva Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.Location = new System.Drawing.Point(0, 0);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(644, 431);
            this.LabelInfo.TabIndex = 1;
            this.LabelInfo.Text = "SteamPulse";
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelHelp);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(644, 468);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label LabelHelp;
    }
}
