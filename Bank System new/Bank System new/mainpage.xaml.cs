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
    /// Interaction logic for mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            PersonalDetails Personal_Details = new PersonalDetails();
            this.NavigationService.Navigate(Personal_Details);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            ContactDetails Contact_Details = new ContactDetails();
            this.NavigationService.Navigate(Contact_Details);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            OpenANewAccount OpenA_NewAccount = new OpenANewAccount();
            this.NavigationService.Navigate(OpenA_NewAccount);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ApplyForLoans Apply_For_Loans = new ApplyForLoans();
            this.NavigationService.Navigate(Apply_For_Loans);

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ApplyForCards Apply_For_Cards = new ApplyForCards();
            this.NavigationService.Navigate(Apply_For_Cards);

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            ApplyForMobileBanking Apply_ForMobile_Banking = new ApplyForMobileBanking();
            this.NavigationService.Navigate(Apply_ForMobile_Banking);

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            ApplyForForeignAccount Apply_For_Foreign_Account = new ApplyForForeignAccount();
            this.NavigationService.Navigate(Apply_For_Foreign_Account);

        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            ApplyForOnlinePayments Apply_For_Online_Payments = new ApplyForOnlinePayments();
            this.NavigationService.Navigate(Apply_For_Online_Payments);

        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            ApplyForLeasing Apply_For_Leasing = new ApplyForLeasing();
            this.NavigationService.Navigate(Apply_For_Leasing);
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            MoneyTransfer Money_Transfer = new MoneyTransfer();
            this.NavigationService.Navigate(Money_Transfer);
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            InvestForRetirements Invest_For_Retirements = new InvestForRetirements();
            this.NavigationService.Navigate(Invest_For_Retirements);

        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            SuggestionsComplaints Suggestions_Complaints = new SuggestionsComplaints();
            this.NavigationService.Navigate(Suggestions_Complaints);

        }

       
    }
}
