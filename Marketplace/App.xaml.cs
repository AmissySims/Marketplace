using Marketplace.Models;
using System.Windows;

namespace Marketplace
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MarketplacePractikEntities db = new MarketplacePractikEntities();
    }
}
