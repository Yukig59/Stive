using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Models
{
    public class Stock
    {
        public int Id { get; set; } 
        public int Article_Id { get; set; }
        public int Qte { get; set; }
        public int Tampon { get; set; }
    }
}
