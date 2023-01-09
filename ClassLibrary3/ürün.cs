namespace ClassLibrary3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Word = Microsoft.Office.Interop.Word;


    public partial class ürün
    {
        [Required]
        [StringLength(50)]
        public string üAdi { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ükodu { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int übarkodu { get; set; }

        public int übirimfiyati { get; set; }

        public int ümiktari { get; set; }

        [Required]
        [StringLength(50)]
        public string ümiktarTüru { get; set; }
    }
}
