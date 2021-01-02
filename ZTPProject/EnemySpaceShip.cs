using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class EnemySpaceShip
    {
        private Point position;
        private int healthPoints;
        private int damage;
        private int money;
        public Point getPosition() { return position; }
        public void setPosition(Point pos) { position = pos; }
        public int getDamage() { return damage; }
        public void setDamage(int dam) { damage = dam; }
        public int getMoney() { return money; }
        public void setMoney(int mon) { money=mon; }
        public int getHealthPoints() { return healthPoints; }
        public void setHealthPoints(int HP) { healthPoints=HP; }

        public void shoot() {; }
        public void addIShot(IShot iSht) {; }
        public abstract void clone();
        public abstract void move();
    }
}
