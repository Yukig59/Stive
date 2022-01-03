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
    public class Roles
    {
        private int _Id;
        private string? _Name;
        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        public string? Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
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
        public static List<Roles> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("roles", Method.GET);
            var result = client.Get(request);
            var roles = JsonConvert.DeserializeObject<List<Roles>>(result.Content);
            return roles;
        } 
    }
}
