
using System.ComponentModel.DataAnnotations;

namespace api.Data.Models
{
    public class Categories
    {
   
        public int Id { get; set; }
        public string? Label { get; set; }

        public List<Articles>? Articles { get; set; }

    }
}
