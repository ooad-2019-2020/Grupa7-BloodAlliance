using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class zahtjev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "Zahtjev",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "Zahtjev");
        }
    }
}
