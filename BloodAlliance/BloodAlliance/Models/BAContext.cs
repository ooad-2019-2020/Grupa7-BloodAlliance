using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class BAContext:DbContext
    {
        public BAContext(DbContextOptions<BAContext> options) : base(options) { }
        public DbSet<Bolnica> Bolnica { get; set; }
        public DbSet<Donacija> Donacija { get; set; }
        public DbSet<Donor> Donor { get; set; }
        public DbSet<ObavijestBolnica> ObavijestBolnica { get; set; }
        public DbSet<ObavijestDonor> ObavijestDonor { get; set; }
        public DbSet<Zahtjev> Zahtjev { get; set; }
        public DbSet<ZdravstvenaHistorija> ZdravstvenaHistorija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Bolnica>().ToTable("Bolnica");
            modelBuilder.Entity<Donacija>().ToTable("Donacija");
            modelBuilder.Entity<Donor>().ToTable("Donor");
            modelBuilder.Entity<ObavijestBolnica>().ToTable("ObavijestBolnica");
            modelBuilder.Entity<ObavijestDonor>().ToTable("ObavijestDonor");
            modelBuilder.Entity<Zahtjev>().ToTable("Zahtjev");
            modelBuilder.Entity<ZdravstvenaHistorija>().ToTable("ZdravstvenaHistorija");
        }

    }
}
