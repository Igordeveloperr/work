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

namespace PCAssemblyServices.Pages
{
    /// <summary>
    /// Логика взаимодействия для AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Page
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void catalog_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new UserPage());
        }

        private void shoppingcart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void assemblies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new AuthPage());
        }
    }
}
