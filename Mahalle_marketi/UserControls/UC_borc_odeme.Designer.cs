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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.PanelBorcOdeme = new System.Windows.Forms.Panel();
            this.labelBorcOdeme = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView_borc_ödeme = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnÖde = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.TextBox_kişiAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelBorcOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_borc_ödeme)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBorcOdeme
            // 
            this.PanelBorcOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelBorcOdeme.Controls.Add(this.labelBorcOdeme);
            this.PanelBorcOdeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBorcOdeme.Location = new System.Drawing.Point(0, 0);
            this.PanelBorcOdeme.Name = "PanelBorcOdeme";
            this.PanelBorcOdeme.Size = new System.Drawing.Size(974, 110);
            this.PanelBorcOdeme.TabIndex = 1;
            // 
            // labelBorcOdeme
            // 
            this.labelBorcOdeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBorcOdeme.AutoSize = true;
            this.labelBorcOdeme.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBorcOdeme.ForeColor = System.Drawing.Color.White;
            this.labelBorcOdeme.Location = new System.Drawing.Point(374, 31);
            this.labelBorcOdeme.Name = "labelBorcOdeme";
            this.labelBorcOdeme.Size = new System.Drawing.Size(226, 49);
            this.labelBorcOdeme.TabIndex = 0;
            this.labelBorcOdeme.Text = "Borç Ödeme";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 59.01363F;
            this.Column1.HeaderText = "Müştri Adı";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 84;
            // 
            // DataGridView_borc_ödeme
            // 
            this.DataGridView_borc_ödeme.AllowUserToAddRows = false;
            this.DataGridView_borc_ödeme.AllowUserToDeleteRows = false;
            this.DataGridView_borc_ödeme.AllowUserToResizeColumns = false;
            this.DataGridView_borc_ödeme.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.DataGridView_borc_ödeme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_borc_ödeme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_borc_ödeme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_borc_ödeme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_borc_ödeme.ColumnHeadersHeight = 32;
            this.DataGridView_borc_ödeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column8,
            this.Column5,
            this.Column3,
            this.Column4,
            this.btnÖde});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_borc_ödeme.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_borc_ödeme.GridColor = System.Drawing.Color.White;
            this.DataGridView_borc_ödeme.Location = new System.Drawing.Point(62, 170);
            this.DataGridView_borc_ödeme.MultiSelect = false;
            this.DataGridView_borc_ödeme.Name = "DataGridView_borc_ödeme";
            this.DataGridView_borc_ödeme.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_borc_ödeme.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_borc_ödeme.RowHeadersVisible = false;
            this.DataGridView_borc_ödeme.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataGridView_borc_ödeme.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_borc_ödeme.RowTemplate.Height = 25;
            this.DataGridView_borc_ödeme.Size = new System.Drawing.Size(853, 566);
            this.DataGridView_borc_ödeme.TabIndex = 9;
            this.DataGridView_borc_ödeme.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.DataGridView_borc_ödeme.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.DataGridView_borc_ödeme.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_borc_ödeme.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_borc_ödeme.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.DataGridView_borc_ödeme.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_borc_ödeme.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_borc_ödeme.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DataGridView_borc_ödeme.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.DataGridView_borc_ödeme.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView_borc_ödeme.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_borc_ödeme.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_borc_ödeme.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView_borc_ödeme.ThemeStyle.HeaderStyle.Height = 32;
            this.DataGridView_borc_ödeme.ThemeStyle.ReadOnly = true;
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Empty;
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.Height = 25;
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_borc_ödeme.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView_borc_ödeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_borc_ödeme_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 59.01363F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Müşteri   Adı";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 59.01363F;
            this.Column8.HeaderText = "Satiş Tutarı";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ödenen";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 59.01363F;
            this.Column3.HeaderText = "Kalan Borc";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 100.3633F;
            this.Column4.HeaderText = "zaman bilgisi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnÖde
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            this.btnÖde.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnÖde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÖde.HeaderText = "";
            this.btnÖde.Name = "btnÖde";
            this.btnÖde.ReadOnly = true;
            this.btnÖde.Text = "Öde";
            this.btnÖde.UseColumnTextForButtonValue = true;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 35;
            this.btn_search.Location = new System.Drawing.Point(851, 128);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(38, 36);
            this.btn_search.TabIndex = 10;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // TextBox_kişiAra
            // 
            this.TextBox_kişiAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_kişiAra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBox_kişiAra.BorderRadius = 20;
            this.TextBox_kişiAra.CustomizableEdges = customizableEdges1;
            this.TextBox_kişiAra.DefaultText = "";
            this.TextBox_kişiAra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_kişiAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_kişiAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_kişiAra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_kişiAra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_kişiAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_kişiAra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_kişiAra.Location = new System.Drawing.Point(596, 128);
            this.TextBox_kişiAra.Name = "TextBox_kişiAra";
            this.TextBox_kişiAra.PasswordChar = '\0';
            this.TextBox_kişiAra.PlaceholderText = "";
            this.TextBox_kişiAra.SelectedText = "";
            this.TextBox_kişiAra.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.TextBox_kişiAra.Size = new System.Drawing.Size(230, 36);
            this.TextBox_kişiAra.TabIndex = 11;
            this.TextBox_kişiAra.TextOffset = new System.Drawing.Point(7, 0);
            this.TextBox_kişiAra.TextChanged += new System.EventHandler(this.TextBox_urunAra_TextChanged);
            // 
            // UC_borc_odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox_kişiAra);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.DataGridView_borc_ödeme);
            this.Controls.Add(this.PanelBorcOdeme);
            this.Name = "UC_borc_odeme";
            this.Size = new System.Drawing.Size(974, 828);
            this.Load += new System.EventHandler(this.UC_borc_odeme_Load);
            this.PanelBorcOdeme.ResumeLayout(false);
            this.PanelBorcOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_borc_ödeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelBorcOdeme;
        private Label labelBorcOdeme;
        private DataGridViewTextBoxColumn Column1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_borc_ödeme;
        private DataGridViewTextBoxColumn Column2;
        private FontAwesome.Sharp.IconButton btn_search;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_kişiAra;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn btnÖde;
    }
}
