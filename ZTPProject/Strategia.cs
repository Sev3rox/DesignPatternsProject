using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Strategia
    {
        public abstract void Poruszanie();
    }

    class Teleportacja : Strategia
    {
        public override void Poruszanie() { }
    }

    class PoosiX : Strategia
    {
        public override void Poruszanie() { }
    }

    class PoosiachXY : Strategia
    {
        public override void Poruszanie() { }
    }

    class Szarża : Strategia
    {
        public override void Poruszanie() { }
    }

    class Nieruchome : Strategia
    {
        public override void Poruszanie() { }
    }
}
