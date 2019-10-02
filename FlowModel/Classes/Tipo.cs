using System.Collections.Generic;

namespace FlowModel
{
    class Tipo
    {
        private bool primario;
        private bool composto;
        private bool derivado;


        private int cardMin;
        private int cardMax;

        public Tipo()
        {
            this.primario = false;
            this.composto = false;
            this.derivado = false;

            this.cardMin = 1;
            this.cardMax = 1;
        }

        public void Altera(bool p, bool c, bool d, int min, int max)
        {
            this.primario = p;
            this.composto = c;
            this.derivado = d;

            this.cardMin = min;
            this.cardMax = max;
        }

        public List<int> GetStatus()
        {
            List<int> status = new List<int>();
            status.Add(this.primario ? 1 : 0);
            status.Add(this.composto ? 1 : 0);
            status.Add(this.derivado ? 1 : 0);

            status.Add(this.cardMin);
            status.Add(this.cardMax);

            return status;
        }

        public string getPropriedades()
        {
            if (this.primario)
                return "Primario";
            if (this.cardMin == 0)
                return "Opcional";
            if (this.composto)
                return "Composto";

            return "Comum";
        }
    }
}
