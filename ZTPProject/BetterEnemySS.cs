﻿using System;
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
    class BetterEnemySS:EnemySpaceShip
    {

        public BetterEnemySS() {; }
        public BetterEnemySS(BetterEnemySS ss) { this.setCD(ss.getCD()); this.setPosition(ss.getPosition()); this.setHealthPoints(ss.getHealthPoints()); this.setDamage(ss.getDamage()); this.setMoney(ss.getMoney()); this.setStrategia(ss.getIStrategia()); this.setImage(ss.getImage()); this.setImgString(ss.getImgString()); }

        public override EnemySpaceShip clone()
        {

            return new BetterEnemySS(this);

        }
      
        public override void move()
        {
            throw new NotImplementedException();
        }
        override public List<IShot> shoot(List<IShot> list, Canvas canvas)
        {
            IShot single = new TShot();
            Point pos = new Point();
            pos.setY(Canvas.GetTop(this.getImage()) + 65);
            pos.setX(Canvas.GetLeft(this.getImage()) + 38);
            single.setPosition(pos);
            Metoda shoot = new Shoot();
            single.setImage((Image)single.wykonaj(shoot, canvas));
            single.setDamage(1);
            list.Add(single);
            return list;
        }
    }
}
