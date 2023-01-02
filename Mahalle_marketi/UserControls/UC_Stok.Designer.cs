namespace Mahalle_marketi.UserControls
{
    partial class UC_Stok
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.PanelStok = new System.Windows.Forms.Panel();
            this.labelStok = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_stok_girisi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_urunler = new Guna.UI2.WinForms.Guna2Button();
            this.panel_stok = new System.Windows.Forms.Panel();
            this.PanelStok.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStok
            // 
            this.PanelStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelStok.Controls.Add(this.labelStok);
            this.PanelStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStok.Location = new System.Drawing.Point(0, 0);
            this.PanelStok.Name = "PanelStok";
            this.PanelStok.Size = new System.Drawing.Size(654, 110);
            this.PanelStok.TabIndex = 3;
            // 
            // labelStok
            // 
            this.labelStok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStok.AutoSize = true;
            this.labelStok.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStok.ForeColor = System.Drawing.Color.White;
            this.labelStok.Location = new System.Drawing.Point(279, 31);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(96, 49);
            this.labelStok.TabIndex = 0;
            this.labelStok.Text = "Stok";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_stok_girisi);
            this.panel1.Controls.Add(this.btn_urunler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 50);
            this.panel1.TabIndex = 4;
            // 
            // btn_stok_girisi
            // 
            this.btn_stok_girisi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_stok_girisi.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_stok_girisi.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_stok_girisi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_stok_girisi.CustomizableEdges = customizableEdges1;
            this.btn_stok_girisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_stok_girisi.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_stok_girisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_stok_girisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_stok_girisi.FillColor = System.Drawing.Color.White;
            this.btn_stok_girisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stok_girisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_stok_girisi.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_stok_girisi.Location = new System.Drawing.Point(170, 0);
            this.btn_stok_girisi.Name = "btn_stok_girisi";
            this.btn_stok_girisi.PressedColor = System.Drawing.Color.GreenYellow;
            this.btn_stok_girisi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btn_stok_girisi.Size = new System.Drawing.Size(157, 50);
            this.btn_stok_girisi.TabIndex = 6;
            this.btn_stok_girisi.Text = "Stok Girişi";
            this.btn_stok_girisi.Click += new System.EventHandler(this.btn_stok_girisi_Click);
            // 
            // btn_urunler
            // 
            this.btn_urunler.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_urunler.Checked = true;
            this.btn_urunler.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_urunler.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_urunler.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btn_urunler.CustomizableEdges = customizableEdges3;
            this.btn_urunler.FillColor = System.Drawing.Color.Empty;
            this.btn_urunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_urunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_urunler.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_urunler.Location = new System.Drawing.Point(7, 0);
            this.btn_urunler.Name = "btn_urunler";
            this.btn_urunler.PressedColor = System.Drawing.Color.GreenYellow;
            this.btn_urunler.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btn_urunler.Size = new System.Drawing.Size(157, 50);
            this.btn_urunler.TabIndex = 5;
            this.btn_urunler.Text = "Ürünler";
            this.btn_urunler.Click += new System.EventHandler(this.btn_urunler_Click);
            // 
            // panel_stok
            // 
            this.panel_stok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_stok.Location = new System.Drawing.Point(0, 160);
            this.panel_stok.Name = "panel_stok";
            this.panel_stok.Size = new System.Drawing.Size(654, 451);
            this.panel_stok.TabIndex = 5;
            // 
            // UC_Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_stok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStok);
            this.Name = "UC_Stok";
            this.Size = new System.Drawing.Size(654, 611);
            this.Load += new System.EventHandler(this.UC_Stok_Load);
            this.PanelStok.ResumeLayout(false);
            this.PanelStok.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelStok;
        private Label labelStok;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_stok_girisi;
        private Guna.UI2.WinForms.Guna2Button btn_urunler;
        private Panel panel_stok;
    }
}
