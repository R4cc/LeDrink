using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class resetdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Bottles_bottleId",
                table: "Mixes");

            migrationBuilder.AlterColumn<int>(
                name: "bottleId",
                table: "Mixes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Milliliters",
                table: "Mixes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Milliliters",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Milliliters",
                value: 225);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Milliliters",
                value: 225);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Milliliters",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Milliliters",
                value: 200);

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Bottles_bottleId",
                table: "Mixes",
                column: "bottleId",
                principalTable: "Bottles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Bottles_bottleId",
                table: "Mixes");

            migrationBuilder.AlterColumn<int>(
                name: "bottleId",
                table: "Mixes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Milliliters",
                table: "Mixes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
                keyValue: 7,
                column: "Milliliters",
                value: 250);

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Bottles_bottleId",
                table: "Mixes",
                column: "bottleId",
                principalTable: "Bottles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
