using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_satis : UserControl
    {
        
        public static int urun_Bk;
        public static int miktar;
        public UC_satis()
        {
            InitializeComponent(); 
        }
        private void UC_satis_Load(object sender, EventArgs e)
        {
            comboBoxSatis.SelectedIndex = 0;
        }

        private void comboBoxSatis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSatis.Text == "Peşin satış")
            {
                textBoxIsim.Visible = false;
                labelisimSoyisim.Visible = false;
            }
            else
            {
                textBoxIsim.Visible = true;
                labelisimSoyisim.Visible = true;
            }
        }

        private void btn_urun_ekle_Click(object sender, EventArgs e)
        {
            AddProductForm urunEkle_ekrani = new AddProductForm();
            urunEkle_ekrani.ShowDialog();

            urun_Bk = urunEkle_ekrani.urun_Bk;
            miktar = urunEkle_ekrani.miktar;

            Ürün urun = DbUrun.find_urunByBk(urun_Bk);
            var tutar = miktar * urun.Urun_satisFiyati;
            DataGridViewSatisEkrani.Rows.Add(urun.Urun_barKd, urun.Urun_adi, miktar, urun.Urun_miktarBirimi, urun.Urun_satisFiyati, tutar);
        }

        private void DataGridViewSatisEkrani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("edit");
                return;
            }
            if (e.ColumnIndex == 7)
            {
                MessageBox.Show("delete");
            }
        }
    }
}
