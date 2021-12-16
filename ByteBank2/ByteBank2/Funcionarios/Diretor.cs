using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        
        
        public double GetBoficacao()
        {
                return Salario;
        }
    }
}
