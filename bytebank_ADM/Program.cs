using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;
using System;

namespace bytebank_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ByteBank Administração \n");

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Funcionario pedro = new Funcionario();
            pedro.Nome = "Pedro";
            pedro.Cpf = "730.546.070-21";
            pedro.Salario = 3700;
            Console.WriteLine("Nome: " + pedro.Nome);


            Console.WriteLine("Bonificação: R$" + pedro.GetBonificacao());

            Console.WriteLine("******************************************\n");

            Diretor paulo = new Diretor();
            paulo.Nome = "Paulo";
            paulo.Cpf = "730.546.070-22";
            paulo.Salario = 9000;
            Console.WriteLine("Nome: " + paulo.Nome);
            Console.WriteLine("Bonificação: R$" + paulo.GetBonificacao());;
            Console.WriteLine("******************************************\n");

            Designer luiz = new Designer();
            luiz.Nome = "Luiz";
            luiz.Cpf = "730.546.070-20";
            luiz.Salario = 4500;
            Console.WriteLine("Nome: " + luiz.Nome);
            Console.WriteLine("Bonificação: R$" + luiz.GetBonificacao());
            Console.WriteLine("******************************************\n");

            Analista amanda = new Analista();
            amanda.Nome = "Amanda";
            amanda.Cpf = "730.546.070-21";
            amanda.Salario = 8200;
            Console.WriteLine("Nome: " + amanda.Nome);
            Console.WriteLine("Bonificação: R$" + amanda.GetBonificacao());
            Console.WriteLine("******************************************\n");

            //gerenciador.Registrar(funcionario);
            gerenciador.Registrar(pedro, paulo, luiz,amanda);

            Console.WriteLine("Total de Bonificação : " + gerenciador.Getbonificacao());
        }
    }
}
