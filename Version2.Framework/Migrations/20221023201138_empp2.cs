using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class empp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Employees",
                newName: "Rate_Rate");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate_Rate",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "Rate_Category",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Rate_OccassionDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rate_OccassionName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate_RateHr",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate_RateOTPct",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate_RatePct",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
