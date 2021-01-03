using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class MoneyMultiplier : Bought
    {
        public MoneyMultiplier(Player player1) { setPlayer(player1); }
        override public float getDamage() { return this.getDamage(); }
        override public float getMoneyMultiplier() { return this.getMoneyMultiplier() * 1.5f; }
    }
}
