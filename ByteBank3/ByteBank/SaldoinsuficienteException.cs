using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoinsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoinsuficienteException()
        {

        }
        public SaldoinsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            this.Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoinsuficienteException (string mensagem)
            : base (mensagem)        
        {
        }
    }
}
