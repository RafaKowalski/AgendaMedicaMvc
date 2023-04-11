using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaMedicaMvc.Migrations
{
    public partial class AdicionandoatributoCrm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroDeAgenda");

            migrationBuilder.AddColumn<string>(
                name: "Crm",
                table: "Medico",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crm",
                table: "Medico");

            migrationBuilder.CreateTable(
                name: "RegistroDeAgenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AgendaId = table.Column<int>(nullable: false),
                    StatusDaAgenda = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroDeAgenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroDeAgenda_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDeAgenda_AgendaId",
                table: "RegistroDeAgenda",
                column: "AgendaId");
        }
    }
}
