using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        public static implicit operator Funcionario(Designer v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Funcionario(Auxiliar v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Funcionario(GerenteDeConta v)
        {
            throw new NotImplementedException();
        }
    }
}