using Stive.Client.Data.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;

namespace Stive.Client.Data.Models
{
    public class Articles //: IApiConn
    {
        public int Id { get; set; }
        public int? Cat_Id { get; set; }
        public int? Fournisseur_Id { get; set; }
        public string? Designation { get; set; }
        public float Prix { get; set; }
        public string? Description { get; set; }
        public string? Media_Path { get; set; }
        public float Tva { get; set; }

        public static List<Articles> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("articles", Method.GET);
            var result = client.Get(request);
            var articles = JsonConvert.DeserializeObject<List<Articles>>(result.Content);
            return articles;
        }
    }
  
}
