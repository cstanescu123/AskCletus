using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class kyle5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DrinkHistories_UserId",
                table: "DrinkHistories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkHistories_Users_UserId",
                table: "DrinkHistories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkHistories_Users_UserId",
                table: "DrinkHistories");

            migrationBuilder.DropIndex(
                name: "IX_DrinkHistories_UserId",
                table: "DrinkHistories");
        }
    }
}
