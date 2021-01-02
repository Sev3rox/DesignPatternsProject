using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Difficulty
    {
        abstract public List<EnemySpaceShip> enemyGenerate(EnemySpaceShip[] EnemyList);
        abstract public int getMoneyMultiplier();
    }
}
