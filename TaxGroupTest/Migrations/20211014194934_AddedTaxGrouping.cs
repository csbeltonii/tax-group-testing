using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxGroupTest.Migrations
{
    public partial class AddedTaxGrouping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxId",
                table: "TaxGroupings");

            migrationBuilder.AddColumn<int>(
                name: "TaxRateTaxId",
                table: "TaxGroupings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TaxGroupTaxRate",
                columns: table => new
                {
                    GroupsTaxGroupId = table.Column<int>(type: "int", nullable: false),
                    RatesTaxId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxGroupTaxRate", x => new { x.GroupsTaxGroupId, x.RatesTaxId });
                    table.ForeignKey(
                        name: "FK_TaxGroupTaxRate_TaxGroups_GroupsTaxGroupId",
                        column: x => x.GroupsTaxGroupId,
                        principalTable: "TaxGroups",
                        principalColumn: "TaxGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxGroupTaxRate_TaxRates_RatesTaxId",
                        column: x => x.RatesTaxId,
                        principalTable: "TaxRates",
                        principalColumn: "TaxId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaxGroupings_TaxRateTaxId",
                table: "TaxGroupings",
                column: "TaxRateTaxId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxGroupTaxRate_RatesTaxId",
                table: "TaxGroupTaxRate",
                column: "RatesTaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateTaxId",
                table: "TaxGroupings",
                column: "TaxRateTaxId",
                principalTable: "TaxRates",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateTaxId",
                table: "TaxGroupings");

            migrationBuilder.DropTable(
                name: "TaxGroupTaxRate");

            migrationBuilder.DropIndex(
                name: "IX_TaxGroupings_TaxRateTaxId",
                table: "TaxGroupings");

            migrationBuilder.DropColumn(
                name: "TaxRateTaxId",
                table: "TaxGroupings");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxId",
                table: "TaxGroupings",
                column: "TaxId",
                principalTable: "TaxRates",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
