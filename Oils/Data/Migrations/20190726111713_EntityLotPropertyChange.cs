using Microsoft.EntityFrameworkCore.Migrations;

namespace Oils.Data.Migrations
{
    public partial class EntityLotPropertyChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Dencity",
                table: "Lots",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dencity",
                table: "Lots");
        }
    }
}
