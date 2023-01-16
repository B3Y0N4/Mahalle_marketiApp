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
        public String MusteriAdi { get; set; }
        public String MusteriSoyadi { get; set; }
        public String Adi { get; set; }
        public int Miktar { get; set; }
        public int Toplam_tutar { get; set; }
        public int Odenen { get; set; }
        public int Borc { get; set; }
        public String Tarih { get; set; }

        public SatisUrun(String satis_id, int urun_Bk, String musteriAdi, String musteriSoyadi, String adi, int miktar, int toplam_tutar, int odenen, int borc, String tarih)
        {
            Satis_id = satis_id;
            Urun_Bk = urun_Bk;
            MusteriAdi = musteriAdi;
            MusteriSoyadi = musteriSoyadi;
            Adi = adi;
            Miktar = miktar;
            Toplam_tutar = toplam_tutar;
            Odenen = odenen;
            Borc = borc;
            Tarih = tarih;
        }
    }
}
