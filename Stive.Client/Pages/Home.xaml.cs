using System.Collections.Generic;
using System.Windows;
using Stive.Client.Data.Models;
using Stive.Client.Data.ViewModels;

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
            var _roles = new Roles();
            var _cat = new Categories();
           InitializeComponent();

            List<Articles> articles = _articles.Get("Articles");
            List<Clients> clients = _clients.Get("Clients");
            List<ClientViewModel> clientvm = new List<ClientViewModel>();
            foreach (var client in clients)
            {
                clientvm.Add(new ClientViewModel(client));
            }
            List<Categories> categories = _cat.Get("Categories");
            List<Fournisseurs> fournisseurs = _fournisseurs.Get("Fournisseurs");
            List<Roles> roles = _roles.Get("Roles");
            clientList.DataContext = _clients ;
            fournisseursList.DataContext = _fournisseurs;
            clientList.ItemsSource = clientvm;
            fournisseursList.ItemsSource = fournisseurs;
            articlesList.ItemsSource = articles;
            categoryList.ItemsSource = categories;
            roleList.ItemsSource = roles;
        }


        private void btn_new_article_Click(object sender, RoutedEventArgs e)
        {
            var win = new Pages.AddArticle();
            win.ShowDialog();
            this.Hide();
        }

        private void btn_edit_article_Click(object sender, RoutedEventArgs e)
        {
            Articles article = (Articles)articlesList.SelectedItem;
            var win = new UpdateArticle(article);
            win.ShowDialog();
            this.Hide();
        }

        private void btn_del_article_Click(object sender, RoutedEventArgs e)
        {
            Articles article = new Articles();
            Articles item = (Articles)articlesList.SelectedItem;
            int id = item.Id;
            var result = article.Delete("Articles/"+id);
            if (result)
            {
                var win = new Home();
                win.Show();
                this.Hide();
            }
        }

        private void btn_new_category_Click(object sender, RoutedEventArgs e)
        {
            var win = new AddCategory();
            win.Show();
            this.Hide();
          
        }

        private void btn_edit_category_Click(object sender, RoutedEventArgs e)
        {
            Categories cat = (Categories)categoryList.SelectedItem;

            var win = new UpdateCategory(cat);
            win.Show();
            this.Hide();
        }

        private void btn_del_category_Click(object sender, RoutedEventArgs e)
        {
            Categories category = new Categories();
            Categories item = (Categories)categoryList.SelectedItem;
            int id = item.Id;
            var result = category.Delete("Categories/" + id);
            if (result)
            {
                var win = new Home();
                win.Show();
                this.Hide();
            }
        }

        private void btn_new_fournisseur_Click(object sender, RoutedEventArgs e)
        {
            var win = new AddFournisseur();
            win.Show();
            this.Hide();
        }

        private void btn_edit_fournisseur_Click(object sender, RoutedEventArgs e)
        {
            Fournisseurs fournisseurs = (Fournisseurs)fournisseursList.SelectedItem;
            var win = new UpdateFournisseur(fournisseurs);
            win.Show();
            this.Hide();
        }

        private void btn_del_fournisseur_Click(object sender, RoutedEventArgs e)
        {
            Fournisseurs fournisseurs = (Fournisseurs)fournisseursList.SelectedItem;
            int id = fournisseurs.Id;
            var result = fournisseurs.Delete("Fournisseurs/" + id);
            if (result)
            {
                var win = new Home();
                win.Show();
                this.Hide();
            }
        }

        private void btn_new_client_Click(object sender, RoutedEventArgs e)
        {
            var win = new AddClient();
            win.Show();
            this.Hide();
        }

        private void btn_edit_client_Click(object sender, RoutedEventArgs e)
        {
            ClientViewModel cvm = (ClientViewModel)clientList.SelectedItem;
            var win = new UpdateClient(cvm.Deserialize());
            win.Show();
            this.Hide();
        }

        private void btn_del_client_Click(object sender, RoutedEventArgs e)
        {
            ClientViewModel _client = (ClientViewModel)clientList.SelectedItem;
            Clients client = _client.Deserialize();
            var result = client.Delete("Clients/" + _client.Id);
            if (result)
            {
                var win = new Home();
                win.Show();
                this.Hide();
            }
        }

        private void btn_new_role_Click(object sender, RoutedEventArgs e)
        {
            var win = new AddRole();
            win.Show();
            this.Hide();
        }
    }
}