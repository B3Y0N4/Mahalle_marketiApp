using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahalle_marketi
{
    public partial class AddProductForm : Form
    {
        public int urun_Bk;
        public int miktar;
        public AddProductForm()
        {
            InitializeComponent();
        }
        

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            ComboBoxAdet.SelectedIndex = 0;
        }

        private void Button_ekle_Click(object sender, EventArgs e)
        {
            if (textBox_urunBarkodu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ürün Barkodu alanı boş bırakılmamalı", "" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (textBox_urunBarkodu.Text.Contains(' '))
            {
                MessageBox.Show("Ürün Barkodu alanında boşluk bırakılmamalı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool urun_sorgula = DbUrun.check_urunBk_availability(Int32.Parse(textBox_urunBarkodu.Text.Trim()));
                if (!urun_sorgula)
                {
                    MessageBox.Show("Bu barkod, stokta hiçbir ürüne ait değil", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                return;
            }
            

            urun_Bk = Int32.Parse(textBox_urunBarkodu.Text.Trim());
            miktar = Int32.Parse(ComboBoxAdet.Text.Trim());

            this.Close();




        }

        private void textBox_urunBarkodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
