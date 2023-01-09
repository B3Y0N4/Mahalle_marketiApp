
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using ClassLibrary3;

namespace Mahalle_marketi
{
    internal class DbSatis
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

        public static void satis_ekle(Satış satis)
        {
            //string sql = "insert into satis (satisId, kullaniciAdi, mAdi, mSoyadi, toplamTutar, odenen, borc, starihi) " +
            //    "values " + "(@satisId, @kullaniciAdi, @mAdi, @mSoyadi, @toplamTutar, @odenen, @borc, @starihi)";
            //SqlConnection con = GetConnection();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Add("@satisId", SqlDbType.Int).Value = satis.Id;
            //cmd.Parameters.AddWithValue("@kullaniciAdi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;
            //cmd.Parameters.AddWithValue("@mAdi", SqlDbType.VarChar).Value = satis.Musteri_adi;
            //cmd.Parameters.AddWithValue("@mSoyadi", SqlDbType.VarChar).Value = satis.Musteri_soyadi;
            //cmd.Parameters.Add("@toplamTutar", SqlDbType.Int).Value = satis.Toplam_satisTutari;
            //cmd.Parameters.Add("@odenen", SqlDbType.Int).Value = satis.Odenen;
            //cmd.Parameters.Add("@borc", SqlDbType.Int).Value = satis.Borc;
            //cmd.Parameters.Add("@starihi", SqlDbType.DateTime).Value = satis.Tarih;

            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Satış başarıyla gerçekleşti! \n" + "Kayıtlar sekmesinde detayları görebilirsiniz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Satış gerçekleşemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            using (Model1 context = new Model1())
            {
               
                
                satis satis1 = new satis();
                satis1.satisId = satis.Id;
                satis1.toplamTutar = satis.Toplam_satisTutari;
                satis1.odenen = satis.Odenen;
                satis1.mSoyadi = satis.Musteri_soyadi;
                satis1.mAdi = satis.Musteri_adi;
                satis1.kullaniciAdi = kullanici.kullanici_adi;
                satis1.borc = satis.Borc;
                satis1.starihi = satis.Tarih;

                    
                context.satis.Add(satis1);
                context.SaveChanges();
                MessageBox.Show("Satış başarıyla gerçekleşti!");



                }


        }


        

        public static DataTable Satis_kayitTablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;

            if (parameter)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@oldDate", SqlDbType.DateTime).Value = oldDate;
                cmd.Parameters.Add("@now", SqlDbType.DateTime).Value = now;
            }

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            var reader = cmd.ExecuteReader();
            if (reader.Read() == false)
            {
                con.Close();
                return null;
            }
            reader.Close();

            SqlDataAdapter apd = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            apd.Fill(tb);
            return tb;

        }

        public static void satis_sil(String query, String satis_id)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", SqlDbType.VarChar).Value = satis_id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla silindi!\n" + "satış ve ürün kayıtları güncellendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Satış silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static Dictionary<String, object> get_satis_toplamTutar(String query, String satis_id)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", SqlDbType.VarChar).Value = satis_id;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("bir hata oluştu! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var map = new Dictionary<String, object>();
                map.Add("ad soyad", reader.GetString(2));
                map.Add("toplam tutar", reader.GetInt32(3));
                map.Add("odenen", reader.GetInt32(4));
                map.Add("borc", reader.GetInt32(5));
                con.Close();
                return map;
            }
            else
            {
                con.Close();
                return null;
            }
        }


        public static void satis_guncelle(String query, String satis_id, int toplam_tutar, int odenen, int borc)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", SqlDbType.VarChar).Value = satis_id;
            cmd.Parameters.Add("@toplam_tutar", SqlDbType.Int).Value = toplam_tutar;
            cmd.Parameters.Add("@toplam_odenen", SqlDbType.Int).Value = odenen;
            cmd.Parameters.Add("@toplam_borc", SqlDbType.Int).Value = borc;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("satış ve ürün kayıtları güncellendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("bir hata oluştu! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}

