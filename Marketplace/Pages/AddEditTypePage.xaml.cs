using Marketplace.Models;
using System.Data.Entity.Infrastructure;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditTypePage.xaml
    /// </summary>
    public partial class AddEditTypePage : Page
    {
        TypeProduct contextTypeProd;
        DbPropertyValues oldValues;
        public AddEditTypePage(TypeProduct typeProduct)
        {
            InitializeComponent();
            contextTypeProd = typeProduct;
            DataContext = contextTypeProd;
            if (contextTypeProd.Id != 0)
            {
                oldValues = App.db.Entry(contextTypeProd).CurrentValues.Clone();
            }
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(contextTypeProd.Title))
            {
                MessageBox.Show("title is null");
                return;
            }
            if (contextTypeProd.Id == 0)
            {
                App.db.TypeProduct.Add(contextTypeProd);
            }
            App.db.SaveChanges();
            MessageBox.Show("Save");
            NavigationService.GoBack();

        }

        private void CancelBt_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
            {
                App.db.Entry(contextTypeProd).CurrentValues.SetValues(oldValues);

            }
            NavigationService.GoBack();
        }

        private void TitleTb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if(!char.IsLetter(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
