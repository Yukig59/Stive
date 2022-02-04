using Api.Data;
using Stive.Api.Data.Models;

namespace Stive.Api.Service
{
    public class PanierService
    {
        private readonly ApiDbContext _context;

        public PanierService(ApiDbContext context)
        {
            _context = context;
        }


        public void isAlreadyPanierId(Panier panier)
        {
           var _user = _context.Panier.Find(panier.ClientsId);

        }


    }
}
