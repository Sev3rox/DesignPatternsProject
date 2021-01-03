using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class TShot:IShot
    {
        override public Object wykonaj(Metoda m) { return m.WykonajNaTShot(this); }
    }
}
