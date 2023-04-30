using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PentaGol.Data.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "MatchDate" },
                values: new object[] { new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "MatchDate" },
                values: new object[] { new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1847), new DateTime(2023, 5, 1, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "MatchDate" },
                values: new object[] { new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1849), new DateTime(2023, 5, 2, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1848) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Leaugues",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "MatchDate" },
                values: new object[] { new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5440), new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "MatchDate" },
                values: new object[] { new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5450), new DateTime(2023, 5, 1, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "MatchDate" },
                values: new object[] { new DateTime(2023, 4, 30, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5451), new DateTime(2023, 5, 2, 5, 58, 49, 541, DateTimeKind.Utc).AddTicks(5450) });
        }
    }
}
