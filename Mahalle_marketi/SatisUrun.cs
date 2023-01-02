using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class SatisUrun
    {
        public String Satis_id { get; set; }
        public int Urun_Bk { get; set; }
        public String Musteri_adiSoyadi { get; set; }
        public String Adi { get; set; }
        public int Miktar { get; set; }
        public int Toplam_tutar { get; set; }
        public int Odenen { get; set; }
        public int Borc { get; set; }
        public DateTime Tarih { get; set; }

        public SatisUrun(String satis_id, int urun_Bk, String musteri_adiSoyadi, String adi, int miktar, int toplam_tutar, int odenen, int borc, DateTime tarih)
        {
            Satis_id = satis_id;
            Urun_Bk = urun_Bk;
            Musteri_adiSoyadi = musteri_adiSoyadi;
            Adi = adi;
            Miktar = miktar;
            Toplam_tutar = toplam_tutar;
            Odenen = odenen;
            Borc = borc;
            Tarih = tarih;
        }
    }
}
