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

            nomeParametro = nomeParametro.ToUpper(); // Vai passar a ser valor
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; //moedaDestino= 
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); //x

            string resultado = _argumentos.Substring (indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('&');
            
             if(indiceEComercial == -1)
            {
                return resultado;
            }
             return resultado.Remove(indiceEComercial);   
        }      
    }
}