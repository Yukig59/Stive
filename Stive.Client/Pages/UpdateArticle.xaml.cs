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
    }
}
