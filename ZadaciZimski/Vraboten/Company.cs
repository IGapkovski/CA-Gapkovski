using System;
using System.Collections.Generic;
using System.Text;

namespace Vraboten
{
    class Company
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Employee> Vraboteni { get; set; }
        public Company(string name)
        {
            Name = name;
        }
        public decimal VkupnaPlata()
        {
            decimal plata = 0M;
            foreach(var vraboten in Vraboteni)
            {
                plata += vraboten.GetPlata();
            }
            return plata;
        }
        public decimal FiltriranaPlata(Employee e)
        {
            var fPlata = 0M;
            var empPlata = e.GetPlata();
            foreach(var vraboten in Vraboteni)
            {
                if (vraboten.GetPlata() == empPlata)
                    fPlata += empPlata;
            }
            return fPlata;
        }
        public void Pecati()
        {
            int freelancer = 0; int houremp = 0; int salaryemp = 0; 
            Console.WriteLine($"Vo kompanijata {Name} rabotat:");
            foreach(var vraboten in Vraboteni)
            {
                switch (vraboten)
                {
                    case SalaryEmployee s: salaryemp++;
                        break;
                    case HourlyEmployee h: houremp++;
                        break;
                    case Freelancer f: freelancer++;
                        break;
                }
            }
            Console.WriteLine($"Salary employees: {salaryemp}");
            Console.WriteLine($"Hourly employees: {houremp}");
            Console.WriteLine($"Freelancers :{freelancer}");
            Console.WriteLine($"Vkupnata plata e: {VkupnaPlata()}");
        }
    }
}
