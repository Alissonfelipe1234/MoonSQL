using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Padrao:Desenho
    {
        private string nome;
        private int x;
        private int y;

        private Entidade padrao;
        private List<Entidade> ents;

        private int id;


        public Padrao(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;

            this.padrao = null;
            this.ents = new List<Entidade>();
        }
        public Entidade getEntidadeP()
        {
            return this.padrao;
        }
        public List<Entidade> getEnts()
        {
            return this.ents;
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
        }

        public string QuemSou()
        {
            return "Padrao";
        }

        public void SeDesenhe(Graphics g, Panel p)
        {
            Image newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Entidade.png");
            g.DrawImage(newImage, this.x, this.y);
            SizeF tam = g.MeasureString(this.nome, new Font(new FontFamily("Arial"), 12));
            tam.Width = tam.Width / 3;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + tam.Width, this.y + 20);

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
