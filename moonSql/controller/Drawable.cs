using System.Drawing;

namespace moonSql.Controller
{
    interface Drawable
    {
        int GetX();
        int GetY();
        bool IsThere(int x, int y);
        void SetX(int newX);
        void SetY(int newY);
        void SetXY(int X, int Y);
        void DrawIt(Graphics g);
    }
}
