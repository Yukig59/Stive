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
    /// Logique d'interaction pour UpdateCategory.xaml
    /// </summary>
    public partial class UpdateCategory : Window
    {
        private int? Id;
        private string? label;
        public UpdateCategory(Categories category)
        {
            InitializeComponent();
            this.Id = category.Id;
            this.label = category.Label;

        }

        private void Button_valider_Click(object sender, RoutedEventArgs e)
        {
            Categories category = new Categories();
            if (!string.IsNullOrEmpty(labelInput.Text))
            {
                this.label = labelInput.Text;
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur valide"); 
            }

            try
            {
                category.Id = (int)Id;
                category.Label = labelInput.Text;
                var result = category.Update("Categories", category);
                if (result)
                {
                    Home home = new Home();
                    home.Show();
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
            var win = new Home();
            win.Show();
            this.Close();
        }
    }
}

