using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class maybe_something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventaire_Articles_ArticleIdId",
                table: "Inventaire");

            migrationBuilder.DropIndex(
                name: "IX_Inventaire_ArticleIdId",
                table: "Inventaire");

            migrationBuilder.DropColumn(
                name: "ArticleIdId",
                table: "Inventaire");

            migrationBuilder.AddColumn<int>(
                name: "InventaireId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_InventaireId",
                table: "Articles",
                column: "InventaireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Inventaire_InventaireId",
                table: "Articles",
                column: "InventaireId",
                principalTable: "Inventaire",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Inventaire_InventaireId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_InventaireId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "InventaireId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "ArticleIdId",
                table: "Inventaire",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventaire_ArticleIdId",
                table: "Inventaire",
                column: "ArticleIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventaire_Articles_ArticleIdId",
                table: "Inventaire",
                column: "ArticleIdId",
                principalTable: "Articles",
                principalColumn: "Id");
        }
    }
}
