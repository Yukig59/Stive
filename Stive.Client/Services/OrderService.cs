#nullable disable
using Stive.Client.Data.Methods;
using Stive.Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Stive.Client.Services
{
    public class OrderService
    { 
       /// <summary>
       /// 
       /// Service de commande à la demande, pour tous les stocks en dessous de leur valeur tampon
       /// </summary>
       public void DoAutoOrder()
        {
            List<Stock> stockList = getStocks();
            foreach(var item in stockList)
            {            
                Articles art = new();
                var article = (Articles)art.GetById("Articles/" + item.ArticlesId);


                if (item.Quantite < item.Tampon && item != null)
                {
                    Commandes commandes = new Commandes();
                    commandes.Action = "restock";
                    commandes.ArticleId = article.Id;
                    commandes.TotalArticle = (int)(2 * item.Tampon);
                    commandes.TotalPrix = commandes.TotalArticle * article.Prix;
                    try
                    {
                    commandes.Create("Commandes");
                    }catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// Receptionne les commandes de restock, et met a jour les stocks
        /// </summary>
        public void RecieveOrder()
        {
            List<Commandes> commandesList = getCmds();
            foreach(Commandes commandes in commandesList)
            {
                if (commandes.Action == "restock")
                {
                    List<Stock> stockList = getStocks();
                    Stock stock = stockList.First<Stock>(predicate: stock => stock.ArticlesId == commandes.ArticleId);
                    try
                    {
                        stock.Quantite += commandes.TotalArticle;
                        commandes.Action = "Recieved";
                        stock.Update("Stocks", stock);
                        commandes.Update("Commandes", commandes);

                    }
                    catch (Exception)
                    {
                        throw;
                    } 
                }
            }
        }
       






        private static List<Stock> getStocks()
        {
            Stock stock = new Stock();
            List<Stock> stockList = stock.Get("Stocks/");
            return stockList;
        }
        private static List<Commandes> getCmds()
        {
            Commandes cmd = new();
            List<Commandes> cmdList = cmd.Get("Commandes/");
            return cmdList;
        }
    }
   
}
