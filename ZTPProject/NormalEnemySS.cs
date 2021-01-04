using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class NormalEnemySS:EnemySpaceShip
    {
        public override EnemySpaceShip clone()
        {
            return this;
        }
        public override void move()
        {
            throw new NotImplementedException();
        }
    }
}
