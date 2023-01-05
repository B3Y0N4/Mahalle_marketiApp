namespace Mahalle_marketi
{
    partial class BorçÖdeme
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
            this.ÖdenecekTutar_girişi = new System.Windows.Forms.TextBox();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.btn_öde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ÖdenecekTutar_girişi
            // 
            this.ÖdenecekTutar_girişi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ÖdenecekTutar_girişi.BackColor = System.Drawing.Color.White;
            this.ÖdenecekTutar_girişi.Location = new System.Drawing.Point(56, 86);
            this.ÖdenecekTutar_girişi.Name = "ÖdenecekTutar_girişi";
            this.ÖdenecekTutar_girişi.Size = new System.Drawing.Size(193, 23);
            this.ÖdenecekTutar_girişi.TabIndex = 0;
            this.ÖdenecekTutar_girişi.Text = "Ödemek İstediğniz Tutarı Giriniz";
            this.ÖdenecekTutar_girişi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tutar.BackColor = System.Drawing.Color.White;
            this.textBox_tutar.Location = new System.Drawing.Point(56, 130);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(193, 23);
            this.textBox_tutar.TabIndex = 1;
            this.textBox_tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_tutar.Click += new System.EventHandler(this.textBox_tutar_Click);
            this.textBox_tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tutar_KeyPress);
            // 
            // btn_öde
            // 
            this.btn_öde.BackColor = System.Drawing.Color.Green;
            this.btn_öde.ForeColor = System.Drawing.Color.White;
            this.btn_öde.Location = new System.Drawing.Point(56, 168);
            this.btn_öde.Name = "btn_öde";
            this.btn_öde.Size = new System.Drawing.Size(193, 57);
            this.btn_öde.TabIndex = 2;
            this.btn_öde.Text = "Ödeme Yap";
            this.btn_öde.UseVisualStyleBackColor = false;
            this.btn_öde.Click += new System.EventHandler(this.btn_öde_Click);
            // 
            // BorçÖdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(313, 258);
            this.Controls.Add(this.btn_öde);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.ÖdenecekTutar_girişi);
            this.Name = "BorçÖdeme";
            this.Text = "BorçÖdeme";
            this.Load += new System.EventHandler(this.BorçÖdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ÖdenecekTutar_girişi;
        private TextBox tutar;
        private Button btn_öde;
        private TextBox textBox_tutar;
    }
}