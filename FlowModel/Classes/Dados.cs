using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowModel
{
    class Dados
    {
        private readonly Dictionary<int, string> possiveis;
        private readonly string escolhido;

        public Dados(int id)
        {
            this.possiveis = new Dictionary<int, string>
            {
                { 0, "varchar" },
                { 1, "integer" },
                { 2, "boolean" },
                { 3, "serial" },
                { 4, "double" },
                { 5, "smallint" },
                { 6, "bigint" },
                { 7, "numeric" },
                { 8, "decimal" },
                { 9, "real" },
                { 10, "char" },
                { 11, "text" },
                { 12, "date" },
                { 13, "bit" }
            };

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

        public string GetDadoById(int id)
        {
            return possiveis[id];
        }

        public string GetDado()
        {
            return escolhido;
        }
        public int GetIDDado()
        {
            for (int i = 0; i < possiveis.Count(); i++)
                if (escolhido.Equals(possiveis[i]))
                    return i;
            return 1;
        }
        public Dictionary<int, string> GetDados()
        {
            return possiveis;
        }


    }
}
