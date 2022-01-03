
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using api.Data.Models;

namespace Api.Data
{
    public class ApiDbContext : DbContext
    {
        #region Ctor
        public static string GetConnectionString()
        {
            return "Server=(localdb)\\MSSQLLocalDB;Database=api_cubes;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var _connectionString = GetConnectionString();
                optionsBuilder.UseSqlServer(_connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        #endregion

        #region Model creation

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Articles>? Articles { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Categories>? Categories { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Clients>? Clients { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Commandes>? Commandes { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Fournisseurs>? Fournisseurs { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Roles>? Roles { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Stock>? Stock { get; set; }

        #endregion

        #region Model creation

        public DbSet<api.Data.Models.Inventaire>? Inventaire { get; set; }


        #endregion
    }
}
