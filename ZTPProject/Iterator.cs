using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class Iterator
    {
        public abstract Object Next();
        public abstract bool hasNext();
    }

    class EnemysIterator : Iterator
    {
        private Random rnd = new Random();
        private List<Enemy> Enemies;
        public EnemysIterator(List<Enemy> Enemies) { this.Enemies = Enemies; }
        public override Object Next() {
            if (Enemies.Count > 1)
            {
                var index = rnd.Next(0, Enemies.Count - 1);
                Enemy enemy = Enemies[index];
                Enemies.Remove(enemy);
                return enemy;
            }
            else
            {
                Enemy enemy = Enemies[0];
                Enemies.Remove(enemy);
                return enemy;
            }
        }
        public override bool hasNext(){
            if (Enemies.Count<=0)
                return false;
            else
                return true;
        }
    }

    abstract class IList
    {
        public abstract Iterator CreateIterator();
    }

    class EnemyList : IList
    {
        private List<Enemy> Enemies;
        public EnemyList(List<Enemy> list) { Enemies = list; }
        public void setEnemies(List<Enemy> list) { Enemies = list; }
        public List<Enemy> GetEnemies() { return Enemies; }
        public override Iterator CreateIterator() { return new EnemysIterator(Enemies); }
    }
}
