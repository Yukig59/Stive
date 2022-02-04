using Stive.Client.Data.Methods;
using Stive.Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.ViewModels
{
    public class ClientViewModel : Entity<ClientViewModel>{

        public int? RoleId { get; set; }
        public string? Role { get; set; }

        public string? Prenom { get; set; }
        public string? Nom { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public ClientViewModel(Clients clients)
        {
            Prenom = clients.Prenom;
            Nom = clients.Nom;
            Email = clients.Email;
            Password = clients.Password;
            RoleId = clients.RoleId;
            int id = clients.Id;
            List<Roles> roles = this.roles();

            Roles role = roles.First<Roles>(role => role.Id == (clients.Id-1));
            Role = role.Name;
        }

        public List<Roles> roles()
        {
            Roles role = new Roles();
            Console.WriteLine(role.Get("Roles/"));
            List<Roles> roles = role.Get("Roles/");
           return roles;

        }



    }
}
