using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY de inteiros com 5 posições!

            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            Console.WriteLine(idades[4]);

            Console.ReadLine();
        }

        static void testaString()
        {
            string padrao = "[0-9]{4,5}-?[0-9]{4,5}";
            string textoDeTeste = "Meu nome é Luan, me ligue em 99940-0813";
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);
            Console.ReadLine();
            string urlTeste = "https://bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://bytebank.com");
            Console.WriteLine(urlTeste.StartsWith("https://bytebank.com"));   //Starts = começa com string 
            Console.WriteLine(urlTeste.EndsWith("cambio")); //Ends = Termina com outra string
            Console.WriteLine(urlTeste.Contains("bytebank")); // Contains tem a mesma logica que StartsWith, EndsWith.                              
            Console.ReadLine();
            //pagina?argumentos
            //012345678
            string urlParametros = "http://bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValordeArgumentosURL extratorDeValores = new ExtratorValordeArgumentosURL(urlParametros);
            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            string valormoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valormoedaOrigem);
            Console.WriteLine(extratorDeValores.GetValor("VALOR"));
            Console.ReadLine();
            //TESTANDO TOLOWER
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";
            Console.WriteLine(mensagemOrigem.ToLower());
            //Testando REPLACE
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);
            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);
            string teste2 = "PALAVRA";
            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();
            //TESTANDO O METODO REMOVE
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();
            string palavra = "pagina?moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";
            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);
            Console.WriteLine("Tamanho da String nomeArgumento " + nomeArgumento.Length);
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
            Console.ReadLine();
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "sabydgsadasdas";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();
            ExtratorValordeArgumentosURL extrator = new ExtratorValordeArgumentosURL(null);
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);
            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
            Console.ReadLine();
        }
    }




}