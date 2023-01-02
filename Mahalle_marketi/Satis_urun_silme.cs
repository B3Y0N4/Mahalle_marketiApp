using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahalle_marketi
{
    public partial class Satis_urun_silme : Form
    {
        public bool delete_product = false;
        public Satis_urun_silme()
        {
            InitializeComponent();
        }

        private void btn_show_hide_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox1.Hide();
        }

        private void btn_show_hide_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextBox_sifre.Text = TextBox1.Text;
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (TextBox_sifre.Text == "")
            {
                MessageBox.Show("Lütfen şifrenizi giriniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TextBox_sifre.Text.Trim() != kullanici.kullanici_sifresi)
            {
                MessageBox.Show("Girdiğiniz şifre yanlış! Tekrar deneyiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            delete_product = true;
            Close();
        }
    }
}
