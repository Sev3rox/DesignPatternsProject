using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

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
