using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel
{
    class Atributo:Desenho
    {
        private string nome;
        private int x;
        private int y;
        private int indice;
        private int qtdAtributos;
        private Dados dado;
        private Tipo propriedades;
        private Desenho proprietario;

        private int id;

        public Atributo(string n, int Px, int Py, Desenho p)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;
            this.dado = null;
            this.propriedades = new Tipo();
            this.proprietario = p;

            switch (p.QuemSou())
            {
                case "Entidade":
                    Entidade ent = (Entidade)this.proprietario;
                    this.indice = ent.getQtdAtributos();
                    ent.addAtributo();
                    break;
                case "Relacionamento":
                    Relacionamento rel = (Relacionamento)this.proprietario;
                    this.indice = rel.getQtdAtributos();
                    rel.addAtributo();
                    break;
                case "Atributo":
                    Atributo atr = (Atributo)this.proprietario;
                    this.indice = atr.getQtdAtributos();
                    atr.addAtributo();
                    break;
            }

        }

        public void addAtributo()
        {
            this.qtdAtributos++;
        }

        public int getQtdAtributos()
        {
            return this.qtdAtributos;
        }

        public void setDado(int idDado)
        {
            this.dado = new Dados(idDado);
        }
         
        public void AlteraTipo (List<int> status)
        {
            this.propriedades.Altera(Convert.ToBoolean(status[0]), Convert.ToBoolean(status[1]), Convert.ToBoolean(status[2]), status[3], status[4]);
        }

        public string getName()
        {
            return nome;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public string getIdDado()
        {
            return this.dado.getDado();
        }

        public List<int> getPropriedade()
        {
            return this.propriedades.GetStatus();
        }
        public void comumToPrimario()
        {
            if(this.propriedades.getPropriedades().Equals("Comum"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(true, Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), atual[3], atual[4]);
                this.y = this.y - 52;
            }
        }
        public void comumToOpcional()
        {
            if (this.propriedades.getPropriedades().Equals("Comum"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(Convert.ToBoolean(atual[0]), Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), 0, atual[4]);
                this.x = this.x + 100;
                this.y = this.y - 52;
            }
        }
        public void PrimarioToComum()
        {
            if (this.propriedades.getPropriedades().Equals("Primario"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(false, Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), atual[3], atual[4]);
                this.y = this.y + 52;
            }
        }
        public void OpcionalToComum()
        {
            if (this.propriedades.getPropriedades().Equals("Opcional"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(Convert.ToBoolean(atual[0]), Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), 1, atual[4]);
                this.x = this.x - 100;
                this.y = this.y + 52;
            }
        }
        public string QuemSou()
        {
            return "Atributo";
        }

        public void SeDesenhe(Graphics g, Panel p)
        {
            Image newImage;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            switch (this.propriedades.getPropriedades())
            {                
                case "Primario":
                    newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Atributo_Chave.png");
                    g.DrawImage(newImage, this.x, this.y);                    
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + 18, this.y - (this.indice * 12));
                    break;
                case "Opcional":
                    newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Atributo_Opcional.png");
                    g.DrawImage(newImage, this.x, this.y);
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + 18, this.y - (this.indice * 12));
                    break;
                case "Comum":
                    newImage = Image.FromFile("C:\\Users\\aliss\\Desktop\\C#\\FlowModel\\FlowModel\\resources\\Atributo_Simples.png");
                    g.DrawImage(newImage, this.x, this.y);
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 12), drawBrush, this.x + 18, this.y + 32 +(this.indice * 12));
                    break;
            }
            p.Refresh();
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
