using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Drinks_DrinkId",
                table: "Mixes");

            migrationBuilder.AlterColumn<int>(
                name: "DrinkId",
                table: "Mixes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ImgPath",
                table: "Drinks",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "Drinks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId" },
                values: new object[] { 1, "Coca Cola", 1 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId" },
                values: new object[] { 2, "Fanta", 2 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId" },
                values: new object[] { 3, "RedBull", 3 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId" },
                values: new object[] { 4, "Vodka", 4 });

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Drinks_DrinkId",
                table: "Mixes",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Drinks_DrinkId",
                table: "Mixes");

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bottles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "Drinks");

            migrationBuilder.AlterColumn<int>(
                name: "DrinkId",
                table: "Mixes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgPath",
                table: "Drinks",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Drinks_DrinkId",
                table: "Mixes",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
