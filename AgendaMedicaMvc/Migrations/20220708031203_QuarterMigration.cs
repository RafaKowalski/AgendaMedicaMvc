using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaMedicaMvc.Migrations
{
    public partial class QuarterMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Medico_MedicoId",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Paciente_PacienteId",
                table: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_MedicoId",
                table: "Agenda");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_PacienteId",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Agenda");

            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Medico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_AgendaId",
                table: "Paciente",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_AgendaId",
                table: "Medico",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_Agenda_AgendaId",
                table: "Medico",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Agenda_AgendaId",
                table: "Paciente",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medico_Agenda_AgendaId",
                table: "Medico");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Agenda_AgendaId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_AgendaId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Medico_AgendaId",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Medico");

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

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_MedicoId",
                table: "Agenda",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PacienteId",
                table: "Agenda",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Medico_MedicoId",
                table: "Agenda",
                column: "MedicoId",
                principalTable: "Medico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Paciente_PacienteId",
                table: "Agenda",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
