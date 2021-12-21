using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Stive.Client.Data.Models
{
    public class VM_Articles 
    {        
        public List<Articles>? Article { get; set; }  

        public VM_Articles()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("articles", Method.GET);
            var result = client.Get<IEnumerable<Articles>>(request);
            Article = JsonConvert.DeserializeObject<List<Articles>>(result.Content);
            
        }
    }
      
  
    }