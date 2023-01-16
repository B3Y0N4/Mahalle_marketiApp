using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClassLibrary3;

namespace Mahalle_marketi
{
    internal class DbStok
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
        public static void stoga_girdi_ekle(String query, String üAdi, int üKodu, int übarkodu, String ümiktarTüru, int ümiktari,  int übirimfiyati)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@üAdi", SqlDbType.VarChar).Value = üAdi;
            cmd.Parameters.Add("@üKodu", SqlDbType.Int).Value = üKodu;
            cmd.Parameters.Add("@übarkodu", SqlDbType.Int).Value = übarkodu;
            cmd.Parameters.Add("@übirimfiyati", SqlDbType.Int).Value = übirimfiyati;
            cmd.Parameters.Add("@ümiktari", SqlDbType.Int).Value = ümiktari;
            cmd.Parameters.Add("@ümiktarTüru", SqlDbType.VarChar).Value = ümiktarTüru;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni gelen ürün stoğa eklendi! \n" + "Giriş yapabilmeniz için bilgilerinizi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("bir hata oluştu. Tekrar deneyiniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            


        }
        public static void display_urun(String query, DataGridView dataGridView)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable(sql);
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }

        public static bool check_urunBk_availability(int barkodu)
        {
            //string sql = "select übarkodu from ürün where übarkodu = @urun_Bk";
            //SqlConnection con = GetConnection();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //var result = 
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Add("@urun_Bk", SqlDbType.Int).Value = barkodu;
            using (Model1 context = new Model1())
            {
                if (context.ürün.Any(o => o.übarkodu == barkodu))
                {
                    return true;
                }
                else
                {
                    return false;
                }
             }

            //        try
            //{
            //    cmd.ExecuteNonQuery();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            //var reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
                //con.Close();
                //return true;
            //}
            //else
            //{
            //    con.Close();
            //    return false;
            //}
        //}

        public static Ürün find_urunByBk(int barkodu)
        {
            //string sql = "select * from ürün where übarkodu = @urun_Bk "; /*and kullaniciAdi = @kullaniciAdi*/
            //SqlConnection con = GetConnection();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Add("@urun_Bk", SqlDbType.Int).Value = barkodu;
            //cmd.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = kullanici.kullanici_adi;
            using (Model1 context = new Model1())
            {
                var result = context.ürün.SingleOrDefault(b => b.übarkodu == barkodu);
                Ürün urun = new Ürün(result.übarkodu, result.ükodu, result.üAdi, result.ümiktari, result.ümiktarTüru, result.übirimfiyati);
                return urun;
            }


            //try
            //{
            //    cmd.ExecuteNonQuery();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}


            //var reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    Ürün urun = new Ürün(reader.GetInt32(2), reader.GetInt32(3), reader.GetString(1), reader.GetInt32(5), reader.GetString(6),  reader.GetInt32(4));
            //    con.Close();
            //    return urun;
            //}
            //else
            //{
            //    con.Close();
            //    return null;
            //}



        }
    }
}



