using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthentIdMobileMvpWebApi.Migrations
{
    /// <inheritdoc />
    public partial class PatchRemoveUserAgentHistoryCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthentIdScans_AuthentIdAgents_AuthentIdAgentId",
                table: "AuthentIdScans");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthentIdScans_AuthentIdUsers_AuthentIdUserId",
                table: "AuthentIdScans");

            migrationBuilder.DropIndex(
                name: "IX_AuthentIdScans_AuthentIdAgentId",
                table: "AuthentIdScans");

            migrationBuilder.DropIndex(
                name: "IX_AuthentIdScans_AuthentIdUserId",
                table: "AuthentIdScans");

            migrationBuilder.DropColumn(
                name: "AuthentIdAgentId",
                table: "AuthentIdScans");

            migrationBuilder.DropColumn(
                name: "AuthentIdUserId",
                table: "AuthentIdScans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthentIdAgentId",
                table: "AuthentIdScans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthentIdUserId",
                table: "AuthentIdScans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AuthentIdScans_AuthentIdAgentId",
                table: "AuthentIdScans",
                column: "AuthentIdAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthentIdScans_AuthentIdUserId",
                table: "AuthentIdScans",
                column: "AuthentIdUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthentIdScans_AuthentIdAgents_AuthentIdAgentId",
                table: "AuthentIdScans",
                column: "AuthentIdAgentId",
                principalTable: "AuthentIdAgents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthentIdScans_AuthentIdUsers_AuthentIdUserId",
                table: "AuthentIdScans",
                column: "AuthentIdUserId",
                principalTable: "AuthentIdUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
