using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Methods
{
    public abstract class Entity<T> : IApiConn
    {
        public int Id { get; set; }

      
    }
}
