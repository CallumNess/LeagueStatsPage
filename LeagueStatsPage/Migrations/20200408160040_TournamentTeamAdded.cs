using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueStatsPage.Migrations
{
    public partial class TournamentTeamAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tourtaments",
                columns: table => new
                {
                    TournamentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TournamentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tourtaments", x => x.TournamentID);
                });

            migrationBuilder.CreateTable(
                name: "TournamentTeams",
                columns: table => new
                {
                    TournamentID = table.Column<int>(nullable: false),
                    TeamsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentTeams", x => new { x.TournamentID, x.TeamsID });
                    table.ForeignKey(
                        name: "FK_TournamentTeams_Teams_TeamsID",
                        column: x => x.TeamsID,
                        principalTable: "Teams",
                        principalColumn: "TeamsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentTeams_Tourtaments_TournamentID",
                        column: x => x.TournamentID,
                        principalTable: "Tourtaments",
                        principalColumn: "TournamentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tourtaments",
                columns: new[] { "TournamentID", "TournamentName" },
                values: new object[,]
                {
                    { 1, "LEC" },
                    { 2, "LCS" },
                    { 3, "Worlds" },
                    { 4, "MSI" },
                    { 5, "LCK" },
                    { 6, "LPL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TournamentTeams_TeamsID",
                table: "TournamentTeams",
                column: "TeamsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TournamentTeams");

            migrationBuilder.DropTable(
                name: "Tourtaments");
        }
    }
}
