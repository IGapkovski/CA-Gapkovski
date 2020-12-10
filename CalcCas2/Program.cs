using System;

namespace CalcCas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = 2;
            var b = 5;
            var c = 2;

            var calc = new Calc("Casio");

            Console.WriteLine("Zbirot od a i b e " + calc.Add(a, b));
            Console.WriteLine(calc.Compare(a, b));
            Console.WriteLine(calc.Compare(a, c));
            Console.WriteLine(calc.Compare(b, c));
            _ = Console.ReadLine();
        }
    }
}
