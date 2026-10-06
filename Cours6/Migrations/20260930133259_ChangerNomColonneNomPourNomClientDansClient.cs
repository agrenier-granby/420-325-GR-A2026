using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cours6.Migrations
{
    /// <inheritdoc />
    public partial class ChangerNomColonneNomPourNomClientDansClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Clients",
                newName: "NomClient");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomClient",
                table: "Clients",
                newName: "Nom");
        }
    }
}
