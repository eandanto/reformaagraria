﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Event> WorkCalendar { get; set; }
        public DbSet<PoliciesDocuments> PoliciesDocuments { get; set; }
        public DbSet<MeetingMinutes> MeetingReport { get; set; }
        public DbSet<ObjectSubjectTora> ObjectSubjectTora { get; set; }
        public DbSet<ToraSubmission> ToraSubmission { get; set; }
        public DbSet<ActProposalDocumentCheckList> ProposalOfActDocumentCheckList { get; set; }
        public DbSet<VillageProfile> ProfileOfVillage { get; set; }
        public DbSet<TipologyOfAgrarianProblem> TipologyOfAgrarianProblem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<VillageMapAttribute>().ToTable("VillageMapAttribute");
            modelBuilder.Entity<ToraMapAttribute>().ToTable("ToraMapAttribute");
            modelBuilder.Entity<Event>().ToTable("WorkCalendar");
            modelBuilder.Entity<PoliciesDocuments>().ToTable("PoliciesDocuments");
            modelBuilder.Entity<MeetingMinutes>().ToTable("MeetingReport");
            modelBuilder.Entity<ObjectSubjectTora>().ToTable("ObjectSubjectTora");
            modelBuilder.Entity<ToraSubmission>().ToTable("ToraSubmission");
            modelBuilder.Entity<ActProposalDocumentCheckList>().ToTable("ProposalOfActDocumentCheckList");
            modelBuilder.Entity<VillageProfile>().ToTable("ProfileOfVillage");
            modelBuilder.Entity<TipologyOfAgrarianProblem>().ToTable("TipologyOfAgrarianProblem");

        }
    }
}
