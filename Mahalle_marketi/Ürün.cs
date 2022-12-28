using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class Ürün
    {
        public int Urun_barKd { get; set; }
        public String Urun_adi { get; set; }
        public String Urun_turu { get; set; }
        public int Urun_miktari { get; set; }
        public String Urun_miktarBirimi { get; set; }
        public int Urun_alisFiyati { get; set; }
        public int Urun_satisFiyati { get; set; }

        public Ürün(int urun_barKd, String urun_adi, String urun_turu, int urun_miktari, String urun_miktarBirimi, int urun_alisFiyati, int urun_satisFiyati)
        {
            Urun_barKd = urun_barKd;
            Urun_adi = urun_adi;
            Urun_turu = urun_turu;
            Urun_miktari = urun_miktari;
            Urun_miktarBirimi = urun_miktarBirimi;
            Urun_alisFiyati = urun_alisFiyati;
            Urun_satisFiyati = urun_satisFiyati;
        }
    }
}
