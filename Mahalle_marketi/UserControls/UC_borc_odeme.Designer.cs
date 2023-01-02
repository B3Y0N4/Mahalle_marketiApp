namespace Mahalle_marketi.UserControls
{
    partial class UC_borc_odeme
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
            this.PanelBorcOdeme = new System.Windows.Forms.Panel();
            this.labelBorcOdeme = new System.Windows.Forms.Label();
            this.PanelBorcOdeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBorcOdeme
            // 
            this.PanelBorcOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelBorcOdeme.Controls.Add(this.labelBorcOdeme);
            this.PanelBorcOdeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBorcOdeme.Location = new System.Drawing.Point(0, 0);
            this.PanelBorcOdeme.Name = "PanelBorcOdeme";
            this.PanelBorcOdeme.Size = new System.Drawing.Size(654, 110);
            this.PanelBorcOdeme.TabIndex = 1;
            // 
            // labelBorcOdeme
            // 
            this.labelBorcOdeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBorcOdeme.AutoSize = true;
            this.labelBorcOdeme.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBorcOdeme.ForeColor = System.Drawing.Color.White;
            this.labelBorcOdeme.Location = new System.Drawing.Point(214, 31);
            this.labelBorcOdeme.Name = "labelBorcOdeme";
            this.labelBorcOdeme.Size = new System.Drawing.Size(226, 49);
            this.labelBorcOdeme.TabIndex = 0;
            this.labelBorcOdeme.Text = "Borç Ödeme";
            // 
            // UC_borc_odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelBorcOdeme);
            this.Name = "UC_borc_odeme";
            this.Size = new System.Drawing.Size(654, 611);
            this.PanelBorcOdeme.ResumeLayout(false);
            this.PanelBorcOdeme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelBorcOdeme;
        private Label labelBorcOdeme;
    }
}
