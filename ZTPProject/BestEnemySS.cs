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
    class BestEnemySS:EnemySpaceShip
    {
        private Boolean shield = true;
        public Boolean getShield() { return shield; }
        public void setShield(Boolean b) { shield = b; }
        public override EnemySpaceShip clone()
        {
            return this;
        }
        public override void move()
        {
            throw new NotImplementedException();
        }
        public void shot(List<IShot> list, Canvas canvas)
        {
            IShot tShot = new TShot();
            tShot.setPosition(this.getPosition());
            Metoda shoot = new Shoot();
            tShot.setImage((Image)tShot.wykonaj(shoot, canvas));
        }
    }
}
