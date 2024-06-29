using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthentIdMobileMvpWebApi.Migrations
{
    /// <inheritdoc />
    public partial class SecondaryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseStation",
                table: "AuthentIdAgents");

            migrationBuilder.DropColumn(
                name: "Constabulary",
                table: "AuthentIdAgents");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "AuthentIdAgents");

            migrationBuilder.RenameColumn(
                name: "SuperiorOfficer",
                table: "AuthentIdAgents",
                newName: "Sector");

            migrationBuilder.RenameColumn(
                name: "Rank",
                table: "AuthentIdAgents",
                newName: "PositionHeld");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "AuthentIdAgents",
                newName: "PhotoUrl");

            migrationBuilder.RenameColumn(
                name: "AgentID",
                table: "AuthentIdAgents",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "AuthentIdUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthentIdUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthentIdScan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ScanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScanLatitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScanLongitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuthentIdUserId = table.Column<int>(type: "int", nullable: false),
                    AuthentIdAgentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthentIdScan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthentIdScan_AuthentIdAgents_AuthentIdAgentId",
                        column: x => x.AuthentIdAgentId,
                        principalTable: "AuthentIdAgents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthentIdScan_AuthentIdUser_AuthentIdUserId",
                        column: x => x.AuthentIdUserId,
                        principalTable: "AuthentIdUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthentIdScan_AuthentIdAgentId",
                table: "AuthentIdScan",
                column: "AuthentIdAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthentIdScan_AuthentIdUserId",
                table: "AuthentIdScan",
                column: "AuthentIdUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthentIdScan");

            migrationBuilder.DropTable(
                name: "AuthentIdUser");

            migrationBuilder.RenameColumn(
                name: "Sector",
                table: "AuthentIdAgents",
                newName: "SuperiorOfficer");

            migrationBuilder.RenameColumn(
                name: "PositionHeld",
                table: "AuthentIdAgents",
                newName: "Rank");

            migrationBuilder.RenameColumn(
                name: "PhotoUrl",
                table: "AuthentIdAgents",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AuthentIdAgents",
                newName: "AgentID");

            migrationBuilder.AddColumn<string>(
                name: "BaseStation",
                table: "AuthentIdAgents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Constabulary",
                table: "AuthentIdAgents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdNumber",
                table: "AuthentIdAgents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
