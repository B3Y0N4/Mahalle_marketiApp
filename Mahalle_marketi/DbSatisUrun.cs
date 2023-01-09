using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities.Collections;
using ClassLibrary3;


namespace Mahalle_marketi
{
    internal class DbSatisUrun
    {
        public static SqlConnection GetConnection()
        {
            string sql = "Data Source=LAPTOP-L2L5OAL6;Initial Catalog=mahalle_marketi;Integrated Security=True";
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }

        public static void satisUrun_ekle(SatisUrun satisUrun)
        {



            using (Model1 context = new Model1())
            {


                satisÜrün satisurun = new satisÜrün();
                satisurun.satisId = satisUrun.Satis_id;
                satisurun.urun_Bk = satisUrun.Urun_Bk;
                satisurun.musteriAdi = satisUrun.MusteriAdi;
                satisurun.musteriSoyadi = satisUrun.MusteriSoyadi;
                satisurun.adi = satisUrun.Adi;
                satisurun.miktar = satisUrun.Miktar;
                satisurun.toplam_tutar = satisUrun.Toplam_tutar;
                satisurun.odenen = satisUrun.Odenen;
                satisurun.borc = satisUrun.Borc;
                satisurun.tarih = satisUrun.Tarih;
                context.satisÜrün.Add(satisurun);
                context.SaveChanges();
                //MessageBox.Show("Satış başarıyla gerçekleşti!");

            }
            //string sql = "insert into satisÜrün(satisId, urun_Bk, musteriAdi, musteriSoyadi, adi, miktar, toplam_tutar, odenen, borc, tarih) " +
            //    "values " + "(@satisId, @urun_Bk, @musteriAdi, @musteriSoyadi, @adi, @miktar, @toplam_tutar, @odenen, @borc, @tarih)";
            //SqlConnection con = GetConnection();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = System.Data.CommandType.Text; 
            //cmd.Parameters.Add("@kullanici_adi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;
            //cmd.Parameters.Add("@satisId", SqlDbType.VarChar).Value = satisUrun.Satis_id;
            //cmd.Parameters.Add("@urun_Bk", SqlDbType.Int).Value = satisUrun.Urun_Bk;
            //cmd.Parameters.Add("@musteriSoyadi", SqlDbType.VarChar).Value = satisUrun.MusteriSoyadi;
            //cmd.Parameters.Add("@musteriAdi", SqlDbType.VarChar).Value = satisUrun.MusteriAdi;
            //cmd.Parameters.Add("@adi", SqlDbType.VarChar).Value = satisUrun.Adi;
            //cmd.Parameters.Add("@miktar", SqlDbType.Int).Value = satisUrun.Miktar;
            //cmd.Parameters.Add("@toplam_tutar", SqlDbType.Int).Value = satisUrun.Toplam_tutar;
            //cmd.Parameters.Add("@odenen", SqlDbType.Int).Value = satisUrun.Odenen;
            //cmd.Parameters.Add("@borc", SqlDbType.Int).Value = satisUrun.Borc;
            //cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = satisUrun.Tarih;

            //try
            //{
            //    cmd.ExecuteNonQuery();


            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}





        }

        public static DataTable urun_kayitTablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@kullanici_adi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;
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

        public static DataTable enCokSatan_Tablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@kullanici_adi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;
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

        public static void urun_sil_by_SatisId(String query, String satis_id)
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
                MessageBox.Show("Satışa ait ürünler silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void urun_sil_by_SatisId_and_urunKb(String query, String satis_id, int urun_bk)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", SqlDbType.VarChar).Value = satis_id;
            cmd.Parameters.Add("@urun_bk", SqlDbType.Int).Value = urun_bk;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("ürün silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
