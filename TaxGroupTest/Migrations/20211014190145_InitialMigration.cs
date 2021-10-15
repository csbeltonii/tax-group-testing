using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxGroupTest.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaxGroups",
                columns: table => new
                {
                    TaxGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxGroups", x => x.TaxGroupId);
                });

            migrationBuilder.CreateTable(
                name: "TaxRates",
                columns: table => new
                {
                    TaxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxMinimum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cap = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRates", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "TaxGroupings",
                columns: table => new
                {
                    TaxId = table.Column<int>(type: "int", nullable: false),
                    TaxGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxGroupings", x => new { x.TaxId, x.TaxGroupId });
                    table.ForeignKey(
                        name: "FK_TaxGroupings_TaxGroups_TaxGroupId",
                        column: x => x.TaxGroupId,
                        principalTable: "TaxGroups",
                        principalColumn: "TaxGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxGroupings_TaxRates_TaxId",
                        column: x => x.TaxId,
                        principalTable: "TaxRates",
                        principalColumn: "TaxId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaxGroupings_TaxGroupId",
                table: "TaxGroupings",
                column: "TaxGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxGroupings");

            migrationBuilder.DropTable(
                name: "TaxGroups");

            migrationBuilder.DropTable(
                name: "TaxRates");
        }
    }
}
