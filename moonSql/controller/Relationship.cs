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

        public Relationship(int x, int y, string name)
        {
            this.x = x - 50;
            this.y = y - 50;
            this.name = name;
            this.childs = new List<Tuple<Drawable, Cardinality>>();
        }
        public void DrawIt(Graphics g)
        {
            Pen pencil = new Pen(Color.Black, 2);

            foreach (Tuple<Drawable, Cardinality> tuple in childs)
            {
                g.DrawLine(pencil, this.x + 50, this.y + 50, tuple.Item1.GetX(), tuple.Item1.GetY()+10);
                tuple.Item1.DrawIt(g);
                tuple.Item2.DrawIt(g);
            }

            Image stamp = (Image)Properties.Resources.ResourceManager.GetObject("relationship");
            g.DrawImage(stamp, this.x, this.y);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(this.name, new Font(new FontFamily("Arial"), 10), drawBrush, this.x + 12, this.y + 37);
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
            int horizontal = x - this.x;
            int vertical = y - this.y;
            if ((horizontal >= 0 && horizontal <= 100) && (vertical >= 21 && vertical <= 72))
                return true;

            return false;
        }
        public void SetX(int newX)
        {
            this.x = newX - 50;
        }
        public void SetY(int newY)
        {
            this.y = newY - 50;
        }
        public void AddChild(Drawable child, Cardinality card)
        {
            this.childs.Add( new Tuple<Drawable, Cardinality>(child, card));
        }
        public void SetXY(int X, int Y)
        {
            SetX(X);
            SetY(Y);
        }
    }
}
