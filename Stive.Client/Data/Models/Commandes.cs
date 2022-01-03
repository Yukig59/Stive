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
    public class Commandes
    {
        private int _Id;
        private int? _Client_Id;
        private string? _Action;
        private List<Articles>? _Articles;
        private int _Total_Articles;
        private float _Total_Prix;
        private string? _Statut;

        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        public int? Client_Id
        {
            get { return _Client_Id; }
            set { SetProperty(ref _Client_Id, value); }
        }
         public string? Action
        {
            get { return _Action; }
            set { SetProperty(ref _Action, value); }
        }
        public List<Articles>? Articles
        {
            get { return _Articles; }
            set { SetProperty(ref _Articles, value); }
        }
        public int Total_Articles
        {
            get { return _Total_Articles;}
            set { SetProperty(ref _Total_Articles, value); }
        }
        public float Total_Prix
        {
            get { return _Total_Prix; }
            set { SetProperty(ref _Total_Prix, value); }
        }
        public string? Statut
        {
            get { return _Statut; }
            set { SetProperty(ref _Statut, value);}
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
        public static List<Commandes> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("commandes", Method.GET);
            var result = client.Get(request);
            var commandes = JsonConvert.DeserializeObject<List<Commandes>>(result.Content);
            return commandes;
        }
    }
}
