using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class modif_classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategorieIdId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Articles_ArticleIdId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_ArticleIdId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ArticleIdId",
                table: "Stock");

            migrationBuilder.RenameColumn(
                name: "CategorieIdId",
                table: "Articles",
                newName: "StockId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategorieIdId",
                table: "Articles",
                newName: "IX_Articles_StockId");

            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "Categories",
                type: "int",
                nullable: true);

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
                name: "FK_Articles_Stock_StockId",
                table: "Articles",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Stock_StockId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategorieId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "Articles",
                newName: "CategorieIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_StockId",
                table: "Articles",
                newName: "IX_Articles_CategorieIdId");

            migrationBuilder.AddColumn<int>(
                name: "ArticleIdId",
                table: "Stock",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ArticleIdId",
                table: "Stock",
                column: "ArticleIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategorieIdId",
                table: "Articles",
                column: "CategorieIdId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Articles_ArticleIdId",
                table: "Stock",
                column: "ArticleIdId",
                principalTable: "Articles",
                principalColumn: "Id");
        }
    }
}
