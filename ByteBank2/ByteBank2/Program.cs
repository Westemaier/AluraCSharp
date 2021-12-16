using ByteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {


            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();





            Funcionario Carlos = new Funcionario ();
            Carlos.Nome = "Carlos";
            Carlos.CPF = "546.879.157-20";
            Carlos.Salario = 2000;

            gerenciador.Registrar(Carlos);

            Diretor Roberta = new Diretor();
            Roberta.Nome = "Roberta";
            Roberta.CPF = "454.658.148-3";
            Roberta.Salario = 5000;
            
            
            gerenciador.Registrar(Roberta);


            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBoficacao());

            Console.WriteLine(Roberta.Nome);
            Console.WriteLine(Roberta.GetBoficacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();



        }
    }
}
