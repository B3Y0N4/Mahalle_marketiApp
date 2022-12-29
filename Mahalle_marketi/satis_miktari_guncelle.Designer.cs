namespace Mahalle_marketi
{
    partial class satis_miktari_guncelle
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.ComboBoxMiktar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelMiktar = new System.Windows.Forms.Label();
            this.Btn_guncelle = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ComboBoxMiktar
            // 
            this.ComboBoxMiktar.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxMiktar.CustomizableEdges = customizableEdges1;
            this.ComboBoxMiktar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxMiktar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMiktar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxMiktar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxMiktar.ItemHeight = 30;
            this.ComboBoxMiktar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxMiktar.Location = new System.Drawing.Point(130, 63);
            this.ComboBoxMiktar.Name = "ComboBoxMiktar";
            this.ComboBoxMiktar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.ComboBoxMiktar.Size = new System.Drawing.Size(154, 36);
            this.ComboBoxMiktar.TabIndex = 1;
            // 
            // labelMiktar
            // 
            this.labelMiktar.AutoSize = true;
            this.labelMiktar.Location = new System.Drawing.Point(77, 74);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(47, 15);
            this.labelMiktar.TabIndex = 2;
            this.labelMiktar.Text = "Miktar :";
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.BorderRadius = 20;
            this.Btn_guncelle.CustomizableEdges = customizableEdges3;
            this.Btn_guncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_guncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_guncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_guncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_guncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_guncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.Btn_guncelle.Location = new System.Drawing.Point(61, 123);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.Btn_guncelle.Size = new System.Drawing.Size(239, 45);
            this.Btn_guncelle.TabIndex = 3;
            this.Btn_guncelle.Text = "Güncelle";
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // satis_miktari_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 221);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.labelMiktar);
            this.Controls.Add(this.ComboBoxMiktar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "satis_miktari_guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Miktarı güncelle";
            this.Load += new System.EventHandler(this.satis_miktari_guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMiktar;
        private Label labelMiktar;
        private Guna.UI2.WinForms.Guna2Button Btn_guncelle;
    }
}