using Microsoft.EntityFrameworkCore.Migrations;

namespace Alterdata.Bimer.Core.Migrations
{
    public partial class vr5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ddd_DddValue",
                table: "Contatos",
                newName: "Ddd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ddd",
                table: "Contatos",
                newName: "Ddd_DddValue");
        }
    }
}
