﻿using Marketplace.Models;
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
    /// Логика взаимодействия для ProviderPage.xaml
    /// </summary>
    public partial class ProviderPage : Page
    {
        public ProviderPage()
        {
            InitializeComponent();
           
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            var selectedProv = ListProv.SelectedItem as Provider;
            if (selectedProv == null)
            {
                MessageBox.Show("choice!");
                return;
            }
            NavigationService.Navigate(new AddEditProviderPage(selectedProv));
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditProviderPage(new Provider()));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListProv.ItemsSource = App.db.Provider.ToList();
        }
    }
}
