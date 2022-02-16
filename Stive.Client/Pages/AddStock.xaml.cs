using Stive.Client.Data.Models;
using Stive.Client.Data.Methods;
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
using System.Windows.Shapes;

namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour AddStock.xaml
    /// </summary>
    public partial class AddStocks : Window
    {
        public AddStocks()
        {
            InitializeComponent();
            articlesList.Items.Clear();
            var article = new Articles();
            articlesList.DataContext = article;
            articlesList.ItemsSource = article.Get("Articles");
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            Stock stock = new Stock();
            if(articlesList.SelectedItem != null)
            {
                Articles article = (Articles)articlesList.SelectedItem;
                stock.ArticlesId = article.Id;
                stock.Article = article;
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un article a stocker");
            }
            if(!qteSelector.IsError)
            {
                stock.Quantite = (int?)qteSelector.Value;
            }
            if (!tamponSelector.IsError)
            {
                stock.Tampon = (int?)tamponSelector.Value;

            }
            try
            {
                var result = stock.Create("Stocks");
                if (result)
                {
                    Accueil accueil = new Accueil();
                    accueil.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            Hide();
        }
    }
}
