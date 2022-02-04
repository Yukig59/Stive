using Stive.Client.Data.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Stive.Client.Data.Models
{
    public class Article :  Entity<Article>
    {
        public int? CategorieId { get;set;}
        public int? FournisseurId {get;set;}
        public string? Designation {get;set;}
        public float Prix {get;set;}
        public string? Description {get;set;}
        public string? MediaPath {get;set;}
        public float Tva {get;set;}

    }
}
