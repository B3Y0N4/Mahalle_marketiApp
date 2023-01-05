﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahalle_marketi
{
    internal class Satış
    {
        public String Id { get; set; }
        public String Musteri_adiSoyadi { get; set; }
        public int Toplam_satisTutari { get; set; }
        public int Odenen { get; set; }
        public int Borc { get; set; }
        public DateTime Tarih { get; set; }
        

        public Satış(String id, String musteri_adiSoyadi, int toplam_satisTutari, int odenen, int borc, DateTime tarih)
        {
            Id = id;
            Musteri_adiSoyadi = musteri_adiSoyadi;
            Toplam_satisTutari = toplam_satisTutari;
            Odenen = odenen;
            Borc = borc;
            Tarih = tarih;
        }
    }
}
