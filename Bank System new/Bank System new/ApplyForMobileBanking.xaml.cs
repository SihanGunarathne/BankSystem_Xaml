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
    /// Interaction logic for ApplyForMobileBanking.xaml
    /// </summary>
    public partial class ApplyForMobileBanking : Page
    {
        public ApplyForMobileBanking()
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
            ApplyForMobileBanking Apply_ForMobile_Banking = new ApplyForMobileBanking();
            this.NavigationService.Navigate(Apply_ForMobile_Banking);

        }
    }
}
