using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class fiximgpath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgPath",
                value: "/images/bottles/Fanta.png");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/images/bottles/RedBull.png");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgPath",
                value: "/images/bottles/Vodka_white.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgPath",
                value: "/images/bottles/fanta.png");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/images/bottles/redbull.png");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgPath",
                value: "/images/bottles/vodka_white.png");
        }
    }
}
