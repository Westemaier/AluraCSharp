using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente();
            minhaConta.saldo = 500;

            ContaCorrente outraConta = minhaConta;
            outraConta.saldo += 1000;

            Console.WriteLine(minhaConta.saldo);
            Console.ReadLine();
        }
    }
}
