using Microsoft.EntityFrameworkCore.Migrations;

namespace Alterdata.Bimer.Core.Migrations
{
    public partial class vr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnderecoEmail_EnderecoEmailValue",
                table: "Contatos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoEmail_EnderecoEmailValue",
                table: "Contatos");
        }
    }
}
