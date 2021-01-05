using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZTPProject
{
    /// <summary>
    /// Interaction logic for Shop1.xaml
    /// </summary>
    public partial class Shop1 : Page
    {
        ZTPContext context;
        double result;
        DBConnection connection;
        public Shop1(DBConnection connection, double result)
        {
            InitializeComponent();
            if (connection.GetContext() == null)
                connection.CreateContext();
            this.connection = connection;
            this.context = connection.GetContext();
            this.result = result;
            Res.Content = "Twój Wynik: " + result.ToString();
      

        }

    

        private void Save(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new MenuPage());
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Game(connection));
        }

        private void Dmg(object sender, RoutedEventArgs e)
        {

        }

        private void DmgProcent(object sender, RoutedEventArgs e)
        {

        }

        private void Money(object sender, RoutedEventArgs e)
        {

        }
    }
}
