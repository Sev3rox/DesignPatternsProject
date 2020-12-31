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
        private int pos;
        public override Object Next() { return new Object(); }
        public override bool hasNext(){return false; }
    }

    abstract class IList
    {
        public abstract Iterator CreateIterator();
    }

    class EnemyList : IList
    {
        private List<Enemy> Enemies;
        public override Iterator CreateIterator() { return new EnemysIterator(); }
    }
}
