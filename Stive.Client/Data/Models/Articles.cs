using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public Categories? Cat_Id { get; set; }
        public Fournisseurs? Fournisseur_Id { get; set; }
        public string? Designation { get; set; }
        public float Prix { get; set; }
        public string? Description { get;set; }
        public string? Media_Path { get; set; }
        public float Tva { get; set; }
        
    }
}
