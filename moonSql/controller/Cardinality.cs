using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moonSql.controller
{
    class Cardinality : Drawable
    {
        private int x;
        private int y;

        private string min;
        private string max;

        public Cardinality(int x, int y, string min, string max)
        {
            this.x = x;
            this.y = y;
            this.min = min;
            this.max = max;
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
        public string GetMax()
        {
            return this.max;
        }
        public string GetMin()
        {
            return this.min;
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
        public void SetMax(string max)
        {
            this.max = max;
        }
        public void SetMin(string min)
        {
            this.min = min;
        }
        public void SetXY(int X, int Y)
        {
            SetX(x);
            SetY(y);
        }
    }
}
