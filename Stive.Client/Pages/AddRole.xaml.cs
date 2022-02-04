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
    /// Logique d'interaction pour AddRole.xaml
    /// </summary>
    public partial class AddRole : Window
    {
        public AddRole()
        {
            InitializeComponent();

        }

        private void Button_valider_Click(object sender, RoutedEventArgs e)
        {
            Roles role = new Roles();
            if (!string.IsNullOrEmpty(labelInput.Text))
            {
                role.Name = labelInput.Text;
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur valide"); 
            }

            try
            {
                var result = role.Create("Roles");
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

