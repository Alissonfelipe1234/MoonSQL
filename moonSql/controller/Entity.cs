using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.controller
{
    class Entity : Drawable
    {
        private int x;
        private int y;

        private List<Drawable> childs;

        public void DrawIt(Graphics g)
        {
            throw new NotImplementedException();
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public bool IsThere(int x, int y)
        {
            throw new NotImplementedException();
        }
        public void SetX(int newX)
        {
            this.x = newX;
        }
        public void SetY(int newY)
        {
            this.x = newY;
        }
    }
}
