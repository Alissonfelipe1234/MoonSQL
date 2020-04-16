using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.Controller
{
    class Generalization : Drawable
    {
        private int x;
        private int y;

        private Entity generic;
        private List<Entity> entities;

        public Generalization(int x, int y)
        {
            this.x = x - 50;
            this.y = y - 20;
            this.entities = new List<Entity>();
        }
        public void DrawIt(Graphics g)
        {
            Pen pencil = new Pen(new SolidBrush(Color.Black));
            if (this.generic != null)
            {
                g.DrawLine(pencil, this.x + 50, this.y, generic.GetX(), generic.GetY() + 10);
                this.generic.DrawIt(g);
            }
            foreach (Entity entity in entities)
            {
                g.DrawLine(pencil, this.x + 50, this.y + 43, entity.GetX(), entity.GetY() + 10);
                entity.DrawIt(g);
            }
            Image stamp = (Image)Properties.Resources.ResourceManager.GetObject("generalization");
            g.DrawImage(stamp, this.x, this.y);
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
            if ((horizontal >= 0 && horizontal <= 100) && (vertical >= 0 && vertical <= 56))
                return true;

            return false;
        }
        public void SetX(int newX)
        {
            this.x = newX - 50;
        }
        public void SetY(int newY)
        {
            this.y = newY - 25;
        }
        public void SetGeneric(Entity entity)
        {
            if (this.generic == null)
                this.generic = entity;
        }
        public void addEntity(Entity entity)
        {
            this.entities.Add(entity);
        }
        public void SetXY(int X, int Y)
        {
            SetX(X);
            SetY(Y);
        }
    }
}
