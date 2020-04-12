using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.controller
{
    class Attribute : Drawable
    {
        private int x;
        private int y;

        private string name;

        private bool primary;
        private bool composite;
        private bool optional;

        private int min;
        private int max;

        private Drawable owner;

        private List<Drawable> childs;

        public int Max { get => max; set => max = value; }
        public int Min { get => min; set => min = value; }
        public bool Primary { get => primary; set => primary = value; }
        public bool Composite { get => composite; set => composite = value; }
        public bool Optional { get => optional; set => optional = value; }

        public Attribute(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.childs = new List<Drawable>();
        }

        public Attribute(bool composite)
        {
            this.Composite = composite;
        }

        public void DrawIt(Graphics g)
        {
            foreach (Drawable child in this.childs)
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
        public void SetXY(int X, int Y)
        {
            SetX(x);
            SetY(y);
        }
    }
}
