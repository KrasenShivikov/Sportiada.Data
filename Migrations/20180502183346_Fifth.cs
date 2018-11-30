using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Sportiada.Data.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "CompetitionsAlpineSki");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionTypeId",
                table: "CompetitionsAlpineSki",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionsAlpineSki_CompetitionTypeId",
                table: "CompetitionsAlpineSki",
                column: "CompetitionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionsAlpineSki_CompetitionTypes_CompetitionTypeId",
                table: "CompetitionsAlpineSki",
                column: "CompetitionTypeId",
                principalTable: "CompetitionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionsAlpineSki_CompetitionTypes_CompetitionTypeId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropTable(
                name: "CompetitionTypes");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionsAlpineSki_CompetitionTypeId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.DropColumn(
                name: "CompetitionTypeId",
                table: "CompetitionsAlpineSki");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "CompetitionsAlpineSki",
                nullable: true);
        }
    }
}
