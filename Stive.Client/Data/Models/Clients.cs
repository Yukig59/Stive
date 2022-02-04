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
        public string? Prenom {get;set;}
        public string? Nom {get;set;}
        public string? Email {get;set;}
        public string? Password { get;  set; }
        public int? RoleId { get; set; }

       
    }
   
}
