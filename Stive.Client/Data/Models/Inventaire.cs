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
    public class Inventaire
    {
        private int _Id;
        private int? _Art_Id;
        private int _Qte;
        private int _Diff;
        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        public int? Art_Id
        {
            get { return _Art_Id; }
            set { SetProperty(ref _Art_Id, value); }
        }
        public int Qte
        {
            get { return _Qte; }
            set { SetProperty(ref _Qte, value); }
        }
        public int Diff
        {
            get { return _Diff; }
            set { SetProperty(ref _Diff, value); }
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
        public event PropertyChangedEventHandler? PropertyChanged; public static List<Inventaire> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("inventaire", Method.GET);
            var result = client.Get(request);
            var inventaire = JsonConvert.DeserializeObject<List<Inventaire>>(result.Content);
            return inventaire;
        }
    }
}
