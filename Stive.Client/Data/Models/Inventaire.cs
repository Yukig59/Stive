using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Inventaire
    {
        public int Id { get; set; } 
        public Articles? Art_Id { get; set; }
        public int Qte { get; set; }
        public int Diff { get; set; }
    }
}
