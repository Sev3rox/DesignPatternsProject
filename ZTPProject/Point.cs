using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class Point
    {
        private int x;
        private int y;
        public Point() { }
        public Point(int xx,int yy) { x = xx;y = yy; }

        public int getX() { return x; }
        public void setX(int xx) { x = xx; }
        public int getY() { return y; }
        public void setY(int yy) { y = yy; }
    }
}
