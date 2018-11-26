﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Relacionamento:Desenho
    {
        private string nome;
        private int x;
        private int y;
        private List<Cardinalidade> card;
        private List<Entidade> ent;
        private int qtdAtributos;
        private int qtdEnv;

        public Relacionamento (string n, int Px, int Py, int qtdEntidadesEnvolvidas)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;
            this.card   = new List<Cardinalidade>();
            this.ent    = new List<Entidade>();
            this.qtdEnv = qtdEntidadesEnvolvidas;
            this.qtdAtributos = 0;
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

        public string getName ()
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

        public int getQtdEnvolvidos()
        {
            return this.qtdEnv;
        }

        public void adicionarCardinalidade (Cardinalidade nova)
        {
            if (this.card.Count < 3)
                this.card.Add(nova);
        }
        public void relacionarEntidade(Entidade e)
        {
            if(this.ent.Count < 3)
                this.ent.Add(e);
        }
        
        public void SeDesenhe(Graphics g, Panel p)
        {
            Pen caneta = new Pen(new System.Drawing.SolidBrush(System.Drawing.Color.Black));
            for (int i = 0; i < this.qtdEnv; i++)
            {
                this.card[i].SeDesenhe(g,p);
                g.DrawLine(caneta, this.x + 50, this.y + 25, this.ent[i].getX()+50, this.ent[i].getY()+25);
                this.ent[i].SeDesenhe(g,p);
            }

            Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("Relacionamento");
            g.DrawImage(newImage, this.x, this.y);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.nome, new Font(new FontFamily("Arial"), 10), drawBrush, this.x + 20, this.y + 37);



            p.Refresh();
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
