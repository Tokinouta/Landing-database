using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoryDemo.Migrations
{
    public partial class NewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuidanceConfig",
                table: "Configurations",
                newName: "UseL1Adaptive");

            migrationBuilder.AddColumn<int>(
                name: "AngularRateController",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttitudeController",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttitudeFilter",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisturbanceObserver",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GuidanceController",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GuidanceFilter",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeckCompensationEnabled",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsWindEnabled",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TrajactoryConfig",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "UseAttitudeTrackingDifferentiator",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UseDisturbanceTypeI",
                table: "Configurations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AngularRateController",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "AttitudeController",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "AttitudeFilter",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "DisturbanceObserver",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "GuidanceController",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "GuidanceFilter",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "IsDeckCompensationEnabled",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "IsWindEnabled",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "TrajactoryConfig",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "UseAttitudeTrackingDifferentiator",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "UseDisturbanceTypeI",
                table: "Configurations");

            migrationBuilder.RenameColumn(
                name: "UseL1Adaptive",
                table: "Configurations",
                newName: "GuidanceConfig");
        }
    }
}
