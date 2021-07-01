using System;
using System.Collections.Generic;
using System.Linq;

namespace Igroteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!Igroteka");
            var kupche = new List<Igracka>();
            Kocka petra;
            Console.Write("Vnesi broj na igracki: ");
            var n = int.Parse(Console.ReadLine());

            // Vnes na lista na igracki 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vnesi 1-Topka ili 2-Kocka: ");
                var izbor = int.Parse(Console.ReadLine());
                if (izbor == 2)
                {
                    Console.Write("Vnesi boja: ");
                    var boja = Console.ReadLine();
                    Console.Write("Vnesi gustina: ");
                    var gustina = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi visina: ");
                    var visina = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi sirina: ");
                    var sirina = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi dolzina: ");
                    var dolzina = int.Parse(Console.ReadLine());
                    kupche.Add(new Kocka(boja, gustina, visina, sirina, dolzina));
                }
                if (izbor == 1)
                {
                    Console.Write("Vnesi boja: ");
                    var boja = Console.ReadLine();
                    Console.Write("Vnesi gustina: ");
                    var gustina = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi radius: ");
                    var radius = int.Parse(Console.ReadLine());
                    kupche.Add(new Topka(boja, gustina, radius));
                }
            }

            
            // Vnesuvanje podatoci za kockata na Petra
            Console.WriteLine("Vnesi podatoci za kockata na Petra");
            Console.Write("Vnesi boja: ");
            var bojaP = Console.ReadLine();
            Console.Write("Vnesi gustina: ");
            var gustinaP = int.Parse(Console.ReadLine());
            Console.Write("Vnesi visina: ");
            var visinaP = int.Parse(Console.ReadLine());
            Console.Write("Vnesi sirina: ");
            var sirinaP = int.Parse(Console.ReadLine());
            Console.Write("Vnesi dolzina: ");
            var dolzinaP = int.Parse(Console.ReadLine());
            petra = new Kocka(bojaP, gustinaP, visinaP, sirinaP, dolzinaP);

            // Pecatenje DA/NE
            double vkupnaMasa = 0.0;
            foreach(var igracka in kupche)
            {
                if (igracka is Topka t)
                    vkupnaMasa += t.GetMasa();
                else if(igracka is Kocka k)
                    vkupnaMasa += k.GetMasa();
            }
            if (vkupnaMasa > petra.GetMasa())
                Console.WriteLine("DA");
            else
                Console.WriteLine("NE");

            // Pecatenje razliki na volumeni i plostini
            var volumeni = new List<float>();
            var plostini = new List<float>();
            
            foreach (var igracka in kupche)
            {
                if (igracka is Topka t)
                {
                    volumeni.Add(t.GetVolumen());
                    plostini.Add(t.GetPlostina());
                }
                else if (igracka is Kocka k)
                {
                    volumeni.Add(k.GetVolumen());
                    plostini.Add(k.GetPlostina());
                }
            }
            Console.WriteLine($"Razlikata e: {Math.Abs(petra.GetVolumen() - volumeni.Max())}");
            Console.WriteLine($"Razlikata e: {Math.Abs(petra.GetPlostina() - plostini.Min())}");
        }
    }
}
