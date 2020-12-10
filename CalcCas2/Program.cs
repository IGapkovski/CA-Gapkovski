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

        class Calc
        {
            string Name;
            public Calc(string name)
            {
                Name = name;
            }

            public int Add(int a, int b)
            {
                return a + b;
            }
            public string Compare(int x, int y)
            {
                if (x == y) return $"{x} e ednakvo na {y}";
                return x > y ? $"{x} e pogolemo od {y}" : $"{x} e pomalo od {y}";
            }
        }
    }
}
