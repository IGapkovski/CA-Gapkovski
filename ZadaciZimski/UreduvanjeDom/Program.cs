using System;
using System.Collections.Generic;

namespace UreduvanjeDom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ureduvanje na dom");
            Console.Write("Vnesi broj na objekti: ");
            int n = int.Parse(Console.ReadLine());
            var domovi = new List<Kukja>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-----Dom {i+1}-----");
                Console.Write("Sirina na masa: ");
                int sirinaMasa = int.Parse(Console.ReadLine());
                Console.Write("Dolzina na masa: ");
                int dolzinaMasa = int.Parse(Console.ReadLine());
                Console.Write("Sirina na soba: ");
                int sirinaSoba = int.Parse(Console.ReadLine());
                Console.Write("Dolzina na soba: ");
                int dolzinaSoba = int.Parse(Console.ReadLine());
                Console.Write("Adresa:");
                string adresa = Console.ReadLine();
                var dom = new Kukja(new Soba(new Masa(dolzinaMasa, sirinaMasa), dolzinaSoba, sirinaSoba), adresa);
                domovi.Add(dom);
            }
            Console.WriteLine();
            foreach(var dom in domovi)
            {
                dom.Pecati();
            }
        }
    }
}
