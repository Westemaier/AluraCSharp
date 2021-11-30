using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__ConversoesEoutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;


            // O int é um variavel que suporta até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;

            Console.WriteLine(salarioEmInteiro);

            // O Long é uma variavel de 64 bits

            long idade;
            idade = 13000000000;
            

            // O Short é uma variavel que suporta até 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;


            float altura = 1.80f;



            Console.ReadLine();





        }
    }
}
