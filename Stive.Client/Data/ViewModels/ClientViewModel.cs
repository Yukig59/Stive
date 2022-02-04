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
        public string? Prenom { get; set; }
        public string? Nom { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public string? Role { get; set; }
        public ClientViewModel(Clients clients)
        {
            Id = clients.Id;
            Prenom = clients.Prenom;
            Nom = clients.Nom;
            Email = clients.Email;
            Password = clients.Password;
            RoleId = clients.RoleId;
            Role = "";
            List<Roles> roles = this.roles();

            try
            {
                Roles role = roles.First<Roles>(predicate: role => role.Id == (clients.RoleId));
                Role = role.Name;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Roles> roles()
        {
            Roles role = new Roles();
            Console.WriteLine(role.Get("Roles/"));
            List<Roles> roles = role.Get("Roles/");
            return roles;

        }

        public Clients Deserialize()
        {
            Clients clients = new Clients();
            clients.Id = (int)this.Id;
            clients.Nom = this.Nom;  
            clients.Prenom = this.Prenom;
            clients.Password = this.Password;
            clients.RoleId = this.RoleId;
            clients.Email = this.Email;
            return clients;
        }


    }
}
