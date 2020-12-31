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
        public abstract int getY();
        public abstract void setY(int y);
        public abstract void Zmieństrategie(Strategia strategy);
        public abstract void porusz();

       
    }
    class Enemy : InterfaceEnemy
    {
        // private EnemySpaceShip enemySpaceShip;
        private Strategia strategy;
        private int x;
        private int y;
        public Enemy() { }

        //  public EnemySpaceShip getEnemySpaceShip() {return enemySpaceShip; }
        //  public void setEnemySpaceShip(EnemySpaceShip enship) {enemySpaceShip=enship; }
        public override int getX() { return x; }
        public override void  setX(int x) { this.x = x; }

        public override int getY() { return y; }
        public override void setY(int y) { this.x = y; }
        public override void  Zmieństrategie(Strategia strategy) { this.strategy = strategy; }
     public override void porusz() { strategy.Poruszanie(x,y/*,enemySpaceShip*/); }


    }

    class ProxyEnemy : InterfaceEnemy
    {
        private Enemy enemy=null;
    public ProxyEnemy() { }

        /* public EnemySpaceShip getEnemySpaceShip() {
           if (enemy == null)
                return null;
         return enemy.getEnemySpaceShip() ;
          }
         public void setEnemySpaceShip(EnemySpaceShip enship) {
         if (enemy == null)
                enemy = new Enemy();
        enemy.setEnemySpaceShip(enship);
        }*/
        public override int getX() {
            if (enemy == null)
                return 0;
            return enemy.getX();
     
        }
        public override void setX(int x) {
            if (enemy == null)
                enemy = new Enemy();
            enemy.setX(x);
                }
        public override int getY()
        {
            if (enemy == null)
                return 0;
            return enemy.getY();

        }
        public override void setY(int y)
        {
            if (enemy == null)
                enemy = new Enemy();
            enemy.setY(y);
        }
        public override void Zmieństrategie(Strategia strategy) { enemy.Zmieństrategie(strategy); }
        public override void porusz() { enemy.porusz(); }

    }
}
