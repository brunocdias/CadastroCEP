using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroCEP.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Sexo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Cep = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Endereco = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Numero = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Complemento = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Bairro = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Estado = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Cidade = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
