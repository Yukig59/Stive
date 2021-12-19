using Stive.Client.Data.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
namespace Stive.Client.Data.Models
{
    public class Articles : IApiConn
    {
        public int Id { get;  }
        public Categories? Cat_Id { get;  }
        public Fournisseurs? Fournisseur_Id { get;  }
        public string? Designation { get;  }
        public float Prix { get;  }
        public string? Description { get; }
        public string? Media_Path { get;  }
        public float Tva { get;  }

        public bool Add()
        {
            return false;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    
}
