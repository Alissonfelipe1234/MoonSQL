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
        private string cardMin;
        private string cardMax;

        private int x;
        private int y;

        public Cardinalidade(int x, int y)
        {
            this.cardMin = "1";
            this.cardMin = "1";

            this.x = x;
            this.y = y;
        }

        public void setCardMin (string min)
        {
            this.cardMin = min;
        }
        public void setCardMax(string max)
        {
            this.cardMax = max;
        }

        public string getCardMin()
        {
            return this.cardMin;
        }

        public string getCardMax()
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
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.getName(), new Font(new FontFamily("Arial"), 8), drawBrush, this.x, this.y);
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

        public string getName()
        {
            return this.cardMin + "," + this.cardMax;
        }
    }
}
