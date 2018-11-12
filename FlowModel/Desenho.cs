using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowModel
{
    interface Desenho
    {
        void SeDesenhe(System.Windows.Forms.Form d);
        string QuemSou();
        void Propriedades(System.Windows.Forms.Panel p);
        bool GetArea(int x, int y);
    }
}
