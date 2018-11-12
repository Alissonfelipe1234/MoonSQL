using System;
using System.Collections.Generic;
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

        public void SeDesenhe(Form d)
        {
            throw new NotImplementedException();
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
