﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Stive.Api.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220204085729_Panier4")]
    partial class Panier4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api.Data.Models.Articles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Designation")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("FournisseursId")
                        .HasColumnType("int");

                    b.Property<string>("MediaPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Prix")
                        .HasColumnType("real");

                    b.Property<float?>("Tva")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("FournisseursId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("api.Data.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("api.Data.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("RolesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolesId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("api.Data.Models.Commandes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClientsId")
                        .HasColumnType("int");

                    b.Property<int?>("PanierID")
                        .HasColumnType("int");

                    b.Property<int>("TotalArticle")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrix")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClientsId");

                    b.HasIndex("PanierID");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("api.Data.Models.Fournisseurs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Siret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("api.Data.Models.Inventaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int?>("DifferenceStock")
                        .HasColumnType("int");

                    b.Property<int?>("Quantité")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticlesId");

                    b.ToTable("Inventaire");
                });

            modelBuilder.Entity("api.Data.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("api.Data.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantite")
                        .HasColumnType("int");

                    b.Property<int?>("Tampon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticlesId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Stive.Api.Data.Models.Panier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticlesId");

                    b.HasIndex("ClientsId");

                    b.ToTable("Panier");
                });

            modelBuilder.Entity("api.Data.Models.Articles", b =>
                {
                    b.HasOne("api.Data.Models.Categories", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesId");

                    b.HasOne("api.Data.Models.Fournisseurs", "Fournisseurs")
                        .WithMany()
                        .HasForeignKey("FournisseursId");

                    b.Navigation("Categories");

                    b.Navigation("Fournisseurs");
                });

            modelBuilder.Entity("api.Data.Models.Clients", b =>
                {
                    b.HasOne("api.Data.Models.Roles", "Roles")
                        .WithMany()
                        .HasForeignKey("RolesId");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("api.Data.Models.Commandes", b =>
                {
                    b.HasOne("api.Data.Models.Clients", "Clients")
                        .WithMany("Commandes")
                        .HasForeignKey("ClientsId");

                    b.HasOne("Stive.Api.Data.Models.Panier", "Panier")
                        .WithMany()
                        .HasForeignKey("PanierID");

                    b.Navigation("Clients");

                    b.Navigation("Panier");
                });

            modelBuilder.Entity("api.Data.Models.Inventaire", b =>
                {
                    b.HasOne("api.Data.Models.Articles", "Articles")
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articles");
                });

            modelBuilder.Entity("api.Data.Models.Stock", b =>
                {
                    b.HasOne("api.Data.Models.Articles", "Articles")
                        .WithMany()
                        .HasForeignKey("ArticlesId");

                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Stive.Api.Data.Models.Panier", b =>
                {
                    b.HasOne("api.Data.Models.Articles", "Articles")
                        .WithMany()
                        .HasForeignKey("ArticlesId");

                    b.HasOne("api.Data.Models.Clients", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientsId");

                    b.Navigation("Articles");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("api.Data.Models.Clients", b =>
                {
                    b.Navigation("Commandes");
                });
#pragma warning restore 612, 618
        }
    }
}
