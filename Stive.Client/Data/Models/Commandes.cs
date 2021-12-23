using Newtonsoft.Json;
using RestSharp;
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
        public int? Client_Id { get; set; }  
        public string? Action { get; set; }
        public List<Articles>? Articles { get;set; }   
        public int Total_Articles { get; set; }
        public float Total_Prix { get; set; }
        public string? Statut { get; set; }
        public static List<Commandes> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("commandes", Method.GET);
            var result = client.Get(request);
            var commandes = JsonConvert.DeserializeObject<List<Commandes>>(result.Content);
            return commandes;
        }
    }
}
