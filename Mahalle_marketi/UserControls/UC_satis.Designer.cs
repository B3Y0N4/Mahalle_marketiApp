namespace Mahalle_marketi.UserControls
{
    partial class UC_satis
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
            this.PanelSatis = new System.Windows.Forms.Panel();
            this.labelSatis = new System.Windows.Forms.Label();
            this.PanelSatis.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSatis
            // 
            this.PanelSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelSatis.Controls.Add(this.labelSatis);
            this.PanelSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSatis.Location = new System.Drawing.Point(0, 0);
            this.PanelSatis.Name = "PanelSatis";
            this.PanelSatis.Size = new System.Drawing.Size(654, 110);
            this.PanelSatis.TabIndex = 0;
            // 
            // labelSatis
            // 
            this.labelSatis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSatis.AutoSize = true;
            this.labelSatis.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSatis.Location = new System.Drawing.Point(277, 31);
            this.labelSatis.Name = "labelSatis";
            this.labelSatis.Size = new System.Drawing.Size(100, 49);
            this.labelSatis.TabIndex = 0;
            this.labelSatis.Text = "Satış";
            // 
            // UC_satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelSatis);
            this.Name = "UC_satis";
            this.Size = new System.Drawing.Size(654, 611);
            this.PanelSatis.ResumeLayout(false);
            this.PanelSatis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelSatis;
        private Label labelSatis;
    }
}
