using Marketplace.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage(new Product()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProductGD.ItemsSource = App.db.Product.ToList();
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedProd = ProductGD.SelectedItem as Product;
            if(selectedProd == null)
            {
                MessageBox.Show("Choice!");
                return;
            }
            NavigationService.Navigate(new AddProductPage(selectedProd));
        }
    }
}
