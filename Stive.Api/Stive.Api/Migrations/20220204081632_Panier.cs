using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class Panier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Commandes_CommandesId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CommandesId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CommandesId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "PanierID",
                table: "Commandes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Panier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientsId = table.Column<int>(type: "int", nullable: true),
                    Quantite = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArticlesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panier_Articles_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_PanierID",
                table: "Commandes",
                column: "PanierID");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_ArticlesId",
                table: "Panier",
                column: "ArticlesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Panier_PanierID",
                table: "Commandes",
                column: "PanierID",
                principalTable: "Panier",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Panier_PanierID",
                table: "Commandes");

            migrationBuilder.DropTable(
                name: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_PanierID",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "PanierID",
                table: "Commandes");

            migrationBuilder.AddColumn<int>(
                name: "CommandesId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CommandesId",
                table: "Articles",
                column: "CommandesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Commandes_CommandesId",
                table: "Articles",
                column: "CommandesId",
                principalTable: "Commandes",
                principalColumn: "Id");
        }
    }
}
