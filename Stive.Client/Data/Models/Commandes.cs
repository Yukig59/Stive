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
    public class Commandes : Entity<Commandes>
    {
        public int Id { get; set; }
        public int? Client_Id { get; set; }
        public string? Action { get; set; }
        public List<Articles>? Articles {get;set;}
        public int Total_Articles {get;set;}
        public float Total_Prix {get;set;}
        public string? Statut {get;set;}

    }
}
