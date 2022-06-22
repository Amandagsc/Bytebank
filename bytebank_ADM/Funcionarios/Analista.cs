using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM
{
    public class Analista
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario * 0.90;
        }
    }
}
