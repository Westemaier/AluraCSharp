using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoinsuficienteException : Exception
    {

        public SaldoinsuficienteException()
        {

        }

        public SaldoinsuficienteException (string mensagem)
            : base (mensagem)        
        {


        }
    }
}
