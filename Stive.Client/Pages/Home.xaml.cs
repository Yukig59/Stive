using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Stive.Client.Data.Methods;
using Stive.Client.Data.Models;

namespace Stive.Client.Pages
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM_Articles data = new VM_Articles();

            var text1 = data.Designation;
            var text2 =data.Description;
            Description.Content = text1;
            Designation.Content = text2;
            myText.Text = text1;
            myblock.Text = text2;
            //TextTest.Text = text1;
        }
    }
}
