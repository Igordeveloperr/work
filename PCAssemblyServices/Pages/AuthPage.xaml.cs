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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string password = TextBoxPassword.Password.Trim();

            if (login == "")
            {
                TextBoxLogin.ToolTip = "Неккоректный ввод!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            if (password == "")
            {
                TextBoxPassword.ToolTip = "Неккоректный ввод!";
                TextBoxPassword.Background = Brushes.DarkRed;
            }

            if (login == "admin" && password == "admin")
            {
                MainWindow.mn.nav.NavigationService.Navigate(new AccountPage());
            }
            
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new RegPage());
        }
    }
}
