using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Eighteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootballGameStatistics_FootballCoaches_CoachId",
                table: "FootballGameStatistics");

            migrationBuilder.DropIndex(
                name: "IX_FootballGameStatistics_CoachId",
                table: "FootballGameStatistics");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "FootballGameStatistics");

            migrationBuilder.DropColumn(
                name: "GameStatisticId",
                table: "FootballCoaches");

            migrationBuilder.CreateTable(
                name: "FootballGameStatisticCoach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoachId = table.Column<int>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGameStatisticCoach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballGameStatisticCoach_FootballCoaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "FootballCoaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballGameStatisticCoach_FootballGameStatistics_GameStatisticId",
                        column: x => x.GameStatisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameStatisticCoach_CoachId",
                table: "FootballGameStatisticCoach",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameStatisticCoach_GameStatisticId",
                table: "FootballGameStatisticCoach",
                column: "GameStatisticId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballGameStatisticCoach");

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "FootballGameStatistics",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameStatisticId",
                table: "FootballCoaches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameStatistics_CoachId",
                table: "FootballGameStatistics",
                column: "CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootballGameStatistics_FootballCoaches_CoachId",
                table: "FootballGameStatistics",
                column: "CoachId",
                principalTable: "FootballCoaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
