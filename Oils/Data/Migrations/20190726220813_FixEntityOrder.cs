using Microsoft.EntityFrameworkCore.Migrations;

namespace Oils.Data.Migrations
{
    public partial class FixEntityOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Orders",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<string>(
                name: "OilsUserId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OilsUserId",
                table: "Orders",
                column: "OilsUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_OilsUserId",
                table: "Orders",
                column: "OilsUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_OilsUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OilsUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OilsUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Orders",
                newName: "isDeleted");
        }
    }
}
