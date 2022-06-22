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

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Pedro";
            funcionario.Cpf = "730.546.070-21";
            funcionario.Salario = 3700;
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("CPF: " + funcionario.Cpf);
            Console.WriteLine("Salário: R$" + funcionario.Salario);

            Console.WriteLine("Bonificação: R$" + funcionario.GetBonificacao());
            Console.WriteLine("Total salário com Bonificação: R$" + (funcionario.Salario + funcionario.GetBonificacao()));
            gerenciador.Registrar(funcionario);
            Console.WriteLine("******************************************\n");

            Diretor diretor = new Diretor();
            diretor.Nome = "Paulo";
            diretor.Cpf = "730.546.070-22";
            diretor.Salario = 9000;
            Console.WriteLine("Nome: " + diretor.Nome);
            Console.WriteLine("CPF: " + diretor.Cpf);
            Console.WriteLine("Salário: R$" + diretor.Salario);

            Console.WriteLine("Bonificação: R$" + diretor.GetBonificacao());
            Console.WriteLine("Total salário com Bonificação: R$" + (diretor.Salario + diretor.GetBonificacao()));

            Console.WriteLine("******************************************\n");

            Designer designer = new Designer();
            designer.Nome = "Luiz";
            designer.Cpf = "730.546.070-20";
            designer.Salario = 4500;
            Console.WriteLine("Nome: " + designer.Nome);
            Console.WriteLine("CPF: " + designer.Cpf);
            Console.WriteLine("Salário: R$" + designer.Salario);

            Console.WriteLine("Bonificação: R$" + designer.GetBonificacao());
            Console.WriteLine("Total salário com Bonificação: R$" + (designer.Salario + designer.GetBonificacao()));
            Console.WriteLine("******************************************\n");

            Analista analista = new Analista();
            analista.Nome = "Amanda";
            analista.Cpf = "730.546.070-21";
            analista.Salario = 8200;
            Console.WriteLine("Nome: " + analista.Nome);
            Console.WriteLine("CPF: " + analista.Cpf);
            Console.WriteLine("Salário: R$" + analista.Salario);

            Console.WriteLine("Bonificação: R$" + analista.GetBonificacao());
            Console.WriteLine("Total salário com Bonificação: R$" + (analista.Salario + analista.GetBonificacao()));
            Console.WriteLine("******************************************\n");
        }
    }
}
