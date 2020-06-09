using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class bolnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NazivBolnice",
                table: "Zahtjev",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RhFaktor",
                table: "Zahtjev",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazivBolnice",
                table: "Zahtjev");

            migrationBuilder.DropColumn(
                name: "RhFaktor",
                table: "Zahtjev");
        }
    }
}
