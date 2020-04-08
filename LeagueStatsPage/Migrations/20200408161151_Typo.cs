using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueStatsPage.Migrations
{
    public partial class Typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TournamentTeams_Tourtaments_TournamentID",
                table: "TournamentTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tourtaments",
                table: "Tourtaments");

            migrationBuilder.RenameTable(
                name: "Tourtaments",
                newName: "Tournaments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments",
                column: "TournamentID");

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentTeams_Tournaments_TournamentID",
                table: "TournamentTeams",
                column: "TournamentID",
                principalTable: "Tournaments",
                principalColumn: "TournamentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TournamentTeams_Tournaments_TournamentID",
                table: "TournamentTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments");

            migrationBuilder.RenameTable(
                name: "Tournaments",
                newName: "Tourtaments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tourtaments",
                table: "Tourtaments",
                column: "TournamentID");

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentTeams_Tourtaments_TournamentID",
                table: "TournamentTeams",
                column: "TournamentID",
                principalTable: "Tourtaments",
                principalColumn: "TournamentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
