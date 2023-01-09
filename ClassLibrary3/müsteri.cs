namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class müsteri
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string mAdi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string mSoyadi { get; set; }

        public int mBorcu { get; set; }
    }
}
