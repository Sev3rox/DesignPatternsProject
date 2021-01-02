using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class MoneyMultiplier:Bought
    {
        override public float getDamage() { return this.getDamage(); }
        override public float getMoneyMultiplier() { return this.getMoneyMultiplier() * 1.5f; }
    }
}
