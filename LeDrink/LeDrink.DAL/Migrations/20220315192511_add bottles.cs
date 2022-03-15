using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class addbottles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 5, "Gin", null, 700, "/images/bottles/gin-700ml.jpg", 700 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 6, "Orange Juice", null, 1000, "/images/bottles/orangejuice-1000ml.jpg", 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
