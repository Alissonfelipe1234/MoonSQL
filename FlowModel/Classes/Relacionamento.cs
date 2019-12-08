using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlowModel
{
    class Relacionamento : Desenho
    {
        private string nome;
        private int x;
        private int y;
        private List<Cardinalidade> card;
        private List<Entidade> ent;
        private int qtdAtributos;
        private int qtdEnv;

        public Relacionamento(string n, int Px, int Py, int qtdEntidadesEnvolvidas)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;
            this.card = new List<Cardinalidade>();
            this.ent = new List<Entidade>();
            this.qtdEnv = qtdEntidadesEnvolvidas;
            this.qtdAtributos = 0;
        }
        public void setEntidade(int index, Entidade e)
        {
            this.ent.RemoveAt(index);
            this.ent.Insert(index, e);
        }
        public void addAtributo()
        {
            this.qtdAtributos++;
        }

        public void removeAtributo()
        {
            this.qtdAtributos--;
        }

        public int getQtdAtributos()
        {
            return this.qtdAtributos;
        }

        public List<Cardinalidade> getCards()
        {
            return this.card;
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

        public int getQtdEnvolvidos()
        {
            return this.qtdEnv;
        }
        public List<Entidade> getEnvolvidos()
        {
            return this.ent;
        }

        public void adicionarCardinalidade(Cardinalidade nova)
        {
            if (this.card.Count < 3)
                this.card.Add(nova);
        }
        public void relacionarEntidade(Entidade e)
        {
            if (this.ent.Count < 3)
                this.ent.Add(e);
        }

        public void SeDesenhe(Graphics g)
        {
            Pen caneta = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
            for (int i = 0; i < this.qtdEnv; i++)
            {
                this.card[i].SeDesenhe(g);
                g.DrawLine(caneta, this.x + 50, this.y + 50, this.ent[i].GetX() + 50, this.ent[i].GetY() + 25);
                this.ent[i].SeDesenhe(g);
            }

            Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("Relacionamento");
            g.DrawImage(newImage, this.x, this.y);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.nome, new Font(new FontFamily("Arial"), 10), drawBrush, this.x + 12, this.y + 37);
        }

        public string QuemSou()
        {
            return "Relacionamento";
        }
        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }

        public bool GetArea(int x, int y)
        {
            if (x - this.x >= 0 && x - this.x <= 100)
                if (y - this.y >= 21 && y - this.y <= 72)
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
