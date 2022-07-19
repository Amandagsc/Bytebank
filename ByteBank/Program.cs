using System;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Bem Vindo ao seu banco, ByteBank! ****\n");

            Cliente amanda = new Cliente();
            amanda.Nome = "Amanda Carvalho";
            amanda.CPF = "228.886.120-70";
            amanda.Profissao = "Analista desenvolvedora";

            ContaCorrente conta01 = new ContaCorrente(255, "255101-x");
            conta01.Saldo = 1000;

            Console.WriteLine("### Informações do titular ###");
            conta01.Titular = amanda;
            Console.WriteLine("Nome: " + conta01.Titular.Nome);
            Console.WriteLine("CPF: " + conta01.Titular.CPF);
            Console.WriteLine("Titular: " + conta01.Titular.Profissao + "\n");

            Console.WriteLine("### Informações da conta ###");
            conta01.Titular = amanda;
            Console.WriteLine("Saldo: " + conta01.Saldo);
            Console.WriteLine("Agência: " + conta01.Numero_Agencia);
        }
    }
}
