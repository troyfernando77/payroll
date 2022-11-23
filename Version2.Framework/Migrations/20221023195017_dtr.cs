using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class dtr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Employees",
                newName: "Rate_Rate");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate_Rate",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "Rate_Category",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Rate_OccassionDate",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rate_OccassionName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate_RateHr",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate_RateOTPct",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate_RatePct",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DTRHead",
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
                    table.PrimaryKey("PK_DTRHead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DTR",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DTRHeadId = table.Column<int>(nullable: true),
                    TimeIn = table.Column<DateTime>(nullable: false),
                    TimeOut = table.Column<DateTime>(nullable: false),
                    TotalHours = table.Column<decimal>(nullable: false),
                    RegularHours = table.Column<decimal>(nullable: false),
                    Rate_Rate = table.Column<decimal>(nullable: true),
                    Rate_RateHr = table.Column<decimal>(nullable: true),
                    Rate_OccassionDate = table.Column<DateTime>(nullable: true),
                    Rate_OccassionName = table.Column<string>(nullable: true),
                    Rate_RatePct = table.Column<decimal>(nullable: true),
                    Rate_RateOTPct = table.Column<decimal>(nullable: true),
                    Rate_Category = table.Column<int>(nullable: true),
                    TotalOT = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    OTAmount = table.Column<decimal>(nullable: false),
                    Deduction = table.Column<decimal>(nullable: false),
                    NetPay = table.Column<decimal>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: true),
                    Reghoursperday = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DTR_DTRHead_DTRHeadId",
                        column: x => x.DTRHeadId,
                        principalTable: "DTRHead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DTR_DTRHeadId",
                table: "DTR",
                column: "DTRHeadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTR");

            migrationBuilder.DropTable(
                name: "DTRHead");

            migrationBuilder.DropColumn(
                name: "Rate_Category",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Rate_OccassionDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Rate_OccassionName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Rate_RateHr",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Rate_RateOTPct",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Rate_RatePct",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Rate_Rate",
                table: "Employees",
                newName: "Rate");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
