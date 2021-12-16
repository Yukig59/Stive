using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data.Models
{
    public class Articles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(128)]
        public string Designation { get; set; }
        public float Prix { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        public string MediaPath { get; set; }
        public float Tva { get; set; }    

        public Fournisseurs FournisseurID { get; set; }

        public Categories CategorieId { get; set; }
    }
}
