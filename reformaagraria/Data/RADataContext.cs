using Microsoft.EntityFrameworkCore;
using reformaagraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reformaagraria.Data
{
    public class RADataContext : DbContext
    {
        public RADataContext(DbContextOptions<RADataContext> options) : base(options)
        {

        }

        public DbSet<KabupatenModel> KabupatenModel { get; set; }
        public DbSet<KecamatanModel> KecamatanModel { get; set; }
        public DbSet<DesaModel> DesaModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KabupatenModel>().ToTable("KabupatenModel");
            modelBuilder.Entity<KecamatanModel>().ToTable("KecamatanModel");
            modelBuilder.Entity<DesaModel>().ToTable("DesaModel");
        }
    }
}
