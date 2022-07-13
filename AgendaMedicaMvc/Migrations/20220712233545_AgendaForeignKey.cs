using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaMedicaMvc.Migrations
{
    public partial class AgendaForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Agenda",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Agenda",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Agenda");
        }
    }
}
