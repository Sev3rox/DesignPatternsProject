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
        private Difficulty difficulty = new Easy();
        private EnemySpaceShip[] org=new EnemySpaceShip[5];
        private double scoreMultiplier;
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
            enemys = difficulty.enemyGenerate(org);
            player.setMoneyMultiplier(difficulty.getMoneyMultiplier());
            scoreMultiplier = difficulty.getScoreMultiplier();
            org[0] = new NormalEnemySS();
            set(org[0],1,2,3,"Enemy1");
            org[1] = new GoodEnemySS();
            set(org[1], 2, 2, 1, "Enemy2");
            org[2] = new BetterEnemySS();
            set(org[2], 3, 2, 3, "Enemy3");
            org[3] = new BestEnemySS();
            set(org[3], 4, 3, 3, "Enemy4");
            org[4] = new BestestEnemySS();
            set(org[5], 10, 30, 3, "Enemy5");
        }
        private void set(EnemySpaceShip ss,int Money,int HP, int Damage,string plik)
        {
            ss.setMoney(Money);
            ss.setHealthPoints(HP);
            ss.setDamage(Damage);
            Image ima2 = new Image
            {

            };
            BitmapImage bi2 = new BitmapImage();
            bi2.BeginInit();
            bi2.UriSource = new Uri("/ Files /"+plik, UriKind.Relative);
            bi2.EndInit();
            ima1.Source = bi2;
            ss.setImage(ima2);
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
            aTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            Canvas.SetLeft(ima1, Canvas.GetLeft(ima1) + 5 * mov);
        }
        public async void OnTimedEvent2(Object source, EventArgs e)
        {
            if (cooldown > 0) cooldown--;
            foreach (Image im in self)
            { Canvas.SetTop(im, Canvas.GetTop(im) - 3); labe.Content = Canvas.GetTop(im) - 3; }
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
