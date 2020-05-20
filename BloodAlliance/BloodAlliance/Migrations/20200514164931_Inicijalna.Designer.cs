﻿// <auto-generated />
using System;
using BloodAlliance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodAlliance.Migrations
{
    [DbContext(typeof(BAContext))]
    [Migration("20200514164931_Inicijalna")]
    partial class Inicijalna
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BloodAlliance.Models.Bolnica", b =>
                {
                    b.Property<string>("BolnicaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BolnicaId");

                    b.ToTable("Bolnica");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donacija", b =>
                {
                    b.Property<string>("DonacijaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DonorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImeDoktora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ObavijestBolnicaId")
                        .HasColumnType("int");

                    b.Property<string>("RhFaktor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumDonacije")
                        .HasColumnType("datetime2");

                    b.HasKey("DonacijaId");

                    b.HasIndex("DonorId");

                    b.HasIndex("ObavijestBolnicaId");

                    b.ToTable("Donacija");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donor", b =>
                {
                    b.Property<string>("DonorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BrojDarivanja")
                        .HasColumnType("int");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jmbg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RhFaktor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TjelesnaTezina")
                        .HasColumnType("float");

                    b.HasKey("DonorId");

                    b.HasIndex("DonorId1");

                    b.ToTable("Donor");
                });

            modelBuilder.Entity("BloodAlliance.Models.Obavijest", b =>
                {
                    b.Property<int>("ObavijestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ObavijestId");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestBolnica", b =>
                {
                    b.Property<int>("ObavijestBolnicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BolnicaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestBolnicaId");

                    b.HasIndex("BolnicaId");

                    b.ToTable("ObavijestBolnica");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestDonor", b =>
                {
                    b.Property<int>("ObavijestDonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Obavijest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestDonorId");

                    b.HasIndex("DonorId");

                    b.ToTable("ObavijestDonor");
                });

            modelBuilder.Entity("BloodAlliance.Models.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BolnicaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datum")
                        .HasColumnType("datetime2");

                    b.HasKey("ZahtjevId");

                    b.HasIndex("BolnicaId");

                    b.ToTable("Zahtjev");
                });

            modelBuilder.Entity("BloodAlliance.Models.ZdravstvenaHistorija", b =>
                {
                    b.Property<bool>("ZdravstvenaHistorijaId")
                        .HasColumnType("bit");

                    b.Property<bool>("BolestiRespiratornogSistema")
                        .HasColumnType("bit");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<string>("DonorId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("HormonalniPoremecaji")
                        .HasColumnType("bit");

                    b.Property<bool>("HronicneBolesti")
                        .HasColumnType("bit");

                    b.Property<bool>("NervniProblemi")
                        .HasColumnType("bit");

                    b.Property<bool>("PolnoPrenosiveBolesti")
                        .HasColumnType("bit");

                    b.Property<bool>("Secer")
                        .HasColumnType("bit");

                    b.Property<bool>("SrcaniProblemi")
                        .HasColumnType("bit");

                    b.HasKey("ZdravstvenaHistorijaId");

                    b.HasIndex("DonorId1");

                    b.ToTable("ZdravstvenaHistroija");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donacija", b =>
                {
                    b.HasOne("BloodAlliance.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId");

                    b.HasOne("BloodAlliance.Models.ObavijestBolnica", "Obavijest")
                        .WithMany("Donacije")
                        .HasForeignKey("ObavijestBolnicaId");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donor", b =>
                {
                    b.HasOne("BloodAlliance.Models.Donor", null)
                        .WithMany("Donori")
                        .HasForeignKey("DonorId1");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestBolnica", b =>
                {
                    b.HasOne("BloodAlliance.Models.Bolnica", "Bolnica")
                        .WithMany("Obavijesti")
                        .HasForeignKey("BolnicaId");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestDonor", b =>
                {
                    b.HasOne("BloodAlliance.Models.Donor", "Donor")
                        .WithMany("Obavijesti")
                        .HasForeignKey("DonorId");
                });

            modelBuilder.Entity("BloodAlliance.Models.Zahtjev", b =>
                {
                    b.HasOne("BloodAlliance.Models.Bolnica", "Bolnica")
                        .WithMany("Zahtjevi")
                        .HasForeignKey("BolnicaId");
                });

            modelBuilder.Entity("BloodAlliance.Models.ZdravstvenaHistorija", b =>
                {
                    b.HasOne("BloodAlliance.Models.Donor", "Donor")
                        .WithMany()
                        .HasForeignKey("DonorId1");
                });
#pragma warning restore 612, 618
        }
    }
}