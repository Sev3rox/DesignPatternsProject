using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Player
    {
        abstract public float getDamage();
        abstract public double getMoneyMultiplier();
        abstract public void setHealthPoints(int hp);
        abstract public int getHealthPoints();
        abstract public void setPosition(Point pos);
        abstract public Point getPosition();
        abstract public double getMoney();
        abstract public void setMoney(double mon);
        abstract public void setMoneyMultiplier(double mon);

    }
}
