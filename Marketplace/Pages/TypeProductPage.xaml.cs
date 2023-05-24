using Marketplace.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
                MessageBox.Show("Choice!");
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
