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

namespace PCAssemblyServices.Pages.Accessories
{
    /// <summary>
    /// Логика взаимодействия для PowerSupplyForUser.xaml
    /// </summary>
    public partial class PowerSupplyForUser : Page
    {
        public PowerSupplyForUser()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mn.nav.NavigationService.GoBack();
        }
    }
}
