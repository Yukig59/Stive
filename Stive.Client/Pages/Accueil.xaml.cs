﻿using Stive.Client.Data.Models;
using Stive.Client.Data.ViewModels;
using Stive.Client.Services;
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
            var _articles = new Articles();
            List<Articles> articles = _articles.Get("Articles");
            List<ArticleViewModel> articlevm = new List<ArticleViewModel>();
            if(articles != null)
            {
                foreach (var article in articles)
                {
                    articlevm.Add(new ArticleViewModel(article));
                }
            }
            else
            {
                MessageBox.Show("Il n'y a pas d'articles !");
            }
            articlesList.ItemsSource = articlevm;
            articlesList.DataContext = _articles;
            #endregion

            #region Clients
            var _clients = new Clients();
            List<Clients> clients = _clients.Get("Clients");
            List<ClientViewModel> clientvm = new List<ClientViewModel>();
            if (clients != null)
            {
                foreach (var client in clients)
                {
                    clientvm.Add(new ClientViewModel(client));
                }
            }
            else
            {
                MessageBox.Show("Il n'y a pas de clients !");
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
            
            List<Family> categories = _cat.Get("Categories");
            categoryList.DataContext = _cat;
            categoryList.ItemsSource = categories;
            #endregion

            #region Stocks
            var _stocks = new Stock();
            List<Stock> stocks = _stocks.Get("Stocks");
            List<StockViewModel> stockvm = new List<StockViewModel>();
            if(stocks != null)
            {
                foreach(var stock in stocks)
                {
                    stockvm.Add(new StockViewModel(stock));
                }
            }
            else
            {
                MessageBox.Show("Il n'y a pas de stocks !");
            }
            stocksList.DataContext = _stocks;
            stocksList.ItemsSource = stockvm;
            #endregion
            #region Restock
            RestockViewModel restock = new RestockViewModel();
            lowStockList.ItemsSource = restock.GetRestockablesItems();
            lowStockList.DataContext = _stocks;
            #endregion

            //  if (false)
            //{
            //   AutoOrderService serv = new AutoOrderService();
            //serv.DoAutoOrder();
            //}
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
            Articles article = new Articles();
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

        private void new_stock(object sender, RoutedEventArgs e)
        {
            AddStocks win = new AddStocks();
            win.Show();
            this.Hide();

        }

        private void edit_stock(object sender, RoutedEventArgs e)
        {
            StockViewModel stockvm = (StockViewModel)stocksList.SelectedItem;
            UpdateStocks win = new UpdateStocks(stockvm.Deserialize());
            win.Show();
            Hide();
        }

        private void delete_stock(object sender, RoutedEventArgs e)
        {
            StockViewModel _stock = (StockViewModel)stocksList.SelectedItem;
            Stock stock = _stock.Deserialize();
            var result = stock.Delete("Stocks/" + _stock.Id);
            if (result)
            {
                var win = new Accueil();
                win.Show();
                this.Hide();
            }

        }

        private void restock(object sender, RoutedEventArgs e)
        {
            var service = new OrderService();
            service.DoAutoOrder();
            Accueil accueil = new Accueil();
            accueil.Show();
            Hide();
        }
       
        private void destock(object sender, RoutedEventArgs e)
        {
            var service = new OrderService();
            service.RecieveOrder();
            Accueil accueil = new Accueil();
            accueil.Show();
            Hide();
        }
    }
}

