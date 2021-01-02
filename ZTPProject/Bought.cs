using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Bought:Player
    {
        private Player player;
        override abstract public float getDamage();
        override abstract public float getMoneyMultiplier();
        override public void setHealthPoints(int hp) { player.setHealthPoints(hp); }
        override public int getHealthPoints() { return player.getHealthPoints(); }
        override public void setPosition(Point pos) { player.setPosition(pos); }
        override public Point getPosition() { return player.getPosition(); }
        override public int getMoney() { return player.getMoney(); }
        override public void setMoney(int mon) { player.setMoney(mon); }

    }
}
