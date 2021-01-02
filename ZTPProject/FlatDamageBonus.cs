using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class FlatDamageBonus : Bought
    {
        override public float getDamage() { return this.getDamage() + 1.0f; }
        override public float getMoneyMultiplier() { return this.getMoneyMultiplier(); }
    }
}
