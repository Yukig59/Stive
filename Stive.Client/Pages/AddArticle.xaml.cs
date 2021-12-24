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
        List<Categories> categories { get; set; }
        List<Fournisseurs> fournisseurs { get; set; }
        public AddArticle()
        {
            InitializeComponent();
            var _categories = new Categories();
            categories = _categories.Get();
            catgorySelector.DataContext = _categories;
            catgorySelector.ItemsSource = categories;
            var _fournisseur = new Fournisseurs();
            fournisseurs = _fournisseur.Get();
            fournisseurSelector.DataContext = _fournisseur;
            fournisseurSelector.ItemsSource = fournisseurs;
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {





            Articles article = new Articles();
            article.Description = description.Text;
            article.Cat_Id = catgorySelector.SelectedIndex;
            article.Fournisseur_Id = fournisseurSelector.SelectedIndex;
            article.Media_Path = "tes";
            article.Designation = designation.Text;
            article.Prix = float.Parse(prix.Text);
            article.Tva = float.Parse(tva.Text);
            var result = article.Create();
            if (result)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
    }
}
