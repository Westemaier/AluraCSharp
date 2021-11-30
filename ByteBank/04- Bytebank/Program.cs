using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoBruno = new ContaCorrente();

            ContaDoBruno.titular = "Bruno";

            Console.WriteLine(ContaDoBruno.saldo);
            bool ResultadoSaque = ContaDoBruno.Sacar(500);
            Console.WriteLine(ContaDoBruno.saldo);
            Console.WriteLine(ResultadoSaque);

            ContaDoBruno.Depositar(500);
            Console.WriteLine(ContaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            Console.WriteLine("Saldo do Bruno : " + ContaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = ContaDoBruno.Transferir(2000, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno : " + ContaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado da transferencia: " + resultadoTransferencia);
            
            
            contaDaGabriela.Transferir(100, ContaDoBruno);
            
            
            Console.WriteLine("Saldo do Bruno : " + ContaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.ReadLine();

        }
    }
}
