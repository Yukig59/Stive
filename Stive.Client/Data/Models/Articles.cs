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
    public class Articles :  INotifyPropertyChanged
    {
        private int _Id;
        private int? _Cat_Id;
        private int? _Fournisseur_Id;
        private string? _Designation;
        private float _Prix;
        private string? _Description;
        private string? _Media_Path;
        private float _Tva;

        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); ; }
        }
        public int? Cat_Id
        {
            get { return _Cat_Id; }

            set {SetProperty(ref _Cat_Id, value);}
        }
        public int? Fournisseur_Id
        {
            get { return _Fournisseur_Id;}
            set { SetProperty(ref _Fournisseur_Id, value); }
        }
        public string? Description
        {
            get { return _Description; }    
            set { SetProperty(ref _Description, value); }
        }
        public float Prix
        {
            get { return _Prix; }
            set { SetProperty(ref _Prix, value); }
        }
        public string? Designation
        {
            get { return _Designation; }
            set { SetProperty(ref _Designation, value); }
        }
        public string? Media_Path
        {

            get { return _Media_Path; } 
            set { SetProperty(ref _Media_Path, value); }
        }
        public float Tva
        {
            get { return _Tva; }
            set { SetProperty(ref _Tva, value); }
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
    

    public List<Articles> Get()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("articles", Method.GET);
            var result = client.Get(request);
            var articles = JsonConvert.DeserializeObject<List<Articles>>(result.Content);
            return articles;
        }

        public bool Create()
        {
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("/articles", Method.POST);
            
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
