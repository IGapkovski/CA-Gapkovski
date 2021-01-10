using System;
using System.Collections.Generic;

namespace Film
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>();
            Console.Write("Vnesi broj na filmovi: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi broj na godina");
            int godinaSporedba = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-------{i+1} film-------");
                string ime = Console.ReadLine();
                string reziser = Console.ReadLine();
                string zanr = Console.ReadLine();
                int godina = int.Parse(Console.ReadLine());
                movies.Add(new Movie(ime, reziser, zanr, godina));
            }
            PecatiPoGodina(movies, godinaSporedba, n);
        }
        static void PecatiPoGodina(List<Movie> movies, int godina, int n)
        {
            foreach(var movie in movies)
            {
                if (movie.Godina == godina)
                    movie.PecatiInfo();
            }
        }
    }
}
