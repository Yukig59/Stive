using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class Panier4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Panier_PanierId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_PanierId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "PanierId",
                table: "Articles");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_ArticlesId",
                table: "Panier",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_ClientsId",
                table: "Panier",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Articles_ArticlesId",
                table: "Panier",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Clients_ClientsId",
                table: "Panier",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Articles_ArticlesId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Clients_ClientsId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Panier_ArticlesId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Panier_ClientsId",
                table: "Panier");

            migrationBuilder.AddColumn<int>(
                name: "PanierId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_PanierId",
                table: "Articles",
                column: "PanierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Panier_PanierId",
                table: "Articles",
                column: "PanierId",
                principalTable: "Panier",
                principalColumn: "Id");
        }
    }
}
