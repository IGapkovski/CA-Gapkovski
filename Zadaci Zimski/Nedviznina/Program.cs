using System;

namespace Nedviznina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nedviznina");
            while (true)
            {
                Console.WriteLine("Vnesi adresa");
                var adresa = Console.ReadLine();
                Console.WriteLine("Vnesi kvadratura");
                var kvadratura = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi kvadratura");
                var cena = int.Parse(Console.ReadLine());
                Console.WriteLine("Kukja ili Vila: K/V ?");
                var tip = Console.ReadLine();
                if (tip == "K")
                {
                    new Nedviznina(adresa, kvadratura, cena).Print();
                }
                else
                {
                    Console.WriteLine("Vnesi Danok na luksuz: ");
                    var danok = int.Parse(Console.ReadLine());
                    new Vila(adresa, kvadratura, cena, danok).Print();
                }
                Console.WriteLine("Nov Vnes: D/N ?");
                if (Console.ReadLine() != "D") return;
            }
        }
    }
}
