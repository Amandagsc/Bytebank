using bytebank_ADM.Funcionarios;

namespace bytebank_ADM
{
    public class Analista : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.90;
        }
    }
}
