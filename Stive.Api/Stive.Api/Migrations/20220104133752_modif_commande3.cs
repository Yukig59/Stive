using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class modif_commande3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Inventaire_InventaireId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_InventaireId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "NumeroCommande",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "InventaireId",
                table: "Articles");

            migrationBuilder.CreateIndex(
                name: "IX_Inventaire_ArticleId",
                table: "Inventaire",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventaire_Articles_ArticleId",
                table: "Inventaire",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventaire_Articles_ArticleId",
                table: "Inventaire");

            migrationBuilder.DropIndex(
                name: "IX_Inventaire_ArticleId",
                table: "Inventaire");

            migrationBuilder.AddColumn<Guid>(
                name: "NumeroCommande",
                table: "Commandes",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
