using System;
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

        public Relacionamento (string n, int Px, int Py, int qtdEntidadesEnvolvidas)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;
            this.card = new List<Cardinalidade>();
            for (int i = 0; i < qtdEntidadesEnvolvidas; i++)
                this.card.Add(new Cardinalidade(Px - 50, Py));
        }

        public string getNome ()
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

        public void alteraCard (Cardinalidade nova, int id)
        {
            if(id > -1 && id < 3)
                this.card[id] = nova;
        }

        public void SeDesenhe(Graphics g, Panel p)
        {
            Image newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Relacionamento.png");
            g.DrawImage(newImage, this.x, this.y);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + 15, this.y + 33);
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
            throw new NotImplementedException();
        }
    }
}
