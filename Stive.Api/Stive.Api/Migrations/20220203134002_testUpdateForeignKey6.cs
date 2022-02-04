using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class testUpdateForeignKey6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticlesId",
                table: "Inventaire",
                newName: "ArticlesId");

            migrationBuilder.AddColumn<int>(
                name: "RolesId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ArticlesId",
                table: "Stock",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventaire_ArticlesId",
                table: "Inventaire",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RolesId",
                table: "Clients",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_FournisseursId",
                table: "Articles",
                column: "FournisseursId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Fournisseurs_FournisseursId",
                table: "Articles",
                column: "FournisseursId",
                principalTable: "Fournisseurs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RolesId",
                table: "Clients",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventaire_Articles_ArticlesId",
                table: "Inventaire",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Articles_ArticlesId",
                table: "Stock",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoriesId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Fournisseurs_FournisseursId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RolesId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventaire_Articles_ArticlesId",
                table: "Inventaire");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Articles_ArticlesId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_ArticlesId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Inventaire_ArticlesId",
                table: "Inventaire");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RolesId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoriesId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_FournisseursId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "RolesId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ArticlesId",
                table: "Inventaire",
                newName: "ArticleId");
        }
    }
}
