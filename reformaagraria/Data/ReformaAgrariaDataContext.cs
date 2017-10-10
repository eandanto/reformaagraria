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
        public DbSet<VillageMapAttribute> VillageMapAttribute { get; set; }
        public DbSet<ToraMapAttribute> ToraMapAttribute { get; set; }
        public DbSet<WorkCalendar> WorkCalendar { get; set; }
        public DbSet<PoliciesDocuments> PoliciesDocuments { get; set; }
        public DbSet<MeetingReport> MeetingReport { get; set; }
        public DbSet<ObjectSubjectTora> ObjectSubjectTora { get; set; }
        public DbSet<ToraSubmission> ToraSubmission { get; set; }
        public DbSet<ProposalOfActDocumentCheckList> ProposalOfActDocumentCheckList { get; set; }
        public DbSet<ProfileOfVillage> ProfileOfVillage { get; set; }
        public DbSet<TipologyOfAgrarianProblem> TipologyOfAgrarianProblem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<Region>().ToTable("VillageMapAttribute");
            modelBuilder.Entity<Region>().ToTable("ToraMapAttribute");
            modelBuilder.Entity<Region>().ToTable("WorkCalendar");
            modelBuilder.Entity<Region>().ToTable("PoliciesDocuments");
            modelBuilder.Entity<Region>().ToTable("MeetingReport");
            modelBuilder.Entity<Region>().ToTable("ObjectSubjectTora");
            modelBuilder.Entity<Region>().ToTable("ToraSubmission");
            modelBuilder.Entity<Region>().ToTable("ProposalOfActDocumentCheckList");
            modelBuilder.Entity<Region>().ToTable("ProfileOfVillage");
            modelBuilder.Entity<Region>().ToTable("TipologyOfAgrarianProblem");

        }
    }
}
