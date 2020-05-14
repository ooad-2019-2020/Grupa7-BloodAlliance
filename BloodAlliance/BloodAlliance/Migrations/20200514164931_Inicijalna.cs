using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolnica",
                columns: table => new
                {
                    BolnicaId = table.Column<string>(nullable: false),
                    naziv = table.Column<string>(nullable: true),
                    adresa = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolnica", x => x.BolnicaId);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    DonorId = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Jmbg = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    KrvnaGrupa = table.Column<string>(nullable: true),
                    RhFaktor = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    BrojDarivanja = table.Column<int>(nullable: false),
                    TjelesnaTezina = table.Column<double>(nullable: false),
                    DonorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_Donor_Donor_DonorId1",
                        column: x => x.DonorId1,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    ObavijestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.ObavijestId);
                });

            migrationBuilder.CreateTable(
                name: "ObavijestBolnica",
                columns: table => new
                {
                    ObavijestBolnicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KrvnaGrupa = table.Column<string>(nullable: true),
                    Kolicina = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    BolnicaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavijestBolnica", x => x.ObavijestBolnicaId);
                    table.ForeignKey(
                        name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                        column: x => x.BolnicaId,
                        principalTable: "Bolnica",
                        principalColumn: "BolnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    ZahtjevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datum = table.Column<DateTime>(nullable: false),
                    KrvnaGrupa = table.Column<string>(nullable: true),
                    BolnicaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.ZahtjevId);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Bolnica_BolnicaId",
                        column: x => x.BolnicaId,
                        principalTable: "Bolnica",
                        principalColumn: "BolnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObavijestDonor",
                columns: table => new
                {
                    ObavijestDonorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Obavijest = table.Column<string>(nullable: true),
                    DonorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavijestDonor", x => x.ObavijestDonorId);
                    table.ForeignKey(
                        name: "FK_ObavijestDonor_Donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZdravstvenaHistroija",
                columns: table => new
                {
                    ZdravstvenaHistorijaId = table.Column<bool>(nullable: false),
                    BolestiRespiratornogSistema = table.Column<bool>(nullable: false),
                    SrcaniProblemi = table.Column<bool>(nullable: false),
                    PolnoPrenosiveBolesti = table.Column<bool>(nullable: false),
                    HormonalniPoremecaji = table.Column<bool>(nullable: false),
                    Secer = table.Column<bool>(nullable: false),
                    HronicneBolesti = table.Column<bool>(nullable: false),
                    NervniProblemi = table.Column<bool>(nullable: false),
                    DonorId = table.Column<int>(nullable: false),
                    DonorId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZdravstvenaHistroija", x => x.ZdravstvenaHistorijaId);
                    table.ForeignKey(
                        name: "FK_ZdravstvenaHistroija_Donor_DonorId1",
                        column: x => x.DonorId1,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Donacija",
                columns: table => new
                {
                    DonacijaId = table.Column<string>(nullable: false),
                    KrvnaGrupa = table.Column<string>(nullable: true),
                    datumDonacije = table.Column<DateTime>(nullable: false),
                    RhFaktor = table.Column<string>(nullable: true),
                    ImeDoktora = table.Column<string>(nullable: true),
                    DonorId = table.Column<string>(nullable: true),
                    ObavijestBolnicaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donacija", x => x.DonacijaId);
                    table.ForeignKey(
                        name: "FK_Donacija_Donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donacija_ObavijestBolnica_ObavijestBolnicaId",
                        column: x => x.ObavijestBolnicaId,
                        principalTable: "ObavijestBolnica",
                        principalColumn: "ObavijestBolnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donacija_DonorId",
                table: "Donacija",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donacija_ObavijestBolnicaId",
                table: "Donacija",
                column: "ObavijestBolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_DonorId1",
                table: "Donor",
                column: "DonorId1");

            migrationBuilder.CreateIndex(
                name: "IX_ObavijestBolnica_BolnicaId",
                table: "ObavijestBolnica",
                column: "BolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObavijestDonor_DonorId",
                table: "ObavijestDonor",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_BolnicaId",
                table: "Zahtjev",
                column: "BolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ZdravstvenaHistroija_DonorId1",
                table: "ZdravstvenaHistroija",
                column: "DonorId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donacija");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "ObavijestDonor");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "ZdravstvenaHistroija");

            migrationBuilder.DropTable(
                name: "ObavijestBolnica");

            migrationBuilder.DropTable(
                name: "Donor");

            migrationBuilder.DropTable(
                name: "Bolnica");
        }
    }
}
