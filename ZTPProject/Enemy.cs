using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{

    abstract class InterfaceEnemy
    {

        //public EnemySpaceShip getEnemySpaceShip() { }
        //public void getEnemySpaceShip(EnemySpaceShip enship) { }
        public abstract int getX();
        public abstract void setX(int x);
        public abstract void Zmieństrategie();

       
    }
    class Enemy : InterfaceEnemy
    {
        // private EnemySpaceShip enemySpaceShip;
        private Strategia strategy;
        private int x;
    public Enemy() { }

        //  public EnemySpaceShip getEnemySpaceShip() { }
        //  public void getEnemySpaceShip(EnemySpaceShip enship) { }
     public override int getX() { return 0; }
     public override void  setX(int x) { }
     public override void  Zmieństrategie() { }

    
    }

    class ProxyEnemy : InterfaceEnemy
    {
        private Enemy enemy;
    public ProxyEnemy() { }

        // public EnemySpaceShip getEnemySpaceShip() { }
        // public void getEnemySpaceShip(EnemySpaceShip enship) { }
        public override int getX() { return 0; }
        public override void setX(int x) { }
        public override void Zmieństrategie() { }


    }
}
