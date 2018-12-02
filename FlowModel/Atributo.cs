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
        private Atributo derivado;

        private int id;

        public override string ToString()
        {
            return this.getName();
        }

        public Atributo(string n, int Px, int Py, Desenho p)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;
            this.dado = new Dados(1);
            this.propriedades = new Tipo();
            this.proprietario = p;
            this.qtdAtributos = 0;
            this.derivado = null;

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
                    this.propriedades.Altera(false, true, false, 1, 1);
                    break;
            }

        }

        public Atributo getDerivado()
        {
            return this.derivado;
        }

        public void setDerivado (Atributo a)
        {
            this.derivado = a;
        }

        public void setProprietario(Desenho a)
        {
            this.proprietario = a;
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

        public void setDado(int idDado)
        {
            this.dado = new Dados(idDado);
        }
        public Dados getDados()
        {
            return this.dado;
        }

        public void setCardMin(int cardMin)
        {
            List<int> atual = this.propriedades.GetStatus();
            if(cardMin != 0)
                this.propriedades.Altera(false, Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), cardMin, atual[4]);
            else
                this.propriedades.Altera(Convert.ToBoolean(atual[0]), Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), cardMin, atual[4]);

        }
        public void setCardMax(int cardMax)
        {
            List<int> atual = this.propriedades.GetStatus();
            this.propriedades.Altera(Convert.ToBoolean(atual[0]), Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), atual[3], cardMax);
        }
        public int getCardMin()
        {
            List<int> atual = this.propriedades.GetStatus();
            return atual[3];
        }
        public int getCardMax()
        {
            List<int> atual = this.propriedades.GetStatus();
            return atual[4];
        }

        public void AlteraTipo (List<int> status)
        {
            this.propriedades.Altera(Convert.ToBoolean(status[0]), Convert.ToBoolean(status[1]), Convert.ToBoolean(status[2]), status[3], status[4]);
        }

        public int getIndice()
        {
            return indice;
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
        public int getIntDado()
        {
            return this.dado.getIDDado();
        }
        public List<int> getPropriedade()
        {
            return this.propriedades.GetStatus();
        }
        public string getTipo()
        {
            return this.propriedades.getPropriedades();
        }
        public void comumToPrimario()
        {
            if(this.propriedades.getPropriedades().Equals("Comum"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(true, Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), atual[3], atual[4]);
                this.y = this.y - 86;
            }
        }
        public void comumToOpcional()
        {
            if (this.propriedades.getPropriedades().Equals("Comum"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(Convert.ToBoolean(atual[0]), Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), 0, atual[4]);
                this.x = this.x + 86;
                this.y = this.y - 90; //tamanho 90 veio do recuo do tamanho da entidade  + o recuo do tamamnho do proprio atributo
            }
        }
        public void PrimarioToComum()
        {
            if (this.propriedades.getPropriedades().Equals("Primario"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(false, Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), atual[3], atual[4]);
                this.y = this.y + 86;
            }
        }
        public void OpcionalToComum()
        {
            if (this.propriedades.getPropriedades().Equals("Opcional"))
            {
                List<int> atual = this.propriedades.GetStatus();
                this.propriedades.Altera(Convert.ToBoolean(atual[0]), Convert.ToBoolean(atual[1]), Convert.ToBoolean(atual[2]), 1, atual[4]);
                this.x = this.x - 86;
                this.y = this.y + 90;
            }
        }
        public string getSql()
        {
            string str = "";
            str += this.getName().Split(' ')[0] + " ";
            str += this.dado.getDado() + " ";
            switch (this.propriedades.getPropriedades())
            {
                case "Primario":
                    str += "PRIMARY KEY";
                    break;
                case "Opcional":
                    break;
                case "Comum":
                    str += "NOT NULL";
                    break;
            }
            return str;
        }
        public Desenho getProprietario()
        {
            return this.proprietario;
        }
        public string QuemSou()
        {
            return "Atributo";
        }

        public void SeDesenhe(Graphics g)
        {
            Image newImage;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            switch (this.propriedades.getPropriedades())
            {                
                case "Primario":
                    newImage = (Image)Properties.Resources.ResourceManager.GetObject("Atributo_Chave");
                    g.DrawImage(newImage, this.x, this.y);                    
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 18, this.y + 12 - (this.indice * 14));
                    break;
                case "Opcional":
                    newImage = (Image)Properties.Resources.ResourceManager.GetObject("Atributo_Opcional");
                    g.DrawImage(newImage, this.x, this.y);
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 18, this.y + 12 - (this.indice * 14));
                    break;
                case "Composto":
                    newImage = (Image)Properties.Resources.ResourceManager.GetObject("Atributo_Composto");
                    g.DrawImage(newImage, this.x, this.y);
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 40 + (this.indice * 50), this.y + 5);
                    break;
                case "Comum":
                    newImage = (Image)Properties.Resources.ResourceManager.GetObject("Atributo_Simples");
                    g.DrawImage(newImage, this.x, this.y);
                    g.DrawString(this.nome, new Font(new FontFamily("Arial"), 9), drawBrush, this.x + 18, this.y + 28 +(this.indice * 14));
                    break;
            }
        }

        public void Propriedades(Panel p)
        {
            throw new NotImplementedException();
        }
        public int getTam()
        {
            Bitmap bmpImagem = new Bitmap(1015, 600);
            Graphics medidor = Graphics.FromImage(bmpImagem);
            SizeF tamanhoString = medidor.MeasureString(this.nome, new Font(new FontFamily("Arial"), 9));
            return Convert.ToInt16(tamanhoString.Width);
        }

        public bool GetArea(int x, int y)
        {
            Bitmap bmpImagem = new Bitmap(1015, 600);
            Graphics medidor = Graphics.FromImage(bmpImagem);
            SizeF tamanhoString = medidor.MeasureString(this.nome, new Font(new FontFamily("Arial"), 9));


            switch (this.propriedades.getPropriedades())
            {
                case "Comum":
                    if (x - this.x >= 18 && x - this.x <= tamanhoString.Width + 18)
                        if (y - this.y >= 28 + (this.indice * 14) && y - this.y <= 28 + (this.indice * 14) + tamanhoString.Height)
                            return true;
                    break;
                case "Primario":
                    if (x - this.x >= 18 && x - this.x <= tamanhoString.Width + 18)
                        if (y - this.y <= 12 - (this.indice * 14) && y - this.y >= 12 - (this.indice * 14)  + tamanhoString.Height)
                            return true;
                    break;
                case "Opcional":
                    if (x - this.x >= 18 && x - this.x <= tamanhoString.Width + 18)
                        if (y - this.y >= 14 - (this.indice * 14) && y - this.y <= 14 - (this.indice * 14) + tamanhoString.Height)
                            return true;
                    break;
                case "Composto":
                    if (x - this.x >= 18 && x - this.x <= tamanhoString.Width + 18)
                        if (y - this.y >= 0 + (this.indice * 14) && y - this.y <= 14 + (this.indice * 14) + tamanhoString.Height)
                            return true;
                    break;
            }


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
