using System;
using System.Collections.Generic;
using System.Text;

namespace Avtomobil
{
    class Date
    {
        public int Year, Month, Day;
        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
        }
        public Date(int year, int month, int day)
        {
            Year = year; Month = month; Day = day;
        }
        public void Print()
        {
            Console.WriteLine($"{Year}.{Month}.{Day}");
        }
    }
}
