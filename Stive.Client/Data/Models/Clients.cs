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
    public class Clients : Entity<Clients>
    {
        public int? Role_Id {get;set;}
        public string? Prenom {get;set;}
        public string? Nom {get;set;}
        public string? Email {get;set;}
        protected string? _password { get;  set; }
        
    }
}
