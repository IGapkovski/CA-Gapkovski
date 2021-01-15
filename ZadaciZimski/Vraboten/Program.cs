using System;
using System.Collections.Generic;

namespace Vraboten
{
    class Program
    {
        static void Main(string[] args)
        {
            var vraboteni = new List<Employee>();

            Console.WriteLine("Kompanija");
            Console.Write("Vnesi ime na kompanijata: ");
            var ime = Console.ReadLine();
            Console.Write("Vnesi broj na vraboteni: ");
            int broj = int.Parse(Console.ReadLine());
            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine($"Podatoci za vraboten br. {i+1}:");
                Console.Write($"Izberi tip na vraboten : 1-Salary employee, 2-Hourly employee, 3-Freelancer");
                int tip = int.Parse(Console.ReadLine());
                Console.Write("Vnesi Ime i Prezime: ");
                string imeprezime = Console.ReadLine();
                Console.Write("Vnesi godini na vraboteniot: ");
                int godini = int.Parse(Console.ReadLine());
                Console.Write("Vnesi godini na iskustvo na vraboteniot: ");
                int godiniIskustvo = int.Parse(Console.ReadLine());
                if (tip == 1)
                {
                    Console.Write("Vnesi osnovna plata: ");
                    var plata = decimal.Parse(Console.ReadLine());
                    vraboteni.Add(new SalaryEmployee(imeprezime, godini, godiniIskustvo, plata));
                }
                if (tip == 2)
                {
                    Console.Write("Vnesi Casovi: ");
                    var casovi = int.Parse(Console.ReadLine());
                    Console.Write("Vnesi Plata po cas: ");
                    var platacas = decimal.Parse(Console.ReadLine());
                    vraboteni.Add(new HourlyEmployee(imeprezime, godini, godiniIskustvo, casovi, platacas));
                }
                if (tip == 3)
                {
                    var sumi = new List<decimal>();
                    Console.WriteLine("Vnesi broj na proekti: ");
                    int proekti = int.Parse(Console.ReadLine());
                    for (int j = 0; j < proekti; j++)
                    {
                        Console.WriteLine($"Vnesi suma za {j+1} proekt: ");
                        sumi.Add(decimal.Parse(Console.ReadLine()));
                    }
                    vraboteni.Add(new Freelancer(imeprezime, godini, godiniIskustvo, proekti, sumi));
                }
            }
            var company = new Company(ime) { Number = broj, Vraboteni = vraboteni };
            company.Pecati();
        }
    }
}
