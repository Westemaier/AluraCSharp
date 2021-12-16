using ByteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
            public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBoficacao();

        }

        public void Registrar(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBoficacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


    }
}
