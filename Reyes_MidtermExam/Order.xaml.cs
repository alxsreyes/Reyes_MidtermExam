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
using System.Xml.Schema;

namespace Reyes_MidtermExam
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        MidtermExamEntities MidtermExamEntities = new MidtermExamEntities();
        int total = 0;
        
        public Order()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            date.Text = DateTime.Now.ToString("dd MMMM,yyyy");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMain = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMain.Show();
        }

        private void HM_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Hamburger . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 30\n");
            total += 30;
            Total.Text = total.ToString();
        }

        private void FF_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("French Fries  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 60\n");
            total += 60;
            Total.Text = total.ToString();
        }

        private void SP_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Spaghetti  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 50\n");
            total += 50;
            Total.Text = total.ToString();
        }

        private void SD_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Sundae  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 25\n");
            total += 25;
            Total.Text = total.ToString();
        }

        private void FN_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Fanta  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 40\n");
            total += 40;
            Total.Text = total.ToString();
        }

        private void CF_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Chicken Fillet  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 50\n");
            total += 50;
            Total.Text = total.ToString();
        }

        private void BQ_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Barbecue . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 25\n");
            total += 25;
            Total.Text = total.ToString();
        }

        private void RC_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Rice  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 15\n");
            total += 15;
            Total.Text = total.ToString();
        }

        private void SH_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Shake . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 60\n");
            total += 60;
            Total.Text = total.ToString();
        }

        private void PS_Click(object sender, RoutedEventArgs e)
        {
            OrdList.AppendText("Pork Sisig  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 50\n");
            total += 50;
            Total.Text = total.ToString();
        }
        
    }
}
