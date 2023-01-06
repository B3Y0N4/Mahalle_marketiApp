using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class DbSatisUrun
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=mahalle_marketi";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }

        public static void satisUrun_ekle(SatisUrun satisUrun)
        {
            string sql = "insert into satışürün (kullaniciAdi ,Sid, ÜrünBk, MüşteriAdıSoyadı, ÜrünAdı, Miktar, ToplamTutar, Ödenen, borç, Starih) " +
                "values " + "(@kullanici_adi, @sid, @ürünBk, @müşteriAdıSoyadı, @ürünAdı, @miktar, @toplamTutar, @ödenen, @Borç, @starih)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text; 
            cmd.Parameters.Add("@kullanici_adi", MySqlDbType.String).Value = kullanici.kullanici_adi;
            cmd.Parameters.Add("@sid", MySqlDbType.String).Value = satisUrun.Satis_id;
            cmd.Parameters.Add("@ürünBk", MySqlDbType.Int32).Value = satisUrun.Urun_Bk;
            cmd.Parameters.Add("@müşteriAdıSoyadı", MySqlDbType.String).Value = satisUrun.Musteri_adiSoyadi;
            cmd.Parameters.Add("@ürünAdı", MySqlDbType.String).Value = satisUrun.Adi;
            cmd.Parameters.Add("@miktar", MySqlDbType.Int32).Value = satisUrun.Miktar;
            cmd.Parameters.Add("@toplamTutar", MySqlDbType.Int32).Value = satisUrun.Toplam_tutar;
            cmd.Parameters.Add("@ödenen", MySqlDbType.Int32).Value = satisUrun.Odenen;
            cmd.Parameters.Add("@Borç", MySqlDbType.Int32).Value = satisUrun.Borc;
            cmd.Parameters.Add("@starih", MySqlDbType.DateTime).Value = satisUrun.Tarih;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable urun_kayitTablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@kullanici_adi", MySqlDbType.String).Value = kullanici.kullanici_adi;
            if (parameter)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@oldDate", MySqlDbType.DateTime).Value = oldDate;
                cmd.Parameters.Add("@now", MySqlDbType.DateTime).Value = now;
            }

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
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

            MySqlDataAdapter apd = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            apd.Fill(tb);
            return tb;

        }

        public static DataTable enCokSatan_Tablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@kullanici_adi", MySqlDbType.String).Value = kullanici.kullanici_adi;
            if (parameter)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@oldDate", MySqlDbType.DateTime).Value = oldDate;
                cmd.Parameters.Add("@now", MySqlDbType.DateTime).Value = now;
            }

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
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

            MySqlDataAdapter apd = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            apd.Fill(tb);
            return tb;

        }

        public static void urun_sil_by_SatisId(String query, String satis_id)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", MySqlDbType.String).Value = satis_id;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Satışa ait ürünler silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void urun_sil_by_SatisId_and_urunKb(String query, String satis_id, int urun_bk)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", MySqlDbType.String).Value = satis_id;
            cmd.Parameters.Add("@urun_bk", MySqlDbType.Int32).Value = urun_bk;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ürün silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static List<int> get_urunler_bk(String satis_id)
        {
            string sql = "select * from satışürün where Sid = @satis_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", MySqlDbType.String).Value = satis_id;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ürün silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            var reader = cmd.ExecuteReader();
            List<int> urunler_bk = new List<int>();
            while (reader.Read())
            {
                urunler_bk.Add(reader.GetInt32(2));
            }
            
            return urunler_bk;

        }

        public static int get_urun_miktari(String satis_id, int urun_bk)
        {
            string sql = "select * from satışürün where Sid = @satis_id and ÜrünBk = @urun_bk";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", MySqlDbType.String).Value = satis_id;
            cmd.Parameters.Add("@urun_bk", MySqlDbType.Int32).Value = urun_bk;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ürün silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            var reader = cmd.ExecuteReader();
            reader.Read();
            

            return reader.GetInt32(5);

        }
    }
}
