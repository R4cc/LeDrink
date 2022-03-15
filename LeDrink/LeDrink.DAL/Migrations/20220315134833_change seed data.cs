using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class changeseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgPath",
                value: "/images/bottles/cocacola-1500ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgPath",
                value: "/images/bottles/fanta-1500ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/images/bottles/redbull-250ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgPath",
                value: "/images/bottles/vodka-700ml.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgPath",
                value: "/wwwroot/images/bottles/cocacola-1500ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgPath",
                value: "/wwwroot/images/bottles/fanta-1500ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/wwwroot/images/bottles/redbull-250ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgPath",
                value: "/wwwroot/images/bottles/vodka-700ml.jpg");
        }
    }
}
