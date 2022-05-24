using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class updatedDBKyle3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBars_Users_UserBar",
                table: "UserBars");

            migrationBuilder.DropIndex(
                name: "IX_UserBars_UserBar",
                table: "UserBars");

            migrationBuilder.DropColumn(
                name: "UserBar",
                table: "UserBars");

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

            migrationBuilder.AddColumn<int>(
                name: "UserBar",
                table: "UserBars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserBars_UserBar",
                table: "UserBars",
                column: "UserBar");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBars_Users_UserBar",
                table: "UserBars",
                column: "UserBar",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
