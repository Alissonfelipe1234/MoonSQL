using System.Drawing;

namespace FlowModel
{
    interface Desenho
    {
        string GetName();
        int GetX();
        int GetY();
        void SetName(string name);
        void SetX(int X);
        void SetY(int Y);
        void SeDesenhe(Graphics g);
        string QuemSou();
        bool GetArea(int x, int y);
    }
}
