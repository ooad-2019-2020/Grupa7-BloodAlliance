using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class Novo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "datum",
                table: "Zahtjev",
                newName: "Datum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Datum",
                table: "Zahtjev",
                newName: "datum");
        }
    }
}
