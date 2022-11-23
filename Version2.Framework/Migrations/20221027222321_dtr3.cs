using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class dtr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DTRHeadId",
                table: "DTR",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DTRHeads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Startdate = table.Column<DateTime>(nullable: false),
                    Cutoffdate = table.Column<DateTime>(nullable: false),
                    Cutoff = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTRHeads", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DTR_DTRHeadId",
                table: "DTR",
                column: "DTRHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_DTR_DTRHeads_DTRHeadId",
                table: "DTR",
                column: "DTRHeadId",
                principalTable: "DTRHeads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DTR_DTRHeads_DTRHeadId",
                table: "DTR");

            migrationBuilder.DropTable(
                name: "DTRHeads");

            migrationBuilder.DropIndex(
                name: "IX_DTR_DTRHeadId",
                table: "DTR");

            migrationBuilder.DropColumn(
                name: "DTRHeadId",
                table: "DTR");
        }
    }
}
