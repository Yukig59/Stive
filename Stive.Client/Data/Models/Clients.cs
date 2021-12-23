using Newtonsoft.Json;
using RestSharp;
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
        public static List<Clients> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("clients", Method.GET);
            var result = client.Get(request);
            var clients = JsonConvert.DeserializeObject<List<Clients>>(result.Content);
            return clients;
        }
    }
}
