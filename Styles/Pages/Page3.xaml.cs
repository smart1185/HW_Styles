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

namespace Styles.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/Page4.xaml", UriKind.Relative);
            Page4 p4 = new Page4();
            MainWindow.mf.NavigationService.Navigate(p4);
        }
        private void Button_Previous_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/Page2.xaml", UriKind.RelativeOrAbsolute);
            Page2 p2 = new Page2();
            MainWindow.mf.NavigationService.Navigate(p2);
        }
    }
}
