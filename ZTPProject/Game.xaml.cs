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
using System.Windows.Threading;

namespace ZTPProject
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        private DispatcherTimer aTimer = new DispatcherTimer();
        private DispatcherTimer bTimer = new DispatcherTimer();
        private DispatcherTimer cTimer = new DispatcherTimer();
        private short mov;
        private Image ima1;
        private List<IShot> list = new List<IShot>();
        private int cooldown = 0;
        private List<Image> self = new List<Image>();
        private EnemyList enemys;
        private Player player = new PlayerSpaceShip();
        public Game()
        {
            InitializeComponent();
            //snake = new Snakee(x, y);
            SetTimer();
            SetTimer2();
            ima1 = new Image
            {

            };
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/Files/MYship.png", UriKind.Relative);
            bi1.EndInit();
            ima1.Source = bi1;
            canvas.Children.Add(ima1);
            Canvas.SetLeft(ima1, 200);
            Canvas.SetTop(ima1, 300);
            Loaded += (xx, yy) => Keyboard.Focus(grid);
        }
        private void SetTimer()
        {
            aTimer.Tick += OnTimedEvent;
        }
        private void SetTimer2()
        {
            bTimer.Tick += OnTimedEvent2;
            bTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            bTimer.Start();
        }
        private void SetTimer3()
        {
            cTimer.Tick += OnTimedEvent2;
            cTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            cTimer.Start();
        }
        private async void startTimer()
        {
            if (aTimer.IsEnabled == false) { aTimer.Interval = new TimeSpan(0); aTimer.Start(); }
        }
        private async void stopTimer()
        {
            if (aTimer.IsEnabled == true) aTimer.Stop();
        }
        public async void OnTimedEvent(Object source, EventArgs e)
        {
            aTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            Canvas.SetLeft(ima1, Canvas.GetLeft(ima1) + 25 * mov);
        }
        public async void OnTimedEvent2(Object source, EventArgs e)
        {
            if (cooldown > 0) cooldown--;
            foreach (Image im in self)
            { Canvas.SetTop(im, Canvas.GetTop(im) + 1); labe.Content = Canvas.GetTop(im) - 1; }
        }
        public async void OnTimedEvent3(Object source, EventArgs e)
        {
        
        }
        private async void KeyEvent(object sender, System.Windows.Input.KeyEventArgs e)
        {

            Keyboard.Focus(grid);
            switch (e.Key)
            {
                case Key.Left:
                    mov = -1;
                    startTimer();
                    //labe.Content = mov;
                    break;
                case Key.Right:
                    mov = 1;
                    startTimer();
                    //labe.Content = mov;
                    break;
                case Key.Up:

                    if (cooldown == 0)
                    {//labe.Content = cooldown;
                        Image ima = new Image
                        {

                        };
                        BitmapImage bi1 = new BitmapImage();
                        bi1.BeginInit();
                        bi1.UriSource = new Uri("/Files/MYship.png", UriKind.Relative);
                        bi1.EndInit();
                        ima.Source = bi1;
                        canvas.Children.Add(ima);
                        Canvas.SetLeft(ima, Canvas.GetLeft(ima1) + 60);
                        Canvas.SetTop(ima, Canvas.GetTop(ima1) - 100);
                        self.Add(ima);
                        cooldown = 100;
                    }
                    break;

            }
        }
        private async void KeyEvent2(object sender, System.Windows.Input.KeyEventArgs e)
        {
            stopTimer();
            mov = 0;
            //labe.Content = mov;
        }
     
    }
}
