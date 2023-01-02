using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class Db_kullanicilar
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

        public static void  kullanici_ekle(String query, String kullaniciAdi, String kullaniciSifresi, DateTime kaydolmaTarihi)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@kullanici_adi", MySqlDbType.String).Value = kullaniciAdi;
            cmd.Parameters.Add("@kullanici_sifresi", MySqlDbType.String).Value = kullaniciSifresi;
            cmd.Parameters.Add("@kaydolma_tarihi", MySqlDbType.DateTime).Value = kaydolmaTarihi;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tebrikler yeni hesap oluşturdunuz! \n" + "Giriş yapabilmeniz için bilgilerinizi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("bir hata oluştu. Tekrar deneyiniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        public static Dictionary<String, String> get_kullanici_bilgileri(String query, String kullaniciAdi)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@kullanici_adi", MySqlDbType.String).Value = kullaniciAdi;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("bir hata oluştu! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            var reader = cmd.ExecuteReader();
            Dictionary<String, String> map = new Dictionary<String, String>();
            if (reader.Read())
            {
                map.Add("kullanici adi", reader.GetString(0));
                map.Add("kullanici sifresi", reader.GetString(1));
                con.Close();
                return map;
            }
            else
            {
                con.Close();
                return map;
            }
        }
    }
}
