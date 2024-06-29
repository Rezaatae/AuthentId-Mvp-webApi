using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthentIdMobileMvpWebApi.Migrations
{
    /// <inheritdoc />
    public partial class SecondaryPatchMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthentIdScan_AuthentIdAgents_AuthentIdAgentId",
                table: "AuthentIdScan");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthentIdScan_AuthentIdUser_AuthentIdUserId",
                table: "AuthentIdScan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthentIdUser",
                table: "AuthentIdUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthentIdScan",
                table: "AuthentIdScan");

            migrationBuilder.RenameTable(
                name: "AuthentIdUser",
                newName: "AuthentIdUsers");

            migrationBuilder.RenameTable(
                name: "AuthentIdScan",
                newName: "AuthentIdScans");

            migrationBuilder.RenameIndex(
                name: "IX_AuthentIdScan_AuthentIdUserId",
                table: "AuthentIdScans",
                newName: "IX_AuthentIdScans_AuthentIdUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthentIdScan_AuthentIdAgentId",
                table: "AuthentIdScans",
                newName: "IX_AuthentIdScans_AuthentIdAgentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthentIdUsers",
                table: "AuthentIdUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthentIdScans",
                table: "AuthentIdScans",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthentIdScans_AuthentIdAgents_AuthentIdAgentId",
                table: "AuthentIdScans");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthentIdScans_AuthentIdUsers_AuthentIdUserId",
                table: "AuthentIdScans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthentIdUsers",
                table: "AuthentIdUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthentIdScans",
                table: "AuthentIdScans");

            migrationBuilder.RenameTable(
                name: "AuthentIdUsers",
                newName: "AuthentIdUser");

            migrationBuilder.RenameTable(
                name: "AuthentIdScans",
                newName: "AuthentIdScan");

            migrationBuilder.RenameIndex(
                name: "IX_AuthentIdScans_AuthentIdUserId",
                table: "AuthentIdScan",
                newName: "IX_AuthentIdScan_AuthentIdUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthentIdScans_AuthentIdAgentId",
                table: "AuthentIdScan",
                newName: "IX_AuthentIdScan_AuthentIdAgentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthentIdUser",
                table: "AuthentIdUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthentIdScan",
                table: "AuthentIdScan",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthentIdScan_AuthentIdAgents_AuthentIdAgentId",
                table: "AuthentIdScan",
                column: "AuthentIdAgentId",
                principalTable: "AuthentIdAgents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthentIdScan_AuthentIdUser_AuthentIdUserId",
                table: "AuthentIdScan",
                column: "AuthentIdUserId",
                principalTable: "AuthentIdUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
