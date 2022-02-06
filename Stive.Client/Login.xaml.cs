﻿using System;
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
using Stive.Client.Pages;
using Stive.Client.Data.Models;
namespace Stive.Client
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
            string password = PasswordBox.PasswordCharProperty.ToString();
            string email = emailInput.Text;
            Clients client = new Clients();
            client.Password = password; 
            client.Email = email;

            if(client.Create("login") != false)
            {
                client.Create("login");
            }
        }
    }
}