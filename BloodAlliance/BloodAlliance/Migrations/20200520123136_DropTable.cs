using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class DropTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ZdravstvenaHistroija");

            migrationBuilder.DropTable(
                name: "Donor");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BolnicaId",
                table: "Zahtjev",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DonorId",
                table: "ObavijestDonor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BolnicaId",
                table: "ObavijestBolnica",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bolnica",
                columns: table => new
                {
                    BolnicaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolnica", x => x.BolnicaId);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    DonorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BrojDarivanja = table.Column<int>(type: "int", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jmbg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrvnaGrupa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RhFaktor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TjelesnaTezina = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.DonorId);
                });

            migrationBuilder.CreateTable(
                name: "ZdravstvenaHistroija",
                columns: table => new
                {
                    ZdravstvenaHistorijaId = table.Column<bool>(type: "bit", nullable: false),
                    BolestiRespiratornogSistema = table.Column<bool>(type: "bit", nullable: false),
                    HormonalniPoremecaji = table.Column<bool>(type: "bit", nullable: false),
                    HronicneBolesti = table.Column<bool>(type: "bit", nullable: false),
                    NervniProblemi = table.Column<bool>(type: "bit", nullable: false),
                    PolnoPrenosiveBolesti = table.Column<bool>(type: "bit", nullable: false),
                    Secer = table.Column<bool>(type: "bit", nullable: false),
                    SrcaniProblemi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZdravstvenaHistroija", x => x.ZdravstvenaHistorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Donacija",
                columns: table => new
                {
                    DonacijaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DonorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ImeDoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrvnaGrupa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObavijestBolnicaId = table.Column<int>(type: "int", nullable: true),
                    RhFaktor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datumDonacije = table.Column<DateTime>(type: "datetime2", nullable: false)
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
    }
}
