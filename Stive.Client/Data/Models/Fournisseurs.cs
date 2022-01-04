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
    public class Fournisseurs : Entity<Fournisseurs>
    {
        public string? Email{get;set;}
        public string? Telephone{get;set;}
        public string? Siret{get;set;}
        public string? Nom{get;set;}

       
    }
}
