using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Strategia
    {
        public abstract void Poruszanie(EnemySpaceShip enemy);
    }

    class Teleportacja : Strategia
    {
        public override void Poruszanie(EnemySpaceShip enemy) { }
    }

    class PoosiX : Strategia
    {
        public override void Poruszanie(EnemySpaceShip enemy) { }
    }

    class PoosiachXY : Strategia
    {
        public override void Poruszanie(EnemySpaceShip enemy) { }
    }

    class Szarża : Strategia
    {
        public override void Poruszanie(EnemySpaceShip enemy) { }
    }

    class Nieruchome : Strategia
    {
        public override void Poruszanie(EnemySpaceShip enemy) { }
    }
}
