using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Eleventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballTeamCoaches");

            migrationBuilder.CreateTable(
                name: "FootballCoachTransfer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoachId = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    TeamId1 = table.Column<int>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    UntilDate = table.Column<DateTime>(nullable: false),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCoachTransfer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballCoachTransfer_FootballCoaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "FootballCoaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCoachTransfer_FootballTeams_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FootballSquadCoaches",
                columns: table => new
                {
                    SquadId = table.Column<int>(nullable: false),
                    CoachId = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSquadCoaches", x => new { x.CoachId, x.SquadId });
                    table.ForeignKey(
                        name: "FK_FootballSquadCoaches_FootballCoaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "FootballCoaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FootballSquadCoaches_FootballSquads_SquadId",
                        column: x => x.SquadId,
                        principalTable: "FootballSquads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoachTransfer_CoachId",
                table: "FootballCoachTransfer",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoachTransfer_TeamId1",
                table: "FootballCoachTransfer",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSquadCoaches_SquadId",
                table: "FootballSquadCoaches",
                column: "SquadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballCoachTransfer");

            migrationBuilder.DropTable(
                name: "FootballSquadCoaches");

            migrationBuilder.CreateTable(
                name: "FootballTeamCoaches",
                columns: table => new
                {
                    CoachId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: true),
                    UntilDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeamCoaches", x => new { x.CoachId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_FootballTeamCoaches_FootballCoaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "FootballCoaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballTeamCoaches_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballTeamCoaches_TeamId",
                table: "FootballTeamCoaches",
                column: "TeamId");
        }
    }
}
