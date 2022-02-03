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
    public class Inventaire : Entity<Inventaire>
    {
        public int? ArticleId { get;set;}
        public int Quantité { get;set;}
        public int DifferenceStock { get;set;}
       
    }
}
