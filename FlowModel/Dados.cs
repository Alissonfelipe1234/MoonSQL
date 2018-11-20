using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowModel
{
    class Dados
    {
        private Dictionary<int, string> possiveis;
        private string escolhido;

        public Dados (int id)
        {
            this.possiveis = new Dictionary<int, string>();
            this.possiveis.Add(0, "varchar");
            this.possiveis.Add(1, "integer");
            this.possiveis.Add(2, "boolean");
            this.possiveis.Add(3, "serial");
            this.possiveis.Add(4, "double");
            this.possiveis.Add(5, "smallint");
            this.possiveis.Add(6, "bigint");
            this.possiveis.Add(7, "numeric");
            this.possiveis.Add(8, "decimal");
            this.possiveis.Add(9, "real");
            this.possiveis.Add(10, "char");
            this.possiveis.Add(11, "text");
            this.possiveis.Add(12, "date");
            this.possiveis.Add(13, "bit");

            //"integer", "boolean", "serial", "double", "smallint", "bigint", 
            //"numeric", "decimal", "real", "char", "text", "date", "bit";
            
            if (id > -1 && id < 14)
            {
                this.escolhido = possiveis[id];
            }
            else
            {
                new Exception();
            }
            
        }

        public string getDadoById(int id)
        {
            return possiveis[id];
        }

        public string getDado()
        {
            return escolhido;
        }

        public Dictionary<int, string> getDados()
        {
            return possiveis;
        }

        
    }
}
