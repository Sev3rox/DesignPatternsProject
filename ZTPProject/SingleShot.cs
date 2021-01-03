using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class SingleShot : IShot
    {
        override public Object wykonaj(Metoda m) { return m.WykonajNaSingle(this); }
    }
}
