using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class empledger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeLedgerHds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Medicines_Amount = table.Column<decimal>(nullable: true),
                    Medicines_Availed = table.Column<decimal>(nullable: true),
                    Medicines_Balance = table.Column<decimal>(nullable: true),
                    ConsultationLabDiagnostic_Amount = table.Column<decimal>(nullable: true),
                    ConsultationLabDiagnostic_Availed = table.Column<decimal>(nullable: true),
                    ConsultationLabDiagnostic_Balance = table.Column<decimal>(nullable: true),
                    Hospitalization_Amount = table.Column<decimal>(nullable: true),
                    Hospitalization_Availed = table.Column<decimal>(nullable: true),
                    Hospitalization_Balance = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLedgerHds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLedgerHds");
        }
    }
}
