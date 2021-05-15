using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoryDemo.Migrations
{
    public partial class ModifiedInit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PsiShip",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Vk",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "XShip",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "YShip",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ZShip",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PsiShip",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "Vk",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "XShip",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "YShip",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "ZShip",
                table: "Initializations");
        }
    }
}
