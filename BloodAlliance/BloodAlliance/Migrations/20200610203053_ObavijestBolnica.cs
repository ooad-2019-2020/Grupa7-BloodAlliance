using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class ObavijestBolnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                table: "ObavijestBolnica");

            migrationBuilder.AlterColumn<int>(
                name: "BolnicaId",
                table: "ObavijestBolnica",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Obavijest",
                table: "ObavijestBolnica",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                table: "ObavijestBolnica",
                column: "BolnicaId",
                principalTable: "Bolnica",
                principalColumn: "BolnicaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                table: "ObavijestBolnica");

            migrationBuilder.DropColumn(
                name: "Obavijest",
                table: "ObavijestBolnica");

            migrationBuilder.AlterColumn<int>(
                name: "BolnicaId",
                table: "ObavijestBolnica",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ObavijestBolnica_Bolnica_BolnicaId",
                table: "ObavijestBolnica",
                column: "BolnicaId",
                principalTable: "Bolnica",
                principalColumn: "BolnicaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
