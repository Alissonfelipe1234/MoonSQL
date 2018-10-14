using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowModel
{
    class Entidade
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

    }
}
