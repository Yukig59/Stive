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
    public class Stock
    {
        public int Id { get; set; }
        public Articles? Article_Id {get;set;}
        public int Qte {get;set;}
        public int Tampon {get;set;}

      
        public static List<Stock> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("stocks", Method.GET);
            var result = client.Get(request);
            var stock = JsonConvert.DeserializeObject<List<Stock>>(result.Content);
            return stock;
        }}
}
