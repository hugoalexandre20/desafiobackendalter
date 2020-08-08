using Microsoft.EntityFrameworkCore.Migrations;

namespace Alterdata.Bimer.Core.Migrations
{
    public partial class ve6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numero_NumeroValue",
                table: "Contatos",
                newName: "NumeroTelefone");

            migrationBuilder.RenameColumn(
                name: "EnderecoEmail_EnderecoEmailValue",
                table: "Contatos",
                newName: "EnderecoEmail");

            migrationBuilder.RenameColumn(
                name: "Descricao_Texto",
                table: "Contatos",
                newName: "Descricao");

            migrationBuilder.AlterColumn<string>(
                name: "EnderecoEmail",
                table: "Contatos",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Contatos",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroTelefone",
                table: "Contatos",
                newName: "Numero_NumeroValue");

            migrationBuilder.RenameColumn(
                name: "EnderecoEmail",
                table: "Contatos",
                newName: "EnderecoEmail_EnderecoEmailValue");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Contatos",
                newName: "Descricao_Texto");

            migrationBuilder.AlterColumn<string>(
                name: "EnderecoEmail_EnderecoEmailValue",
                table: "Contatos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao_Texto",
                table: "Contatos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
