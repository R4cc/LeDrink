using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class fix225 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Bottles_BottleId",
                table: "Mixes");

            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Drinks_DrinkId",
                table: "Mixes");

            migrationBuilder.RenameColumn(
                name: "DrinkId",
                table: "Mixes",
                newName: "drinkId");

            migrationBuilder.RenameColumn(
                name: "BottleId",
                table: "Mixes",
                newName: "bottleId");

            migrationBuilder.RenameIndex(
                name: "IX_Mixes_DrinkId",
                table: "Mixes",
                newName: "IX_Mixes_drinkId");

            migrationBuilder.RenameIndex(
                name: "IX_Mixes_BottleId",
                table: "Mixes",
                newName: "IX_Mixes_bottleId");

            migrationBuilder.AlterColumn<int>(
                name: "drinkId",
                table: "Mixes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 1, 250.0, 4, 1 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 2, 250.0, 1, 1 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 3, 250.0, 2, 2 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 4, 250.0, 1, 2 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 5, 300.0, 2, 3 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 6, 200.0, 3, 3 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 7, 250.0, 4, 4 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 8, 250.0, 1, 4 });

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Bottles_bottleId",
                table: "Mixes",
                column: "bottleId",
                principalTable: "Bottles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Drinks_drinkId",
                table: "Mixes",
                column: "drinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Bottles_bottleId",
                table: "Mixes");

            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Drinks_drinkId",
                table: "Mixes");

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mixes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "drinkId",
                table: "Mixes",
                newName: "DrinkId");

            migrationBuilder.RenameColumn(
                name: "bottleId",
                table: "Mixes",
                newName: "BottleId");

            migrationBuilder.RenameIndex(
                name: "IX_Mixes_drinkId",
                table: "Mixes",
                newName: "IX_Mixes_DrinkId");

            migrationBuilder.RenameIndex(
                name: "IX_Mixes_bottleId",
                table: "Mixes",
                newName: "IX_Mixes_BottleId");

            migrationBuilder.AlterColumn<int>(
                name: "DrinkId",
                table: "Mixes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Bottles_BottleId",
                table: "Mixes",
                column: "BottleId",
                principalTable: "Bottles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Drinks_DrinkId",
                table: "Mixes",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id");
        }
    }
}
