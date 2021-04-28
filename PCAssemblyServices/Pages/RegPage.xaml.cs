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
using PCAssemblyServices.Model.account;
using PCAssemblyServices.Model.dataBase;
using PCAssemblyServices.Pages;

namespace PCAssemblyServices.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string email = TextBoxEmail.Text.Trim();
            string login = TextBoxLogin.Text.Trim();
            string password = TextBoxPassword.Password.Trim();
            string repeatPassword = TextBoxRepeatPassword.Password.Trim();

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Неккоректный ввод!";
                TextBoxEmail.Background = Brushes.DarkRed;
            }
            else if (email.Length > 5 || email.Contains("@") || email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Данные корректны!";
                TextBoxEmail.Background = Brushes.Transparent;
            }
            if (login.Length < 7)
            {
                TextBoxLogin.ToolTip = "Неккоректный ввод!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if (login.Length > 7)
            {
                TextBoxLogin.ToolTip = "Данные корректны!";
                TextBoxLogin.Background = Brushes.Transparent;
            }
            if (password.Length < 8)
            {
                TextBoxPassword.ToolTip = "Слишком простой пароль!";
                TextBoxPassword.Background = Brushes.DarkRed;
            }
            else if (password.Length > 8)
            {
                TextBoxPassword.ToolTip = "Хороший пароль";
                TextBoxPassword.Background = Brushes.Transparent;
            }
            else if (password.Length > 15)
            {
                TextBoxPassword.ToolTip = "Отличный пароль";
                TextBoxPassword.Background = Brushes.Transparent;
            }
            if (password != repeatPassword)
            {
                TextBoxRepeatPassword.ToolTip = "Пароли не совпадают!";
                TextBoxRepeatPassword.Background = Brushes.DarkRed;
            }
            else if (password == repeatPassword)
            {
                TextBoxRepeatPassword.ToolTip = "Пароли совпадают";
                TextBoxRepeatPassword.Background = Brushes.Transparent;
            }
            AccountContext account = new AccountContext();
            User test = account.Users.Where(usertest=> usertest.Name == login && usertest.Password == password).FirstOrDefault();
            if (test != null)
            {
                MessageBox.Show("Вы уже зарегистрированны!");
            }
            else
            {
                User user = new User();
                user.Name = login;
                user.Password = password;
                user.SingUp();
                MainWindow.mn.nav.NavigationService.Navigate(new AccountPage());
            }
        }

        private void Button_AuthPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.Navigate(new AuthPage());
        }
    }
}
