using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Mahalle_marketi
{
    internal class DbUrun
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=mahalle_marketi";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL bağlantısı kurulmadı! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }

        public static bool check_urunBk_availability(int id)
        {
            string sql = "select Ükodu from ürünler where Ükodu = @urun_Bk";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@urun_Bk", MySqlDbType.Int32).Value = id;

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public static Ürün find_urunByBk(int id) {
            string sql = "select * from ürünler where Ükodu = @urun_Bk";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@urun_Bk", MySqlDbType.Int32).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Ürün urun = new Ürün(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(4), reader.GetString(3), reader.GetInt32(5), reader.GetInt32(6));
                con.Close();
                return urun;
            }
            else
            {
                con.Close();
                return null;
            }



        }
    }
}
