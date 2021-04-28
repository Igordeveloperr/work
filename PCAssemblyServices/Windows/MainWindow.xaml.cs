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
using PCAssemblyServices.Model;
using PCAssemblyServices.Model.account;
using PCAssemblyServices.Model.dataBase;
using PCAssemblyServices.Pages;

namespace PCAssemblyServices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mn;
        public MainWindow()
        {
            InitializeComponent();
            mn = this;
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            nav.NavigationService.Navigate(new AuthPage());
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            nav.NavigationService.Navigate(new RegPage());
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
