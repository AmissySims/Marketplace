using Marketplace.Models;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        Product contextProduct;
        DbPropertyValues oldValues;
        public AddProductPage(Product product)
        {
            InitializeComponent();
            CbProviders.ItemsSource = App.db.Provider.ToList();
            CbType.ItemsSource = App.db.TypeProduct.ToList();
            contextProduct = product;
            DataContext = contextProduct;
            if (contextProduct.Id != 0)
            {
                oldValues = App.db.Entry(contextProduct).CurrentValues.Clone();
            }
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contextProduct.Title))
            {
                MessageBox.Show("title is null");
                return;
            }
            if (string.IsNullOrEmpty(contextProduct.Description))
            {
                MessageBox.Show("description is null");
                return;
            }
            if (string.IsNullOrEmpty(Convert.ToString(contextProduct.Price)))
            {
                MessageBox.Show("price is null");
                return;
            }
            if (string.IsNullOrEmpty(Convert.ToString(contextProduct.Count)))
            {
                MessageBox.Show("count is null");
                return;
            }
            if (contextProduct.Provider == null)
            {
                MessageBox.Show("is null provider");
                return;

            }
            if (contextProduct.TypeProduct == null)
            {
                MessageBox.Show("is null type");
                return;
            }
            else
            {
                if (contextProduct.Id == 0)
                {
                    App.db.Product.Add(contextProduct);
                }

            }
            App.db.SaveChanges();
            MessageBox.Show("save");
            NavigationService.GoBack();
        }

        private void CancelBt_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
            {
                App.db.Entry(contextProduct).CurrentValues.SetValues(oldValues);
               
            }
            NavigationService.GoBack();
        }

        private void PriceTb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if(!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void CountTb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
