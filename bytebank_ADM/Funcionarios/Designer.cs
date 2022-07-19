using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class Designer:Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.50;
        }
    }
}
