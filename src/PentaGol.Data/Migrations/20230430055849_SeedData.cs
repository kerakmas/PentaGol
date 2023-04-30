using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PentaGol.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaugeId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "LeaugeId",
                table: "Clubs");

            migrationBuilder.InsertData(
                table: "Leaugues",
                columns: new[] { "Id", "CreatedOn", "ImgPath", "IsDeleted", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5293), "https://s.scr365.net/s1/logo/22_221_7/v5wl5i_200_15.png", false, "Italia.Seria a", null },
                    { 2L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5295), "https://b.fssta.com/uploads/application/soccer/competition-logos/EnglishPremierLeague.png", false, "Premier Liga", null },
                    { 3L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5296), "https://iscreativestudio.com/wp-content/uploads/2016/08/logotipos4.jpg", false, "LaLiga", null },
                    { 4L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5297), "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Bundesliga_logo_%282017%29.svg/1200px-Bundesliga_logo_%282017%29.svg.png", false, "BundesLiga", null },
                    { 5L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5298), "https://upload.wikimedia.org/wikipedia/commons/4/49/Ligue1_Uber_Eats_logo.png", false, "Ligue", null }
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CreatedOn", "ImgPath", "IsDeleted", "LeaugueId", "Name", "TotalGamesPlayed", "TotalScoredGoals", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5417), "https://example.com/juventus.png", false, 1L, "Juventus", 0, 0, null },
                    { 2L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5419), "https://example.com/acmilan.png", false, 1L, "AC Milan", 0, 0, null },
                    { 3L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5420), "https://example.com/realmadrid.png", false, 3L, "Real Madrid", 0, 0, null },
                    { 4L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5420), "https://example.com/barcelona.png", false, 3L, "Barcelona", 0, 0, null },
                    { 5L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5421), "https://example.com/bayernmunich.png", false, 4L, "Bayern Munich", 0, 0, null },
                    { 6L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5422), "https://example.com/psg.png", false, 5L, "Paris Saint-Germain", 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayClubId", "AwayClubScore", "CreatedOn", "HomeClubId", "HomeClubScore", "IsDeleted", "LeaugueId", "MatchDate", "Status", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, 2L, 0, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5440), 1L, 0, false, 1L, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5438), false, null },
                    { 2L, 4L, 0, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5450), 3L, 0, false, 3L, new DateTime(2023, 5, 1, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5440), false, null },
                    { 3L, 6L, 0, new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5451), 5L, 0, false, 4L, new DateTime(2023, 5, 2, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5450), false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.AddColumn<long>(
                name: "LeaugeId",
                table: "Matches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LeaugeId",
                table: "Clubs",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
