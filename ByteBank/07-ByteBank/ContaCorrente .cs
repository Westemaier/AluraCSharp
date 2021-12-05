using _07_ByteBank;


namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }


        }
        public int Numero { get; set; }


        private double _Saldo = 100;

        public double Saldo
        {
            get
            {
                return _Saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _Saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

           TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (_Saldo < valor)
            {
                return false;
            }

            _Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _Saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._Saldo < valor)
            {
                return false;
            }

            _Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}



