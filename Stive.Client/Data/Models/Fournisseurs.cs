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
    public class Fournisseurs
    {
        private int _Id;
        private string? _Email;
        private string? _Telephone;
        private string? _Siret;
        private string? _Nom;

        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        public string? Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); } 
        }
        public string? Telephone
        {
            get { return _Telephone; }  
            set { SetProperty(ref _Telephone, value); }
        }
        public string? Siret
        {
            get { return _Siret; }
            set { SetProperty(ref _Siret, value); }
        }
        public string? Nom
        {
            get { return _Nom; }    
            set { SetProperty(ref _Nom, value); }
        }

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
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Fournisseurs> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("fournisseurs", Method.GET);
            var result = client.Get(request);
            var fournisseurs = JsonConvert.DeserializeObject<List<Fournisseurs>>(result.Content);
            return fournisseurs;
        }
    }
}
