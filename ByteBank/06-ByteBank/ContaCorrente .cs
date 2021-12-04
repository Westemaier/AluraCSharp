using _06_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int Agencia;
        public int Numero;
        private double Saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            this.Saldo = saldo;

        }
        public double ObterSaldo()
        {
            return Saldo;
        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}



