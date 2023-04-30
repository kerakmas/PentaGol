using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PentaGol.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Leaugues_LeaugueId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_AwayClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_HomeClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leaugues_LeaugueId",
                table: "Matches");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminRole = table.Column<byte>(type: "tinyint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Leaugues_LeaugueId",
                table: "Clubs",
                column: "LeaugueId",
                principalTable: "Leaugues",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                name: "FK_Clubs_Leaugues_LeaugueId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_AwayClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Clubs_HomeClubId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leaugues_LeaugueId",
                table: "Matches");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Leaugues_LeaugueId",
                table: "Clubs",
                column: "LeaugueId",
                principalTable: "Leaugues",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leaugues_LeaugueId",
                table: "Matches",
                column: "LeaugueId",
                principalTable: "Leaugues",
                principalColumn: "Id");
        }
    }
}
