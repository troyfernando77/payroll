using Microsoft.EntityFrameworkCore.Migrations;

namespace Version2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Messages",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MessageCode = table.Column<string>(nullable: true),
            //        Message = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Messages", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Rules",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RuleName = table.Column<string>(nullable: true),
            //        Category = table.Column<string>(nullable: true),
            //        Priority = table.Column<int>(nullable: true),
            //        RuleTarget = table.Column<int>(nullable: true),
            //        Status = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Rules", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Messages");

            //migrationBuilder.DropTable(
            //    name: "Rules");
        }
    }
}
