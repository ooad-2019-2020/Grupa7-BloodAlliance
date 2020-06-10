using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class ObavijestDonor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavijestDonor_Donor_DonorId",
                table: "ObavijestDonor");

            migrationBuilder.AlterColumn<int>(
                name: "DonorId",
                table: "ObavijestDonor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ObavijestDonor_Donor_DonorId",
                table: "ObavijestDonor",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObavijestDonor_Donor_DonorId",
                table: "ObavijestDonor");

            migrationBuilder.AlterColumn<int>(
                name: "DonorId",
                table: "ObavijestDonor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ObavijestDonor_Donor_DonorId",
                table: "ObavijestDonor",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
