using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ZTPProject
{
    class Easy:Difficulty
    {
        public override double getMoneyMultiplier()
        {
            return 2;
        }
        public override double getScoreMultiplier()
        {
            return 0.5;
        }
        public override EnemyList enemyGenerate(EnemySpaceShip[] enemyList)
        {
            int l1 = 0;
            int l2 = 0;
            int l3 = 9;
            List<Enemy> lista = new List<Enemy>();
            for(int i=0;i<l1;i++)
            {
                EnemySpaceShip enS=enemyList[0].clone();
               
                Enemy en = new Enemy();
                en.setEnemySpaceShip(enS);
               
                lista.Add(en);
            }
            for (int i = 0; i < l2; i++)
            {
                EnemySpaceShip enS = enemyList[1].clone();
                Enemy en = new Enemy();
                en.setEnemySpaceShip(enS);
                lista.Add(en);
            }
            for (int i = 0; i < l3; i++)
            {
                EnemySpaceShip enS = enemyList[2].clone();
                Enemy en = new Enemy();
                en.setEnemySpaceShip(enS);
                lista.Add(en);
            }
            return new EnemyList(lista);
        }
    }
}
