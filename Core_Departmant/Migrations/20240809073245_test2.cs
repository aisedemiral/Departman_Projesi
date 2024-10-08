using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Departmant.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "departid",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departid",
                table: "Personels",
                column: "departid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_departmanlars_departid",
                table: "Personels",
                column: "departid",
                principalTable: "departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_departmanlars_departid",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_departid",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "departid",
                table: "Personels");

            migrationBuilder.AddColumn<int>(
                name: "departmanlarid",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departmanlarid",
                table: "Personels",
                column: "departmanlarid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_departmanlars_departmanlarid",
                table: "Personels",
                column: "departmanlarid",
                principalTable: "departmanlars",
                principalColumn: "id");
        }
    }
}
