using Marketplace.Models;
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

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для TypeProductPage.xaml
    /// </summary>
    public partial class TypeProductPage : Page
    {
        public TypeProductPage()
        {
            InitializeComponent();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditTypePage(new TypeProduct()));
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedTypeprod = ListTypesproduct.SelectedItem as TypeProduct;
            if (selectedTypeprod == null)
            {
                MessageBox.Show("choice!");
                return;
            }
            NavigationService.Navigate(new AddEditTypePage(selectedTypeprod));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListTypesproduct.ItemsSource = App.db.TypeProduct.ToList();
        }
    }
}
