using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportiada.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlpineSkiDisciplines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlpineSkiDisciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(maxLength: 4, nullable: false),
                    PicturePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ProfileName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    Foot = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayers", x => x.Id);
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
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Start = table.Column<DateTime>(nullable: true),
                    End = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballCoaches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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
                name: "FootballReferees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
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
                name: "FootballTournamnets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
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
                name: "PlacesAlpineSki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesAlpineSki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacesAlpineSki_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skiers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Club = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    LargePicturePath = table.Column<string>(nullable: true),
                    SmallPicturePath = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skiers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerCountry",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    MainCountry = table.Column<bool>(nullable: false)
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
                name: "FootballPlayerNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
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
                name: "FootballPlayerPicture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    PicturePath = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerPicture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerPicture_FootballPlayers_PlayerId",
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
                    Name = table.Column<string>(nullable: true),
                    PlayerId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
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
                name: "FootballTeams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    History = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballTeams_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
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
                    TypeId = table.Column<int>(nullable: false),
                    TournamentId = table.Column<int>(nullable: false)
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
                name: "CompetitionsAlpineSki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(nullable: false),
                    CompetitionTypeId = table.Column<int>(nullable: false),
                    Track = table.Column<string>(nullable: true),
                    SeasonId = table.Column<int>(nullable: false),
                    TournamentId = table.Column<int>(nullable: false),
                    PlaceAlpineSkiId = table.Column<int>(nullable: false),
                    DisciplineAlpineSkiId = table.Column<int>(nullable: false),
                    FisTechnicalDelegate = table.Column<string>(nullable: true),
                    Referee = table.Column<string>(nullable: true),
                    AssistantRef = table.Column<string>(nullable: true),
                    CompetitionAlpineSkiChief = table.Column<string>(nullable: true),
                    StartRef = table.Column<string>(nullable: true),
                    FinishRef = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionsAlpineSki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompetitionsAlpineSki_CompetitionTypes_CompetitionTypeId",
                        column: x => x.CompetitionTypeId,
                        principalTable: "CompetitionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionsAlpineSki_AlpineSkiDisciplines_DisciplineAlpineSkiId",
                        column: x => x.DisciplineAlpineSkiId,
                        principalTable: "AlpineSkiDisciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionsAlpineSki_PlacesAlpineSki_PlaceAlpineSkiId",
                        column: x => x.PlaceAlpineSkiId,
                        principalTable: "PlacesAlpineSki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionsAlpineSki_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionsAlpineSki_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballStadium",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Opened = table.Column<string>(nullable: true),
                    Architect = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Surface = table.Column<string>(nullable: true),
                    PrevousNames = table.Column<string>(nullable: true),
                    Facts = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: false)
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
                name: "FootballTeamCoaches",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false),
                    CoachId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: true),
                    UntilDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FootballTeamPlayers",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: true),
                    UntilDate = table.Column<DateTime>(nullable: true),
                    OnLoan = table.Column<bool>(nullable: false),
                    TeamSelections = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "FootballRounds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    CompetitionId = table.Column<int>(nullable: false)
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
                name: "ResultsAlpineSki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkierId = table.Column<int>(nullable: false),
                    Stage = table.Column<string>(nullable: true),
                    CompetitionAlpineSkiId = table.Column<int>(nullable: false),
                    TimeFirstManch = table.Column<string>(nullable: true),
                    TimeSecondManch = table.Column<string>(nullable: true),
                    FinalTime = table.Column<string>(nullable: true),
                    Difference = table.Column<string>(nullable: true),
                    Metters = table.Column<string>(nullable: true),
                    Place = table.Column<int>(nullable: false),
                    Bib = table.Column<int>(nullable: false),
                    StartOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultsAlpineSki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultsAlpineSki_CompetitionsAlpineSki_CompetitionAlpineSkiId",
                        column: x => x.CompetitionAlpineSkiId,
                        principalTable: "CompetitionsAlpineSki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultsAlpineSki_Skiers_SkierId",
                        column: x => x.SkierId,
                        principalTable: "Skiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IntermediatesAlpineSki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Place = table.Column<int>(nullable: false),
                    Difference = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    ResultAlpineSkiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntermediatesAlpineSki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntermediatesAlpineSki_ResultsAlpineSki_ResultAlpineSkiId",
                        column: x => x.ResultAlpineSkiId,
                        principalTable: "ResultsAlpineSki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballGameReferees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
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
                        onDelete: ReferentialAction.NoAction);
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
                    TypeId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    LineUpId = table.Column<int>(nullable: false),
                    BallPossession = table.Column<int>(nullable: false),
                    Corners = table.Column<int>(nullable: false),
                    ShotsOnTarget = table.Column<int>(nullable: false),
                    ShotsWide = table.Column<int>(nullable: false),
                    Fouls = table.Column<int>(nullable: false),
                    Offsides = table.Column<int>(nullable: false)
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
                        name: "FK_FootballGameStatistics_FootballTeams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "FootballTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    TypeId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    FirstHalf = table.Column<bool>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false)
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
                    TypeId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    FirstHalf = table.Column<bool>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false),
                    AssistanceId = table.Column<int>(nullable: false)
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
                    PlayerId = table.Column<int>(nullable: false),
                    GameStattisticId = table.Column<int>(nullable: false)
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
                name: "FootballReserves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    GameStattisticId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballReserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballReserves_FootballGameStatistics_GameStattisticId",
                        column: x => x.GameStattisticId,
                        principalTable: "FootballGameStatistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballReserves_FootballPlayers_PlayerId",
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
                    PlayerId = table.Column<int>(nullable: false),
                    ReasonId = table.Column<int>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false)
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
                    PlayerInId = table.Column<int>(nullable: false),
                    PlayerOutId = table.Column<int>(nullable: false),
                    GameStatisticId = table.Column<int>(nullable: false)
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
                    PlayerId = table.Column<int>(nullable: false),
                    GoalId = table.Column<int>(nullable: false)
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerIns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    FirstHalf = table.Column<bool>(nullable: false),
                    SubstituteId = table.Column<int>(nullable: false),
                    InIcon = table.Column<string>(nullable: true)
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
                    PlayerId = table.Column<int>(nullable: false),
                    Minute = table.Column<int>(nullable: false),
                    FirstHalf = table.Column<bool>(nullable: false),
                    SubstituteId = table.Column<int>(nullable: false),
                    OutIcon = table.Column<string>(nullable: true)
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_CompetitionTypeId",
                table: "CompetitionsAlpineSki",
                column: "CompetitionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_DisciplineAlpineSkiId",
                table: "CompetitionsAlpineSki",
                column: "DisciplineAlpineSkiId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_PlaceAlpineSkiId",
                table: "CompetitionsAlpineSki",
                column: "PlaceAlpineSkiId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_SeasonId",
                table: "CompetitionsAlpineSki",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_TournamentId",
                table: "CompetitionsAlpineSki",
                column: "TournamentId");

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
                name: "IX_FootballGameStatistics_TeamId",
                table: "FootballGameStatistics",
                column: "TeamId");

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
                name: "IX_FootballPlayerNumber_PlayerId",
                table: "FootballPlayerNumber",
                column: "PlayerId");

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
                name: "IX_FootballPlayerPicture_PlayerId",
                table: "FootballPlayerPicture",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerTypes_PlayerId",
                table: "FootballPlayerTypes",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballReferees_CountryId",
                table: "FootballReferees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballReserves_GameStattisticId",
                table: "FootballReserves",
                column: "GameStattisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballReserves_PlayerId",
                table: "FootballReserves",
                column: "PlayerId");

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
                name: "IX_FootballStadium_TeamId",
                table: "FootballStadium",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballSubstitutes_GameStatisticId",
                table: "FootballSubstitutes",
                column: "GameStatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTeamCoaches_TeamId",
                table: "FootballTeamCoaches",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTeamPlayers_PlayerId",
                table: "FootballTeamPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTeams_CityId",
                table: "FootballTeams",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballTournamnets_CountryId",
                table: "FootballTournamnets",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_IntermediatesAlpineSki_ResultAlpineSkiId",
                table: "IntermediatesAlpineSki",
                column: "ResultAlpineSkiId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesAlpineSki_CountryId",
                table: "PlacesAlpineSki",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsAlpineSki_CompetitionAlpineSkiId",
                table: "ResultsAlpineSki",
                column: "CompetitionAlpineSkiId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultsAlpineSki_SkierId",
                table: "ResultsAlpineSki",
                column: "SkierId");

            migrationBuilder.CreateIndex(
                name: "IX_Skiers_CountryId",
                table: "Skiers",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "FootballPlayerNumber");

            migrationBuilder.DropTable(
                name: "FootballPlayerOuts");

            migrationBuilder.DropTable(
                name: "FootballPlayerPicture");

            migrationBuilder.DropTable(
                name: "FootballPlayerTypes");

            migrationBuilder.DropTable(
                name: "FootballReserves");

            migrationBuilder.DropTable(
                name: "FootballSidelines");

            migrationBuilder.DropTable(
                name: "FootballStadium");

            migrationBuilder.DropTable(
                name: "FootballTeamCoaches");

            migrationBuilder.DropTable(
                name: "FootballTeamPlayers");

            migrationBuilder.DropTable(
                name: "IntermediatesAlpineSki");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                name: "FootballCoaches");

            migrationBuilder.DropTable(
                name: "ResultsAlpineSki");

            migrationBuilder.DropTable(
                name: "FootballPlayers");

            migrationBuilder.DropTable(
                name: "FootballGoalTypes");

            migrationBuilder.DropTable(
                name: "FootballGameStatistics");

            migrationBuilder.DropTable(
                name: "CompetitionsAlpineSki");

            migrationBuilder.DropTable(
                name: "Skiers");

            migrationBuilder.DropTable(
                name: "FootballGames");

            migrationBuilder.DropTable(
                name: "FootballTeams");

            migrationBuilder.DropTable(
                name: "FootballGameStatisticTypes");

            migrationBuilder.DropTable(
                name: "AlpineSkiDisciplines");

            migrationBuilder.DropTable(
                name: "PlacesAlpineSki");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "FootballRounds");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "FootballCompetitions");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "FootballTournamnets");

            migrationBuilder.DropTable(
                name: "CompetitionTypes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
