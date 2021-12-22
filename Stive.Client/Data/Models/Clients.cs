using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Clients
    {
        public int Id { get; set; } 
        public int? Role_Id { get; set; }
        public string? Prenom { get; set; }
        public string? Nom { get; set; }
        public string? Email { get; set; }
        protected string? _password { get; set; }
    }
}
