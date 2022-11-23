using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class dtr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DTR_DTRHead_DTRHeadId",
                table: "DTR");

            migrationBuilder.DropTable(
                name: "DTRHead");

            migrationBuilder.DropIndex(
                name: "IX_DTR_DTRHeadId",
                table: "DTR");

            migrationBuilder.DropColumn(
                name: "DTRHeadId",
                table: "DTR");

            migrationBuilder.AddColumn<int>(
                name: "DTRSummaryId",
                table: "DTR",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DTRSummaryId",
                table: "DTR");

            migrationBuilder.AddColumn<int>(
                name: "DTRHeadId",
                table: "DTR",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DTRHead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutoff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cutoffdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTRHead", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DTR_DTRHeadId",
                table: "DTR",
                column: "DTRHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_DTR_DTRHead_DTRHeadId",
                table: "DTR",
                column: "DTRHeadId",
                principalTable: "DTRHead",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
