using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class updateCommandeClassIenumerable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Articles_ArticlesId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_ArticlesId",
                table: "Commandes");

            migrationBuilder.RenameColumn(
                name: "ArticlesId",
                table: "Commandes",
                newName: "ArticlesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticlesID",
                table: "Commandes",
                newName: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ArticlesId",
                table: "Commandes",
                column: "ArticlesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Articles_ArticlesId",
                table: "Commandes",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id");
        }
    }
}
