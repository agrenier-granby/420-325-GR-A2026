using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cours6.Migrations
{
    /// <inheritdoc />
    public partial class AjoutColonneTelephoneDansClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Clients");
        }
    }
}
