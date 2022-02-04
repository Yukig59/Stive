using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class UpdateModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventaire_Articles_ArticleId",
                table: "Inventaire");

            migrationBuilder.DropIndex(
                name: "IX_Inventaire_ArticleId",
                table: "Inventaire");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_ClientId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RoleId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ClientsId",
                table: "Commandes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FournisseurId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ClientsId",
                table: "Commandes",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Clients_ClientsId",
                table: "Commandes",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Clients_ClientsId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_ClientsId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "FournisseurId",
                table: "Articles");

            migrationBuilder.CreateIndex(
                name: "IX_Inventaire_ArticleId",
                table: "Inventaire",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ClientId",
                table: "Commandes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RoleId",
                table: "Clients",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventaire_Articles_ArticleId",
                table: "Inventaire",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
