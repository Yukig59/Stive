using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class updateCommandeClass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticlesId",
                table: "Commandes",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Articles_ArticlesId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_ArticlesId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "ArticlesId",
                table: "Commandes");
        }
    }
}
