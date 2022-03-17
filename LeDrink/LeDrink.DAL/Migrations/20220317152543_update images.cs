using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class updateimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgPath",
                value: "/images/bottles/CocaCola.png");

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

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgPath",
                value: "/images/bottles/Gin.png");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgPath",
                value: "/images/bottles/OrangeJuice.png");

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 7, "Bacardi", null, 1000, "/images/bottles/Bacardi.png", 1000 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 8, "Malibu", null, 1000, "/images/bottles/Malibu.png", 1000 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 9, "RedWine", null, 1000, "/images/bottles/RedWine.png", 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgPath",
                value: "/images/bottles/gin-700ml.jpg");

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgPath",
                value: "/images/bottles/orangejuice-1000ml.jpg");
        }
    }
}
