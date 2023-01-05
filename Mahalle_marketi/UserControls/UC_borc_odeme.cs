using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_borc_odeme : UserControl
    {
        List<String> satis_Idleri = new List<String>();
        public UC_borc_odeme()
        {
            InitializeComponent();
        }

        private void tabloyu_doldur(String query)
        {
            DataGridView_borc_ödeme.Rows.Clear();
            DataTable dt;
            try
            {
                dt = DbSatis.borc_kayitTablosunu_Doldur(query) != null ? DbSatis.borc_kayitTablosunu_Doldur(query) : null;
            }
            catch
            {
                return;
            }

            if (dt == null) return;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DataGridView_borc_ödeme.Rows.Insert(0, dr["SMüşteriAdıSoyadı"], dr["StoplamTutar"], dr["Södenen"], dr["Sborç"], dr["Starih"]);
                satis_Idleri.Insert(0,(String)dr["SatışId"]);
            }
            
        }

        private void DataGridView_borc_ödeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                String satis_id = satis_Idleri[e.RowIndex];
                int mevcut_odenen = (int)DataGridView_borc_ödeme.Rows[e.RowIndex].Cells[2].Value;
                int mevcut_borc = (int)DataGridView_borc_ödeme.Rows[e.RowIndex].Cells[3].Value;
                BorçÖdeme borçödeme = new BorçÖdeme(this);
                borçödeme.mevcut_borc = mevcut_borc;
                borçödeme.ShowDialog();

                String musteri_adi = (String)DataGridView_borc_ödeme.Rows[e.RowIndex].Cells[0].Value;


                int odenen_yeni_miktar = borçödeme.odenen_miktar + mevcut_odenen;
                int borc_yeni_miktar = mevcut_borc - borçödeme.odenen_miktar;

                try
                {
                    DbSatis.borclari_guncelle("update satış set Södenen = @toplam_odenen, Sborç = @toplam_borc where SatışId = @satis_id and kullaniciAdi = @kullanici_adi and SMüşteriAdıSoyadı = @isim_soyisim", satis_id, odenen_yeni_miktar, borc_yeni_miktar, musteri_adi);
                    tabloyu_doldur("select * from satış where SMüşteriAdıSoyadı is not null and kullaniciAdi = @kullanici_adi");
                }
                catch
                {
                    return;
                }


            }
            
        }

        private void UC_borc_odeme_Load(object sender, EventArgs e)
        {
            tabloyu_doldur("select * from satış where SMüşteriAdıSoyadı is not null and kullaniciAdi = @kullanici_adi");
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            DataGridView_borc_ödeme.Rows.Clear();

            String aranan = TextBox_kişiAra.Text.Trim();

            DateTime now = DateTime.Now;
        }

        private void TextBox_urunAra_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

