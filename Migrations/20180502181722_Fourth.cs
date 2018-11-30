using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Season",
                table: "CompetitionsAlpineSki");

            migrationBuilder.AddColumn<int>(
                name: "SeasonId",
                table: "CompetitionsAlpineSki",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_SeasonId",
                table: "CompetitionsAlpineSki",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsAlpineSki_Seasons_SeasonId",
                table: "CompetitionsAlpineSki",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsAlpineSki_Seasons_SeasonId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionsAlpineSki_SeasonId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropColumn(
                name: "SeasonId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.AddColumn<string>(
                name: "Season",
                table: "CompetitionsAlpineSki",
                nullable: true);
        }
    }
}
