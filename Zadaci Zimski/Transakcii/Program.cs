using System;
using System.Collections.Generic;

namespace Transakcii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===VNESUVANJE NA TRANSAKCIITE I SPRAVUVANJE SO ISKLUCOCI===");
            Console.WriteLine("Vnesi broj na transakcii");
            var Transakcii = new List<Transakcija>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string valuta = "";
                Console.WriteLine("Denarska/Devizna: 1/2 ? ");
                var tip = Console.ReadLine();
                Console.WriteLine("Vnesi den: ");
                var den = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi mesec: ");
                var mesec = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi godina: ");
                var godina = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi sredstva: ");
                var sredstva = decimal.Parse(Console.ReadLine());
                try
                {
                    if (tip == "1")
                    {
                        Transakcii.Add(new DenarskaTransakcija(den, mesec, godina, sredstva));
                    }
                    else if (tip == "2")
                    {
                        Console.WriteLine("Vnesi valuta: ");
                        valuta = Console.ReadLine();
                        Transakcii.Add(new DeviznaTransakcija(den, mesec, godina, sredstva, valuta));
                    }
                }
                catch (InvalidDateException)
                {
                    Console.WriteLine($"Invalid Date {den}/{mesec}/{godina}");
                }
                catch (NotSupportedCurrencyException)
                {
                    Console.WriteLine($"{valuta} is not a supported currency");
                }
            }

            Console.WriteLine("===PECHATENJE NA SITE TRANSAKCII===");
            foreach(var transakcija in Transakcii)
            {
                transakcija.Pecati();
            }


        }
    }
}
