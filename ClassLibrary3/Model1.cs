using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClassLibrary3
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<kullanicilar> kullanicilar { get; set; }
        public virtual DbSet<müsteri> müsteri { get; set; }
        public virtual DbSet<satis> satis { get; set; }
        public virtual DbSet<satisÜrün> satisÜrün { get; set; }
        public virtual DbSet<tedarekci> tedarekci { get; set; }
        public virtual DbSet<ürün> ürün { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<kullanicilar>()
                .Property(e => e.kullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<kullanicilar>()
                .Property(e => e.sifre)
                .IsUnicode(false);

            modelBuilder.Entity<kullanicilar>()
                .Property(e => e.kaydolmaTarihi)
                .IsUnicode(false);

            modelBuilder.Entity<müsteri>()
                .Property(e => e.mAdi)
                .IsUnicode(false);

            modelBuilder.Entity<müsteri>()
                .Property(e => e.mSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<satis>()
                .Property(e => e.starihi)
                .IsUnicode(false);

            modelBuilder.Entity<satis>()
                .Property(e => e.mSoyadi)
                .IsFixedLength();

            modelBuilder.Entity<satis>()
                .Property(e => e.kullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<satisÜrün>()
                .Property(e => e.musteriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<satisÜrün>()
                .Property(e => e.musteriSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<satisÜrün>()
                .Property(e => e.adi)
                .IsUnicode(false);

            modelBuilder.Entity<satisÜrün>()
                .Property(e => e.tarih)
                .IsUnicode(false);

            modelBuilder.Entity<tedarekci>()
                .Property(e => e.firmaAdi)
                .IsUnicode(false);

            modelBuilder.Entity<tedarekci>()
                .Property(e => e.iTarihi)
                .IsUnicode(false);

            modelBuilder.Entity<ürün>()
                .Property(e => e.üAdi)
                .IsUnicode(false);

            modelBuilder.Entity<ürün>()
                .Property(e => e.ümiktarTüru)
                .IsUnicode(false);
        }
    }
}
