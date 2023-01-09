using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Mahalle_marketi
{
	internal class DbTedarikci
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
        public static void firmaya_borc_ekle(String query, String firmaAdi, int marketinBorcu, DateTime itarihi)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@firmaAdi", SqlDbType.VarChar).Value = firmaAdi;
            cmd.Parameters.Add("@itarihi", SqlDbType.DateTime).Value = itarihi;
            cmd.Parameters.Add("@marketinBorcu", SqlDbType.Int).Value = marketinBorcu;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Firmaya yeni borç oluştu! \n" + "Giriş yapabilmeniz için bilgilerinizi giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("bir hata oluştu. Tekrar deneyiniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public static void display_tedarikci_borclari(String query, DataGridView dataGridView)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable(sql);
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public static void borcu_kapat(String query, String firmaAdi, int odenecek)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@firmaAdi", SqlDbType.VarChar).Value=firmaAdi;
            cmd.Parameters.Add("@odenecek", SqlDbType.Int).Value=odenecek;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ödeme tamamlandi! \n", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("bir hata oluştu. Tekrar deneyiniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        }
    }





