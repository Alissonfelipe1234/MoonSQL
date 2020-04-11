using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.controller
{
    class Relationship : Drawable
    {
        private int x;
        private int y;

        private List<Drawable> childs;

        public Relationship(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.childs = new List<Drawable>();
        }

        public void DrawIt(Graphics g)
        {
            foreach (Drawable child in childs)
            {
                child.DrawIt(g);
            }
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
            this.y = newY;
        }

        public void AddChild(Drawable child)
        {
            this.childs.Add(child);
        }
    }
}
