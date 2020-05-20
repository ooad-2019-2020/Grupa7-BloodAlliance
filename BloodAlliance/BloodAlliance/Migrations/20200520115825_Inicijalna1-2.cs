using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class Inicijalna12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.AddColumn<int>(
                name: "DonorId",
                table: "ZdravstvenaHistroija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DonorId1",
                table: "ZdravstvenaHistroija",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    ObavijestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.ObavijestId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZdravstvenaHistroija_DonorId1",
                table: "ZdravstvenaHistroija",
                column: "DonorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ZdravstvenaHistroija_Donor_DonorId1",
                table: "ZdravstvenaHistroija",
                column: "DonorId1",
                principalTable: "Donor",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Restrict);*/
        }
    }
}
