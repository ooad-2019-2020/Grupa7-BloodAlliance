using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class Novo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donor_ZdravstvenaHistorija_ZdravstvenaHistorijaId1",
                table: "Donor");

            migrationBuilder.DropIndex(
                name: "IX_Donor_ZdravstvenaHistorijaId1",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "DonorId",
                table: "ZdravstvenaHistorija");

            migrationBuilder.DropColumn(
                name: "ZdravstvenaHistorijaId1",
                table: "Donor");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_ZdravstvenaHistorijaId",
                table: "Donor",
                column: "ZdravstvenaHistorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donor_ZdravstvenaHistorija_ZdravstvenaHistorijaId",
                table: "Donor",
                column: "ZdravstvenaHistorijaId",
                principalTable: "ZdravstvenaHistorija",
                principalColumn: "ZdravstvenaHistorijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donor_ZdravstvenaHistorija_ZdravstvenaHistorijaId",
                table: "Donor");

            migrationBuilder.DropIndex(
                name: "IX_Donor_ZdravstvenaHistorijaId",
                table: "Donor");

            migrationBuilder.AddColumn<int>(
                name: "DonorId",
                table: "ZdravstvenaHistorija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZdravstvenaHistorijaId1",
                table: "Donor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donor_ZdravstvenaHistorijaId1",
                table: "Donor",
                column: "ZdravstvenaHistorijaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Donor_ZdravstvenaHistorija_ZdravstvenaHistorijaId1",
                table: "Donor",
                column: "ZdravstvenaHistorijaId1",
                principalTable: "ZdravstvenaHistorija",
                principalColumn: "ZdravstvenaHistorijaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
