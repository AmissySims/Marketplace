using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Marketplace.Models;
using Marketplace.Pages;
namespace Marketplace.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void AuthBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void RegBt_Click(object sender, RoutedEventArgs e)
        {
            var check = App.db.User.FirstOrDefault(x => x.Login == LoginTb.Text);
            if (string.IsNullOrWhiteSpace(NameTb.Text.Trim()))
            {
                MessageBox.Show("Name is null");
                return;
            }
            if (string.IsNullOrWhiteSpace(LoginTb.Text.Trim()))
            {
                MessageBox.Show("Login is null");
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordTb.Text.Trim()))
            {
                MessageBox.Show("Password is null");
                return;
            }
            if (string.IsNullOrWhiteSpace(FNameTb.Text.Trim()))
            {
                MessageBox.Show("First name is null");
                return;
            }
            if (string.IsNullOrWhiteSpace(MiddleNameTb.Text.Trim()))
            {
                MessageBox.Show("Middle name is null");
                return;
            }
            if(check == null)
            {

                User user = new User
                {
                    Name = NameTb.Text,
                    Password = PasswordTb.Text,
                    FName = FNameTb.Text,
                    RoleId = 3,
                    MiddleName = MiddleNameTb.Text,
                    Login = LoginTb.Text
                };
                App.db.User.Add(user);
                App.db.SaveChanges();
                MessageBox.Show("Registration is done");
            }
            else
            {
                MessageBox.Show("User is exists");
                return; 
            }
            

        }
    }
}
