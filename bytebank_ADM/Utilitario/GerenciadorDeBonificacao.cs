using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }
        public double Getbonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
