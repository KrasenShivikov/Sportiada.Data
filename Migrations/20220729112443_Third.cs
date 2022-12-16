using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballPlayerNumber");

            migrationBuilder.DropTable(
                name: "FootballPlayerPictures");

            migrationBuilder.DropTable(
                name: "FootballPlayerTypes");

            migrationBuilder.DropTable(
                name: "FootballTeamPlayers");

            migrationBuilder.CreateTable(
                name: "FootballPlayerTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    Season = table.Column<string>(nullable: true),
                    PreviousTeam = table.Column<string>(nullable: true),
                    PreviousTeamLogo = table.Column<string>(nullable: true),
                    PreviousTeamCountryFlag = table.Column<string>(nullable: true),
                    CurrentTeam = table.Column<string>(nullable: true),
                    CurrentTeamLogo = table.Column<string>(nullable: true),
                    CurrentTeamCountryFlag = table.Column<string>(nullable: true),
                    TransferPrice = table.Column<string>(nullable: true),
                    OnLoan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerTransfers_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballSquads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSquads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballSquads_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballSquads_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SquadPlayers",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    SquadId = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    SquadType = table.Column<string>(nullable: true),
                    ContractStartDate = table.Column<string>(nullable: true),
                    ContractEndDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadPlayers", x => new { x.PlayerId, x.SquadId });
                    table.ForeignKey(
                        name: "FK_SquadPlayers_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SquadPlayers_FootballSquads_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballSquads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerTransfers_PlayerId",
                table: "FootballPlayerTransfers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSquads_SeasonId",
                table: "FootballSquads",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSquads_TeamId",
                table: "FootballSquads",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballPlayerTransfers");

            migrationBuilder.DropTable(
                name: "SquadPlayers");

            migrationBuilder.DropTable(
                name: "FootballSquads");

            migrationBuilder.CreateTable(
                name: "FootballPlayerNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerNumber_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerPictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    PicturePath = table.Column<string>(nullable: true),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerPictures_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerTypes_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballTeamPlayers",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: true),
                    OnLoan = table.Column<bool>(nullable: false),
                    TeamSelections = table.Column<string>(nullable: true),
                    UntilDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeamPlayers", x => new { x.TeamId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_FootballTeamPlayers_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballTeamPlayers_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerNumber_PlayerId",
                table: "FootballPlayerNumber",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerPictures_PlayerId",
                table: "FootballPlayerPictures",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerTypes_PlayerId",
                table: "FootballPlayerTypes",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTeamPlayers_PlayerId",
                table: "FootballTeamPlayers",
                column: "PlayerId");
        }
    }
}
