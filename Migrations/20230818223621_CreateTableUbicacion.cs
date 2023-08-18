using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reach_Home.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUbicacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "activo",
                table: "Usuarios",
                newName: "usuario_activo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuario_activo",
                table: "Usuarios",
                newName: "activo");
        }
    }
}
