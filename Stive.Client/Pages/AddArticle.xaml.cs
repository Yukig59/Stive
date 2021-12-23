using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Stive.Client.Data.Models;
using RestSharp;
using Newtonsoft.Json;

namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour AddArticle.xaml
    /// </summary>
    public partial class AddArticle : Window
    {
        public AddArticle()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {  
            var client = new RestClient("http://localhost:8080/");
            var request = new RestRequest("/articles", Method.POST);
            Articles article = new Articles();
            article.Id = 15;
            article.Description = description.Text;
            article.Cat_Id = 1;
            article.Fournisseur_Id = 1;
            article.Media_Path = "tes";
            article.Designation = designation.Text;
            article.Prix = float.Parse(prix.Text);
            article.Tva = float.Parse(tva.Text);
            string json = JsonConvert.SerializeObject(article); ;
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddJsonBody(json);
            request.RequestFormat = RestSharp.DataFormat.Json;
            try
            {
                client.Execute(request);
                this.Hide();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
