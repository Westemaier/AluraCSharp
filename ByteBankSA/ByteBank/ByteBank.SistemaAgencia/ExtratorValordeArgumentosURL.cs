using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
     public class ExtratorValordeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValordeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O Argumento url não pode ser nulo ou vazio.", nameof(url));
            }
            URL = url;
            int indiceInterrogacao = URL.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }
        public string GetValor(string nomeParametro)
        {

            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring (indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');
            
             if(indiceEComercial == -1)
            {
                return resultado;
            }
             return resultado.Remove(indiceEComercial);   
        }      
    }
}