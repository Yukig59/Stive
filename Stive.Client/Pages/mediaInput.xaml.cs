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
    /// Logique d'interaction pour mediaInput.xaml
    /// </summary>
    public partial class mediaInput : Window
    {
        public string? Url { get; set; }
        public mediaInput()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var url = urlInput.Text;
            this.Url = url;
            DialogResult = true;
            this.Hide();
        }

        private void Button_annuler_Click(object sender, RoutedEventArgs e)
        {
            var win = new Home();
            win.Show();
            this.Close();
        }
    }
}
