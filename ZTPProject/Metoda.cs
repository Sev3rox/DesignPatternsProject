using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    interface Metoda
    {
        Object WykonajNaSingle(SingleShot shot);
        Object WykonajNaTShot(TShot shot);
        Object WykonajNaBigTShot(BigTShot shot);
    }
}
