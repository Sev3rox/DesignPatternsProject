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
        int result;
      
        public Shop1(ZTPContext context, int result)
        {
            InitializeComponent();
            this.context = context;
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
            nav.Navigate(new Game());
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
