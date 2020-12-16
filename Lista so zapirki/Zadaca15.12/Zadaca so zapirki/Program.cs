using System;
using System.Collections.Generic;

namespace Zadaca_so_zapirki
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi lista na broevi odvoeni so zapirki");
            string listaVneseniBroevi = Console.ReadLine();
            List<int> listaBroevi = KreirajLista(listaVneseniBroevi);
            PrintajLista(listaBroevi);
            //var sortiraniBroevi = SortirajLista(listaBroevi);
            //PrintajLista(sortiraniBroevi);
        }

        static List<int> KreirajLista(string lista)
        {
            var sortiranaLista = new List<int>();
            for (int i = 0; i < lista.Length; i++)
            {
                string novBroj = "";
                while (lista[i] != ',')
                {
                    novBroj += lista[i];
                    if (i == lista.Length - 1) break;
                    i++;
                }
                sortiranaLista.Add(Convert.ToInt32(novBroj));
            }
            return sortiranaLista;
        }
        static void PrintajLista(List<int> lista)
        {
            foreach(int broj in lista)
            {
                Console.WriteLine(broj);
            }
        }
    }
}
