using System;
using System.Collections.Generic;

namespace SoncevSistem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soncev Sistem");
            Console.WriteLine("Vnesi broj na planeti: ");
            var n = int.Parse(Console.ReadLine());
            var planeti = new List<Planeta>();
            SonchevSistem ss;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Vnesi ime na {i+1} planeta: ");
                var ime = Console.ReadLine();
                Console.WriteLine("Vnesi dijametar na planeta: ");
                var dijametar = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi oddalecenost od Sonceto: ");
                var o = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi masa na planetata: ");
                var masa = float.Parse(Console.ReadLine());
                planeti.Add(new Planeta(ime, dijametar, o, masa));
            }

            ss = new SonchevSistem(planeti);
            ss.Print();
            Console.WriteLine("Vnesi masa za sporedba: ");
            var masaSporedba = float.Parse(Console.ReadLine());
            ss.PecatiSoMasa(masaSporedba);
        }
    }
}
