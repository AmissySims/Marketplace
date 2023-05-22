using Marketplace.Models;
using System.Data.Entity.Infrastructure;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditProviderPage.xaml
    /// </summary>
    public partial class AddEditProviderPage : Page
    {
        Provider contextProvider;
        DbPropertyValues oldValues;
        public AddEditProviderPage(Provider provider)
        {
            InitializeComponent();
            contextProvider = provider;
            DataContext = contextProvider;
            if (contextProvider.Id != 0)
            {
                oldValues = App.db.Entry(contextProvider).CurrentValues.Clone();
            }
        }

        private void SaveTb_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(contextProvider.Title))
            {
                MessageBox.Show("title is null");
                return;
            }
            if (string.IsNullOrEmpty(contextProvider.Adress))
            {
                MessageBox.Show("adress is null");
                return;
            }

            if (contextProvider.Id == 0)
            {
                App.db.Provider.Add(contextProvider);
            }
            App.db.SaveChanges();
            MessageBox.Show("save");
            NavigationService.GoBack();

        }


        private void CancelTb_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
            {
                App.db.Entry(contextProvider).CurrentValues.SetValues(oldValues);

            }
            NavigationService.GoBack();
        }
    }
}
