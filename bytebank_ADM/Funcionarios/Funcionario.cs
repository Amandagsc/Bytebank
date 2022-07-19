using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        //0 - Funcionário (Bonificação de 10% sobre o salário)
        //1 - Diretor (Bonificação de 100% sobre o salário)
        //2 - Designer
        //3 - Analista

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
