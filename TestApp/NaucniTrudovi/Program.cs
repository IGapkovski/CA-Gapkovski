using System;
using System.Collections.Generic;

namespace NaucniTrudovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fakultet");
            Console.WriteLine("Vnesi ime na fakultet");
            var imeFaks = Console.ReadLine();
            Console.WriteLine("Vnesi broj na studenti");
            int brojStudenti = int.Parse(Console.ReadLine());
            var studenti = new List<Student>();

            for (int i = 0; i < brojStudenti; i++)
            {
                Console.WriteLine($"Vnesuvanje na student {i+1}");
                Console.WriteLine("Vnesi tip na student: Regular(1) ili PhD (2):");
                var tipStudent = Console.ReadLine();
                Console.WriteLine("Vnesi ime na student");
                var imestudent = Console.ReadLine();
                Console.WriteLine("Vnesi index");
                var index = Console.ReadLine();
                Console.WriteLine("Vnesi godina upis");
                int godinaUpis = int.Parse(Console.ReadLine());
                Console.WriteLine("Vnesuvanje na lista na predmeti / ocenki");
                var ocenki = new List<Subject>();
                Console.WriteLine("Vnesi broj na predmeti");
                int brojPredmeti = int.Parse(Console.ReadLine());
                try 
                {
                    for (int j = 0; j < brojPredmeti; j++)
                    {
                        Console.WriteLine("Vnesi ime na predmet");
                        var imePredmet = Console.ReadLine();
                        Console.WriteLine("Vnesi ocena");
                        int ocena = int.Parse(Console.ReadLine());
                        ocenki.Add(new Subject(imePredmet, ocena));
                    }
                }
                catch (InvalidGradeException e)
                {
                    Console.WriteLine(e.Message);
                }
                if (tipStudent == "1") studenti.Add(new Student(imestudent, index, godinaUpis, ocenki));
                else
                {
                    var articles = new List<Article>();
                    Console.WriteLine("Vnesi broj na articles");
                    int brArticles = int.Parse(Console.ReadLine());
                    try
                    {
                        for (int j = 0; j < brArticles; j++)
                        {
                            Console.WriteLine("Vnesi naslov");
                            var naslov = Console.ReadLine();
                            Console.WriteLine("Vnesi tip 1/2");
                            int tip = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vnesi godina izdavanje");
                            int godIzdavanje = int.Parse(Console.ReadLine());
                            articles.Add(new Article(naslov, (VidTrud)tip, godIzdavanje));
                        }
                        
                        studenti.Add(new PhDStudent(imestudent, index, godinaUpis, ocenki, articles));
                    }
                    catch (InvalidPublishDateException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            var faks = new Faculty(imeFaks, studenti);
            faks.Print();

        }
    }
}
