using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class testUpdateForeignKey5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Commandes");

            migrationBuilder.RenameColumn(
                name: "FournisseurId",
                table: "Articles",
                newName: "FournisseursId");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Articles",
                newName: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FournisseursId",
                table: "Articles",
                newName: "FournisseurId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Articles",
                newName: "CategorieId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Commandes",
                type: "int",
                nullable: true);
        }
    }
}
