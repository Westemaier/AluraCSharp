﻿using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //pagina?argumentos
            //012345678
            string teste2 = "PALAVRA";
            Console.WriteLine(teste2.IndexOf("Ra"));
            Console.ReadLine();


            string urlParametros = "http://bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValordeArgumentosURL extratorDeValores = new ExtratorValordeArgumentosURL(urlParametros);
            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            string valormoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valormoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));
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