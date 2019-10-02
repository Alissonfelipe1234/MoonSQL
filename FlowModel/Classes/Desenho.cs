using System.Drawing;

namespace FlowModel
{
    interface Desenho
    {
        string getName();
        int getX();
        int getY();
        void setName(string name);
        void setX(int X);
        void setY(int Y);
        void SeDesenhe(Graphics g);
        string QuemSou();
        bool GetArea(int x, int y);
    }
}
