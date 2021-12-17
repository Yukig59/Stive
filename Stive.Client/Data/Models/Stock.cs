using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Stock
    {
        public int Id { get; set; } 
        public Articles? Article_Id { get; set; }
        public int Qte { get; set; }
        public int Tampon { get; set; }
    }
}
