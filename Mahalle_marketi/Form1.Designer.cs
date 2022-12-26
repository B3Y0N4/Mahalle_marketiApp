namespace Mahalle_marketi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panel_stok = new System.Windows.Forms.Panel();
            this.btn_stok_girisi = new System.Windows.Forms.Button();
            this.btn_urunler = new System.Windows.Forms.Button();
            this.btn_stok = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_tedarikci = new System.Windows.Forms.Button();
            this.btn_borc_odeme = new System.Windows.Forms.Button();
            this.Btn_satis = new System.Windows.Forms.Button();
            this.panelMarket = new System.Windows.Forms.Panel();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.panel_basket = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panel_stok.SuspendLayout();
            this.panelMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.panel_stok);
            this.panelNavigation.Controls.Add(this.btn_stok);
            this.panelNavigation.Controls.Add(this.btn_cikis);
            this.panelNavigation.Controls.Add(this.btn_tedarikci);
            this.panelNavigation.Controls.Add(this.btn_borc_odeme);
            this.panelNavigation.Controls.Add(this.Btn_satis);
            this.panelNavigation.Controls.Add(this.panelMarket);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 517);
            this.panelNavigation.TabIndex = 0;
            // 
            // panel_stok
            // 
            this.panel_stok.BackColor = System.Drawing.Color.White;
            this.panel_stok.Controls.Add(this.btn_stok_girisi);
            this.panel_stok.Controls.Add(this.btn_urunler);
            this.panel_stok.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stok.Location = new System.Drawing.Point(0, 283);
            this.panel_stok.Name = "panel_stok";
            this.panel_stok.Size = new System.Drawing.Size(200, 81);
            this.panel_stok.TabIndex = 8;
            // 
            // btn_stok_girisi
            // 
            this.btn_stok_girisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stok_girisi.FlatAppearance.BorderSize = 0;
            this.btn_stok_girisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_stok_girisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stok_girisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stok_girisi.ForeColor = System.Drawing.Color.Green;
            this.btn_stok_girisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stok_girisi.Location = new System.Drawing.Point(0, 38);
            this.btn_stok_girisi.Name = "btn_stok_girisi";
            this.btn_stok_girisi.Size = new System.Drawing.Size(200, 38);
            this.btn_stok_girisi.TabIndex = 9;
            this.btn_stok_girisi.Text = "                    Stok Girişi";
            this.btn_stok_girisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stok_girisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stok_girisi.UseVisualStyleBackColor = true;
            // 
            // btn_urunler
            // 
            this.btn_urunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_urunler.FlatAppearance.BorderSize = 0;
            this.btn_urunler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_urunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urunler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_urunler.ForeColor = System.Drawing.Color.Green;
            this.btn_urunler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urunler.Location = new System.Drawing.Point(0, 0);
            this.btn_urunler.Name = "btn_urunler";
            this.btn_urunler.Size = new System.Drawing.Size(200, 38);
            this.btn_urunler.TabIndex = 8;
            this.btn_urunler.Text = "                    Ürünler";
            this.btn_urunler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urunler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_urunler.UseVisualStyleBackColor = true;
            // 
            // btn_stok
            // 
            this.btn_stok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stok.FlatAppearance.BorderSize = 0;
            this.btn_stok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_stok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stok.ForeColor = System.Drawing.Color.Green;
            this.btn_stok.Image = ((System.Drawing.Image)(resources.GetObject("btn_stok.Image")));
            this.btn_stok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stok.Location = new System.Drawing.Point(0, 245);
            this.btn_stok.Name = "btn_stok";
            this.btn_stok.Size = new System.Drawing.Size(200, 38);
            this.btn_stok.TabIndex = 7;
            this.btn_stok.Text = "   Stok";
            this.btn_stok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stok.UseVisualStyleBackColor = true;
            this.btn_stok.Click += new System.EventHandler(this.btn_stok_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cikis.ForeColor = System.Drawing.Color.Green;
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.Location = new System.Drawing.Point(0, 479);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(200, 38);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "  Çıkış";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cikis.UseVisualStyleBackColor = true;
            // 
            // btn_tedarikci
            // 
            this.btn_tedarikci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tedarikci.FlatAppearance.BorderSize = 0;
            this.btn_tedarikci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_tedarikci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tedarikci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tedarikci.ForeColor = System.Drawing.Color.Green;
            this.btn_tedarikci.Image = ((System.Drawing.Image)(resources.GetObject("btn_tedarikci.Image")));
            this.btn_tedarikci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tedarikci.Location = new System.Drawing.Point(0, 207);
            this.btn_tedarikci.Name = "btn_tedarikci";
            this.btn_tedarikci.Size = new System.Drawing.Size(200, 38);
            this.btn_tedarikci.TabIndex = 4;
            this.btn_tedarikci.Text = "   Tedarikçi detayları";
            this.btn_tedarikci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tedarikci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tedarikci.UseVisualStyleBackColor = true;
            this.btn_tedarikci.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_borc_odeme
            // 
            this.btn_borc_odeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_borc_odeme.FlatAppearance.BorderSize = 0;
            this.btn_borc_odeme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_borc_odeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borc_odeme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borc_odeme.ForeColor = System.Drawing.Color.Green;
            this.btn_borc_odeme.Image = ((System.Drawing.Image)(resources.GetObject("btn_borc_odeme.Image")));
            this.btn_borc_odeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borc_odeme.Location = new System.Drawing.Point(0, 169);
            this.btn_borc_odeme.Name = "btn_borc_odeme";
            this.btn_borc_odeme.Size = new System.Drawing.Size(200, 38);
            this.btn_borc_odeme.TabIndex = 3;
            this.btn_borc_odeme.Text = "   Borç ödeme";
            this.btn_borc_odeme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borc_odeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borc_odeme.UseVisualStyleBackColor = true;
            this.btn_borc_odeme.Click += new System.EventHandler(this.btn_borc_odeme_Click);
            // 
            // Btn_satis
            // 
            this.Btn_satis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_satis.FlatAppearance.BorderSize = 0;
            this.Btn_satis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.Btn_satis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_satis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_satis.ForeColor = System.Drawing.Color.Green;
            this.Btn_satis.Image = global::Mahalle_marketi.Properties.Resources.icons8_shopping_cart_32__1_;
            this.Btn_satis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_satis.Location = new System.Drawing.Point(0, 131);
            this.Btn_satis.Name = "Btn_satis";
            this.Btn_satis.Size = new System.Drawing.Size(200, 38);
            this.Btn_satis.TabIndex = 1;
            this.Btn_satis.Text = "  Satış";
            this.Btn_satis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_satis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_satis.UseVisualStyleBackColor = true;
            this.Btn_satis.Click += new System.EventHandler(this.Btn_satis_Click);
            // 
            // panelMarket
            // 
            this.panelMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.panelMarket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMarket.Controls.Add(this.labelSeparator);
            this.panelMarket.Controls.Add(this.panel_basket);
            this.panelMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarket.Location = new System.Drawing.Point(0, 0);
            this.panelMarket.Name = "panelMarket";
            this.panelMarket.Size = new System.Drawing.Size(200, 131);
            this.panelMarket.TabIndex = 0;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BackColor = System.Drawing.Color.White;
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSeparator.ForeColor = System.Drawing.Color.White;
            this.labelSeparator.Location = new System.Drawing.Point(0, 130);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(200, 1);
            this.labelSeparator.TabIndex = 1;
            // 
            // panel_basket
            // 
            this.panel_basket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.panel_basket.BackgroundImage = global::Mahalle_marketi.Properties.Resources.tutti_shopping_basket_with_fruit_milk_and_wine_1;
            this.panel_basket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_basket.Location = new System.Drawing.Point(32, 0);
            this.panel_basket.Name = "panel_basket";
            this.panel_basket.Size = new System.Drawing.Size(139, 114);
            this.panel_basket.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 517);
            this.Controls.Add(this.panelNavigation);
            this.Name = "Form1";
            this.Text = "Market Sistem yönetimi";
            this.panelNavigation.ResumeLayout(false);
            this.panel_stok.ResumeLayout(false);
            this.panelMarket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNavigation;
        private Button btn_cikis;
        private Button btn_tedarikci;
        private Button btn_borc_odeme;
        private Button Btn_satis;
        private Panel panelMarket;
        private Panel panel_basket;
        private Label labelSeparator;
        private Panel panel_stok;
        private Button btn_stok_girisi;
        private Button btn_urunler;
        private Button btn_stok;
    }
}