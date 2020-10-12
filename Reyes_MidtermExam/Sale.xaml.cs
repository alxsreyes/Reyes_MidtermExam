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
using System.Windows.Shapes;

namespace Reyes_MidtermExam
{
    /// <summary>
    /// Interaction logic for Sale.xaml
    /// </summary>
    public partial class Sale : Window
    {
        MidtermExamEntities MidtermExamEntities = new MidtermExamEntities();
        public Sale()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMain.Show();
        }
    }
}
