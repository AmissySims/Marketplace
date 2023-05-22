using Marketplace.Pages;
using System.Windows;

namespace Marketplace
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new AuthPage());
        }

        private void BtnFff_Click(object sender, RoutedEventArgs e)
        {
            #region button
            // try
            // {
            //     var search = Convert.ToInt32(TbSearch.Text);
            //     var user = App.db.User.FirstOrDefault(us => us.Id == search);
            //     if (user == null)
            //     {
            //         MessageBox.Show("Not found");
            //     }
            //     else
            //     {
            //         MessageBox.Show(user.Name);
            //     }
            // }
            //catch(ArgumentException ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }
            // catch (FormatException Eex)
            // {
            //     MessageBox.Show("Incorrect data");
            // }
            // catch (Exception EWex)
            // {
            //     MessageBox.Show("Error");
            // }
            // finally
            // {
            //     MessageBox.Show("Good");
            // } 
            #endregion
        }


    }
}
