using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PentaGol.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_AwayClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_HomeClubId",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "AwayClubScore",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeClubScore",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LeaugeId",
                table: "Matches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LeaugueId",
                table: "Matches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Matches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LeaugueId",
                table: "Matches",
                column: "LeaugueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Clubs_AwayClubId",
                table: "Matches",
                column: "AwayClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Clubs_HomeClubId",
                table: "Matches",
                column: "HomeClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leaugues_LeaugueId",
                table: "Matches",
                column: "LeaugueId",
                principalTable: "Leaugues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_AwayClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_HomeClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leaugues_LeaugueId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_LeaugueId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "AwayClubScore",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HomeClubScore",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "LeaugeId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "LeaugueId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Matches");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Clubs_AwayClubId",
                table: "Matches",
                column: "AwayClubId",
                principalTable: "Clubs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Clubs_HomeClubId",
                table: "Matches",
                column: "HomeClubId",
                principalTable: "Clubs",
                principalColumn: "Id");
        }
    }
}
