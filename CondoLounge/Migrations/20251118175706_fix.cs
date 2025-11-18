using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "Buildings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_ApplicationUserId",
                table: "Buildings",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_AspNetUsers_ApplicationUserId",
                table: "Buildings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_AspNetUsers_ApplicationUserId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_ApplicationUserId",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Buildings");
        }
    }
}
