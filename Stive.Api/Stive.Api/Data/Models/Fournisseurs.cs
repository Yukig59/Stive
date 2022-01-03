
using System.ComponentModel.DataAnnotations;

namespace api.Data.Models
{
    public class Fournisseurs
    {

        public int Id { get; set; }

        public string? Email { get; set; }

        public string? Telephone { get; set; }

        public string? Siret { get; set; }

        public string? Nom { get; set; }

        public List<Articles>? Articles { get; set; }
    }
}
