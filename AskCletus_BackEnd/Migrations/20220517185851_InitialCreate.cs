using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrinkHistories",
                columns: table => new
                {
                    HistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrinkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkHistories", x => x.HistoryId);
                });

            migrationBuilder.CreateTable(
                name: "UserBars",
                columns: table => new
                {
                    BarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strIngredient1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strIngredient25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBars", x => x.BarId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkHistories");

            migrationBuilder.DropTable(
                name: "UserBars");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
