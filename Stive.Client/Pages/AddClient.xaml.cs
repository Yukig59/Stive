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
    /// Logique d'interaction pour AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        List<Roles> roles { get; set; }
        public AddClient()
        {
            InitializeComponent();

            var _role = new Roles();
            roles = _role.Get("Roles");
            roleSelector.DataContext = _role;
            roleSelector.ItemsSource = roles;
        }

        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {
            Clients client = new Clients();

            #region Data validation
            if (!string.IsNullOrEmpty(nameInput.Text))
            {
                client.Nom = nameInput.Text;
            }
            else
            {
                MessageBox.Show("Le nom n'est pas renseigné");
            } if (!string.IsNullOrEmpty(surnameInput.Text))
            {
                client.Prenom = surnameInput.Text;
            }
            else
            {
                MessageBox.Show("Le prénom n'est pas renseigné");
            } if (!string.IsNullOrEmpty(emailInput.Text))
            {
                client.Email = emailInput.Text;
            }
            else
            {
                MessageBox.Show("Le mail n'est pas renseigné");
            } if (!string.IsNullOrEmpty(password.Password))
            {
                client.Password = password.Password;
            }
            else
            {
                MessageBox.Show("Le mot de passe n'est pas renseigné");
            } if (roleSelector.SelectedIndex != -1)
            {
                Roles role = (Roles)roleSelector.SelectedItem;
                client.RoleId = role.Id;
            }
            #endregion
            try
            {
                var result = client.Create("Clients");
                if (result != false)
                {
                    Accueil accueil = new Accueil();
                    accueil.Show();
                    this.Hide();
                }
            } catch (Exception)
            {
                throw;
            }


        }

        private void btn_annuler_Click(object sender, RoutedEventArgs e)
        {
            var win = new Accueil();
            win.Show();
            this.Close();
        }
    }
}