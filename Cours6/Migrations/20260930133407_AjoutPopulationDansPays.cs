using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cours6.Migrations
{
    /// <inheritdoc />
    public partial class AjoutPopulationDansPays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Pays",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Population",
                table: "Pays");
        }
    }
}
