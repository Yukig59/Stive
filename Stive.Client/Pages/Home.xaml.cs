using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using RestSharp;
using Stive.Client.Data.Models;
namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private List<Articles> _articles;
        private List<Clients> _clients;
        private List<Fournisseurs> _fournisseurs;
        private List<Commandes> _cmd;
        private List<VM_Articles> _vmarticles;
        public Home()
        {
            InitializeComponent();
            #region Stocks
            _articles = new List<Articles>
            {
                new Articles
                {
                    Id = 1,
                    Designation = "Cotes du rhone",
                    Prix = 15,

                    Description = "test"
                },
                 new Articles
                {
                    Id = 1,
                    Designation = "Bourgogne",
                    Prix = 15,
                    Description = "Rouge pas degeu"
                },
                new Articles
                { 
                    Description = "test3"
                }
            };
            stockList.ItemsSource = _articles;
            #endregion

            #region Inventaire
           
            inventaireList.ItemsSource = _articles;
            #endregion

            #region Clients
            _clients = new List<Clients>
            {
                new Clients
                {
                    Prenom = "Pierre",
                    Nom = "Dumoulin",
                    Email = "pierre.dumoulin@gmail.com"
                },
                new Clients
                {
                    Prenom = "Paul",
                    Nom = "Hubert",
                    Email = "paul.hubert@gmail.com"
                },
                new Clients
                {
                    Prenom = "Jacques",
                    Nom = "Sandrier",
                    Email = "jacques.sandrier@gmail.com"
                }

            };
            clientList.ItemsSource = _clients;
            #endregion

            #region Fournisseurs
            _fournisseurs = new List<Fournisseurs>
            {
                new Fournisseurs
                {
                    Email = "Company1@gmail.com",
                    Telephone = "0213546897",
                    Siret = "FZBUCNAP5646",
                    Nom = "Company 1"
                },
                 new Fournisseurs
                {
                    Email = "Company2@gmail.com",
                    Telephone = "8564125694",
                    Siret = "PMZXNUFBK1687M",
                    Nom = "Company 2"
                }, new Fournisseurs
                {
                    Email = "Company3@gmail.com",
                    Telephone = "0648793210",
                    Siret = "NXSOBCZN5541565",
                    Nom = "Company 3"
                },
            };
            fournisseursList.ItemsSource = _fournisseurs;
            #endregion

            #region Commandes
            _cmd = new List<Commandes> 
            { 
                new Commandes
                {
                    Action = "Achat",
                    Total_Articles = 51,
                    Total_Prix = 4523,
                    Statut = "En cours de livraison"
                },
                new Commandes
                {
                    Action = "Achat",
                    Total_Articles = 45,
                    Total_Prix = 3124,
                    Statut = "Payé, en attente d'expedition"
                },
                new Commandes
                {
                    Action = "Achat",
                    Total_Articles = 5,
                    Total_Prix = 245,
                    Statut = "Livré"
                },
            };
            cmdList.ItemsSource = _cmd;
            #endregion

            #region Articles
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("articles", Method.GET);
            var result = client.Get(request);
            var data = JsonConvert.DeserializeObject<List<Articles>>(result.Content);

             articlesList.ItemsSource = data; 



            #endregion

        }
    }
}