using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoryDemo.Migrations
{
    public partial class ModifiedInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InitialPositionZ",
                table: "Initializations",
                newName: "Z");

            migrationBuilder.RenameColumn(
                name: "InitialPositionY",
                table: "Initializations",
                newName: "Y");

            migrationBuilder.RenameColumn(
                name: "InitialPositionX",
                table: "Initializations",
                newName: "X");

            migrationBuilder.RenameColumn(
                name: "InitialAttitudeTheta",
                table: "Initializations",
                newName: "Theta");

            migrationBuilder.RenameColumn(
                name: "InitialAttitudePsi",
                table: "Initializations",
                newName: "R");

            migrationBuilder.RenameColumn(
                name: "InitialAttitudePhi",
                table: "Initializations",
                newName: "Q");

            migrationBuilder.AddColumn<double>(
                name: "Alpha",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "P",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Phi",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Psi",
                table: "Initializations",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alpha",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "P",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "Phi",
                table: "Initializations");

            migrationBuilder.DropColumn(
                name: "Psi",
                table: "Initializations");

            migrationBuilder.RenameColumn(
                name: "Z",
                table: "Initializations",
                newName: "InitialPositionZ");

            migrationBuilder.RenameColumn(
                name: "Y",
                table: "Initializations",
                newName: "InitialPositionY");

            migrationBuilder.RenameColumn(
                name: "X",
                table: "Initializations",
                newName: "InitialPositionX");

            migrationBuilder.RenameColumn(
                name: "Theta",
                table: "Initializations",
                newName: "InitialAttitudeTheta");

            migrationBuilder.RenameColumn(
                name: "R",
                table: "Initializations",
                newName: "InitialAttitudePsi");

            migrationBuilder.RenameColumn(
                name: "Q",
                table: "Initializations",
                newName: "InitialAttitudePhi");
        }
    }
}
