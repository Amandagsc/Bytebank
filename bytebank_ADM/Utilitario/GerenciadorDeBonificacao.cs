using bytebank_ADM.Funcionarios;


namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;
        public void Registrar
            (
            Funcionario funcionario, 
            Diretor diretor,
            Designer designer, 
            Analista analista
            )
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        } 
        public double Getbonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
