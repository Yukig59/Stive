using Newtonsoft.Json;
using RestSharp;
using Stive.Client.Data.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Clients : Entity<Clients>
    {
       // public int Id { get; set; }
        public int? Role_Id {get;set;}
        public string? Prenom {get;set;}
        public string? Nom {get;set;}
        public string? Email {get;set;}
        protected string? _password { get; private set; }

       
        public List<Clients> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("clients", Method.GET);
            var result = client.Get(request);
            var clients = JsonConvert.DeserializeObject<List<Clients>>(result.Content);
            return clients;
        }
    }
}
