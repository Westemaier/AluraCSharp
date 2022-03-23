using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensões
{
    public static class ListExtensoes<T>
    {

        public static void AdicionarVarios (List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);


            ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4);

            List<string> nomes = new List<string>();
            nomes.Add("Luan Lucas");

            ListExtensoes<string>.AdicionarVarios(nomes, "Lucas");


        }




    }

}
