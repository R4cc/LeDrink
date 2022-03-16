using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class addtotalmltodrink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Milliliters",
                table: "Mixes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Milliliters",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Milliliters",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Milliliters",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Milliliters",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Milliliters",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Milliliters",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Milliliters",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Milliliters",
                value: 250);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Milliliters",
                table: "Mixes",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Milliliters",
                value: 250.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Milliliters",
                value: 250.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Milliliters",
                value: 250.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Milliliters",
                value: 250.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Milliliters",
                value: 300.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Milliliters",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Milliliters",
                value: 250.0);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Milliliters",
                value: 250.0);
        }
    }
}
