using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
