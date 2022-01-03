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
    public class Roles
    {
        public int Id { get;set; }
        public string? Name { get; set; }
       
        public static List<Roles> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("roles", Method.GET);
            var result = client.Get(request);
            var roles = JsonConvert.DeserializeObject<List<Roles>>(result.Content);
            return roles;
        } 
    }
}
