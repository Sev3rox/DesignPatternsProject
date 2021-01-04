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
        private int pos=0;
        private List<Enemy> Enemies;
        public EnemysIterator(List<Enemy> Enemies) { this.Enemies = Enemies; }
        public override Object Next() { return Enemies[pos++]; }
        public override bool hasNext(){
            if (pos+1==Enemies.Count)
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
