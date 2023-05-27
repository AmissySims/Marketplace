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
            FilterCb.Items.Add("all");
            FilterCb.Items.Add("0-500");
            FilterCb.Items.Add(" от 500 до 2000");
            FilterCb.Items.Add("от 2000");

            SortCb.Items.Add("all");
            SortCb.Items.Add("price min");
            SortCb.Items.Add("price max");

            var providers = App.db.Provider.ToList();
            providers.Insert(0, new Provider() { Title = "all"});
            ProviderCb.ItemsSource = providers;

        
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage(new Product()));
        }
        public void Refresh()
        {
            var search = FoundTb.Text.ToLower();
            var selProv = ProviderCb.SelectedItem as Provider;
            var products = App.db.Product.ToList();

            if (!string.IsNullOrEmpty(search))
                products = App.db.Product.Where(p => p.Title.ToLower().Contains(search) ||
                                            p.Description.ToLower().Contains(search) || 
                                            p.TypeProduct.Title.ToLower().Contains(search)).ToList();
         
            if (FilterCb.SelectedIndex == 1)
            {
                products = products.Where(p => p.Price < 500).ToList();
            }
            if (FilterCb.SelectedIndex == 2)
            {
                products = products.Where(p => p.Price >= 500 && p.Price <2000).ToList();
            }
            if (FilterCb.SelectedIndex == 3)
            {
                products = products.Where(p => p.Price >= 2000).ToList();
            }

            if (SortCb.SelectedIndex == 1)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            if (SortCb.SelectedIndex == 2)
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }

            if(selProv !=  null && selProv.Id != 0)
            {
                products = products.Where(p => p.ProviderId == selProv.Id).ToList();
            }

         


            ProductGD.ItemsSource = products;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
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

        private void FoundTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void FilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void ProviderCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
