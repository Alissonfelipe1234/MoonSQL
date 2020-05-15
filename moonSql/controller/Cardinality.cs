using System.Drawing;

namespace moonSql.Controller
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
            SolidBrush pencil = new SolidBrush(Color.Black);
            g.DrawString(this.min + ", " + this.max, new Font(new FontFamily("Arial Black"), 8), pencil, this.x, this.y);
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
            int horizontal = x - this.x;
            int vertical = y - this.y;

            if ((horizontal >= 0 && horizontal <= 20) && (vertical >= 0 && vertical <= 12))
                return true;

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
            SetX(X);
            SetY(Y);
        }
    }
}
