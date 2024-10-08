using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Departmant.Migrations
{
    /// <inheritdoc />
    public partial class SutunKaldir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detay",
                table: "departmanlars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
