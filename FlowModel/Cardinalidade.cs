using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Cardinalidade:Desenho
    {
        private int cardMin;
        private int cardMax;

        private int x;
        private int y;

        public Cardinalidade(int x, int y)
        {
            this.cardMin = 1;
            this.cardMin = 1;

            this.x = x;
            this.y = y;
        }

        public void setCardMin (int min)
        {
            if (min == 0 || min == 1)
                this.cardMin = min;
        }
        public void setCardMax(int max)
        {
            if (max == 1 || max == 2)
                this.cardMax = max;
        }

        public int getCardMin()
        {
            return this.cardMin;
        }

        public int getCardMax()
        {
            return this.cardMax;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void SeDesenhe(Graphics g, Panel p)
        {
            throw new NotImplementedException();
        }

        public string QuemSou()
        {
            return "Cardinalidade";
        }

        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }

        public bool GetArea(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
