using System;
using System.Collections.Generic;
using System.Drawing;

namespace moonSql.controller
{
    class Generalization : Drawable
    {
        private int x;
        private int y;

        private Entity generic;
        private List<Entity> entities;

        public Generalization(int x, int y, Entity generic)
        {
            this.x = x;
            this.y = y;
            this.generic = generic;
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
            SetX(X);
            SetY(Y);
        }
    }
}
