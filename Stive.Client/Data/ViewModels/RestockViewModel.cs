using Stive.Client.Data.Methods;
using Stive.Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.ViewModels
{
    public class RestockViewModel : Entity<RestockViewModel>, IViewModel<Stock>

    {
        public string? ArticleName { get; set; }

        public List<StockViewModel> GetRestockablesItems()
        {
            List<Stock> stockList = getStocks();
            List<StockViewModel> newStockList = new List<StockViewModel>();
            foreach (var item in stockList)
            {
                if (item.Quantite < item.Tampon && item != null)
                {
                    newStockList.Add(new StockViewModel(item));
                }
            }
            return newStockList;    
        }
        public Stock Deserialize()
        {
            throw new NotImplementedException();
        }
        private static List<Stock> getStocks()
        {
            Stock stock = new Stock();
            List<Stock> stockList = stock.Get("Stocks/");
            return stockList;
        }
       
    }
}
