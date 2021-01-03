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
    /// Interaction logic for Lose.xaml
    /// </summary>
    public partial class Lose : Page
    {
        ZTPContext context;
        int result;
        public Lose(ZTPContext context, int result)
        {
            InitializeComponent();
            this.context = context;
            this.result = result;
            Res.Content = "Twój Wynik: " + result.ToString();

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Wyniki wyn = new Wyniki();
            wyn.result = result;
            if (text.Text != "")
                wyn.nick = text.Text;
            else
                wyn.nick = "Noname";
            context.Wyniki.Add(wyn);
            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new MenuPage());
        }
        private void Nick(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }

    }
}
