﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowModel
{
    interface Desenho
    {
        void SeDesenhe(Graphics g, System.Windows.Forms.Panel p);
        string QuemSou();
        void Propriedades(System.Windows.Forms.Panel p);
        bool GetArea(int x, int y);
    }
}
