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
    /// Logique d'interaction pour UpdateClient.xaml
    /// </summary>
    public partial class UpdateClient : Window
    {
        List<Roles> roles { get; set; }
        public UpdateClient(Clients client)
        {

            InitializeComponent();

            var _role = new Roles();
            roles = _role.Get("Roles");
            roleSelector.DataContext = _role;
            roleSelector.ItemsSource = roles;
            nameInput.Text = client.Nom;
            surnameInput.Text = client.Prenom;
            emailInput.Text = client.Email;
            password.Password = client.Password;
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
                client.RoleId = roleSelector.SelectedIndex;
            }
            #endregion
            try
            {
                var result = client.Update("Clients", client);
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