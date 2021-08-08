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


namespace Bank_System_new
{
    /// <summary>
    /// Interaction logic for ApplyForCards.xaml
    /// </summary>
    public partial class ApplyForCards : Page
    {
        public ApplyForCards()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainpage main_page = new mainpage();
            this.NavigationService.Navigate(main_page);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submited your results successfully");
            ApplyForCards Apply_For_Cards = new ApplyForCards();
            this.NavigationService.Navigate(Apply_For_Cards);

        }
    }
}
