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
        public int? Art_Id {get;set;}
        public int Qte {get;set;}
        public int Diff {get;set;}
       
    }
}
