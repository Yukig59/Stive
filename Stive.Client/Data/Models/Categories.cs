using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
namespace Stive.Client.Data.Models
{
    public class Categories
    {
        public int Id { get ; set; } 
        public string? Label { get; set; }
        public List<Categories> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("categories", Method.GET);
            var result = client.Get(request);
            var categories = JsonConvert.DeserializeObject<List<Categories>>(result.Content);
            return categories;
        }
        
    }
}
