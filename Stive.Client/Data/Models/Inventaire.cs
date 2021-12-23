using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Inventaire
    {
        public int Id { get; set; } 
        public int? Art_Id { get; set; }
        public int Qte { get; set; }
        public int Diff { get; set; } 
        public static List<Inventaire> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("inventaire", Method.GET);
            var result = client.Get(request);
            var inventaire = JsonConvert.DeserializeObject<List<Inventaire>>(result.Content);
            return inventaire;
        }
    }
}
