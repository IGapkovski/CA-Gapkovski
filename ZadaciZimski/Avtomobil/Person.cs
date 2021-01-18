using System;
using System.Collections.Generic;
using System.Text;

namespace Avtomobil
{
    class Person
    {
        string Name;
        string LastName;
        public Person()
        {
            Name = "Not specified"; LastName = "Not specified";
        }
        public Person(string name, string lastName)
        {
            Name = name; LastName = lastName;
        }
        public void Print()
        {
            Console.WriteLine($"{Name} {LastName}");
        }

    }
}
