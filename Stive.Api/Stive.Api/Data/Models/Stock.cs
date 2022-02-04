
using System.ComponentModel.DataAnnotations;

namespace api.Data.Models
{
    public class Stock
    {

        public int Id { get; set; }

        public int? Quantite { get; set; }

        public int? Tampon { get; set; }

        public int? ArticlesId { get; set; }

        public virtual Articles? Articles { get; set; }
    }
}
