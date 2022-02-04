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
using System.Windows.Shapes;

namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour AddFournisseur.xaml
    /// </summary>
    public partial class AddFournisseur : Window
    {
        public AddFournisseur()
        {
            InitializeComponent();
        }

        private void Button_valider_Click(object sender, RoutedEventArgs e)
        {
            Fournisseurs fournisseur = new Fournisseurs();
            #region Data validation
            if (!string.IsNullOrEmpty(nameInput.Text))
            {
                fournisseur.Nom = nameInput.Text;
            }
            else
            {
                MessageBox.Show("Le nom n'est pas renseignée");
            }if (!string.IsNullOrEmpty(emailInput.Text))
            {
                fournisseur.Email = emailInput.Text;
            }
            else
            {
                MessageBox.Show("Le Mail n'est pas renseignée");
            }if (!string.IsNullOrEmpty(siretInput.Text))
            {
                fournisseur.Siret = siretInput.Text;
            }
            else
            {
                MessageBox.Show("Le Siret n'est pas renseignée");
            }if (!string.IsNullOrEmpty(telInput.Text))
            {
                fournisseur.Telephone = telInput.Text;
            }
            else
            {
                MessageBox.Show("Le Siret n'est pas renseignée");
            }
            #endregion
            try
            {
                var result = fournisseur.Create("Fournisseurs");
                if (result)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                throw;
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
