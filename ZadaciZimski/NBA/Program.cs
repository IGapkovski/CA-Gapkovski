using System;

namespace NBA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NBA zadaca");
            Console.Write("Vnesi broj na igraci");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vnesi ime:");
                string name = Console.ReadLine();
                Console.WriteLine("Vnesi tim:");
                string tim = Console.ReadLine();
                Console.WriteLine("Vnesi poeni:");
                var points = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi asistencii:");
                var assists = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi skokovi:");
                var rebounds = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi poeni od All star:");
                var allpoints = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi asistencii od all star:");
                var allassists = double.Parse(Console.ReadLine());
                Console.WriteLine("Vnesi skokovi od all star:");
                var allrebounds = double.Parse(Console.ReadLine());
                AllStarPlayer player = new AllStarPlayer(new NBAPlayer(name, tim, points, assists, rebounds), allpoints, allassists, allrebounds);
                player.Print();
            }
        }
    }
}
