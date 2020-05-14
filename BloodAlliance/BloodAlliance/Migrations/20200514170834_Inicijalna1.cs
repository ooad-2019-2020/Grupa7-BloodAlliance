using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class Inicijalna1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donor_Donor_DonorId1",
                table: "Donor");

            migrationBuilder.DropIndex(
                name: "IX_Donor_DonorId1",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "DonorId1",
                table: "Donor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DonorId1",
                table: "Donor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donor_DonorId1",
                table: "Donor",
                column: "DonorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Donor_Donor_DonorId1",
                table: "Donor",
                column: "DonorId1",
                principalTable: "Donor",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
