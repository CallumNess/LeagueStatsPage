using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueStatsPage.Migrations
{
    public partial class SeasonsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonTitle = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsCancelled = table.Column<bool>(nullable: false),
                    TournamentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonID);
                    table.ForeignKey(
                        name: "FK_Seasons_Tournaments_TournamentID",
                        column: x => x.TournamentID,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    FixtureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeTeamID = table.Column<int>(nullable: false),
                    AwayTeamID = table.Column<int>(nullable: false),
                    HomeTeamResult = table.Column<int>(nullable: false),
                    AwayTeamResult = table.Column<int>(nullable: false),
                    GameDate = table.Column<DateTime>(nullable: false),
                    SeasonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.FixtureID);
                    table.ForeignKey(
                        name: "FK_Fixtures_Teams_AwayTeamID",
                        column: x => x.AwayTeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamsID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Fixtures_Teams_HomeTeamID",
                        column: x => x.HomeTeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamsID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Fixtures_Seasons_SeasonID",
                        column: x => x.SeasonID,
                        principalTable: "Seasons",
                        principalColumn: "SeasonID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_AwayTeamID",
                table: "Fixtures",
                column: "AwayTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_HomeTeamID",
                table: "Fixtures",
                column: "HomeTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_SeasonID",
                table: "Fixtures",
                column: "SeasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_TournamentID",
                table: "Seasons",
                column: "TournamentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixtures");

            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}
