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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void Button_Previous_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/Page3.xaml", UriKind.RelativeOrAbsolute);
            Page3 p3 = new Page3();
            MainWindow.mf.NavigationService.Navigate(p3);
        }
    }
}
