using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Especializacao:Desenho
    {
        private string nome;
        private int x;
        private int y;

        private Entidade especializada;
        private List<Entidade> entidades;

        private int id;


        public Especializacao(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;

            especializada = null;
            entidades = new List<Entidade>();
        }
        public Entidade getEntidadeEspecializada()
        {
            return this.especializada;
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
        public void setEntidadeEspecializada(Entidade e)
        {
            this.especializada = e;
        }
        public void addEntidades(Entidade x)
        {
            this.entidades.Add(x);
        }
        public string QuemSou()
        {
            return "Especializacao";
        }

        public void SeDesenhe(Graphics g)
        {
            Pen caneta = new Pen(new System.Drawing.SolidBrush(System.Drawing.Color.Black));
            g.DrawLine(caneta, this.x + 50, this.y, this.especializada.getX() + 50, this.especializada.getY() + 25);
            this.especializada.SeDesenhe(g);
            for (int i = 0; i < this.entidades.Count; i++)
            {
                g.DrawLine(caneta, this.x + 50, this.y + 40, this.entidades[i].getX(), this.entidades[i].getY() + 25);
                this.entidades[i].SeDesenhe(g);
            }
            Image newImage = (Image)Properties.Resources.ResourceManager.GetObject("Especializacao");
            g.DrawImage(newImage, this.x, this.y);
        }

        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }

        public bool GetArea(int x, int y)
        {
            if (x - this.x >= 0 && x - this.x <= 100)
                if(y - this.y >= 0 && y - this.y <= 43)
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
