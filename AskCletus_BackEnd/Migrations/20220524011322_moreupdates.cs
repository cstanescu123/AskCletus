using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class moreupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBars_Users_UserId",
                table: "UserBars");

            migrationBuilder.DropIndex(
                name: "IX_UserBars_UserId",
                table: "UserBars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
