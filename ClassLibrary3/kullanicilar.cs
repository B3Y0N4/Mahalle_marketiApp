namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kullanicilar")]
    public partial class kullanicilar
    {
        [Key]
        [StringLength(50)]
        public string kullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string sifre { get; set; }

        [Required]
        [StringLength(50)]
        public string kaydolmaTarihi { get; set; }
    }
}
