using Microsoft.EntityFrameworkCore;
using reformaagraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Data
{
    public class ReformaAgrariaDataContext : DbContext
    {
        public ReformaAgrariaDataContext(DbContextOptions<ReformaAgrariaDataContext> options) : base(options)
        {

        }

        public DbSet<Region> Region { get; set; }
        public DbSet<AtributPetaDesa> AtributPetaDesa { get; set; }
        public DbSet<AtributPetaTora> AtributPetaTora { get; set; }
        public DbSet<KalenderKerja> KalenderKerja { get; set; }
        public DbSet<KebijakanPustaka> KebijakanPustaka { get; set; }
        public DbSet<LaporanPertemuan> LaporanPertemuan { get; set; }
        public DbSet<ObyekSubyekTora> ObyekSubyekTora { get; set; }
        public DbSet<PengajuanTora> PengajuanTora { get; set; }
        public DbSet<PeriksaDokumenUsulanPenetapan> PeriksaDokumenUsulanPenetapan { get; set; }
        public DbSet<ProfilDesa> ProfilDesa { get; set; }
        public DbSet<TipologiPermasalahanAgraria> TipologiPermasalahanTora { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<Region>().ToTable("AtributPetaDesa");
            modelBuilder.Entity<Region>().ToTable("AtributPetaTora");
            modelBuilder.Entity<Region>().ToTable("KalenderKerja");
            modelBuilder.Entity<Region>().ToTable("KebijakanPustaka");
            modelBuilder.Entity<Region>().ToTable("LaporanPertemuan");
            modelBuilder.Entity<Region>().ToTable("ObyekSubyekTora");
            modelBuilder.Entity<Region>().ToTable("PengajuanTora");
            modelBuilder.Entity<Region>().ToTable("PeriksaDokumenUsulanPenetapan");
            modelBuilder.Entity<Region>().ToTable("ProfilDesa");
            modelBuilder.Entity<Region>().ToTable("TipologiPermasalahanTora");

        }
    }
}
