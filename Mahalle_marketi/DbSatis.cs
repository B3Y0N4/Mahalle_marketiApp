using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sql = "insert into satış (SatışId, SMüşteriAdıSoyadı, StoplamTutar, Södenen, Sborç, Starih) " +
                "values " + "(@SatışId, @musteri_adiSoyadi, @toplamTutar, @ödenen, @borç, @tarih)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
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
                MessageBox.Show("Internet bağlantısını kontrol ediniz! \n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
