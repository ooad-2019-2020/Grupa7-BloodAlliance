using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BloodAlliance.ModelsAPI
{
    public partial class BloodAllianceContext : DbContext
    {
        public BloodAllianceContext()
        {
        }

        public BloodAllianceContext(DbContextOptions<BloodAllianceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Bolnica> Bolnica { get; set; }
        public virtual DbSet<Donacija> Donacija { get; set; }
        public virtual DbSet<Donor> Donor { get; set; }
        public virtual DbSet<Obavijest> Obavijest { get; set; }
        public virtual DbSet<ObavijestBolnica> ObavijestBolnica { get; set; }
        public virtual DbSet<ObavijestDonor> ObavijestDonor { get; set; }
        public virtual DbSet<Zahtjev> Zahtjev { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:ooad2020new.database.windows.net,1433;Initial Catalog=BloodAlliance;Persist Security Info=False;User ID=BloodAlliance;Password=Test123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Bolnica>(entity =>
            {
                entity.Property(e => e.Adresa).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Username).IsRequired();
            });

            modelBuilder.Entity<Donacija>(entity =>
            {
                entity.HasIndex(e => e.DonorId);

                entity.HasIndex(e => e.ObavijestBolnicaId);

                entity.Property(e => e.KrvnaGrupa).IsRequired();

                entity.Property(e => e.RhFaktor).IsRequired();

                entity.Property(e => e.SifraDonacije).IsRequired();

                entity.HasOne(d => d.Donor)
                    .WithMany(p => p.Donacija)
                    .HasForeignKey(d => d.DonorId);

                entity.HasOne(d => d.ObavijestBolnica)
                    .WithMany(p => p.Donacija)
                    .HasForeignKey(d => d.ObavijestBolnicaId);
            });

            modelBuilder.Entity<Donor>(entity =>
            {
                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Hemoglobin).IsRequired();

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.Jmbg).IsRequired();

                entity.Property(e => e.KrvnaGrupa).IsRequired();

                entity.Property(e => e.KrvniPritisak).IsRequired();

                entity.Property(e => e.MjestoDarivanja).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.RhFaktor).IsRequired();

                entity.Property(e => e.Username).IsRequired();
            });

            modelBuilder.Entity<ObavijestBolnica>(entity =>
            {
                entity.HasIndex(e => e.BolnicaId);

                entity.HasOne(d => d.Bolnica)
                    .WithMany(p => p.ObavijestBolnica)
                    .HasForeignKey(d => d.BolnicaId);
            });

            modelBuilder.Entity<ObavijestDonor>(entity =>
            {
                entity.HasIndex(e => e.DonorId);

                entity.Property(e => e.DatumObavijesti).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Donor)
                    .WithMany(p => p.ObavijestDonor)
                    .HasForeignKey(d => d.DonorId);
            });

            modelBuilder.Entity<Zahtjev>(entity =>
            {
                entity.HasIndex(e => e.BolnicaId);

                entity.HasOne(d => d.Bolnica)
                    .WithMany(p => p.Zahtjev)
                    .HasForeignKey(d => d.BolnicaId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
