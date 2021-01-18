using System;
using System.Collections.Generic;

namespace Avtomobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi Sopstvenik");
            Console.Write("Vnesi Ime: ");
            string ime = Console.ReadLine();
            Console.Write("Vnesi Prezime: ");
            string prezime = Console.ReadLine();
            Console.Write("Vnesi Godina: ");
            int godina = int.Parse(Console.ReadLine());
            Console.Write("Vnesi Mesec: ");
            int mesec = int.Parse(Console.ReadLine());
            Console.Write("Vnesi Den: ");
            int den = int.Parse(Console.ReadLine());
            Console.Write("Vnesi Cena: ");
            float cena = float.Parse(Console.ReadLine());
            var car = new Car() { Datum = new Date(den, mesec, godina), Price = cena, Sopstvenik = new Person(ime, prezime) };
            car.Print();
        }
        static void CheaperThan(List<Car> cars, int numCars, float price)
        {
            foreach(var car in cars)
            {
                if (car.Price < price)
                    car.Print();
            }
        }
    }
}
