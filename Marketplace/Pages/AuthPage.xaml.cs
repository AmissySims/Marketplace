using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void AuthBt_Click(object sender, RoutedEventArgs e)
        {

            var login = LoginTb.Text;
            var password = PasswordTb.Text;
            var user = App.db.User.FirstOrDefault(us => us.Login == login && us.Password == password);
            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Login is null");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is null");
                return;
            }
            if (user == null)
            {
                MessageBox.Show("Incorrect");

            }
            else
            {
                MessageBox.Show("Enter");
                NavigationService.Navigate(new MainPage());
            }
               
        }

      
        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
    }
}
