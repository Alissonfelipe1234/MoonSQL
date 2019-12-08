using System;
using System.Collections.Generic;
using System.Drawing;

namespace FlowModel
{
    class Padronizacao : Desenho
    {
        private string nome;
        private int x;
        private int y;

        private Entidade padrao;
        private readonly List<Entidade> entidades;


        public Padronizacao(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;

            this.padrao = null;
            this.entidades = new List<Entidade>();
        }
        public Entidade GetEntidadePadrao()
        {
            return this.padrao;
        }
        public List<Entidade> GetEntidades()
        {
            return this.entidades;
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

        public void SetPadrao(Entidade x)
        {
            this.padrao = x;
        }
        public void AddEntidade(Entidade x)
        {
            this.entidades.Add(x);
        }

        public string QuemSou()
        {
            return "Padronizacao";
        }

        public void SeDesenhe(Graphics g)
        {
            Pen caneta = new Pen(new System.Drawing.SolidBrush(System.Drawing.Color.Black));
            g.DrawLine(caneta, this.x + 50, this.y + 43, this.padrao.GetX() + 50, this.padrao.GetY() + 25);
            this.padrao.SeDesenhe(g);
            for (int i = 0; i < this.entidades.Count; i++)
            {
                g.DrawLine(caneta, this.x + 50, this.y, this.entidades[i].GetX(), this.entidades[i].GetY() + 25);
                this.entidades[i].SeDesenhe(g);
            }
            Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("Generalizacao");
            g.DrawImage(newImage, this.x, this.y);
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
