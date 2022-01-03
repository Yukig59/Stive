using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class maybe_something7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Articles",
                newName: "CategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Articles",
                newName: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
