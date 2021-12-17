using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Fournisseurs
    {
        public int Id { get; set; } 
        public string? Email { get; set; }
        public string? Telephone { get;set; }
        public string? Siret { get; set; }  
        public string? Nom { get;set;}
    }
}
