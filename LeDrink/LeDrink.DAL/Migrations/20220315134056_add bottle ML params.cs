using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class addbottleMLparams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BottleSlotId",
                table: "Bottles",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "CurrentMl",
                table: "Bottles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Bottles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxMl",
                table: "Bottles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 1500, "/wwwroot/images/bottles/cocacola-1500ml.jpg", 1500 });

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 1500, "/wwwroot/images/bottles/fanta-1500ml.jpg", 1500 });

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 250, "/wwwroot/images/bottles/redbull-250ml.jpg", 250 });

            migrationBuilder.UpdateData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 700, "/wwwroot/images/bottles/vodka-700ml.jpg", 700 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentMl",
                table: "Bottles");

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Bottles");

            migrationBuilder.DropColumn(
                name: "MaxMl",
                table: "Bottles");

            migrationBuilder.AlterColumn<int>(
                name: "BottleSlotId",
                table: "Bottles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
