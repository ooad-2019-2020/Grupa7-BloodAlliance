using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodAlliance.Migrations
{
    public partial class zdravstvenaHistorija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donor_ZdravstvenaHistorija_ZdravstvenaHistorijaId",
                table: "Donor");

            migrationBuilder.DropTable(
                name: "ZdravstvenaHistorija");

            migrationBuilder.DropIndex(
                name: "IX_Donor_ZdravstvenaHistorijaId",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "ZdravstvenaHistorijaId",
                table: "Donor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZdravstvenaHistorijaId",
                table: "Donor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ZdravstvenaHistorija",
                columns: table => new
                {
                    ZdravstvenaHistorijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_ZdravstvenaHistorija", x => x.ZdravstvenaHistorijaId);
                });

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
    }
}
