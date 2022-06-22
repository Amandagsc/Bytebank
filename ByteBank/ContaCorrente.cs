using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular
        {
            get;
            set;
        }
        public string Nome_Agencia { get; set; }
        
        private int _numero_agencia;
        public int Numero_Agencia 
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }


        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para Saque!\n");
                Console.WriteLine("Saldo: R$" + saldo);
                return false;
            }
            if (valor < 0)
            {
                Console.WriteLine("\nValor inválido para Saque!");
                return false;
            }
            else
            {
                saldo = saldo - valor;
                Console.WriteLine("\n Saque Efetuado com sucesso!!!");
                Console.WriteLine("\n Saldo Pós-Saque: R$" + saldo);
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (saldo < 0)
            {
                Console.WriteLine("\nValor inválido para Depósito!");
            }
            else
            {
                saldo = saldo + valor;
                Console.WriteLine("\n Depósito Efetuado com sucesso!!!");
                Console.WriteLine("\n Saldo Pós-Depósito: R$" + saldo);
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para Transferência!\n");
                Console.WriteLine("Saldo: R$" + saldo);
                return false;
            }
            if (valor < 0)
            {
                Console.WriteLine("\nValor inválido para Transferência!");
                return false;
            }

            else
            {
                saldo = saldo - valor;
                Console.WriteLine("\n Transferência Efetuada com sucesso!!!");
                Console.WriteLine("\n Saldo Pós-Transferência: R$" + saldo);
                return true;
            }
        }
        
        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;
            TotalDeContascriadas += 1;
        }

        public static int TotalDeContascriadas { get; set; }
    }
}
