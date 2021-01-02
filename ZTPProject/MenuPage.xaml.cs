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
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        private ZTPContext con;
        public MenuPage()
        {
            InitializeComponent();
            DBConnection connection;
            connection = DBConnection.GetInstance();
            connection.CreateContext();
            con = connection.GetContext();

            /*  int i = 1;
              for (int j = 0; j < 10; j++)
              {
                  Wyniki wyn = new Wyniki();
                  wyn.nick = "us"+i.ToString();
                  wyn.result = i;
                  con.Wyniki.Add(wyn);
                  i++;
                  con.SaveChanges();
              } */
          
        }

        private void Wyniki(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new WynikiPage(con));
        }
        private void NowaGra(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Game());
        }

        private void Wyjście(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void Continue(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
