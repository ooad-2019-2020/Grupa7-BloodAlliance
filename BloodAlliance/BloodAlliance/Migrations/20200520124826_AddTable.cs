using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BolnicaId",
                table: "Zahtjev",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DonorId",
                table: "ObavijestDonor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BolnicaId",
                table: "ObavijestBolnica",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bolnica",
                columns: table => new
                {
                    BolnicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolnica", x => x.BolnicaId);
                });

            migrationBuilder.CreateTable(
                name: "ZdravstvenaHistorija",
                columns: table => new
                {
                    ZdravstvenaHistorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolestiRespiratornogSistema = table.Column<bool>(nullable: false),
                    SrcaniProblemi = table.Column<bool>(nullable: false),
                    PolnoPrenosiveBolesti = table.Column<bool>(nullable: false),
                    HormonalniPoremecaji = table.Column<bool>(nullable: false),
                    Secer = table.Column<bool>(nullable: false),
                    HronicneBolesti = table.Column<bool>(nullable: false),
                    DonorId = table.Column<int>(nullable: false),
                    NervniProblemi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZdravstvenaHistorija", x => x.ZdravstvenaHistorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    DonorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    BrojTelefona = table.Column<string>(nullable: true),
                    Jmbg = table.Column<string>(nullable: false),
                    KrvnaGrupa = table.Column<string>(nullable: false),
                    RhFaktor = table.Column<string>(nullable: false),
                    BrojDarivanja = table.Column<int>(nullable: false),
                    TjelesnaTezina = table.Column<double>(nullable: false),
                    MjestoDarivanja = table.Column<string>(nullable: false),
                    DatumPosljednjeDonacije = table.Column<DateTime>(nullable: false),
                    Hemoglobin = table.Column<string>(nullable: false),
                    KrvniPritisak = table.Column<string>(nullable: false),
                    Pol = table.Column<int>(nullable: false),
                    StatusDonora = table.Column<int>(nullable: false),
                    ZdravstvenaHistorijaId = table.Column<int>(nullable: false),
                    ZdravstvenaHistorijaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_Donor_ZdravstvenaHistorija_ZdravstvenaHistorijaId1",
                        column: x => x.ZdravstvenaHistorijaId1,
                        principalTable: "ZdravstvenaHistorija",
                        principalColumn: "ZdravstvenaHistorijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Donacija",
                columns: table => new
                {
                    DonacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SifraDonacije = table.Column<string>(nullable: false),
                    KrvnaGrupa = table.Column<string>(nullable: false),
                    DatumDonacije = table.Column<DateTime>(nullable: false),
                    RhFaktor = table.Column<string>(nullable: false),
                    ImeDoktora = table.Column<string>(nullable: true),
                    DonorId = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donacija_ObavijestBolnica_ObavijestBolnicaId",
                        column: x => x.ObavijestBolnicaId,
                        principalTable: "ObavijestBolnica",
                        principalColumn: "ObavijestBolnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_BolnicaId",
                table: "Zahtjev",
                column: "BolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObavijestDonor_DonorId",
                table: "ObavijestDonor",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_ObavijestBolnica_BolnicaId",
                table: "ObavijestBolnica",
                column: "BolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Donacija_DonorId",
                table: "Donacija",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donacija_ObavijestBolnicaId",
                table: "Donacija",
                column: "ObavijestBolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_ZdravstvenaHistorijaId1",
                table: "Donor",
                column: "ZdravstvenaHistorijaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                table: "ObavijestBolnica",
                column: "BolnicaId",
                principalTable: "Bolnica",
                principalColumn: "BolnicaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavijestDonor_Donor_DonorId",
                table: "ObavijestDonor",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zahtjev_Bolnica_BolnicaId",
                table: "Zahtjev",
                column: "BolnicaId",
                principalTable: "Bolnica",
                principalColumn: "BolnicaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                table: "ObavijestBolnica");

            migrationBuilder.DropForeignKey(
                name: "FK_ObavijestDonor_Donor_DonorId",
                table: "ObavijestDonor");

            migrationBuilder.DropForeignKey(
                name: "FK_Zahtjev_Bolnica_BolnicaId",
                table: "Zahtjev");

            migrationBuilder.DropTable(
                name: "Bolnica");

            migrationBuilder.DropTable(
                name: "Donacija");

            migrationBuilder.DropTable(
                name: "Donor");

            migrationBuilder.DropTable(
                name: "ZdravstvenaHistorija");

            migrationBuilder.DropIndex(
                name: "IX_Zahtjev_BolnicaId",
                table: "Zahtjev");

            migrationBuilder.DropIndex(
                name: "IX_ObavijestDonor_DonorId",
                table: "ObavijestDonor");

            migrationBuilder.DropIndex(
                name: "IX_ObavijestBolnica_BolnicaId",
                table: "ObavijestBolnica");

            migrationBuilder.DropColumn(
                name: "BolnicaId",
                table: "Zahtjev");

            migrationBuilder.DropColumn(
                name: "DonorId",
                table: "ObavijestDonor");

            migrationBuilder.DropColumn(
                name: "BolnicaId",
                table: "ObavijestBolnica");
        }
    }
}
