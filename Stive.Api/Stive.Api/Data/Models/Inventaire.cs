
using System.ComponentModel.DataAnnotations;

namespace api.Data.Models
{
    public class Inventaire
    {

        public int Id { get; set; }

<<<<<<< HEAD
        public int ArticleId { get; set; }
=======
        public int ArticlesId { get; set; }

        public virtual Articles? Articles { get; set; } 
>>>>>>> API

        public int? Quantité { get; set; }

        public int? DifferenceStock { get; set; }
    }
}
