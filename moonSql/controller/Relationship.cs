using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.controller
{
    class Relationship : Drawable
    {
        private int x;
        private int y;
        private string name;

        private List<Tuple<Drawable, Cardinality>> childs;

        public Relationship(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.childs = new List<Tuple<Drawable, Cardinality>>();
        }
        public void DrawIt(Graphics g)
        {
            foreach (Tuple<Drawable, Cardinality> tuple in childs)
            {
                tuple.Item1.DrawIt(g);
                tuple.Item2.DrawIt(g);
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
        public void AddChild(Drawable child, Cardinality card)
        {
            this.childs.Add( new Tuple<Drawable, Cardinality>(child, card));
        }
        public void SetXY(int X, int Y)
        {
            SetX(x);
            SetY(y);
        }
    }
}
