using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite", "Price" },
                values: new object[] { 1, "VodkaBull", "https://media.kaufland.com/images/PPIM/AP_Content_1010/std.lang.all/54/80/Asset_1895480.jpg", true, 20 });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite", "Price" },
                values: new object[] { 2, "Spezi", "https://www.spezi.com/wp-content/uploads/thumbnail-logo-spezi-original.jpg", true, 10 });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite", "Price" },
                values: new object[] { 3, "Fantabull", "https://media.istockphoto.com/photos/fanta-red-bull-and-coca-cola-cans-picture-id458092615", false, 15 });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite", "Price" },
                values: new object[] { 4, "VodkaCoke", "https://www.acouplecooks.com/wp-content/uploads/2020/12/Vodka-and-Coke-001.jpg", true, 35 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
