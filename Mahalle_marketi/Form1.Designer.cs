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
            this.panelMarket = new System.Windows.Forms.Panel();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.panel_basket = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panelMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.panelMarket);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 517);
            this.panelNavigation.TabIndex = 0;
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
            this.panelMarket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNavigation;
        private Panel panelMarket;
        private Panel panel_basket;
        private Label labelSeparator;
    }
}