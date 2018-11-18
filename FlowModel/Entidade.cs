using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Entidade:Desenho
    {
        private string nome;
        private int x;
        private int y;

        private int id;


        public Entidade(string n, int Px, int Py)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;            
        }

        public string getNome()
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

        public string QuemSou()
        {
            return "Entidade";
        }

        public void SeDesenhe(Graphics g, Panel p)
        {
            Image newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Entidade.png");
            g.DrawImage(newImage, this.x, this.y-20);
            SizeF tam = g.MeasureString(this.nome, new Font(new FontFamily("Arial"), 12));
            tam.Width = tam.Width / 3;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + tam.Width, this.y);
        }

        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }

        public bool GetArea(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
