using _06_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int Agencia;
        public int Numero;
        private double Saldo = 100;

        DefinirSaldo (double saldo)
        public double ObterSaldo()
        {
            return Saldo;
        }

        public bool Sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}



