using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class refreshseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgPath",
                value: "/images/drinks/template-cup-test.png");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "/images/drinks/template-cup-test.png");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImgPath", "IsFavourite" },
                values: new object[] { "/images/drinks/template-cup-test.png", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgPath",
                value: "https://www.spezi.com/wp-content/uploads/thumbnail-logo-spezi-original.jpg");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgPath",
                value: "https://media.istockphoto.com/photos/fanta-red-bull-and-coca-cola-cans-picture-id458092615");

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImgPath", "IsFavourite" },
                values: new object[] { "https://www.acouplecooks.com/wp-content/uploads/2020/12/Vodka-and-Coke-001.jpg", true });
        }
    }
}
