using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 4989754);
            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("dsadsadas");

            Console.WriteLine(conta.Numero);


            Console.ReadLine();
               

        }
    }
}