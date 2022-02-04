using Stive.Client.Data.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Stive.Client.Data.Models;
namespace Stive.Client.Data.ViewModels
{
    public class ArticleViewModel :  Entity<ArticleViewModel>
    {
        public int? CategorieId { get;set;}
        public string? Categorie { get;set;}
        public int? FournisseurId {get;set;}
        public string? Fournisseur {get;set;}
        public string? Designation {get;set;}
        public float Prix {get;set;}
        public string? Description {get;set;}
        public string? MediaPath {get;set;}
        public float Tva {get;set;}

        public ArticleViewModel(Article art)
        {
            Id = art.Id;
            CategorieId = art.CategorieId;
            FournisseurId = art.FournisseurId;
            Description = art.Description;
            Designation = art.Designation;
            Prix = art.Prix;
            MediaPath = art.MediaPath;
            Tva = art.Tva;
            Categorie = "";
            Fournisseur = "";
            List<Categories> catList = cats();
            List<Fournisseurs>fournisseursList = fournisseurs();
            try
            {
                Categories categoy = catList.First<Categories>(predicate: category => category.Id == art.CategorieId);
                Categorie = categoy.Label;

            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                Fournisseurs fournisseur = fournisseursList.First<Fournisseurs>(predicate: fourn => fourn.Id == art.FournisseurId);
                Fournisseur = fournisseur.Nom + "(" + fournisseur.Siret + ")";
            }catch (Exception)
            { 
                throw;
            }
        }
        private List<Categories> cats()
        {
            Categories categories = new Categories();
            List<Categories> cats = categories.Get("Categories/");
            return cats;
        }
        private List<Fournisseurs> fournisseurs()
        {
            Fournisseurs fournisseurs = new Fournisseurs();
            List<Fournisseurs> fourn = fournisseurs.Get("Fournisseurs/");
            return fourn;
        }
        public Article Deserialize()
        {
            Article article = new Article();
            article.Id = this.Id;
            article.CategorieId = this.CategorieId;
            article.FournisseurId = this.FournisseurId;     
            article.Designation = this.Designation;
            article.Description = this.Description;
            article.Prix = this.Prix;
            article.Tva = this.Tva;
            article.MediaPath = this.MediaPath;
            return article;
        }
    }
}
