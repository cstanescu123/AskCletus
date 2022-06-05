using Microsoft.EntityFrameworkCore.Migrations;

namespace AskCletus_BackEnd.Migrations
{
    public partial class DrinkHistoryUpdateRemoval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DrinkName",
                table: "DrinkHistories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrinkName",
                table: "DrinkHistories");
        }
    }
}
