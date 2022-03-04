using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeDrink.DAL.Migrations
{
    public partial class AddBottletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BottleName",
                table: "Mixes");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Drinks",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Drinks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Bottles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BottleSlotId = table.Column<int>(type: "INTEGER", nullable: false),
                    BottleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bottles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mixes_BottleId",
                table: "Mixes",
                column: "BottleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mixes_Bottles_BottleId",
                table: "Mixes",
                column: "BottleId",
                principalTable: "Bottles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mixes_Bottles_BottleId",
                table: "Mixes");

            migrationBuilder.DropTable(
                name: "Bottles");

            migrationBuilder.DropIndex(
                name: "IX_Mixes_BottleId",
                table: "Mixes");

            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Drinks");

            migrationBuilder.AddColumn<string>(
                name: "BottleName",
                table: "Mixes",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Drinks",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
