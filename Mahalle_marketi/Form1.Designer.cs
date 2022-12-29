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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btn_kayitlar = new FontAwesome.Sharp.IconButton();
            this.btn_cikis = new FontAwesome.Sharp.IconButton();
            this.btn_stok = new FontAwesome.Sharp.IconButton();
            this.btn_tedarikci_detaylari = new FontAwesome.Sharp.IconButton();
            this.btn_borc_odeme = new FontAwesome.Sharp.IconButton();
            this.btn_satis = new FontAwesome.Sharp.IconButton();
            this.panelMarket = new System.Windows.Forms.Panel();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.panel_basket = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panelMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.btn_kayitlar);
            this.panelNavigation.Controls.Add(this.btn_cikis);
            this.panelNavigation.Controls.Add(this.btn_stok);
            this.panelNavigation.Controls.Add(this.btn_tedarikci_detaylari);
            this.panelNavigation.Controls.Add(this.btn_borc_odeme);
            this.panelNavigation.Controls.Add(this.btn_satis);
            this.panelNavigation.Controls.Add(this.panelMarket);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(230, 611);
            this.panelNavigation.TabIndex = 0;
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kayitlar.FlatAppearance.BorderSize = 0;
            this.btn_kayitlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_kayitlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayitlar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_kayitlar.ForeColor = System.Drawing.Color.Green;
            this.btn_kayitlar.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btn_kayitlar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_kayitlar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_kayitlar.IconSize = 25;
            this.btn_kayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.Location = new System.Drawing.Point(0, 360);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(230, 50);
            this.btn_kayitlar.TabIndex = 6;
            this.btn_kayitlar.Text = "  Kayıtlar";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_kayitlar.UseVisualStyleBackColor = true;
            this.btn_kayitlar.Click += new System.EventHandler(this.btn_kayitlar_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cikis.ForeColor = System.Drawing.Color.Green;
            this.btn_cikis.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_cikis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_cikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cikis.IconSize = 25;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.Location = new System.Drawing.Point(0, 561);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(230, 50);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "  Çıkış";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_stok
            // 
            this.btn_stok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stok.FlatAppearance.BorderSize = 0;
            this.btn_stok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_stok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stok.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stok.ForeColor = System.Drawing.Color.Green;
            this.btn_stok.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btn_stok.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_stok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stok.IconSize = 25;
            this.btn_stok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stok.Location = new System.Drawing.Point(0, 310);
            this.btn_stok.Name = "btn_stok";
            this.btn_stok.Size = new System.Drawing.Size(230, 50);
            this.btn_stok.TabIndex = 4;
            this.btn_stok.Text = "  Stok";
            this.btn_stok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stok.UseVisualStyleBackColor = true;
            this.btn_stok.Click += new System.EventHandler(this.btn_stok_Click);
            // 
            // btn_tedarikci_detaylari
            // 
            this.btn_tedarikci_detaylari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tedarikci_detaylari.FlatAppearance.BorderSize = 0;
            this.btn_tedarikci_detaylari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_tedarikci_detaylari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tedarikci_detaylari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tedarikci_detaylari.ForeColor = System.Drawing.Color.Green;
            this.btn_tedarikci_detaylari.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btn_tedarikci_detaylari.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_tedarikci_detaylari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_tedarikci_detaylari.IconSize = 25;
            this.btn_tedarikci_detaylari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tedarikci_detaylari.Location = new System.Drawing.Point(0, 260);
            this.btn_tedarikci_detaylari.Name = "btn_tedarikci_detaylari";
            this.btn_tedarikci_detaylari.Size = new System.Drawing.Size(230, 50);
            this.btn_tedarikci_detaylari.TabIndex = 3;
            this.btn_tedarikci_detaylari.Text = "  Tedarikçi detayları";
            this.btn_tedarikci_detaylari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tedarikci_detaylari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tedarikci_detaylari.UseVisualStyleBackColor = true;
            this.btn_tedarikci_detaylari.Click += new System.EventHandler(this.btn_tedarikci_detaylari_Click);
            // 
            // btn_borc_odeme
            // 
            this.btn_borc_odeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_borc_odeme.FlatAppearance.BorderSize = 0;
            this.btn_borc_odeme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_borc_odeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borc_odeme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borc_odeme.ForeColor = System.Drawing.Color.Green;
            this.btn_borc_odeme.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btn_borc_odeme.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_borc_odeme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_borc_odeme.IconSize = 25;
            this.btn_borc_odeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borc_odeme.Location = new System.Drawing.Point(0, 210);
            this.btn_borc_odeme.Name = "btn_borc_odeme";
            this.btn_borc_odeme.Size = new System.Drawing.Size(230, 50);
            this.btn_borc_odeme.TabIndex = 2;
            this.btn_borc_odeme.Text = "  Borç ödeme";
            this.btn_borc_odeme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_borc_odeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_borc_odeme.UseVisualStyleBackColor = true;
            this.btn_borc_odeme.Click += new System.EventHandler(this.btn_borc_odeme_Click);
            // 
            // btn_satis
            // 
            this.btn_satis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_satis.FlatAppearance.BorderSize = 0;
            this.btn_satis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.btn_satis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_satis.ForeColor = System.Drawing.Color.Green;
            this.btn_satis.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.btn_satis.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.btn_satis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_satis.IconSize = 25;
            this.btn_satis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_satis.Location = new System.Drawing.Point(0, 160);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(230, 50);
            this.btn_satis.TabIndex = 1;
            this.btn_satis.Text = "  Satış";
            this.btn_satis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_satis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
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
            this.panelMarket.Size = new System.Drawing.Size(230, 160);
            this.panelMarket.TabIndex = 0;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BackColor = System.Drawing.Color.White;
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSeparator.ForeColor = System.Drawing.Color.White;
            this.labelSeparator.Location = new System.Drawing.Point(0, 159);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(230, 1);
            this.labelSeparator.TabIndex = 1;
            // 
            // panel_basket
            // 
            this.panel_basket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(252)))), ((int)(((byte)(76)))));
            this.panel_basket.BackgroundImage = global::Mahalle_marketi.Properties.Resources.tutti_shopping_basket_with_fruit_milk_and_wine_1;
            this.panel_basket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_basket.Location = new System.Drawing.Point(46, 23);
            this.panel_basket.Name = "panel_basket";
            this.panel_basket.Size = new System.Drawing.Size(139, 114);
            this.panel_basket.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(230, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(654, 611);
            this.panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelNavigation);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Sistem yönetimi";
            this.panelNavigation.ResumeLayout(false);
            this.panelMarket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNavigation;
        private Panel panelMarket;
        private Panel panel_basket;
        private Label labelSeparator;
        private FontAwesome.Sharp.IconButton btn_cikis;
        private FontAwesome.Sharp.IconButton btn_stok;
        private FontAwesome.Sharp.IconButton btn_tedarikci_detaylari;
        private FontAwesome.Sharp.IconButton btn_borc_odeme;
        private FontAwesome.Sharp.IconButton btn_satis;
        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton btn_kayitlar;
    }
}