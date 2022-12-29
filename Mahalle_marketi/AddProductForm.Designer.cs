namespace Mahalle_marketi
{
    partial class AddProductForm
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
            this.label_urunBarkodu = new System.Windows.Forms.Label();
            this.textBox_urunBarkodu = new System.Windows.Forms.TextBox();
            this.labelAdet = new System.Windows.Forms.Label();
            this.ComboBoxAdet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_ekle = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label_urunBarkodu
            // 
            this.label_urunBarkodu.AutoSize = true;
            this.label_urunBarkodu.Location = new System.Drawing.Point(95, 49);
            this.label_urunBarkodu.Name = "label_urunBarkodu";
            this.label_urunBarkodu.Size = new System.Drawing.Size(80, 15);
            this.label_urunBarkodu.TabIndex = 0;
            this.label_urunBarkodu.Text = "Ürün Barkodu";
            // 
            // textBox_urunBarkodu
            // 
            this.textBox_urunBarkodu.Location = new System.Drawing.Point(95, 67);
            this.textBox_urunBarkodu.Name = "textBox_urunBarkodu";
            this.textBox_urunBarkodu.Size = new System.Drawing.Size(171, 23);
            this.textBox_urunBarkodu.TabIndex = 1;
            this.textBox_urunBarkodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_urunBarkodu_KeyPress);
            // 
            // labelAdet
            // 
            this.labelAdet.AutoSize = true;
            this.labelAdet.Location = new System.Drawing.Point(95, 113);
            this.labelAdet.Name = "labelAdet";
            this.labelAdet.Size = new System.Drawing.Size(41, 15);
            this.labelAdet.TabIndex = 2;
            this.labelAdet.Text = "Miktar";
            // 
            // ComboBoxAdet
            // 
            this.ComboBoxAdet.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxAdet.CustomizableEdges = customizableEdges1;
            this.ComboBoxAdet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxAdet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAdet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxAdet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxAdet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxAdet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxAdet.ItemHeight = 30;
            this.ComboBoxAdet.Items.AddRange(new object[] {
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
            this.ComboBoxAdet.Location = new System.Drawing.Point(95, 131);
            this.ComboBoxAdet.Name = "ComboBoxAdet";
            this.ComboBoxAdet.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.ComboBoxAdet.Size = new System.Drawing.Size(171, 36);
            this.ComboBoxAdet.TabIndex = 3;
            // 
            // Button_ekle
            // 
            this.Button_ekle.BorderRadius = 20;
            this.Button_ekle.CustomizableEdges = customizableEdges3;
            this.Button_ekle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_ekle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_ekle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_ekle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_ekle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_ekle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_ekle.ForeColor = System.Drawing.Color.White;
            this.Button_ekle.Location = new System.Drawing.Point(67, 204);
            this.Button_ekle.Name = "Button_ekle";
            this.Button_ekle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.Button_ekle.Size = new System.Drawing.Size(227, 45);
            this.Button_ekle.TabIndex = 4;
            this.Button_ekle.Text = "Ekle";
            this.Button_ekle.Click += new System.EventHandler(this.Button_ekle_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 291);
            this.Controls.Add(this.Button_ekle);
            this.Controls.Add(this.ComboBoxAdet);
            this.Controls.Add(this.labelAdet);
            this.Controls.Add(this.textBox_urunBarkodu);
            this.Controls.Add(this.label_urunBarkodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_urunBarkodu;
        private TextBox textBox_urunBarkodu;
        private Label labelAdet;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxAdet;
        private Guna.UI2.WinForms.Guna2Button Button_ekle;
    }
}