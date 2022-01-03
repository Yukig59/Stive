using Stive.Client.Data.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Stive.Client.Data.Models
{
    public class Categories : INotifyPropertyChanged
    {
        private int _Id;
        private string? _Label;

        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        public string? Label
        {
            get { return _Label; }
            set { SetProperty(ref _Label, value); }
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
        public List<Categories> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("categories", Method.GET);
            var result = client.Get(request);
            var categories = JsonConvert.DeserializeObject<List<Categories>>(result.Content);
            return categories;
        }
        public bool Create()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("/categories", Method.POST);

            string json = JsonConvert.SerializeObject(this); ;
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddJsonBody(json);
            request.RequestFormat = DataFormat.Json;
            try
            {
                client.Execute(request);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
