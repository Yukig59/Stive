
using Stive.Api.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data.Models
{
    public class Commandes
    {

        public int Id { get; set; }
        public string? Action { get; set; }
        //TODO a affilier au clients class
        public int? ClientsId { get; set; }
        public virtual Clients? Clients { get; set; }

        //TODO affiler une list d'articles créer via le front
        public int? PanierID { get; set; }

        public virtual Panier? Panier { get; set;}

        public int TotalArticle { get; set; }

        public float TotalPrix { get; set; }




        
    }
}
