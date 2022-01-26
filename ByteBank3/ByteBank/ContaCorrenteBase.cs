using System;

namespace ByteBank
{
    public class ContaCorrenteBase
    {
        private double _saldo;

        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new ArgumentException();
            }

            _saldo -= valor;

        }
    }
}