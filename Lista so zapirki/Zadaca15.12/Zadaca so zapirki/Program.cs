using System;
using System.Collections.Generic;

namespace Zadaca_so_zapirki
{
    class Program
    {
        static bool isSorted = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi lista na broevi odvoeni so zapirki");
            string listaVneseniBroevi = Console.ReadLine();
            List<int> listaBroevi = KreirajLista(listaVneseniBroevi);
            PrintajLista(listaBroevi);
            var sortiraniBroevi = SortirajLista(listaBroevi);
            PrintajLista(sortiraniBroevi);
        }

        static List<int> KreirajLista(string lista)
        {
            var nesortiranaLista = new List<int>();
            for (int i = 0; i < lista.Length; i++)
            {
                string novBroj = "";
                while (lista[i] != ',')
                {
                    novBroj += lista[i];
                    if (i == lista.Length - 1) break;
                    i++;
                }
                nesortiranaLista.Add(Convert.ToInt32(novBroj));
            }
            return nesortiranaLista;
        }

        static List<int> SortirajLista(List<int> lista)
        {
            var sortiranaLista = new List<int>(lista.Count);
            for (int i = 0; i < lista.Count; i++)
            {
                var tekovenBroj = lista[i];
                var tekovenIndex = i;

                while (tekovenIndex > 0 && sortiranaLista[tekovenIndex - 1] > tekovenBroj)
                {
                    tekovenIndex--;
                }

                sortiranaLista.Insert(tekovenIndex, tekovenBroj);
            }
            return sortiranaLista;
        }

        static void PrintajLista(List<int> lista)
        {
            if (!isSorted)
            {
                Console.WriteLine("Vnesena Lista");
                isSorted = true;
            }
            else Console.WriteLine("Sortirana lista");

            foreach (int broj in lista)
            {
                Console.WriteLine(broj);
            }
        }
    }
}
