using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stive.Api.Migrations
{
    public partial class Panier5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroPanier",
                table: "Panier",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroPanier",
                table: "Panier");
        }
    }
}
