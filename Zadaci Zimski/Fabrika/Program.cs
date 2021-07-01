using System;
using System.Collections.Generic;

namespace Fabrika
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabrika = new Fabrika();
            fabrika.Rabotnici = new List<Rabotnik>();
            Console.WriteLine("Fabrika");
            Console.Write("Vnesi broj na rabotnici: ");
            int n = int.Parse(Console.ReadLine());
            fabrika.BrojRabotnici = n;
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-----Rabotnik {i + 1}-----");
                Console.Write("Vnesi ime: ");
                string ime = Console.ReadLine();
                Console.Write("Vnesi prezime: ");
                string prezime = Console.ReadLine();
                Console.Write("Vnesi plata: ");
                int plata = int.Parse(Console.ReadLine());
                fabrika.Rabotnici.Add(new Rabotnik(ime, prezime, plata));
            }
            Console.Write("Vnesi minimalna plata: ");
            int minPlata = int.Parse(Console.ReadLine());
            Console.WriteLine("Site vraboteni: ");
            fabrika.PecatiVraboteni();
            Console.WriteLine($"\nVraboteni so plata povisoka od {minPlata}:");
            fabrika.PecatiSoPlata(minPlata);
        }
    }
}
