using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxGroupTest.Migrations
{
    public partial class RemovedLocationId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "TaxRates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "TaxRates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
