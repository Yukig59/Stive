using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Siret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleIDId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Roles_RoleIDId",
                        column: x => x.RoleIDId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientsIDId = table.Column<int>(type: "int", nullable: true),
                    TotalArticle = table.Column<int>(type: "int", nullable: false),
                    TotalPrix = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients_ClientsIDId",
                        column: x => x.ClientsIDId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tva = table.Column<float>(type: "real", nullable: false),
                    FournisseurIDId = table.Column<int>(type: "int", nullable: true),
                    CategorieIdId = table.Column<int>(type: "int", nullable: true),
                    CommandesId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategorieIdId",
                        column: x => x.CategorieIdId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Commandes_CommandesId",
                        column: x => x.CommandesId,
                        principalTable: "Commandes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Fournisseurs_FournisseurIDId",
                        column: x => x.FournisseurIDId,
                        principalTable: "Fournisseurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventaire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleIdId = table.Column<int>(type: "int", nullable: true),
                    Quantité = table.Column<int>(type: "int", nullable: false),
                    DifferenceStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventaire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventaire_Articles_ArticleIdId",
                        column: x => x.ArticleIdId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    Tampon = table.Column<int>(type: "int", nullable: false),
                    ArticleIdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Articles_ArticleIdId",
                        column: x => x.ArticleIdId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategorieIdId",
                table: "Articles",
                column: "CategorieIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CommandesId",
                table: "Articles",
                column: "CommandesId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_FournisseurIDId",
                table: "Articles",
                column: "FournisseurIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RoleIDId",
                table: "Clients",
                column: "RoleIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ClientsIDId",
                table: "Commandes",
                column: "ClientsIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventaire_ArticleIdId",
                table: "Inventaire",
                column: "ArticleIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ArticleIdId",
                table: "Stock",
                column: "ArticleIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventaire");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Fournisseurs");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
