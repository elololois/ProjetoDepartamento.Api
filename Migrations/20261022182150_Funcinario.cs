using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoDepartamento.Api.Migrations
{
    /// <inheritdoc />
    public partial class Funcinario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Salario",
                table: "Funcionarios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CodigoDeAcesso",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CodigoDeAcesso",
                table: "Departamentos");
        }
    }
}
