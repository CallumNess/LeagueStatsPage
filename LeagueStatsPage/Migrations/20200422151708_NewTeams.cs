using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueStatsPage.Migrations
{
    public partial class NewTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamsID", "TeamName" },
                values: new object[,]
                {
                    { 11, "100 Thieves" },
                    { 31, "Bilibili Gaming" },
                    { 32, "Dominus Esports" },
                    { 33, "EDward Gaming" },
                    { 34, "eStar" },
                    { 35, "FunPlus Phoenix" },
                    { 36, "Invictus Gaming" },
                    { 37, "JD Gaming" },
                    { 38, "LGD Gaming" },
                    { 39, "LNG Esports" },
                    { 40, "Oh My God" },
                    { 41, "Rogue Warriors" },
                    { 42, "RNG" },
                    { 43, "Suning" },
                    { 44, "Team WE" },
                    { 45, "Top Esports" },
                    { 30, "T1" },
                    { 46, "Vici Gaming" },
                    { 29, "SANDBOX Gaming" },
                    { 27, "Hanwha Life" },
                    { 12, "Cloud 9" },
                    { 13, "CLG" },
                    { 14, "Dignitas" },
                    { 15, "Evil Geniuses" },
                    { 16, "FlyQuest" },
                    { 17, "Golden Guardians" },
                    { 18, "Immortals" },
                    { 19, "Team Liquid" },
                    { 20, "Team SoloMid" },
                    { 21, "Afreeca Freecs" },
                    { 22, "APK Prince" },
                    { 23, "DAMWON Gaming" },
                    { 24, "DragonX" },
                    { 25, "Gen.G" },
                    { 26, "Griffin" },
                    { 28, "KT Rolster" },
                    { 47, "Victory Five" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamsID",
                keyValue: 47);
        }
    }
}
