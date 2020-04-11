using System.Drawing;

namespace moonSql.controller
{
    interface Drawable
    {
        int GetX();
        int GetY();
        bool IsThere(int x, int y);
        void SetX(int newX);
        void SetY(int newY);
        void DrawIt(Graphics g);
    }
}
