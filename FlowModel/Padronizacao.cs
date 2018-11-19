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

        public void SeDesenhe(Graphics g, Panel p)
        {
            Pen caneta = new Pen(new System.Drawing.SolidBrush(System.Drawing.Color.Black));
            g.DrawLine(caneta, this.x + 50, this.y + 43, this.padrao.getX() + 50, this.padrao.getY() + 25);
            this.padrao.SeDesenhe(g, p);
            for (int i = 0; i < this.entidades.Count; i++)
            {
                g.DrawLine(caneta, this.x + 50, this.y, this.entidades[i].getX(), this.entidades[i].getY() + 25);
                this.entidades[i].SeDesenhe(g, p);
            }
            Image newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Generalizacao.png");
            g.DrawImage(newImage, this.x, this.y);
            //SizeF tam = g.MeasureString(this.nome, new Font(new FontFamily("Arial"), 12));
            //tam.Width = tam.Width / 3;
            //System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            //g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + tam.Width, this.y + 20);


            p.Refresh();
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
    }
}
