using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxGroupTest.Migrations
{
    public partial class UpdatedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateId",
                table: "TaxGroupings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxGroupings",
                table: "TaxGroupings");

            migrationBuilder.DropIndex(
                name: "IX_TaxGroupings_TaxRateId",
                table: "TaxGroupings");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "TaxGroupings");

            migrationBuilder.AlterColumn<int>(
                name: "TaxRateId",
                table: "TaxGroupings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxGroupings",
                table: "TaxGroupings",
                columns: new[] { "TaxRateId", "TaxGroupId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateId",
                table: "TaxGroupings",
                column: "TaxRateId",
                principalTable: "TaxRates",
                principalColumn: "TaxRateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateId",
                table: "TaxGroupings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxGroupings",
                table: "TaxGroupings");

            migrationBuilder.AlterColumn<int>(
                name: "TaxRateId",
                table: "TaxGroupings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "TaxGroupings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxGroupings",
                table: "TaxGroupings",
                columns: new[] { "TaxId", "TaxGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_TaxGroupings_TaxRateId",
                table: "TaxGroupings",
                column: "TaxRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxGroupings_TaxRates_TaxRateId",
                table: "TaxGroupings",
                column: "TaxRateId",
                principalTable: "TaxRates",
                principalColumn: "TaxRateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
