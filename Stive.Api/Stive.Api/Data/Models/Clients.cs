
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data.Models
{
    public class Clients
    {

        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        //TODO modifier role pour qu'il accepte 
        public int? RoleId  { get; set; }
<<<<<<< HEAD
=======

        public virtual Roles? Roles { get; set; }
>>>>>>> API

        public List<Commandes>? Commandes { get; set; }
    }
}
