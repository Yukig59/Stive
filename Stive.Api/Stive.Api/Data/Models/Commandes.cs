using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data.Models
{
    public class Commandes
    {

        public int Id { get; set; }
        public string? Action { get; set; }
        //TODO a affilier au clients class
        public Clients? ClientsID { get; set; }

        //TODO affiler une list d'articles créer via le front
        public ICollection<Articles>? Articles { get; set; }

        public int TotalArticle { get; set; }

        public float TotalPrix { get; set; }
    }
}
