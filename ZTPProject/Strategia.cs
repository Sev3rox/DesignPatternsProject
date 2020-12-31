using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Strategia
    {
        public abstract void Poruszanie(int x,int y/*,enemySpaceShip*/);
    }

    class Teleportacja : Strategia
    {
        public override void Poruszanie(int x, int y) { }
    }

    class PoosiX : Strategia
    {
        public override void Poruszanie(int x, int y) { }
    }

    class PoosiachXY : Strategia
    {
        public override void Poruszanie(int x, int y) { }
    }

    class Szarża : Strategia
    {
        public override void Poruszanie(int x, int y) { }
    }

    class Nieruchome : Strategia
    {
        public override void Poruszanie(int x, int y) { }
    }
}
