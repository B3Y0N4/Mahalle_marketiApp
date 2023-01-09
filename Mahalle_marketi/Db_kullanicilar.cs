using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Mahalle_marketi
{
    internal class Db_kullanicilar
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

        public static void  kullanici_ekle(String query, String kullaniciAdi, String sifresi, DateTime kaydolmaTarihi)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@kullanici_adi", SqlDbType.VarChar).Value = kullaniciAdi;
            cmd.Parameters.Add("@kullanici_sifresi", SqlDbType.VarChar).Value = sifresi;
            cmd.Parameters.Add("@kaydolma_tarihi", SqlDbType.DateTime).Value = kaydolmaTarihi;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tebrikler yeni hesap oluşturdunuz! \n" + "Giriş yapabilmeniz için bilgilerinizi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("bir hata oluştu. Tekrar deneyiniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        public static Dictionary<String, String> get_kullanici_bilgileri(String query, String kullaniciAdi)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@kullanici_adi", SqlDbType.VarChar).Value = kullaniciAdi;

            try
            {
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
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
