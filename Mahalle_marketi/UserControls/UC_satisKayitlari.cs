using MySqlX.XDevAPI.Relational;
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
    public partial class UC_satisKayitlari : UserControl
    {
        List<String> satisId_listesi = new List<String>();
        int satis_toplam_tutar;
        int odenen_satis_adeti;
        int odenen_satis_tutari;

        public UC_satisKayitlari()
        {
            InitializeComponent();
        }

        private void UC_satisKayitlari_Load(object sender, EventArgs e)
        {
            ComboBox_filtreleme.SelectedIndex = 0;


        }

        void istatistikleri_guncelle()
        {
            label_satis_toplamAdeti.Text = DataGridView_satisKayitlari.Rows.Count.ToString();
            satis_toplam_tutar = 0;
            foreach (DataGridViewRow row in DataGridView_satisKayitlari.Rows)
            {
                satis_toplam_tutar += (int)DataGridView_satisKayitlari.Rows[row.Index].Cells[1].Value;
            }
            label_satis_toplamTutar.Text = satis_toplam_tutar.ToString() + " ₺";


            odenen_satis_adeti = 0;
            foreach (DataGridViewRow row in DataGridView_satisKayitlari.Rows)
            {
                odenen_satis_adeti = (int)DataGridView_satisKayitlari.Rows[row.Index].Cells[2].Value != 0 ? odenen_satis_adeti + 1 : odenen_satis_adeti;
            }
            label_odenen_satisAdeti.Text = odenen_satis_adeti.ToString();
            label_borc_adeti.Text = (DataGridView_satisKayitlari.Rows.Count - odenen_satis_adeti).ToString();


            odenen_satis_tutari = 0;
            foreach (DataGridViewRow row in DataGridView_satisKayitlari.Rows)
            {
                odenen_satis_tutari += (int)DataGridView_satisKayitlari.Rows[row.Index].Cells[2].Value;
            }
            label_odenen_satisTutari.Text = odenen_satis_tutari.ToString() + " ₺";
            label_borc_tutari.Text = (satis_toplam_tutar - odenen_satis_tutari).ToString() + " ₺";
        }

        private void tabloyu_doldur(String query, DateTime now, DateTime oldDate, bool parameter)
        {
            DataTable dt;
            try
            {
                dt = DbSatis.Satis_kayitTablosunu_Doldur(query, now, oldDate, parameter) != null ? DbSatis.Satis_kayitTablosunu_Doldur(query, now, oldDate, parameter) : null;
            }
            catch
            {
                return;
            }

            if (dt == null) return;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DataGridView_satisKayitlari.Rows.Insert(0, dr["SMüşteriAdıSoyadı"], dr["StoplamTutar"], dr["Södenen"], dr["Sborç"], dr["Starih"]);
                satisId_listesi.Insert(0, (String)dr["SatışId"]);
            }

            istatistikleri_guncelle();


        }

        private void ComboBox_filtreleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_satisKayitlari.Rows.Clear();
            satisId_listesi.Clear();
            istatistikleri_guncelle();
            DateTime now = DateTime.Now;
            if (ComboBox_filtreleme.Text == "Bugün")
            {
                tabloyu_doldur("select * from satış where kullaniciAdi = @kullanici_adi and DATE(Starih) = CURDATE()", now, now, false);
            }
            else if (ComboBox_filtreleme.Text == "son hafta")
            {
                DateTime bir_hafta_once = now.AddDays(-7);
                tabloyu_doldur("select * from satış where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_hafta_once, now, true);
            }
            else if (ComboBox_filtreleme.Text == "Son ayda")
            {
                DateTime bir_ay_once = now.AddDays(-30);
                tabloyu_doldur("select * from satış where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_ay_once, now, true);
            }
            else if (ComboBox_filtreleme.Text == "Son yılda")
            {
                DateTime bir_yil_once = now.AddYears(-1);
                tabloyu_doldur("select * from satış where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_yil_once, now, true);
            }
            else
            {
                tabloyu_doldur("select * from satış where kullaniciAdi = @kullanici_adi", now, now, false);
            }
        }

        // Silme Butonu
        private void DataGridView_satisKayitlari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Bu satışı kayıt listesinden silmek istediğinizden emin misiniz ?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Satis_urun_silme satis_urun_silme_form = new Satis_urun_silme();
                    satis_urun_silme_form.ShowDialog();

                    if (satis_urun_silme_form.delete_product)
                    {
                        try
                        {
                            DbSatis.satis_sil($"delete from satış where SatışId = @satis_id", satisId_listesi[e.RowIndex]);
                            DbSatisUrun.urun_sil_by_SatisId($"delete from satışürün where Sid = @satis_id", satisId_listesi[e.RowIndex]);
                        }
                        catch
                        {
                            return;
                        }
                        satisId_listesi.RemoveAt(e.RowIndex);
                        DataGridView_satisKayitlari.Rows.RemoveAt(DataGridView_satisKayitlari.SelectedRows[0].Index);
                        istatistikleri_guncelle();
                    }
                }
            }
        }
    }
}
