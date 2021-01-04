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
    /// //Width=600
    public partial class Game : Page
    {
        private DispatcherTimer aTimer = new DispatcherTimer();
        private DispatcherTimer bTimer = new DispatcherTimer();
        private DispatcherTimer cTimer = new DispatcherTimer();
        private DispatcherTimer dTimer = new DispatcherTimer();
        private short mov;
        private Random rnd = new Random();
        private Image ima1;
        private List<IShot> list = new List<IShot>();
        private int cooldown = 0;
        private List<Image> self = new List<Image>();
        private EnemyList enemys;
        private List<Enemy> incombat=new List<Enemy>();
        private Enemy en;
        private Player player = new PlayerSpaceShip();
        private Difficulty difficulty = new Easy();
        private EnemySpaceShip[] org=new EnemySpaceShip[5];
        private double scoreMultiplier;
        private int buffor;
        private bool isEnemy = false;
        private EnemysIterator iter;
        private int result;
        private DBConnection connection;
        public Game(DBConnection connection)
        {
            InitializeComponent();
            //snake = new Snakee(x, y);
            this.connection = connection;
            SetTimer();
            SetTimer2();
            SetTimer3();
            SetTimer4();
            ima1 = new Image
            {

            };
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/Files/MYship.png", UriKind.Relative);
            bi1.EndInit();
            ima1.Source = bi1;
            canvas.Children.Add(ima1);
            double a = canvas.ActualWidth;
            double b = ima1.Width;
            double c = canvas.ActualHeight;
            double d = ima1.Height;
            Canvas.SetLeft(ima1, canvas.Width/2-80);//139
            Canvas.SetTop(ima1, canvas.Height-129);//129
            Loaded += (xx, yy) => Keyboard.Focus(grid);
            
            player.setMoneyMultiplier(difficulty.getMoneyMultiplier());
            scoreMultiplier = difficulty.getScoreMultiplier();
            org[0] = new NormalEnemySS();
            set(org[0],1,2,3,"Enemy1.png",new Szarża());
            org[1] = new GoodEnemySS();
            set(org[1], 2, 2, 1, "Enemy2.png", new Nieruchome());
            org[2] = new BetterEnemySS();
            set(org[2], 3, 2, 3, "Enemy3.png", new Teleportacja());
            org[3] = new BestEnemySS();
            set(org[3], 4, 3, 3, "Enemy4.png", new PoosiachXY());
            org[4] = new BestestEnemySS();
            set(org[4], 10, 30, 3, "Boss.png", new PoosiX());
            enemys = difficulty.enemyGenerate(org);

            iter = (EnemysIterator)enemys.CreateIterator();
        }
        private void set(EnemySpaceShip ss,int Money,int HP, int Damage,string plik,Strategia str)
        {
            ss.setMoney(Money);
            ss.setHealthPoints(HP);
            ss.setDamage(Damage);
            ss.setImgString("/Files/"+plik);
            ss.setStrategia(str);
         
          
           
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
            cTimer.Tick += OnTimedEvent3;
            cTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            cTimer.Start();
        }
        private void SetTimer4()
        {
            dTimer.Tick += OnTimedEvent4;
            dTimer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            dTimer.Start();
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
            if((Canvas.GetLeft(ima1)+5*mov>0&&mov<0)|| (Canvas.GetLeft(ima1) + 5 * mov<canvas.Width-160)&&mov>0)
            Canvas.SetLeft(ima1, Canvas.GetLeft(ima1) + 5 * mov);
        }
        public async void OnTimedEvent2(Object source, EventArgs e)
        {
            if (cooldown > 0) cooldown--;
            foreach (Image im in self)
            { Canvas.SetTop(im, Canvas.GetTop(im) - 5); labe.Content = Canvas.GetTop(im) - 5; }
        }


        public async void OnTimedEvent3(Object source, EventArgs e)
        {
            if (buffor == 0 && isEnemy == false)
            {
                if (iter.hasNext())
                {
                    en = (Enemy)iter.Next();
                    en.setX(rnd.Next(0, 6));
                    Image ima = new Image
                    {

                    };
                    BitmapImage bi1 = new BitmapImage();
                    bi1.BeginInit();
                    bi1.UriSource = new Uri(en.getEnemySpaceShip().getImgString(), UriKind.Relative);
                    bi1.EndInit();
                    ima.Source = bi1;
                    en.getEnemySpaceShip().setImage(ima);
           
                    //canvas.Children.Remove(ima);
                    canvas.Children.Add(ima);
                    Canvas.SetLeft(ima,  en.getX()*80);
                    Canvas.SetTop(ima,  0);
                    incombat.Add(en);
                }
                else
                {
                    NavigationService nav = NavigationService.GetNavigationService(this);
                    nav.Navigate(new Shop1(connection,result));
                    this.aTimer.Stop();
                    this.bTimer.Stop();
                    this.cTimer.Stop();
                    this.dTimer.Stop();
                }
                buffor = 100;
            }
            buffor--;
        
        }

        public async void OnTimedEvent4(Object source, EventArgs e)
        {
          
            if (incombat.Count > 0)
            {
                foreach (Enemy enmove in incombat)
                {
            
                    enmove.porusz();
                }
            }
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
                        cooldown = 10;
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
