using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadacaZapirki
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine(); //23,-16,43
            var listaBroevi = ParseTextNumbers(text);
            PecatiMaksimum(listaBroevi);

            // Za doma da se resi istata zadaca so koristenje na funkcijata split
            Console.WriteLine("Izlez na text.Split so delimiter zapirka:");
            var textSplitPoZapirkaArray = text.Split(','); // string array -----> string[]
            var textSplitPoZapirkaList = text.Split(',').ToList(); // predhodniot array zacuvan vo lista

            Console.WriteLine(String.Join(';', textSplitPoZapirkaList));
        }

        public static void PecatiMaksimum(List<int> lista)
        {
            Console.WriteLine("Nesortirana lista na broevi: " + String.Join(';', lista));
            lista.Sort();
            Console.WriteLine("Sortirana lista na broevi: " + String.Join(';', lista));

            Console.WriteLine("Maksimum od broevite e posledniot element od sortiranata lista: " + lista[lista.Count - 1]);
            //Console.WriteLine("Maksimum od broevite e posledniot element od sortiranata lista: " + listaNaBroevi[^1]); //C# 8 - isto kako predhodnata linija

            Console.WriteLine("Maksimum od listata broevi e (koristime funkcija Last() na vekje sortirana lista)" + lista.Last());
            Console.WriteLine("Maksimum od listata broevi e (koristime funkcuja Max()): " + lista.Max());
        }

        public static List<int> ParseTextNumbers(string text)
        {
            var stringListaNaBroevi = text.Split(',').ToList();
            var listaNaBroevi = new List<int>();
            foreach(string broj in stringListaNaBroevi)
            {
                int validenBroj;
                if (Int32.TryParse(broj, out validenBroj)) listaNaBroevi.Add(validenBroj);
            }

            //String e char array, zatoa moze da iterirame so foreach
            //var tempBrojString = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    //if (text[i] != ',')
            //    //{
            //    //    tempBrojString = tempBrojString + text[i];
            //    //}

            //    //if (text[i] == ',' || i == text.Length - 1)
            //    //{
            //    //    try
            //    //    {
            //    //        listaNaBroevi.Add(Convert.ToInt32(tempBrojString));
            //    //        tempBrojString = "";
            //    //    }
            //    //    catch (Exception ex)
            //    //    {
            //    //        Console.WriteLine("Nevaliden vnes na podatok i ovoj ke bide preskoknat: " + tempBrojString);
            //    //    }
            //    //    finally
            //    //    {
            //    //        tempBrojString = "";
            //    //    }
            //    //}
            //}

            return listaNaBroevi;
        }
    }
}