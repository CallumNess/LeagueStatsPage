using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueStatsPage.Migrations
{
    public partial class SeasonsDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonID", "EndDate", "IsCancelled", "SeasonTitle", "StartDate", "TournamentID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spring Split", new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Summer Split", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spring Split", new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Summer Split", new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, new DateTime(2020, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spring Split", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Summer Split", new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Spring Split", new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 8, new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Summer Split", new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonID",
                keyValue: 8);
        }
    }
}
