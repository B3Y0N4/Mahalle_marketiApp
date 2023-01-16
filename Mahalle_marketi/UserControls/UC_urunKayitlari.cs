
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_urunKayitlari : UserControl
    {
        List<String> satisId_listesi = new List<String>();
        int urun_toplam_miktari;
        int urun_toplam_tutari;
        int odenen_urun_miktari;
        int odenen_toplamTutari;
        public UC_urunKayitlari()
        {
            InitializeComponent();
        }
        public String conString = "Data Source=LAPTOP-L2L5OAL6;Initial Catalog=mahalle_marketi;Integrated Security=True";

        private void UC_urunKayitlari_Load(object sender, EventArgs e)
        {
            ComboBox_filtreleme.SelectedIndex = 0;
            ComboBox_enCokSatan_filtreleme.SelectedIndex = 0;
            DateTime now = DateTime.Now;
            urun_kayitTablosunu_Doldur("select * from satisÜrün CONVERT(DATETIME, starih, 103) = CURDATE()", now, now, false);
            istatistikleri_guncelle();
        }



        private void urun_kayitTablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            DataTable dt;
            try 
            {
                dt = DbSatisUrun.urun_kayitTablosunu_Doldur(query, oldDate, now, parameter) != null ? DbSatisUrun.urun_kayitTablosunu_Doldur(query, oldDate, now, parameter) : null;
            }
            catch
            {
                return;
            }
            
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DataGridView_urunKayitlari.Rows.Insert(0, dr["ÜrünBk"], dr["ÜrünAdı"], dr["Miktar"], dr["ToplamTutar"], dr["Ödenen"], dr["borç"], dr["Starih"]);
                satisId_listesi.Insert(0, (String)dr["Sid"]);
            }
            istatistikleri_guncelle();


        }


        private void enCokSatan_Tablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            DataTable dt;
            try
            {
                dt = DbSatisUrun.enCokSatan_Tablosunu_Doldur(query, oldDate, now, parameter) != null ? DbSatisUrun.enCokSatan_Tablosunu_Doldur(query, oldDate, now, parameter) : null;
            }
            catch
            {
                return;
            }

            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DataGridView_enCokSatan.Rows.Insert(0, dr["ÜrünBk"], dr["ÜrünAdı"], dr["toplam_miktar"], dr["toplam_tutar"], dr["toplam_odenen"], dr["toplam_borc"]);

            }


        }

        void istatistikleri_guncelle()
        {
            urun_toplam_miktari = 0;
            foreach (DataGridViewRow row in DataGridView_urunKayitlari.Rows)
            {
                urun_toplam_miktari += (int)DataGridView_urunKayitlari.Rows[row.Index].Cells[2].Value;
            }
            label_urun_toplamMiktari.Text = urun_toplam_miktari.ToString() + " adet/kg";


            urun_toplam_tutari = 0;
            foreach (DataGridViewRow row in DataGridView_urunKayitlari.Rows)
            {
                urun_toplam_tutari += (int)DataGridView_urunKayitlari.Rows[row.Index].Cells[3].Value;
            }
            label_urun_toplamTutar.Text = urun_toplam_tutari.ToString() + " ₺";


            odenen_urun_miktari = 0;
            foreach (DataGridViewRow row in DataGridView_urunKayitlari.Rows)
            {
                odenen_urun_miktari = (int)DataGridView_urunKayitlari.Rows[row.Index].Cells[3].Value == (int)DataGridView_urunKayitlari.Rows[row.Index].Cells[4].Value ? odenen_urun_miktari + (int)DataGridView_urunKayitlari.Rows[row.Index].Cells[2].Value : odenen_urun_miktari;
            }
            label_odenen_miktar.Text = odenen_urun_miktari.ToString() + " adet/kg";
            label_borc_olarak_urunMiktar.Text = (urun_toplam_miktari - odenen_urun_miktari).ToString() + " adet/kg";


            odenen_toplamTutari = 0;
            foreach (DataGridViewRow row in DataGridView_urunKayitlari.Rows)
            {
                odenen_toplamTutari += (int)DataGridView_urunKayitlari.Rows[row.Index].Cells[4].Value;
            }
            label_odenen_toplamTutari.Text = odenen_toplamTutari.ToString() + " ₺";
            label_borc_toplamTutari.Text = (urun_toplam_tutari - odenen_toplamTutari).ToString() + " ₺";
        }

        

        

        void search_based_onTime()
        {
            DateTime now = DateTime.Now;
            switch (ComboBox_filtreleme.Text)
            {
                case "Bugün":
                    urun_kayitTablosunu_Doldur("select * from satışürün where kullaniciAdi = @kullanici_adi and DATE(Starih) = CURDATE()", now, now, false);
                    break;
                case "son hafta":
                    DateTime bir_hafta_once = now.AddDays(-7);
                    urun_kayitTablosunu_Doldur("select * from satışürün where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_hafta_once, now, true);
                    break;
                case "Son ayda":
                    DateTime bir_ay_once = now.AddDays(-30);
                    urun_kayitTablosunu_Doldur("select * from satışürün where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_ay_once, now, true);

                    break;
                case "Son yılda":
                    DateTime bir_yil_once = now.AddYears(-1);
                    urun_kayitTablosunu_Doldur("select * from satışürün where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_yil_once, now, true);
                    break;
                default:
                    urun_kayitTablosunu_Doldur("select * from satışürün where kullaniciAdi = @kullanici_adi", now, now, false);
                    break;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataGridView_urunKayitlari.Rows.Clear();
            satisId_listesi.Clear();
            istatistikleri_guncelle();

            String aranan = TextBox_urunAra.Text.Trim();

            if (aranan == "")
            {
                search_based_onTime();
                return;
            }
            if (aranan == "Ürün arama, örnek: elma" && TextBox_urunAra.ForeColor != Color.Black)
            {
                search_based_onTime();
                return;
            }

            DateTime now = DateTime.Now;

            switch (ComboBox_filtreleme.Text)
            {
                case "Bugün":
                    urun_kayitTablosunu_Doldur($"select * from satışürün where ÜrünAdı like '{aranan}%' and kullaniciAdi = @kullanici_adi and DATE(Starih) = CURDATE()", now, now, false);
                    break;
                case "son hafta":
                    DateTime bir_hafta_once = now.AddDays(-7);
                    urun_kayitTablosunu_Doldur($"select * from satışürün where ÜrünAdı like '{aranan}%' and kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_hafta_once, now, true);
                    break;
                case "Son ayda":
                    DateTime bir_ay_once = now.AddDays(-30);
                    urun_kayitTablosunu_Doldur($"select * from satışürün where ÜrünAdı like '{aranan}%' and kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_ay_once, now, true);

                    break;
                case "Son yılda":
                    DateTime bir_yil_once = now.AddYears(-1);
                    urun_kayitTablosunu_Doldur($"select * from satışürün where ÜrünAdı like '{aranan}%' and kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now", bir_yil_once, now, true);
                    break;
                default:
                    urun_kayitTablosunu_Doldur($"select * from satışürün where ÜrünAdı like '{aranan}%' and kullaniciAdi = @kullanici_adi", now, now, false);
                    break;
            }
        }

        private void TextBox_urunAra_Enter(object sender, EventArgs e)
        {
            if (TextBox_urunAra.Text == "Ürün arama, örnek: elma")
            {
                TextBox_urunAra.Text = "";
                TextBox_urunAra.ForeColor = Color.Black;
            }
        }

        private void TextBox_urunAra_Leave(object sender, EventArgs e)
        {
            if (TextBox_urunAra.Text == "")
            {
                TextBox_urunAra.Text = "Ürün arama, örnek: elma";
                TextBox_urunAra.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        private void ComboBox_enCokSatan_filtreleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_enCokSatan.Rows.Clear();
            DateTime now = DateTime.Now;
            if (ComboBox_enCokSatan_filtreleme.Text == "Bugün")
            {
                enCokSatan_Tablosunu_Doldur("select ÜrünBk, ÜrünAdı, sum(Miktar) as toplam_miktar, sum(ToplamTutar) as toplam_tutar, sum(Ödenen) as toplam_odenen, sum(borç) as toplam_borc from satışürün where kullaniciAdi = @kullanici_adi and DATE(Starih) = CURDATE() group by ÜrünBk order by toplam_miktar", now, now, false);
            }
            else if (ComboBox_enCokSatan_filtreleme.Text == "son hafta")
            {
                DateTime bir_hafta_once = now.AddDays(-7);
                enCokSatan_Tablosunu_Doldur("select ÜrünBk, ÜrünAdı, sum(Miktar) as toplam_miktar, sum(ToplamTutar) as toplam_tutar, sum(Ödenen) as toplam_odenen, sum(borç) as toplam_borc from satışürün where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now group by ÜrünBk order by toplam_miktar", bir_hafta_once, now, true);
            }
            else if (ComboBox_enCokSatan_filtreleme.Text == "Son ayda")
            {
                DateTime bir_ay_once = now.AddDays(-30);
                enCokSatan_Tablosunu_Doldur("select ÜrünBk, ÜrünAdı, sum(Miktar) as toplam_miktar, sum(ToplamTutar) as toplam_tutar, sum(Ödenen) as toplam_odenen, sum(borç) as toplam_borc from satışürün where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now group by ÜrünBk order by toplam_miktar", bir_ay_once, now, true);
            }
            else if (ComboBox_enCokSatan_filtreleme.Text == "Son yılda")
            {
                DateTime bir_yil_once = now.AddYears(-1);
                enCokSatan_Tablosunu_Doldur("select ÜrünBk, ÜrünAdı, sum(Miktar) as toplam_miktar, sum(ToplamTutar) as toplam_tutar, sum(Ödenen) as toplam_odenen, sum(borç) as toplam_borc from satışürün where kullaniciAdi = @kullanici_adi and Starih between @oldDate and @now group by ÜrünBk order by toplam_miktar", bir_yil_once, now, true);
            }
            else
            {
                enCokSatan_Tablosunu_Doldur("select ÜrünBk, ÜrünAdı, sum(Miktar) as toplam_miktar, sum(ToplamTutar) as toplam_tutar, sum(Ödenen) as toplam_odenen, sum(borç) as toplam_borc from satışürün where kullaniciAdi = @kullanici_adi group by ÜrünBk order by toplam_miktar", now, now, false);
            }
        }

        private void DataGridView_urunKayitlari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Bu ürünü satış ürün kaydı listesinden silmek istediğinizden emin misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Satis_urun_silme satis_urun_silme_form = new Satis_urun_silme();
                    satis_urun_silme_form.ShowDialog();

                    if (satis_urun_silme_form.delete_product)
                    {
                        int odenen;
                        int kalan;
                        int borc;
                        string ad_soyad;
                        try
                        {
                            DbSatisUrun.urun_sil_by_SatisId_and_urunKb($"delete from satışürün where Sid = @satis_id and ÜrünBk = @urun_bk", satisId_listesi[e.RowIndex], (int)DataGridView_urunKayitlari.Rows[e.RowIndex].Cells[0].Value);
                            Dictionary<String, object> map = DbSatis.get_satis_toplamTutar("select * from satış where SatışId = @satis_id", satisId_listesi[e.RowIndex]);
                            ad_soyad= (String)map["ad soyad"];
                            int satis_toplam_tutari = (int)map["toplam tutar"];
                            odenen = (int)map["odenen"];
                            borc = (int)map["borc"];
                            kalan = satis_toplam_tutari - (int)DataGridView_urunKayitlari.Rows[e.RowIndex].Cells[3].Value;
                            if (kalan == 0)
                            {
                                DbSatis.satis_sil($"delete from satış where SatışId = @satis_id", satisId_listesi[e.RowIndex]);
                            }
                            else
                            {
                                if (odenen == 0)
                                {
                                    borc -= (int)DataGridView_urunKayitlari.Rows[e.RowIndex].Cells[3].Value;
                                    DbSatis.satis_guncelle($"update satış set StoplamTutar = @toplam_tutar, Södenen = @toplam_odenen, Sborç = @toplam_borc where SatışId = @satis_id", satisId_listesi[e.RowIndex], kalan, odenen, borc);

                                }
                                else if (borc == 0)
                                {
                                    odenen -= (int)DataGridView_urunKayitlari.Rows[e.RowIndex].Cells[3].Value;
                                    DbSatis.satis_guncelle($"update satış set StoplamTutar = @toplam_tutar, Södenen = @toplam_odenen, Sborç = @toplam_borc where SatışId = @satis_id", satisId_listesi[e.RowIndex], kalan, odenen, borc);

                                }
                                else if (kalan >= odenen)
                                {
                                    borc = kalan - odenen;
                                    DbSatis.satis_guncelle($"update satış set StoplamTutar = @toplam_tutar, Södenen = @toplam_odenen, Sborç = @toplam_borc where SatışId = @satis_id", satisId_listesi[e.RowIndex], kalan, odenen, borc);

                                }
                                else
                                {
                                    borc = kalan - odenen;
                                    DbSatis.satis_sil($"delete from satış where SatışId = @satis_id", satisId_listesi[e.RowIndex]);
                                    if (kalan < odenen)
                                    {
                                        MessageBox.Show($"{ad_soyad} adlı kişiye {borc} TL para iadesi yapılacaktır\n", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }

                                }
                            }
                        }
                        catch
                        {
                            return;
                        }
                        
                        satisId_listesi.RemoveAt(e.RowIndex);
                        DataGridView_urunKayitlari.Rows.RemoveAt(DataGridView_urunKayitlari.SelectedRows[0].Index);
                        istatistikleri_guncelle();
                    }
                }
            }
        }
    }


    
}
