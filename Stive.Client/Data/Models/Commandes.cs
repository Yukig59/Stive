using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Commandes
    {   
        public int Id { get; set; }
        public Clients? Client_Id { get; set; }  
        public string? Action { get; set; }
        public List<Articles>? Articles { get;set; }   
        public int Total_Articles { get; set; }
        public float Total_Prix { get; set; }
        public string? Statut { get; set; }  
    }
}
