using System;

namespace Dogovor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dogovor!");
            var dogovor = new Dogovor();
            if (dogovor.IsSamePP())
            {
                Console.WriteLine($"Dogovor {dogovor.BrDogovor}:");
                Console.WriteLine("Postojat potpishuvaci so ist EMBG");
            }
            else
            {
                Console.WriteLine($"Dogovor br. {dogovor.BrDogovor} - {dogovor.Kategorija}");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{dogovor.PP[i].EMBG} {dogovor.PP[i].Ime}, {dogovor.PP[i].Prezime}");
                }
            }
        }
    }
}
