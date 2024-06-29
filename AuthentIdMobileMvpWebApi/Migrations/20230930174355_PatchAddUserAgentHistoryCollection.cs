using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthentIdMobileMvpWebApi.Migrations
{
    /// <inheritdoc />
    public partial class PatchAddUserAgentHistoryCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "AuthentIdScans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AuthentIdScans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "AuthentIdScans");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AuthentIdScans");
        }
    }
}
