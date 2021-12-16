﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
   public class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        // 3 - Gerente de conta corrente
        // 4 - Coordenador
        // N - ...



        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }


        public double GetBoficacao()
        {
            return Salario * 0.10;
        }
    }
}
