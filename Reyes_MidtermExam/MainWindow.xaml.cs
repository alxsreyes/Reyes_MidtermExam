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

namespace Reyes_MidtermExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void b_order_Click(object sender, RoutedEventArgs e)
        {
            Order objOrder = new Order();
            this.Visibility = Visibility.Hidden;
            objOrder.Show();
        }

        private void b_sales_Click(object sender, RoutedEventArgs e)
        {
            Sale objSales = new Sale();
            this.Visibility = Visibility.Hidden;
            objSales.Show();
        }

        private void b_inventtory_Click(object sender, RoutedEventArgs e)
        {
            Products objProducts = new Products();
            this.Visibility = Visibility.Hidden;
            objProducts.Show();
        }
    }
}
