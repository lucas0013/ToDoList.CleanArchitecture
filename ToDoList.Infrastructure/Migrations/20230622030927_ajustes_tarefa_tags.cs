using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ajustes_tarefa_tags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Tarefas_TarefaId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_TarefaId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TarefaId",
                table: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Tarefas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_TagId",
                table: "Tarefas",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Tags_TagId",
                table: "Tarefas",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Tags_TagId",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_TagId",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Tarefas");

            migrationBuilder.AddColumn<int>(
                name: "TarefaId",
                table: "Tags",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TarefaId",
                table: "Tags",
                column: "TarefaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Tarefas_TarefaId",
                table: "Tags",
                column: "TarefaId",
                principalTable: "Tarefas",
                principalColumn: "Id");
        }
    }
}
