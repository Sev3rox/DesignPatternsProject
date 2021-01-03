using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class BigTShot: IShot
    {
        override public Object wykonaj(Metoda m) { return m.WykonajNaBigTShot(this); }
    }
}
