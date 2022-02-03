using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class modif_commande : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Stock_StockId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleIDId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Clients_ClientsIDId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_Articles_StockId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ClientsIDId",
                table: "Commandes",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Commandes_ClientsIDId",
                table: "Commandes",
                newName: "IX_Commandes_ClientId");

            migrationBuilder.RenameColumn(
                name: "RoleIDId",
                table: "Clients",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_RoleIDId",
                table: "Clients",
                newName: "IX_Clients_RoleId");

            migrationBuilder.AddColumn<int>(
                name: "ArticlesId",
                table: "Stock",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Inventaire",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "NumeroCommande",
                table: "Commandes",
                type: "uniqueidentifier",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Roles_RoleId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "ArticlesId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Inventaire");

            migrationBuilder.DropColumn(
                name: "NumeroCommande",
                table: "Commandes");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Commandes",
                newName: "ClientsIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Commandes_ClientId",
                table: "Commandes",
                newName: "IX_Commandes_ClientsIDId");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Clients",
                newName: "RoleIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_RoleId",
                table: "Clients",
                newName: "IX_Clients_RoleIDId");

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_StockId",
                table: "Articles",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Stock_StockId",
                table: "Articles",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Roles_RoleIDId",
                table: "Clients",
                column: "RoleIDId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Clients_ClientsIDId",
                table: "Commandes",
                column: "ClientsIDId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
