using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.Controller
{
    class Attr : Drawable
    {
        private int x;
        private int y;
        private bool primary;
        private bool optional;

        private string name;
        private int min;
        private int max;

        private Drawable owner;


        public int Max { get => max; set => max = value; }
        public int Min { get => min; set => min = value; }
        public bool Primary { get => primary; set => primary = value; }
        public bool Optional { get => optional; set => optional = value; }
        public string Name { get => name; set => name = value; }
        public string data { get;  set; }

        public Attr(int x, int y, Drawable draw)
        {
            this.x = x + 25;
            this.y = y + 30;
            this.owner = draw;
        }

        public void DrawIt(Graphics g)
        {
            Image stamp;
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            if (this.primary)
            {
                stamp = (Image)Properties.Resources.ResourceManager.GetObject("attribute_primary_key");
                g.DrawString(this.name, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 18, this.y + 12 - (this.GetIndex() * 14));
            }
            else if (this.optional)
            {
                stamp = (Image)Properties.Resources.ResourceManager.GetObject("attribute_optional");
                g.DrawString(this.name, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 18, this.y + 12 - (this.GetIndex() * 14));
            }
            else
            {
                stamp = (Image)Properties.Resources.ResourceManager.GetObject("attribute");
                g.DrawString(this.name, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 18, this.y + 12 + (this.GetIndex() * 14));
            }
            g.DrawImage(stamp, this.x, this.y);
            this.owner.DrawIt(g);
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        internal string GetName()
        {
            return this.name;
        }
        private int GetIndex()
        {
            if (this.owner.GetType() == typeof(Entity))
                return ((Entity)owner).GetAttrs();

            return ((Relationship)owner).GetAttrs();
        }
        public bool IsThere(int x, int y)
        {
            Bitmap bmpImagem = new Bitmap(100, 100);
            Graphics metric = Graphics.FromImage(bmpImagem);
            SizeF text = metric.MeasureString(this.name, new Font(new FontFamily("Arial"), 9));

            int h = x - this.x;
            int v = y - this.y;
            if (this.primary)
            {
                if ((h >= 0 && h <= text.Width + 18) && (v >= 0 && v <= 12 - (GetIndex() * 14) + text.Height))
                    return true;
            }
            else if (this.optional)
            {
                if ((h >= 0 && h <= text.Width + 18) && (v >= 0 && v <= 12 - (GetIndex() * 14) + text.Height))
                    return true;
            }
            else
            {
                if ((h >= 0 && h <= text.Width + 18) && (v >= 28 && v <= 28 + (GetIndex() * 14) + text.Height))
                    return true;
            }
            return false;
        }
        public void SetX(int newX)
        {
            this.x = newX;
        }
        public void SetY(int newY)
        {
            this.y = newY;
        }
        public void SetXY(int X, int Y)
        {
            SetX(X);
            SetY(Y);
        }
        internal void SetName(string text)
        {
            this.Name = text;
        }
    }
}
