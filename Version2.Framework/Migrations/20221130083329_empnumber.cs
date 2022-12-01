using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class empnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNumber",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeNumber",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
