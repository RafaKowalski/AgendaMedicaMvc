using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaMedicaMvc.Migrations
{
    public partial class ExcluindoStatusDaAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusDaAgenda",
                table: "Agenda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusDaAgenda",
                table: "Agenda",
                nullable: false,
                defaultValue: 0);
        }
    }
}
