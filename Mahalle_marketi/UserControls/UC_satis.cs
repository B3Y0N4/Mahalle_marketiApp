using MySql.Data.MySqlClient;
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
        private int bitmek_uzere_olan_urun_sayisi;
        private String kullanici_adi;
        private String kullanici_sifresi;
        public static int urun_Bk;
        public static int miktar;
        public int guncellenmesi_istenen_miktar;
        public int toplam_tutar;

        public UC_satis()
        {
            InitializeComponent();
            kullanici_adi = kullanici.kullanici_adi;
            kullanici_sifresi = kullanici.kullanici_sifresi;



        }
        private void UC_satis_Load(object sender, EventArgs e)
        {
            comboBoxSatis.SelectedIndex = 0;
            panel_tumunuSil.Visible = false;
            panel_uyari.Visible = false;

            uyari_mesaji();


        }

        private void uyari_mesaji()
        {
            bitmek_uzere_olan_urun_sayisi = DbUrun.bitmek_uzere_olan_urun_sayisi();
            if (bitmek_uzere_olan_urun_sayisi > 0)
            {
                panel_uyari.Visible = true;
                label_biten_urun_sayisi.Text = $"Stokta {bitmek_uzere_olan_urun_sayisi} adet ürün";
            }
            else
            {
                panel_uyari.Visible = false;
            }
        }

        private void comboBoxSatis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSatis.Text == "Peşin satış")
            {
                textBoxIsim.Visible = false;
                labelisimSoyisim.Visible = false;
                textBoxIsim.Text = "";
            }
            else
            {
                textBoxIsim.Visible = true;
                labelisimSoyisim.Visible = true;
            }
        }

        public void toplam_tutari_guncelle()
        {
            toplam_tutar = 0;
            foreach (DataGridViewRow row in DataGridViewSatisEkrani.Rows)
            {
                toplam_tutar += (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[5].Value;
            }
            labelToplamTutar.Text = toplam_tutar.ToString() + ".00 ₺";
        }

        private void btn_urun_ekle_Click(object sender, EventArgs e)
        {
            AddProductForm urunEkle_ekrani = new AddProductForm();
            urunEkle_ekrani.ShowDialog();

            urun_Bk = urunEkle_ekrani.urun_Bk;
            miktar = urunEkle_ekrani.miktar;

            if (DataGridViewSatisEkrani.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in DataGridViewSatisEkrani.Rows)
                {
                    if((int)DataGridViewSatisEkrani.Rows[row.Index].Cells[0].Value == urun_Bk)
                    {
                        if ((int)DataGridViewSatisEkrani.Rows[row.Index].Cells[2].Value + miktar <= 10)
                        {
                            DataGridViewSatisEkrani.Rows[row.Index].Cells[2].Value = (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[2].Value + miktar;
                            DataGridViewSatisEkrani.Rows[row.Index].Cells[5].Value = (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[2].Value * (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[4].Value;
                            toplam_tutari_guncelle();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Bir üründen en fazla 10 tane alabilirsiniz\n", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }

                    }
                }
            }
            try
            {
                Ürün urun = DbUrun.find_urunByBk(urun_Bk);
                if (urun != null)
                {
                    if (DataGridViewSatisEkrani.Rows.Count == 0)
                    {
                        panel_tumunuSil.Visible = true;
                    }
                    var tutar = miktar * urun.Urun_satisFiyati;
                    DataGridViewSatisEkrani.Rows.Add(urun.Urun_barKd, urun.Urun_adi, miktar, urun.Urun_miktarBirimi, urun.Urun_satisFiyati, tutar);
                    toplam_tutari_guncelle();

                }
            }
            catch
            {
                return;
            }
            
        }

        private void DataGridViewSatisEkrani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                guncellenmesi_istenen_miktar = (int)DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[2].Value;
                satis_miktari_guncelle miktari_guncelle = new satis_miktari_guncelle();
                miktari_guncelle.index = guncellenmesi_istenen_miktar - 1;
                miktari_guncelle.ShowDialog();

                DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[2].Value = miktari_guncelle.guncellenen_miktar;
                int miktar = (int)DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[2].Value;
                int fiyat = (int)DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[4].Value;
                int tutar = fiyat * miktar;
                DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[5].Value = tutar;
                toplam_tutari_guncelle();
                return;
            }
            if (e.ColumnIndex == 7)
            {
                DataGridViewSatisEkrani.Rows.RemoveAt(DataGridViewSatisEkrani.SelectedRows[0].Index);
                if (DataGridViewSatisEkrani.Rows.Count == 0)
                {
                    panel_tumunuSil.Visible = false;
                }
                toplam_tutari_guncelle();
            }
        }

        private void bilgileriSifirla()
        {
            labelToplamTutar.Text = "0.00 ₺";
            textBoxIsim.Text = "";
            comboBoxSatis.SelectedIndex = 0;
            DataGridViewSatisEkrani.Rows.Clear();
            toplam_tutar = 0;
            panel_tumunuSil.Visible = false;

        }

        private void btn_satisiOnayla_Click(object sender, EventArgs e)
        {
            if (toplam_tutar == 0)
            {
                MessageBox.Show("Ürün eklemeniz gerekmektedir", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxSatis.Text == "Cari satış")
            {
                if (textBoxIsim.Text.Length == 0)
                {
                    MessageBox.Show("İsim ve Soyisim alanı boş bırakılmamalı", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!textBoxIsim.Text.Contains(' '))
                {
                    MessageBox.Show("İsim ve Soyisim alanında müşterinin tam adını yazınız", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            DateTime dateTime = DateTime.Now;
            int odenen = comboBoxSatis.Text == "Cari satış" ? 0 : toplam_tutar;
            int borc = comboBoxSatis.Text == "Cari satış" ? toplam_tutar : 0;
            string id =  IdGenerator.NewId();
            Satış satis = new Satış(id, textBoxIsim.Text, toplam_tutar, odenen, borc, dateTime);
            
            try
            {
                DbSatis.satis_ekle(satis);
                SatisUrun satisUrun;
                int urun_bk;
                String urun_adi;
                int urun_miktari;
                int urun_toplam_tutari;
                int urun_odenen_miktari;
                int urun_borc_miktari;
                int urun_stok_miktari;
                int urun_stok_yeni_miktari;

                foreach (DataGridViewRow row in DataGridViewSatisEkrani.Rows)
                {
                    urun_bk = (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[0].Value;
                    urun_adi = (String)DataGridViewSatisEkrani.Rows[row.Index].Cells[1].Value;
                    urun_miktari = (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[2].Value;
                    urun_toplam_tutari = (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[5].Value;
                    urun_odenen_miktari = comboBoxSatis.Text == "Cari satış" ? 0 : urun_toplam_tutari;
                    urun_borc_miktari = comboBoxSatis.Text == "Cari satış" ? urun_toplam_tutari : 0;
                    satisUrun = new SatisUrun(id, urun_bk, textBoxIsim.Text, urun_adi, urun_miktari, urun_toplam_tutari, urun_odenen_miktari, urun_borc_miktari, dateTime);
                    DbSatisUrun.satisUrun_ekle(satisUrun);


                    urun_stok_miktari = DbUrun.find_urunByBk(urun_bk).Urun_miktari;
                    urun_stok_yeni_miktari = urun_stok_miktari - urun_miktari;
                    DbUrun.urun_miktarini_guncelle(urun_bk, urun_stok_yeni_miktari);

                }
                
            }
            catch
            {
                return;

            }

            bilgileriSifirla();
            uyari_mesaji();
        }

        private void btn_tumunuSil_Click(object sender, EventArgs e)
        {
            DataGridViewSatisEkrani.Rows.Clear();
            labelToplamTutar.Text = "0.00 ₺";
            toplam_tutar = 0;
            panel_tumunuSil.Visible = false;

        }
    }
}
