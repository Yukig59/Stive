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
       
        public Home()
        {
            InitializeComponent();
            var client = new RestClient("http://localhost:8080/");

            #region Articles
            var articlerequest = new RestRequest("articles", Method.GET);
            var articleresult = client.Get(articlerequest);
            var articles = JsonConvert.DeserializeObject<List<Articles>>(articleresult.Content);
            articlesList.ItemsSource = articles;

            #endregion

            #region Clients
            var clientrequest = new RestRequest("clients", Method.GET);
            var clientresult = client.Get(clientrequest);
            var clients = JsonConvert.DeserializeObject<List<Clients>>(clientresult.Content);
            clientList.ItemsSource = clients;
            #endregion
                    



        }

        private void btn_new_article_Click(object sender, RoutedEventArgs e)
        {
            var win = new Pages.AddArticle();
            var result = win.ShowDialog();
        }
    }
}