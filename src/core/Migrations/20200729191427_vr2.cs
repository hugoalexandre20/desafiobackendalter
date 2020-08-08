using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Alterdata.Bimer.Core.Migrations
{
    public partial class vr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Identificador = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomePrincipal = table.Column<string>(maxLength: 30, nullable: true),
                    Sobrenome = table.Column<string>(maxLength: 50, nullable: true),
                    Rua = table.Column<string>(maxLength: 50, nullable: true),
                    NumeroEndereco = table.Column<int>(maxLength: 10, nullable: true),
                    Bairro = table.Column<string>(maxLength: 30, nullable: true),
                    ComplementoEndereco = table.Column<string>(maxLength: 10, nullable: true),
                    Cep = table.Column<string>(maxLength: 10, nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Identificador);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Identificador = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao_Texto = table.Column<string>(nullable: true),
                    ClienteIdentificador = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Numero_NumeroValue = table.Column<int>(nullable: true),
                    Ddd_DddValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Identificador);
                    table.ForeignKey(
                        name: "FK_Contatos_Clientes_ClienteIdentificador",
                        column: x => x.ClienteIdentificador,
                        principalTable: "Clientes",
                        principalColumn: "Identificador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_ClienteIdentificador",
                table: "Contatos",
                column: "ClienteIdentificador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
