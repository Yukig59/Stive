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
    public class Stock
    {
        private int _Id;
        private Articles? _Article_Id;
        private int _Qte;
        private int _Tampon;

        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        public Articles? Article_Id
        {
            get { return _Article_Id; } 
            set { SetProperty(ref _Article_Id, value); }
        }
        public int Qte
        {
            get { return _Qte; }
            set { SetProperty(ref _Qte, value); }
        }
        public int Tampon
        {
            get { return _Tampon; }
            set { SetProperty(ref _Tampon, value); }
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
        public static List<Stock> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("stocks", Method.GET);
            var result = client.Get(request);
            var stock = JsonConvert.DeserializeObject<List<Stock>>(result.Content);
            return stock;
        }}
}
