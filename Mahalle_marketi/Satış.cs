using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class Satış
    {
        public String Id { get; set; }
        public String Musteri_adi { get; set; }
        public String Musteri_soyadi { get; set; }
        public int Toplam_satisTutari { get; set; }
        public int Odenen { get; set; }
        public int Borc { get; set; }
        public String Tarih { get; set; }
        

        public Satış(String id, String musteri_adi, String musteri_soyadi, int toplam_satisTutari, int odenen, int borc, String tarih)
        {
            Id = id;
            Musteri_adi = musteri_adi;
            Musteri_soyadi = musteri_soyadi;
            Toplam_satisTutari = toplam_satisTutari;
            Odenen = odenen;
            Borc = borc;
            Tarih = tarih;
        }
    }
}
