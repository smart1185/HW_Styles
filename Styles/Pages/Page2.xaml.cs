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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/Page3.xaml", UriKind.Relative);
            Page3 p3 = new Page3();
            MainWindow.mf.NavigationService.Navigate(p3);
        }
        private void Button_Previous_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/Page1.xaml", UriKind.RelativeOrAbsolute);
            Page1 p = new Page1();
            MainWindow.mf.NavigationService.Navigate(p);
        }
    }
}
