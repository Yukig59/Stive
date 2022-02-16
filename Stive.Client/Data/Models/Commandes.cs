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
        public string? Action { get; set; }
        public int? ClientsId { get; set; }

        //TODO affiler une list d'articles créer via le front

        public int? ArticleId { get; set; }

        public int TotalArticle { get; set; }

        public float TotalPrix { get; set; }


    }
}
