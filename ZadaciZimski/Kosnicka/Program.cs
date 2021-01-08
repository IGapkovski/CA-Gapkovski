using System;
using System.Collections.Generic;

namespace Kosnicka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kupuvacka Kosnicka");
            Console.Write("Vnesi broj na artikli: ");
            int n = int.Parse(Console.ReadLine());
            PrintajKosnicka(PolniKosnicka(n));
        }
        static List<Proizvod> PolniKosnicka(int n)
        {
            var artikli = new List<Proizvod>();
            for (int i = 0; i < n; i++)
            {
                var artikl = new Proizvod();
                Console.WriteLine($"-------Vnesi artikl {i + 1}-------");
                Console.Write("Vnesi ime na proizvod: ");
                artikl.Ime = Console.ReadLine();
                Console.Write("Vnesi cena: ");
                artikl.Cena = decimal.Parse(Console.ReadLine());
                Console.Write("Vnesi kolicina: ");
                artikl.Kolicina = int.Parse(Console.ReadLine());
                artikli.Add(artikl);
            }
            return artikli;
        }
        static void PrintajKosnicka(List<Proizvod> artikli)
        {
            int i = 0;
            decimal total = 0;
            foreach(var artikl in artikli)
            {
                var vkCena = artikl.Cena * artikl.Kolicina;
                Console.WriteLine($"{i+1}. {artikl.Ime}\t{artikl.Cena:C}x{artikl.Kolicina}={vkCena}");
                total += vkCena; 
            }
            Console.WriteLine($"Total: {total}");
        }
    }
}
