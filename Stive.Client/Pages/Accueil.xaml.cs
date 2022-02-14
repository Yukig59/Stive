using Stive.Client.Data.Models;
using Stive.Client.Data.ViewModels;
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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        public Accueil()
        {
            InitializeComponent();
            #region Articles
            var _articles = new Article();
            List<Article> articles = _articles.Get("Articles");
            List<ArticleViewModel> articlevm = new List<ArticleViewModel>();
            foreach (var article in articles)
            {
                articlevm.Add(new ArticleViewModel(article));
            }
            articlesList.ItemsSource = articlevm;
            articlesList.DataContext = _articles;
            #endregion

            #region Clients
            var _clients = new Clients();
            List<Clients> clients = _clients.Get("Clients");
            List<ClientViewModel> clientvm = new List<ClientViewModel>();
            foreach (var client in clients)
            {
                clientvm.Add(new ClientViewModel(client));
            }
            clientList.DataContext = _clients;
            clientList.ItemsSource = clientvm;
            #endregion

            #region Fournisseurs
            var _fournisseurs = new Fournisseurs();
            List<Fournisseurs> fournisseurs = _fournisseurs.Get("Fournisseurs");
            fournisseursList.DataContext = _fournisseurs;
            fournisseursList.ItemsSource = fournisseurs;
            #endregion

            #region Famillles
            var _cat = new Family();
            foreach (var article in articles)
            {
                articlevm.Add(new ArticleViewModel(article));
            }
            List<Family> categories = _cat.Get("Categories");
            categoryList.ItemsSource = categories;
            #endregion

        }

        private void new_article(object sender, RoutedEventArgs e)
        {
            var win = new Pages.AddArticle();
            win.ShowDialog();
            this.Hide();
        }

        private void edit_article(object sender, RoutedEventArgs e)
        {
            ArticleViewModel article = (ArticleViewModel)articlesList.SelectedItem;
            var win = new UpdateArticle(article.Deserialize());
            win.ShowDialog();
            this.Hide();
        }

        private void delete_article(object sender, RoutedEventArgs e)
        {
            Article article = new Article();
            ArticleViewModel item = (ArticleViewModel)articlesList.SelectedItem;
            int id = item.Id;
            var result = article.Delete("Articles/" + id);
            if (result)
            {
                var win = new Accueil();
                win.Show();
                this.Hide();
            }
        }

        private void new_family(object sender, RoutedEventArgs e)
        {
            var win = new AddFamilly();
            win.Show();
            this.Hide();
        }

        private void edit_family(object sender, RoutedEventArgs e)
        {
            Family cat = (Family)categoryList.SelectedItem;

            var win = new UpdateFamilly(cat);
            win.Show();
            this.Hide();
        }

        private void delete_family(object sender, RoutedEventArgs e)
        {
            Family category = new Family();
            Family item = (Family)categoryList.SelectedItem;
            int id = item.Id;
            var result = category.Delete("Categories/" + id);
            if (result)
            {
                var win = new Accueil();
                win.Show();
                this.Hide();
            }
        }

        private void new_client(object sender, RoutedEventArgs e)
        {
            var win = new AddClient();
            win.Show();
            this.Hide();
        }

        private void edit_client(object sender, RoutedEventArgs e)
        {
            ClientViewModel cvm = (ClientViewModel)clientList.SelectedItem;
            var win = new UpdateClient(cvm.Deserialize());
            win.Show();
            this.Hide();
        }

        private void delete_client(object sender, RoutedEventArgs e)
        {
            ClientViewModel _client = (ClientViewModel)clientList.SelectedItem;
            Clients client = _client.Deserialize();
            var result = client.Delete("Clients/" + _client.Id);
            if (result)
            {
                var win = new Accueil();
                win.Show();
                this.Hide();
            }
        }

        private void new_fournisseur(object sender, RoutedEventArgs e)
        {
            var win = new AddFournisseur();
            win.Show();
            this.Hide();
        }

        private void edit_fournisseur(object sender, RoutedEventArgs e)
        {
            Fournisseurs fournisseurs = (Fournisseurs)fournisseursList.SelectedItem;
            var win = new UpdateFournisseur(fournisseurs);
            win.Show();
            this.Hide();
        }

        private void delete_fournisseur(object sender, RoutedEventArgs e)
        {
            Fournisseurs fournisseurs = (Fournisseurs)fournisseursList.SelectedItem;
            int id = fournisseurs.Id;
            var result = fournisseurs.Delete("Fournisseurs/" + id);
            if (result)
            {
                var win = new Accueil();
                win.Show();
                this.Hide();
            }
        }
    }
}

