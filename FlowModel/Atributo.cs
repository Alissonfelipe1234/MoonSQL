using System;
using System.Collections.Generic;
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
        private Dados dado;
        private Tipo propriedades;
        private int idProprietario;
        private int tipoProprietario;

        private int id;

        public Atributo(string n, int Px, int Py, int idDado, int idP, int tipoP)
        {
            this.nome = n;
            this.x = Px;
            this.y = Py;
            this.dado = new Dados(idDado);
            this.propriedades = new Tipo();
            this.idProprietario = idP;
            this.tipoProprietario = tipoP;
        }
         
        public void AlteraTipo (List<int> status)
        {
            this.propriedades.Altera(Convert.ToBoolean(status[0]), Convert.ToBoolean(status[1]), Convert.ToBoolean(status[2]), status[3], status[4]);
        }

        public string getNome()
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

        public int getIdProprietario()
        {
            return this.idProprietario;
        }

        public int getTipoProprietario()
        {
            return this.tipoProprietario;
        }

        public void SeDesenhe(Form d)
        {
            throw new NotImplementedException();
        }

        public string QuemSou()
        {
            return "Atributo";
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
