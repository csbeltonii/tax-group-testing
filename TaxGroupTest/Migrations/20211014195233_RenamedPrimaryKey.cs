using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxGroupTest.Migrations
{
    public partial class RenamedPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateTaxId",
                table: "TaxGroupings");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupTaxRate_TaxRates_RatesTaxId",
                table: "TaxGroupTaxRate");

            migrationBuilder.RenameColumn(
                name: "TaxId",
                table: "TaxRates",
                newName: "TaxRateId");

            migrationBuilder.RenameColumn(
                name: "RatesTaxId",
                table: "TaxGroupTaxRate",
                newName: "RatesTaxRateId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxGroupTaxRate_RatesTaxId",
                table: "TaxGroupTaxRate",
                newName: "IX_TaxGroupTaxRate_RatesTaxRateId");

            migrationBuilder.RenameColumn(
                name: "TaxRateTaxId",
                table: "TaxGroupings",
                newName: "TaxRateId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxGroupings_TaxRateTaxId",
                table: "TaxGroupings",
                newName: "IX_TaxGroupings_TaxRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateId",
                table: "TaxGroupings",
                column: "TaxRateId",
                principalTable: "TaxRates",
                principalColumn: "TaxRateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupTaxRate_TaxRates_RatesTaxRateId",
                table: "TaxGroupTaxRate",
                column: "RatesTaxRateId",
                principalTable: "TaxRates",
                principalColumn: "TaxRateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateId",
                table: "TaxGroupings");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupTaxRate_TaxRates_RatesTaxRateId",
                table: "TaxGroupTaxRate");

            migrationBuilder.RenameColumn(
                name: "TaxRateId",
                table: "TaxRates",
                newName: "TaxId");

            migrationBuilder.RenameColumn(
                name: "RatesTaxRateId",
                table: "TaxGroupTaxRate",
                newName: "RatesTaxId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxGroupTaxRate_RatesTaxRateId",
                table: "TaxGroupTaxRate",
                newName: "IX_TaxGroupTaxRate_RatesTaxId");

            migrationBuilder.RenameColumn(
                name: "TaxRateId",
                table: "TaxGroupings",
                newName: "TaxRateTaxId");

            migrationBuilder.RenameIndex(
                name: "IX_TaxGroupings_TaxRateId",
                table: "TaxGroupings",
                newName: "IX_TaxGroupings_TaxRateTaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateTaxId",
                table: "TaxGroupings",
                column: "TaxRateTaxId",
                principalTable: "TaxRates",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupTaxRate_TaxRates_RatesTaxId",
                table: "TaxGroupTaxRate",
                column: "RatesTaxId",
                principalTable: "TaxRates",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
