using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class carsonfirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strIngredient1",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient10",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient11",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient12",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient13",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient14",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient15",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient16",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient17",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient18",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient19",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient2",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient20",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient21",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient22",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient23",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient24",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient25",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient3",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient4",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient5",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient6",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient7",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "strIngredient8",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "DrinkName",
                table: "DrinkHistories");

            migrationBuilder.RenameColumn(
                name: "strIngredient9",
                table: "UserBars",
                newName: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "BarId",
                table: "UserBars",
                newName: "IngredientsId");

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DrinkId",
                table: "DrinkHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserBars_UserId",
                table: "UserBars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBars_Users_UserId",
                table: "UserBars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBars_Users_UserId",
                table: "UserBars");

            migrationBuilder.DropIndex(
                name: "IX_UserBars_UserId",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "DrinkHistories");

            migrationBuilder.RenameColumn(
                name: "Ingredients",
                table: "UserBars",
                newName: "strIngredient9");

            migrationBuilder.RenameColumn(
                name: "IngredientsId",
                table: "UserBars",
                newName: "BarId");

            migrationBuilder.AddColumn<string>(
                name: "strIngredient1",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient10",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient11",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient12",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient13",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient14",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient15",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient16",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient17",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient18",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient19",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient2",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient20",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient21",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient22",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient23",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient24",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient25",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient3",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient4",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient5",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient6",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient7",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strIngredient8",
                table: "UserBars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrinkName",
                table: "DrinkHistories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
