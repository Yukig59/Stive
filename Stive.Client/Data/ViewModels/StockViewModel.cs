
#nullable disable
using Stive.Client.Data.Methods;
using Stive.Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.ViewModels
{
    public class StockViewModel : Entity<StockViewModel>, IViewModel<Stock>
    {
        public string ArticleName { get;set;}
        public int? Quantite { get; set; }
        public int? Tampon { get; set; }
        public string? Status { get; set; }
        public StockViewModel(Stock stock)
        {
            Id = stock.Id;
            List<Articles> arts = articles();
            List<Commandes> cmdList = getCmds();

            try
            {
               Articles article = arts.First<Articles>(predicate: article => article.Id == stock.ArticlesId);
               ArticleName = article.Designation;
                Commandes cmd = cmdList.First<Commandes>(predicate: cmd => cmd.ArticleId == stock.ArticlesId);
               Status = cmd.Action;
            }
            catch (Exception)
            {
                throw;
            }
            Quantite = stock.Quantite;
            Tampon = stock.Tampon;
        }

        public Stock Deserialize() 
        {
            Stock stock = new Stock();
            stock.Id = Id;
           List<Articles> arts = articles();
            Articles article = arts.First<Articles>(predicate: article => article.Designation == this.ArticleName);
            stock.ArticlesId = article.Id;
            stock.Article = article;
            stock.Quantite = Quantite;
            stock.Tampon = Tampon;
            return stock;
        }
        private List<Family> cats()
        {
            Family categories = new Family();
            List<Family> cats = categories.Get("Categories/");
            return cats;
        }
        private List<Fournisseurs> fournisseurs()
        {
            Fournisseurs fournisseurs = new Fournisseurs();
            List<Fournisseurs> fourn = fournisseurs.Get("Fournisseurs/");
            return fourn;
        }
        private List<Articles> articles()
        {
            Articles articles = new Articles();
            List<Articles> arts = articles.Get("Articles");
            return arts;
        }
        private static List<Commandes> getCmds()
        {
            Commandes cmd = new();
            List<Commandes> cmdList = cmd.Get("Commandes/");
            return cmdList;
        }
    }
}
