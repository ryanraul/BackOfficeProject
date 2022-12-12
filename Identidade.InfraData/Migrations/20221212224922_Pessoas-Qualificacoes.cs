using Microsoft.EntityFrameworkCore.Migrations;

namespace Identidade.InfraData.Migrations
{
    public partial class PessoasQualificacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qualificacao",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualificacao",
                table: "Pessoas");
        }
    }
}
