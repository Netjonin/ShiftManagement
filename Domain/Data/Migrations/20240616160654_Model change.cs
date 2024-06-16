using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftManager.Domain.Data.Migrations
{
    /// <inheritdoc />
    public partial class Modelchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Workers",
                newName: "Department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Workers",
                newName: "Position");
        }
    }
}
