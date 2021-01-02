using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    abstract class IShot
    {
        private Point position;

        public Point getPosition() { return position; }
        public void setPosition(Point pos) { position=pos; }
        abstract public Object wykonaj(Metoda met);
    }
}
