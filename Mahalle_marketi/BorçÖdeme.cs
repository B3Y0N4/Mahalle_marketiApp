using Mahalle_marketi.UserControls;
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
    public partial class BorçÖdeme : Form
    {
        public int mevcut_odenen;
        public int mevcut_borc;
        public int odenen_miktar;
        UC_borc_odeme uc_borc_odemedgw;
        public BorçÖdeme(UC_borc_odeme uc_borc_odemed)
        {
            InitializeComponent();
        UC_borc_odeme uc_borc_odemedgw;
            this.uc_borc_odemedgw = uc_borc_odemed;
        }

        private void BorçÖdeme_Load(object sender, EventArgs e)
        {

        }

        private void btn_öde_Click(object sender, EventArgs e)
        {
            if(textBox_tutar.Text.Trim().Length == 0)
            {
                MessageBox.Show("Boş tutar girdiniz tekrar deneyiniz");
                return;
            }

            
            odenen_miktar = Int32.Parse(textBox_tutar.Text.Trim());
            if(odenen_miktar > mevcut_borc) 
            {
                MessageBox.Show("Borcunundan daha büyük tutar girdiniz");
                return;
            }

            if(odenen_miktar <= mevcut_borc)
            {
                MessageBox.Show("Borcununuzu başarli başarli bir şekilde ödediniz");
                return;
            }

        }

        private void textBox_tutar_Click(object sender, EventArgs e)
        {

        }

        private void textBox_tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
