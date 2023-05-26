using System.Windows;
using System.Windows.Controls;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ProductBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame2.Navigate(new ProductPage());
        }

        private void OrdersBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame2.Navigate(new OrdersPage());
        }

        private void ProvidersBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame2.Navigate(new ProviderPage());
        }

        private void TypesBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame2.Navigate(new TypeProductPage());
        }

        private void StattBt_Click(object sender, RoutedEventArgs e)
        {
            MainFrame2.Navigate(new StatisticPage());
        }
    }
}
