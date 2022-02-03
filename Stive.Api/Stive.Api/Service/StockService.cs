using api.Data.Models;
using Api.Data;
using System.Diagnostics;

namespace Stive.Api.Service
{
    public class StockService
    {
        private readonly ApiDbContext _context;

        public StockService(ApiDbContext context)
        {
            _context = context;
        }

        public Stock Find(int id)
        {
            Stock stock = _context.Stock.Find(id);
            return stock;
        }

        public void SetUpdateStockInventaire(int id, int stock)
        {
            Stock stock1 = Find(id);
            stock1.Quantite = stock;
            _context.SaveChanges();

        }

        public void IncrementeStockByIdArticle(int id, int quantite)
        {
            Stock stock1 = Find(id);
            var quantiteEnStock = stock1.Quantite;
            var quantiteIncremente = quantite + quantiteEnStock;
            stock1.Quantite = quantiteIncremente;
            _context.SaveChanges();

        }

        public void DecrementeStockByIdArticle(int id, int quantite)
        {
            Stock stock1 = Find(id);
            var quantiteEnStock = stock1.Quantite;
            var quantiteIncremente = quantite - quantiteEnStock;
            stock1.Quantite = quantiteIncremente;
            _context.SaveChanges();

        }


    }
}
