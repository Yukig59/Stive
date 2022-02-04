using api.Data.Models;

namespace Stive.Api.Data.Models
{
    public class Panier
    {

        public int Id { get; set; }

        public int? ClientsId { get; set; }
        public virtual Clients? Clients { get; set; }

        public Guid? NumeroPanier { get; set; }

        public int? Quantite { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int? ArticlesId  { get; set; }

        public virtual Articles? Articles { get; set; }



    }
}
