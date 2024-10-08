using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Departmant.Migrations
{
    /// <inheritdoc />
    public partial class departmandetayeklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detay",
                table: "departmanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detay",
                table: "departmanlars");
        }
    }
}
