using Microsoft.EntityFrameworkCore.Migrations;

namespace Oils.Data.Migrations
{
    public partial class EditEntityProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PackageWeight",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PackageWeight",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
