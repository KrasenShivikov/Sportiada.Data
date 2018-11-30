using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Thirteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballCardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCardTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballCoaches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCoaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballCoaches_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGameStatisticTypes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGameStatisticTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FootballGoalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGoalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballReferees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballReferees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballReferees_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballRefereeType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballRefereeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballSidelineReasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSidelineReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballTournamnets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTournamnets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballTournamnets_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(nullable: false),
                    History = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    StadiumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballTeams_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerCountry",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerCountry", x => new { x.PlayerId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_FootballPlayerCountry_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayerCountry_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballCompetitions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonId = table.Column<int>(nullable: false),
                    TournamentId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCompetitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballCompetitions_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCompetitions_FootballTournamnets_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "FootballTournamnets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCompetitions_CompetitionTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CompetitionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballSides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballSides_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballSides_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballStadium",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adress = table.Column<string>(nullable: true),
                    Architect = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Facts = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Opened = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PrevousNames = table.Column<string>(nullable: true),
                    Surface = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: false),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballStadium", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballStadium_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballRounds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompetitionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballRounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballRounds_FootballCompetitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "FootballCompetitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballCaochSides",
                columns: table => new
                {
                    CoachId = table.Column<int>(nullable: false),
                    SideId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: true),
                    UntilDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCaochSides", x => new { x.CoachId, x.SideId });
                    table.ForeignKey(
                        name: "FK_FootballCaochSides_FootballCoaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "FootballCoaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FootballCaochSides_FootballSides_SideId",
                        column: x => x.SideId,
                        principalTable: "FootballSides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerSides",
                columns: table => new
                {
                    SideId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: true),
                    PlayerNumber = table.Column<int>(nullable: false),
                    PlayerPicture = table.Column<string>(nullable: true),
                    UntilDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerSides", x => new { x.SideId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_FootballPlayerSides_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayerSides_FootballSides_SideId",
                        column: x => x.SideId,
                        principalTable: "FootballSides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attendance = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    RoundId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballGames_FootballRounds_RoundId",
                        column: x => x.RoundId,
                        principalTable: "FootballRounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGameReferees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: false),
                    RefereeId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGameReferees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballGameReferees_FootballGames_GameId",
                        column: x => x.GameId,
                        principalTable: "FootballGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballGameReferees_FootballReferees_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "FootballReferees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FootballGameReferees_FootballRefereeType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FootballRefereeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGameStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BallPossession = table.Column<int>(nullable: false),
                    Corners = table.Column<int>(nullable: false),
                    Fouls = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    LineUpId = table.Column<int>(nullable: false),
                    Offsides = table.Column<int>(nullable: false),
                    ShotsOnTarget = table.Column<int>(nullable: false),
                    ShotsWide = table.Column<int>(nullable: false),
                    SideId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGameStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballGameStatistics_FootballGames_GameId",
                        column: x => x.GameId,
                        principalTable: "FootballGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballGameStatistics_FootballSides_SideId",
                        column: x => x.SideId,
                        principalTable: "FootballSides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FootballGameStatistics_FootballGameStatisticTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FootballGameStatisticTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstHalf = table.Column<bool>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballCards_FootballGameStatistics_GameStatisticId",
                        column: x => x.GameStatisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCards_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCards_FootballCardTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FootballCardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGoals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssistanceId = table.Column<int>(nullable: false),
                    FirstHalf = table.Column<bool>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballGoals_FootballGameStatistics_GameStatisticId",
                        column: x => x.GameStatisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballGoals_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballGoals_FootballGoalTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FootballGoalTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballLineUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameStattisticId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballLineUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballLineUps_FootballGameStatistics_GameStattisticId",
                        column: x => x.GameStattisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballLineUps_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballSidelines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameStatisticId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    ReasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSidelines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballSidelines_FootballGameStatistics_GameStatisticId",
                        column: x => x.GameStatisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballSidelines_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballSidelines_FootballSidelineReasons_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "FootballSidelineReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballSubstitutes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameStatisticId = table.Column<int>(nullable: false),
                    PlayerInId = table.Column<int>(nullable: false),
                    PlayerOutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballSubstitutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballSubstitutes_FootballGameStatistics_GameStatisticId",
                        column: x => x.GameStatisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGoalAssistances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GoalId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballGoalAssistances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballGoalAssistances_FootballGoals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "FootballGoals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballGoalAssistances_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerIns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstHalf = table.Column<bool>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    SubstituteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerIns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerIns_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayerIns_FootballSubstitutes_SubstituteId",
                        column: x => x.SubstituteId,
                        principalTable: "FootballSubstitutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerOuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstHalf = table.Column<bool>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    SubstituteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerOuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerOuts_FootballPlayers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayerOuts_FootballSubstitutes_SubstituteId",
                        column: x => x.SubstituteId,
                        principalTable: "FootballSubstitutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCaochSides_SideId",
                table: "FootballCaochSides",
                column: "SideId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCards_GameStatisticId",
                table: "FootballCards",
                column: "GameStatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCards_PlayerId",
                table: "FootballCards",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCards_TypeId",
                table: "FootballCards",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCoaches_CountryId",
                table: "FootballCoaches",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCompetitions_SeasonId",
                table: "FootballCompetitions",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCompetitions_TournamentId",
                table: "FootballCompetitions",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCompetitions_TypeId",
                table: "FootballCompetitions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameReferees_GameId",
                table: "FootballGameReferees",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameReferees_RefereeId",
                table: "FootballGameReferees",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameReferees_TypeId",
                table: "FootballGameReferees",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGames_RoundId",
                table: "FootballGames",
                column: "RoundId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameStatistics_GameId",
                table: "FootballGameStatistics",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameStatistics_SideId",
                table: "FootballGameStatistics",
                column: "SideId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGameStatistics_TypeId",
                table: "FootballGameStatistics",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGoalAssistances_GoalId",
                table: "FootballGoalAssistances",
                column: "GoalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballGoalAssistances_PlayerId",
                table: "FootballGoalAssistances",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGoals_GameStatisticId",
                table: "FootballGoals",
                column: "GameStatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGoals_PlayerId",
                table: "FootballGoals",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballGoals_TypeId",
                table: "FootballGoals",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballLineUps_GameStattisticId",
                table: "FootballLineUps",
                column: "GameStattisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballLineUps_PlayerId",
                table: "FootballLineUps",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerCountry_CountryId",
                table: "FootballPlayerCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerIns_PlayerId",
                table: "FootballPlayerIns",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerIns_SubstituteId",
                table: "FootballPlayerIns",
                column: "SubstituteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerOuts_PlayerId",
                table: "FootballPlayerOuts",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerOuts_SubstituteId",
                table: "FootballPlayerOuts",
                column: "SubstituteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerSides_PlayerId",
                table: "FootballPlayerSides",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballReferees_CountryId",
                table: "FootballReferees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballRounds_CompetitionId",
                table: "FootballRounds",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSidelines_GameStatisticId",
                table: "FootballSidelines",
                column: "GameStatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSidelines_PlayerId",
                table: "FootballSidelines",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSidelines_ReasonId",
                table: "FootballSidelines",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSides_SeasonId",
                table: "FootballSides",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSides_TeamId",
                table: "FootballSides",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballStadium_TeamId",
                table: "FootballStadium",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSubstitutes_GameStatisticId",
                table: "FootballSubstitutes",
                column: "GameStatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTeams_CityId",
                table: "FootballTeams",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTournamnets_CountryId",
                table: "FootballTournamnets",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballCaochSides");

            migrationBuilder.DropTable(
                name: "FootballCards");

            migrationBuilder.DropTable(
                name: "FootballGameReferees");

            migrationBuilder.DropTable(
                name: "FootballGoalAssistances");

            migrationBuilder.DropTable(
                name: "FootballLineUps");

            migrationBuilder.DropTable(
                name: "FootballPlayerCountry");

            migrationBuilder.DropTable(
                name: "FootballPlayerIns");

            migrationBuilder.DropTable(
                name: "FootballPlayerOuts");

            migrationBuilder.DropTable(
                name: "FootballPlayerSides");

            migrationBuilder.DropTable(
                name: "FootballSidelines");

            migrationBuilder.DropTable(
                name: "FootballStadium");

            migrationBuilder.DropTable(
                name: "FootballCoaches");

            migrationBuilder.DropTable(
                name: "FootballCardTypes");

            migrationBuilder.DropTable(
                name: "FootballReferees");

            migrationBuilder.DropTable(
                name: "FootballRefereeType");

            migrationBuilder.DropTable(
                name: "FootballGoals");

            migrationBuilder.DropTable(
                name: "FootballSubstitutes");

            migrationBuilder.DropTable(
                name: "FootballSidelineReasons");

            migrationBuilder.DropTable(
                name: "FootballPlayers");

            migrationBuilder.DropTable(
                name: "FootballGoalTypes");

            migrationBuilder.DropTable(
                name: "FootballGameStatistics");

            migrationBuilder.DropTable(
                name: "FootballGames");

            migrationBuilder.DropTable(
                name: "FootballSides");

            migrationBuilder.DropTable(
                name: "FootballGameStatisticTypes");

            migrationBuilder.DropTable(
                name: "FootballRounds");

            migrationBuilder.DropTable(
                name: "FootballTeams");

            migrationBuilder.DropTable(
                name: "FootballCompetitions");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "FootballTournamnets");
        }
    }
}
