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
using Stive.Client.Data.Methods;
using Newtonsoft.Json.Linq;
namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
       
        public Home()
        {
            var _articles = new Articles();
            var _clients = new Clients();
            var _fournisseurs = new Fournisseurs(); 
            

            InitializeComponent();
            List<Articles> articles = _articles.Get();
            List<Clients> clients = _clients.Get();
            List<Fournisseurs> fournisseurs = _fournisseurs.Get();

            clientList.ItemsSource = clients;
            fournisseursList.ItemsSource = fournisseurs;
            articlesList.ItemsSource =articles; 
        }


        private void btn_new_article_Click(object sender, RoutedEventArgs e)
        {
            var win = new Pages.AddArticle();
            win.ShowDialog();
        }
    }
}