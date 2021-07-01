using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static List<FootballTeam> timovi = new List<FootballTeam>();
        static void Main(string[] args)
        {
            Console.WriteLine("----Footbal Teams------");
            Console.WriteLine("Vnesi broj na timovi");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                // Vnesi gi site potrebni informacii za klubovite
                Console.WriteLine("Klub (1) ili Reprezentacija (2): ");
                var tip = Console.ReadLine();
                Console.WriteLine("vnesi ime na trener");
                var imeTrener = Console.ReadLine();
                Console.WriteLine("vnesi ime na trener");
                var prezimeTrener = Console.ReadLine();


            }
        }
    }
}
