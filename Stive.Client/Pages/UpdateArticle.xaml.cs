using Microsoft.Win32;
using Stive.Client.Data.Models;
using System.Windows;


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
            var _categories = new Family();
            var categories = _categories.Get("Categories");
            catgorySelector.DataContext = _categories;
            catgorySelector.ItemsSource = categories;
            var _fournisseur = new Fournisseurs();
            var fournisseurs = _fournisseur.Get("Fournisseurs");
            fournisseurSelector.DataContext = _fournisseur;
            fournisseurSelector.ItemsSource = fournisseurs;



            designation.Text = article.Designation;
            catgorySelector.SelectedValue = article.CategorieId;
            fournisseurSelector.SelectedValue = article.FournisseurId;
            description.Text = article.Description;
            prix.Text = article.Prix.ToString();
            tva.Text = article.Tva.ToString();
            mediaPicker.Content = article.MediaPath;

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
                article.MediaPath = mediaPicker.Content.ToString();
            }
            if (catgorySelector.SelectedIndex != -1)
            {
                article.CategorieId = catgorySelector.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Veuillez choisir une catégorie");
            }
            if (fournisseurSelector.SelectedIndex != -1)
            {
                article.FournisseurId = fournisseurSelector.SelectedIndex;

            }
            else
            {
                MessageBox.Show("Veuillez choisir un fournisseur");
            }
            #endregion


            var result = article.Update("Articles", article);
            if (result)
            {
                Accueil accueil = new Accueil();
                accueil.Show();
                this.Hide();
            }
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            var win = new Accueil();
            win.Show();
            this.Close();
        }
    }
}
