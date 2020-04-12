using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.controller
{
    class Specialization : Drawable
    {
        private int x;
        private int y;

        private Entity special;
        private List<Entity> entities;

        public Specialization(int x, int y, Entity special)
        {
            this.x = x;
            this.y = y;
            this.special = special;
            this.entities = new List<Entity>();
        }

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
            this.y = newY;
        }
        public void addEntity(Entity entity)
        {
            this.entities.Add(entity);
        }
        public void SetXY(int X, int Y)
        {
            SetX(x);
            SetY(y);
        }
    }
}
