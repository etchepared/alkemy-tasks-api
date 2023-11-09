using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace david_etchepare.Migrations
{
    public partial class Version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    tarea_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarea_title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    tarea_description = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    tarea_isCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.tarea_id);
                });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "tarea_id", "tarea_isCompleted", "tarea_description", "tarea_title" },
                values: new object[] { 1, false, "Detalles de Tarea1", "Tarea1" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "tarea_id", "tarea_isCompleted", "tarea_description", "tarea_title" },
                values: new object[] { 2, false, "Detalles de Tarea2", "Tarea2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
