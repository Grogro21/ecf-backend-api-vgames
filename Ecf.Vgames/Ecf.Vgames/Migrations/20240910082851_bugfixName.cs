using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecf.Vgames.Migrations
{
    /// <inheritdoc />
    public partial class bugfixName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gizmondos_Publishers_publisher",
                table: "Gizmondos");

            migrationBuilder.RenameColumn(
                name: "publisher",
                table: "Gizmondos",
                newName: "publisherId");

            migrationBuilder.RenameIndex(
                name: "IX_Gizmondos_publisher",
                table: "Gizmondos",
                newName: "IX_Gizmondos_publisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gizmondos_Publishers_publisherId",
                table: "Gizmondos",
                column: "publisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gizmondos_Publishers_publisherId",
                table: "Gizmondos");

            migrationBuilder.RenameColumn(
                name: "publisherId",
                table: "Gizmondos",
                newName: "publisher");

            migrationBuilder.RenameIndex(
                name: "IX_Gizmondos_publisherId",
                table: "Gizmondos",
                newName: "IX_Gizmondos_publisher");

            migrationBuilder.AddForeignKey(
                name: "FK_Gizmondos_Publishers_publisher",
                table: "Gizmondos",
                column: "publisher",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
