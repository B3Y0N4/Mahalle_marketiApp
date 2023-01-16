using ClassLibrary3;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_satisKayitlari : UserControl
    {
        public static SqlConnection GetConnection()
        {
            String conString = "Data Source=LAPTOP-L2L5OAL6;Initial Catalog=mahalle_marketi;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql server Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
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

        //private void tabloyu_doldur(String query)
        //{
        //    DataTable tb;
        //    try
        //    {
        //        string sql = query;
        //        SqlConnection con = GetConnection();
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        cmd.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;

                
        //        SqlDataAdapter apd = new SqlDataAdapter(cmd);
        //        tb = new DataTable();
        //        apd.Fill(tb);

        //        //dt = DbSatis.Satis_kayitTablosunu_Doldur(query, now, oldDate, parameter) != null ? DbSatis.Satis_kayitTablosunu_Doldur(query, now, oldDate, parameter) : null;
        //    }
        //    catch
        //    {
        //        return;
        //    }

        //    if (tb == null) return;
            
        //    for (int i = 0; i < tb.Rows.Count; i++)
        //    {
        //        DataRow dr = tb.Rows[i];
        //        DataGridView_satisKayitlari.Rows.Insert(0, dr["SMüşteriAdıSoyadı"], dr["StoplamTutar"], dr["Södenen"], dr["Sborç"], dr["Starih"]);
        //        satisId_listesi.Insert(0, (String)dr["SatışId"]);
        //    }

        //    istatistikleri_guncelle();


        //}

        private void ComboBox_filtreleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_satisKayitlari.Rows.Clear();
            satisId_listesi.Clear();
            istatistikleri_guncelle();
            DateTime now = DateTime.Now;
            if (ComboBox_filtreleme.Text == "Bugün")
            {
                //tabloyu_doldur("select * from satis where satis.the_date > DATE_SUB(CURDATE(), INTERVAL 1 DAY)");
                //String query = "Select * From tedarekci";
                //DbTedarikci.display_tedarikci_borclari(query, DataGridView_satisKayitlari);
                //string sql = "select * from satis where satis.starihi >= DATEADD(day,-1,GETDATE())";
                //SqlConnection con = GetConnection();
                //SqlDataAdapter da = new SqlDataAdapter(sql, con);
                //DataTable dt = new DataTable(sql);
                //da.Fill(dt);
                //DataGridView_satisKayitlari.DataSource = dt;

                
                //DataGridView_satisKayitlari.DataSource = model1.satis.ToList();
                using (Model1 db = new Model1())
                {
                    var result = db.satis.SingleOrDefault(b => b.starihi == DateTime.Now.ToString());
                    if (result != null)
                    {
                        DataGridView_satisKayitlari.DataSource = db.satis.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Bugün satis hic yok.");
                        DataGridView_satisKayitlari.DataSource = db.satis.ToList();
                    }
                }





            }
            //else if (ComboBox_filtreleme.Text == "son hafta")
            //{
            //    DateTime bir_hafta_once = now.AddDays(-7);
            //    tabloyu_doldur("select * from satis where  starihi between @oldDate and @now", bir_hafta_once, now, true);
            //}
            //else if (ComboBox_filtreleme.Text == "Son ayda")
            //{
            //    DateTime bir_ay_once = now.AddDays(-30);
            //    tabloyu_doldur("select * from satis where  starihi between @oldDate and @now", bir_ay_once, now, true);
            //}
            //else if (ComboBox_filtreleme.Text == "Son yılda")
            //{
            //    DateTime bir_yil_once = now.AddYears(-1);
            //    tabloyu_doldur("select * from satis where  starihi between @oldDate and @now", bir_yil_once, now, true);
            //}
            ////kullaniciAdi = @kullanici_adi and
            //else
            //{
            //    tabloyu_doldur("select * from satis ", now, now, false); //where kullaniciAdi = @kullanici_adi
            //}
        }

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
                            DbSatis.satis_sil($"delete from satis where satisId = @satis_id", satisId_listesi[e.RowIndex]);
                            DbSatisUrun.urun_sil_by_SatisId($"delete from satisÜrün where satisId = @satis_id", satisId_listesi[e.RowIndex]);
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
