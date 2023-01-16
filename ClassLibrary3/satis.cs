namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class satis
    {
        public String mAdi { get; set; }

        

        [Required]
        [StringLength(200)]
        public string starihi { get; set; }

        public int borc { get; set; }

        [Required]
        [StringLength(10)]
        public string mSoyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string kullaniciAdi { get; set; }

        public int toplamTutar { get; set; }

        public int odenen { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String satisId { get; set; }
    }
}
