using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class ReTreux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBars");

            migrationBuilder.CreateTable(
                name: "UserIngredient",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIngredient", x => x.IngredientsId);
                    table.ForeignKey(
                        name: "FK_UserIngredient_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserIngredient_UserId",
                table: "UserIngredient",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserIngredient");

            migrationBuilder.CreateTable(
                name: "UserBars",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBars", x => x.IngredientsId);
                    table.ForeignKey(
                        name: "FK_UserBars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBars_UserId",
                table: "UserBars",
                column: "UserId");
        }
    }
}
