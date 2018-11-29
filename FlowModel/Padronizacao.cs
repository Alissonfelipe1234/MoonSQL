using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Padronizacao:Desenho
    {
        private string nome;
        private int x;
        private int y;

        private Entidade padrao;
        private List<Entidade> entidades;

        private int id;


        public Padronizacao(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;

            this.padrao = null;
            this.entidades = new List<Entidade>();
        }
        public Entidade getEntidadePadrao()
        {
            return this.padrao;
        }
        public List<Entidade> getEntidades()
        {
            return this.entidades;
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

        public void setPadrao (Entidade x)
        {
            this.padrao = x;
        }
        public void addEntidade(Entidade x)
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
            g.DrawLine(caneta, this.x + 50, this.y + 43, this.padrao.getX() + 50, this.padrao.getY() + 25);
            this.padrao.SeDesenhe(g);
            for (int i = 0; i < this.entidades.Count; i++)
            {
                g.DrawLine(caneta, this.x + 50, this.y, this.entidades[i].getX(), this.entidades[i].getY() + 25);
                this.entidades[i].SeDesenhe(g);
            }
            Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("Generalizacao");
            g.DrawImage(newImage, this.x, this.y);
        }

        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }

        public bool GetArea(int x, int y)
        {
            if (x - this.x >= 0 && x - this.x <= 100)
                if(y - this.y >= 0 && y - this.y <= 52)
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
