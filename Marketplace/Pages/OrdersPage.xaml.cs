using System.Linq;
using System.Windows.Controls;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            ListOrders.ItemsSource = App.db.Order.ToList();
        }
    }
}
