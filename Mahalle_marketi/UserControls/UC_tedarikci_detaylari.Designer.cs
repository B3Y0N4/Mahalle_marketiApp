namespace Mahalle_marketi.UserControls
{
    partial class UC_tedarikci_detaylari
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
            this.PanelTedarikciDetaylari = new System.Windows.Forms.Panel();
            this.labelTedarikciDetaylari = new System.Windows.Forms.Label();
            this.PanelTedarikciDetaylari.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTedarikciDetaylari
            // 
            this.PanelTedarikciDetaylari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelTedarikciDetaylari.Controls.Add(this.labelTedarikciDetaylari);
            this.PanelTedarikciDetaylari.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTedarikciDetaylari.Location = new System.Drawing.Point(0, 0);
            this.PanelTedarikciDetaylari.Name = "PanelTedarikciDetaylari";
            this.PanelTedarikciDetaylari.Size = new System.Drawing.Size(654, 110);
            this.PanelTedarikciDetaylari.TabIndex = 2;
            // 
            // labelTedarikciDetaylari
            // 
            this.labelTedarikciDetaylari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTedarikciDetaylari.AutoSize = true;
            this.labelTedarikciDetaylari.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTedarikciDetaylari.Location = new System.Drawing.Point(163, 31);
            this.labelTedarikciDetaylari.Name = "labelTedarikciDetaylari";
            this.labelTedarikciDetaylari.Size = new System.Drawing.Size(329, 49);
            this.labelTedarikciDetaylari.TabIndex = 0;
            this.labelTedarikciDetaylari.Text = "Tedarikçi Detayları";
            // 
            // UC_tedarikci_detaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTedarikciDetaylari);
            this.Name = "UC_tedarikci_detaylari";
            this.Size = new System.Drawing.Size(654, 611);
            this.PanelTedarikciDetaylari.ResumeLayout(false);
            this.PanelTedarikciDetaylari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelTedarikciDetaylari;
        private Label labelTedarikciDetaylari;
    }
}
