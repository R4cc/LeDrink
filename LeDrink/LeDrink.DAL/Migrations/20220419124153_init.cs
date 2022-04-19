using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bottles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BottleSlotId = table.Column<int>(type: "INTEGER", nullable: true),
                    BottleName = table.Column<string>(type: "TEXT", nullable: false),
                    ImgPath = table.Column<string>(type: "TEXT", nullable: true),
                    MaxMl = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentMl = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bottles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DrinkName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ImgPath = table.Column<string>(type: "TEXT", nullable: true),
                    IsFavourite = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    bottleId = table.Column<int>(type: "INTEGER", nullable: true),
                    drinkId = table.Column<int>(type: "INTEGER", nullable: false),
                    Milliliters = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mixes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mixes_Bottles_bottleId",
                        column: x => x.bottleId,
                        principalTable: "Bottles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mixes_Drinks_drinkId",
                        column: x => x.drinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 1, "Coca Cola", 1, 1500, "/images/bottles/CocaCola.png", 1500 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 2, "Fanta", 2, 1500, "/images/bottles/Fanta.png", 1500 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 3, "RedBull", 3, 250, "/images/bottles/RedBull.png", 250 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 4, "Vodka", 4, 700, "/images/bottles/Vodka_white.png", 700 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 5, "Gin", null, 700, "/images/bottles/Gin.png", 700 });

            migrationBuilder.InsertData(
                table: "Bottles",
                columns: new[] { "Id", "BottleName", "BottleSlotId", "CurrentMl", "ImgPath", "MaxMl" },
                values: new object[] { 6, "Orange Juice", null, 1000, "/images/bottles/OrangeJuice.png", 1000 });

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

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite" },
                values: new object[] { 1, "VodkaBull", "/images/drinks/template-cup-test.png", true });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite" },
                values: new object[] { 2, "Spezi", "/images/drinks/template-cup-test.png", true });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite" },
                values: new object[] { 3, "Fantabull", "/images/drinks/template-cup-test.png", false });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "DrinkName", "ImgPath", "IsFavourite" },
                values: new object[] { 4, "VodkaCoke", "/images/drinks/template-cup-test.png", false });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 1, 250, 4, 1 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 2, 200, 1, 1 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 3, 225, 2, 2 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 4, 225, 1, 2 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 5, 250, 2, 3 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 6, 200, 3, 3 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 7, 200, 4, 4 });

            migrationBuilder.InsertData(
                table: "Mixes",
                columns: new[] { "Id", "Milliliters", "bottleId", "drinkId" },
                values: new object[] { 8, 250, 1, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Mixes_bottleId",
                table: "Mixes",
                column: "bottleId");

            migrationBuilder.CreateIndex(
                name: "IX_Mixes_drinkId",
                table: "Mixes",
                column: "drinkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mixes");

            migrationBuilder.DropTable(
                name: "Bottles");

            migrationBuilder.DropTable(
                name: "Drinks");
        }
    }
}
