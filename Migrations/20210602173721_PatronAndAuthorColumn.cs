using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class PatronAndAuthorColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Patron",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Author",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patron_UserId",
                table: "Patron",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_UserId",
                table: "Author",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_AspNetUsers_UserId",
                table: "Author",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_AspNetUsers_UserId",
                table: "Patron",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_AspNetUsers_UserId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_AspNetUsers_UserId",
                table: "Patron");

            migrationBuilder.DropIndex(
                name: "IX_Patron_UserId",
                table: "Patron");

            migrationBuilder.DropIndex(
                name: "IX_Author_UserId",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Patron");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Author");
        }
    }
}
