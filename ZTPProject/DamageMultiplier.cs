using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class DamageMultiplier : Bought
    {
        override public float getDamage() { return this.getDamage() *1.5f; }
        override public float getMoneyMultiplier() { return this.getMoneyMultiplier(); }
    }
}
