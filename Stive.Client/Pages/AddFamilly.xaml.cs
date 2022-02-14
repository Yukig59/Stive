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
    /// Logique d'interaction pour AddCategory.xaml
    /// </summary>
    public partial class AddFamilly : Window
    {
        public AddFamilly()
        {
            InitializeComponent();

        }

        private void Button_valider_Click(object sender, RoutedEventArgs e)
        {
            Family category = new Family();
            if (!string.IsNullOrEmpty(labelInput.Text))
            {
                category.Label = labelInput.Text;
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur valide"); 
            }

            try
            {
                var result = category.Create("Categories");
                if (result)
                {
                    Accueil accueil = new Accueil();
                    accueil.Show();
                    this.Hide();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void Button_annuler_Click(object sender, RoutedEventArgs e)
        {
            var win = new Accueil();
            win.Show();
            this.Close();
        }
    }
}

