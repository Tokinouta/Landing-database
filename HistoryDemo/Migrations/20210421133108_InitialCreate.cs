using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoryDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuidanceConfig = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Initializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InitialPositionX = table.Column<double>(type: "REAL", nullable: false),
                    InitialPositionY = table.Column<double>(type: "REAL", nullable: false),
                    InitialPositionZ = table.Column<double>(type: "REAL", nullable: false),
                    InitialAttitudePhi = table.Column<double>(type: "REAL", nullable: false),
                    InitialAttitudePsi = table.Column<double>(type: "REAL", nullable: false),
                    InitialAttitudeTheta = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Initializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasicInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SimConfigurationId = table.Column<int>(type: "INTEGER", nullable: true),
                    SimInitializationId = table.Column<int>(type: "INTEGER", nullable: true),
                    PathToData = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicInformations_Configurations_SimConfigurationId",
                        column: x => x.SimConfigurationId,
                        principalTable: "Configurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicInformations_Initializations_SimInitializationId",
                        column: x => x.SimInitializationId,
                        principalTable: "Initializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasicInformations_SimConfigurationId",
                table: "BasicInformations",
                column: "SimConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicInformations_SimInitializationId",
                table: "BasicInformations",
                column: "SimInitializationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicInformations");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "Initializations");
        }
    }
}
