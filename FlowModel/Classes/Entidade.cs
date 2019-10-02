using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlowModel
{
    class Entidade : Desenho
    {
        private string nome;
        private int x;
        private int y;

        private int qtdAtributos;
        private int id;

        public override string ToString()
        {
            return this.getName();
        }

        public Entidade(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;

            qtdAtributos = 0;
        }

        public string getName()
        {
            return this.nome;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public int getQtdAtributos()
        {
            return this.qtdAtributos;
        }

        public void addAtributo()
        {
            this.qtdAtributos++;
        }

        public string QuemSou()
        {
            return "Entidade";
        }

        public void SeDesenhe(Graphics g)
        {

            Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("Entidade");
            g.DrawImage(newImage, this.x, this.y);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + 5, this.y + 15);
        }

        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }

        public bool GetArea(int x, int y)
        {
            if (x - this.x >= 0 && x - this.x <= 100)
                if (y - this.y >= 0 && y - this.y <= 52)
                    return true;

            return false;
        }

        public void setName(string name)
        {
            this.nome = name;
        }

        public void setX(int X)
        {
            this.x = X;
        }

        public void setY(int Y)
        {
            this.y = Y;
        }
    }
}
