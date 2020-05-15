using System.Collections.Generic;
using System.Drawing;

namespace moonSql.Controller
{
    class Specialization : Drawable
    {
        private int x;
        private int y;

        private Entity special;
        private List<Entity> entities;

        public Specialization(int x, int y)
        {
            this.x = x - 50;
            this.y = y - 20;
            this.entities = new List<Entity>();
        }

        public void DrawIt(Graphics g)
        {
            Pen pencil = new Pen(new SolidBrush(Color.Black));
            if (this.special != null)
            {
                g.DrawLine(pencil, this.x + 50, this.y + 43, this.special.GetX(), this.special.GetY() + 10);
                this.special.DrawIt(g);
            }
            foreach (Entity entity in entities)
            {
                g.DrawLine(pencil, this.x + 50, this.y, entity.GetX(), entity.GetY() + 10);
                entity.DrawIt(g);
            }
            Image stamp = (Image)Properties.Resources.ResourceManager.GetObject("specialization");
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
        public Entity GetSpecial()
        {
            return this.special;
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
            this.x = newX - 50;
        }
        public void SetY(int newY)
        {
            this.y = newY - 20;
        }
        public void SetSpecial(Entity entity)
        {
            if (this.special == null)
                this.special = entity;
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
