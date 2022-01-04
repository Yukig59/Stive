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
    public class Roles : Entity<Roles>
    {
        public string? Name { get; set; }
       
     
    }
}
