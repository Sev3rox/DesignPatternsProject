using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class PlayerSpaceShip : Player
    {
        private int healthPoints;
        private Point position;
        private int money;
        private double moneyMultiplier;
        override public float getDamage() { return 1; }
        override public double getMoneyMultiplier() { return moneyMultiplier; }
        override public void setHealthPoints(int hp) { healthPoints = hp; }
        override public int getHealthPoints() { return healthPoints; }
        override public void setPosition(Point pos) { position = pos; }
        override public Point getPosition() { return position; }
        override public int getMoney() { return money; }
        override public void setMoney(int mon) { money = mon; }
        override public void setMoneyMultiplier(double mon) { moneyMultiplier = mon; }
    }
}
