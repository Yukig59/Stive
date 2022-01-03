using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stive.Client.Data.Models
{
    public class Clients : INotifyPropertyChanged
    {
        private int _Id;
        private int? _Role_Id;
        private string? _Prenom;
        private string? _Nom;
        private string? _Email;
        protected string? _password { get; private set; }

        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }

        public int? Role_Id
        {
            get { return _Role_Id;}
            set { SetProperty(ref _Role_Id, value); }
        }
        public string? Prenom
        {
            get { return _Prenom; }
            set { SetProperty(ref _Prenom, value); }   
        }
        public string? Nom
        {
            get { return _Nom; }
            set { SetProperty(ref _Nom, value); }
        }
        public string? Email
        {
            get { return _Email; }  
            set { SetProperty(ref _Email, value); }
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (object.Equals(storage, value)) return false;
            storage = value;
            this.OnPropertyChaned(propertyName);
            return true;
        }

        private void OnPropertyChaned(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public List<Clients> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("clients", Method.GET);
            var result = client.Get(request);
            var clients = JsonConvert.DeserializeObject<List<Clients>>(result.Content);
            return clients;
        }
    }
}
