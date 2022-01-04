using Microsoft.Win32;
using Stive.Client.Data.Models;
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

namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour UpdateArticle.xaml
    /// </summary>
    public partial class UpdateArticle : Window
    {
        public UpdateArticle(Articles article)
        {
            InitializeComponent();
            designation.Text = article.Designation;
            catgorySelector.SelectedIndex = (int)article.Cat_Id;
            fournisseurSelector.SelectedIndex = (int)article.Fournisseur_Id;
            description.Text = article.Description;
            prix.Text = article.Prix.ToString();
            tva.Text = article.Tva.ToString();

        }
        private void imgChoice(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Souhaitez vous uploader une image depuis internet ?", "Source de l'image", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    mediaInput mediabox = new mediaInput();
                    mediabox.ShowDialog();
                    if (mediabox.DialogResult == true)
                    {
                        mediaPicker.Content = mediabox.Url;
                    }
                    break;
                case MessageBoxResult.No:
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == true)
                    {
                        mediaPicker.Content = openFileDialog.FileName;
                    }
                    break;
            }
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            Articles article = new Articles();

            #region data validation
            if (!string.IsNullOrEmpty(description.Text))
            {
                article.Description = description.Text;
            }
            else
            {
                MessageBox.Show("La description n'est pas renseignée");
            }
            if (!string.IsNullOrEmpty(designation.Text))
            {
                article.Designation = designation.Text;
            }
            else
            {
                MessageBox.Show("La désignation n'est pas renseignée");
            }
            if (!string.IsNullOrWhiteSpace(prix.Text))
            {
                article.Prix = float.Parse(prix.Text);
            }
            else
            {
                MessageBox.Show("Le prix n'est pas renseigné");
            }
            if (!string.IsNullOrWhiteSpace(tva.Text))
            {
                article.Tva = float.Parse(tva.Text);
            }
            else
            {
                MessageBox.Show("La TVA n'est pas renseignée");
            }
            if (mediaPicker.Content.ToString() != "Ajouter une image")
            {
                article.Media_Path = mediaPicker.Content.ToString();
            }
            if (catgorySelector.SelectedIndex != -1)
            {
                article.Cat_Id = catgorySelector.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Veuillez choisir une catégorie");
            }
            if (fournisseurSelector.SelectedIndex != -1)
            {
                article.Fournisseur_Id = fournisseurSelector.SelectedIndex;

            }
            else
            {
                MessageBox.Show("Veuillez choisir un fournisseur");
            }
            #endregion


            var result = article.Update(article.Id);
            if (result)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
    }
}
