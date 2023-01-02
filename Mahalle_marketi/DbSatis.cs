using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mahalle_marketi
{
    internal class DbSatis
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

        public static void satis_ekle(Satış satis)
        {
            string sql = "insert into satış (kullaniciAdi, SatışId, SMüşteriAdıSoyadı, StoplamTutar, Södenen, Sborç, Starih) " +
                "values " + "(@kullanici_adi, @SatışId, @musteri_adiSoyadi, @toplamTutar, @ödenen, @borç, @tarih)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@kullanici_adi", MySqlDbType.String).Value = kullanici.kullanici_adi;
            cmd.Parameters.Add("@SatışId", MySqlDbType.String).Value = satis.Id;
            cmd.Parameters.Add("@musteri_adiSoyadi", MySqlDbType.String).Value = satis.Musteri_adiSoyadi;
            cmd.Parameters.Add("@toplamTutar", MySqlDbType.Int32).Value = satis.Toplam_satisTutari;
            cmd.Parameters.Add("@ödenen", MySqlDbType.Int32).Value = satis.Odenen;
            cmd.Parameters.Add("@borç", MySqlDbType.Int32).Value = satis.Borc;
            cmd.Parameters.Add("@tarih", MySqlDbType.DateTime).Value = satis.Tarih;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla gerçekleşti! \n" + "Kayıtlar sekmesinde detayları görebilirsiniz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Satış gerçekleşemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static DataTable Satis_kayitTablosunu_Doldur(String query, DateTime oldDate, DateTime now, bool parameter)
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

        public static void satis_sil(String query, String satis_id)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", MySqlDbType.String).Value = satis_id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla silindi!\n" + "satış ve ürün kayıtları güncellendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Satış silinemedi! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static Dictionary<String, object> get_satis_toplamTutar(String query, String satis_id)
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
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@satis_id", MySqlDbType.String).Value = satis_id;
            cmd.Parameters.Add("@toplam_tutar", MySqlDbType.Int32).Value = toplam_tutar;
            cmd.Parameters.Add("@toplam_odenen", MySqlDbType.Int32).Value = odenen;
            cmd.Parameters.Add("@toplam_borc", MySqlDbType.Int32).Value = borc;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("satış ve ürün kayıtları güncellendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("bir hata oluştu! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
