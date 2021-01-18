using System;
using System.Collections.Generic;
using System.Text;

namespace Avtomobil
{
    class Car
    {
        public Person Sopstvenik { get; set; }
        public Date Datum { get; set; }
        public float Price { get; set; }
        public float GetPrice()
        {
            return Price;
        }
        public void Print()
        {
            Sopstvenik.Print();
            Datum.Print();
            Console.WriteLine($"Price: {Price}");
        }
    }
}
