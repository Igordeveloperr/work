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
using PCAssemblyServices.Pages.Accessories;

namespace PCAssemblyServices.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void procc_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new ProccForUser());
        }

        private void ram_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new RamForUser());
        }

        private void motherboard_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new MotherboardForUser());
        }

        private void videoadapter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new VideoadapterForUser());
        }

        private void cooler_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new CoolerForUser());
        }

        private void hdd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new HddForUser());
        }

        private void sdd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new SsdForUser());
        }

        private void powersupply_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new PowerSupplyForUser());
        }

        private void case_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new CaseForUser());
        }

        private void useraccount_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new AccountPage());
        }
    }
}
