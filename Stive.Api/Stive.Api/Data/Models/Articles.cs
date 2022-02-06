using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data.Models
{
    public class Articles
    {
        
        public int Id { get; set; }
        [StringLength(128)]
        public string? Designation { get; set; }
        public float? Prix { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }
        public string? MediaPath { get; set; }
        public float? Tva { get; set; }  


        public int? CategorieId { get; set; }
        public int? FournisseurId { get; set; }

        public int? CategoriesId { get; set; }
        public virtual Categories? Categories { get; set; }


        public int? FournisseursId { get; set; }
        public virtual Fournisseurs? Fournisseurs { get; set; }
                
    }
}
