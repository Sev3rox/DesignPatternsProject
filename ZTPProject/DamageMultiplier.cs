using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class DamageMultiplier : Bought
    {
        public DamageMultiplier(Player player1) { setPlayer(player1); }
        override public float getDamage() { return this.getDamage() * 1.5f; }
        override public float getMoneyMultiplier() { return this.getMoneyMultiplier(); }
    }
}
