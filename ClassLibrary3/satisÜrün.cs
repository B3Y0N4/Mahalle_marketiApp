namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class satisÜrün
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String satisId { get; set; }

        public int urun_Bk { get; set; }

        [Required]
        [StringLength(50)]
        public string musteriAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string musteriSoyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string adi { get; set; }

        public int miktar { get; set; }

        public int toplam_tutar { get; set; }

        public int odenen { get; set; }

        public int borc { get; set; }

        [Required]
        [StringLength(100)]
        public string tarih { get; set; }
    }
}
