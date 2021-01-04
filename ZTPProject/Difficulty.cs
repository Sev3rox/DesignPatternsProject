using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Difficulty
    {
        abstract public EnemyList enemyGenerate(EnemySpaceShip[] EnemyList);
        abstract public double getMoneyMultiplier();
        abstract public double getScoreMultiplier();
    }
}
