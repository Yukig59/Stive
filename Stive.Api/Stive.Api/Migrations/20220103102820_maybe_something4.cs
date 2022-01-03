using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class maybe_something4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Fournisseurs_FournisseurIDId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategorieId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "FournisseurIDId",
                table: "Articles",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_FournisseurIDId",
                table: "Articles",
                newName: "IX_Articles_CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Articles",
                newName: "FournisseurIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles",
                newName: "IX_Articles_FournisseurIDId");

            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategorieId",
                table: "Articles",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Fournisseurs_FournisseurIDId",
                table: "Articles",
                column: "FournisseurIDId",
                principalTable: "Fournisseurs",
                principalColumn: "Id");
        }
    }
}
