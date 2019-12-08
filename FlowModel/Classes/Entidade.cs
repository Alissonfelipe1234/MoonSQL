using System;
using System.Drawing;

namespace FlowModel
{
    class Entidade : Desenho
    {
        private string nome;
        private int x;
        private int y;

        private int qtdAtributos;

        public override string ToString()
        {
            return this.GetName();
        }

        public Entidade(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;

            qtdAtributos = 0;
        }

        public string GetName()
        {
            return this.nome;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetQtdAtributos()
        {
            return this.qtdAtributos;
        }

        public void AddAtributo()
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

        public void Propriedades()
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

        public void SetName(string name)
        {
            this.nome = name;
        }

        public void SetX(int X)
        {
            this.x = X;
        }

        public void SetY(int Y)
        {
            this.y = Y;
        }
    }
}
