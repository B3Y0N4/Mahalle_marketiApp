namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tedarekci")]
    public partial class tedarekci
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string firmaAdi { get; set; }

        public int marketinBorcu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public String iTarihi { get; set; }
    }
}
