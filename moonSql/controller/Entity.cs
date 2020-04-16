using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.Controller
{
    class Entity : Drawable
    {
        private int x;
        private int y;

        private string name;

        private List<Drawable> childs;

        public Entity(int x, int y, string name)
        {
            this.x = x-50;
            this.y = y-16;
            this.name = name;
            this.childs = new List<Drawable>();
        }

        public void DrawIt(Graphics g)
        {
            Image square = (Image)Properties.Resources.ResourceManager.GetObject("entity");
            g.DrawImage(square, this.x, this.y);
            SolidBrush title = new SolidBrush(Color.Black);
            g.DrawString(this.name, new Font(new FontFamily("Arial"), 12), title, this.x + 5, this.y + 15);
        }
        public int GetX()
        {
            return this.x+50;
        }
        public int GetY()
        {
            return this.y+16;
        }
        public int GetAttrs()
        {
            int counter = 0;
            foreach (Drawable draw in childs)
                if (draw.GetType() == typeof(Attr))
                    counter++;

            return counter;
        }
        public bool IsThere(int x, int y)
        {
            int horizontal = x - this.x;
            int vertical = y - this.y;
            if ((horizontal >= 0 && horizontal <= 100) && (vertical >= 0 && vertical <= 52))
                return true;

            return false;
        }
        public void SetX(int newX)
        {
            this.x = newX-50;
        }
        public void SetY(int newY)
        {
            this.y = newY-16;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void AddChild(Drawable child)
        {
            this.childs.Add(child);
        }
        public void SetXY(int X, int Y)
        {
            SetX(X);
            SetY(Y);
        }
    }
}
