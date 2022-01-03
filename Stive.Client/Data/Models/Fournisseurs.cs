using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Fournisseurs
    {
        public int Id { get; set; }
        public string? Email{get;set;}
        public string? Telephone{get;set;}
        public string? Siret{get;set;}
        public string? Nom{get;set;}

        public List<Fournisseurs> Get()
        {
            var client = new RestClient("http://localhost:5189/api/");
            var request = new RestRequest("Fournisseurs", Method.GET);
            var result = client.Get(request);
            var fournisseurs = JsonConvert.DeserializeObject<List<Fournisseurs>>(result.Content);
            return fournisseurs;
        }
    }
}
