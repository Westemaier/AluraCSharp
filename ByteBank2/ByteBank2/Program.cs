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
            Funcionario Carlos = new Funcionario (1);

            Carlos.Nome = "Carlos";
            Carlos.CPF = "546.879.157-20";
            Carlos.Salario = 2000;
            
            
            
            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBoficacao());
            


            Console.ReadLine();



        }
    }
}
