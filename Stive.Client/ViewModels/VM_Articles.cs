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
        public VM_Articles()
        {
            var client = new RestSharp.RestClient("http://localhost:44333/api/");
            var request = new RestSharp.RestRequest("Articles");
            var result = client.Get<IEnumerable<Articles>>(request);
            var data = result.Data;

            VM_Article = new ObservableCollection<Articles>(data);

        }    
        public ObservableCollection<Articles> VM_Article { get; set; }   
    }
      
  
    }