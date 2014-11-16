using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace BeautifulQuotes
{
    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.RemoveBackEntry() != null)
                {
                    NavigationService.RemoveBackEntry();
                }
            }
            }
        
        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask();
            task.To = "selcouth@outlook.com";
            task.Subject = "Quotes Garden v 1.0 Feedback";
            task.Show();
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            MarketplaceReviewTask task = new MarketplaceReviewTask();
            task.Show();
        }

        private void ApplicationBarMenuItem_Click_3(object sender, EventArgs e)
        {
            MarketplaceSearchTask task = new MarketplaceSearchTask();
            task.SearchTerms = "Akshayjain";
            task.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BeautifulQuotes;component/Pages/Quotes.xaml", UriKind.Relative));
        }

        private void themeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BeautifulQuotes;component/Pages/About.xaml", UriKind.Relative));
        }

        
    }
}