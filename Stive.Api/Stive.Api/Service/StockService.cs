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



        public void SetUpdateStock(int id, int stock)
        {
            Stock stock1 = _context.Stock.Find(id);
            stock1.Quantite = stock;
            _context.SaveChanges();
         
        }
    }
}
