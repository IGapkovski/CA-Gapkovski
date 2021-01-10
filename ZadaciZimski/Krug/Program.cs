using System;

namespace Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Krug");
            var krug = new Krug(5);
            Console.WriteLine($"Perimetar na krugot = {krug.PresmetajPerimetar()}");
            Console.WriteLine($"Plostina na krugot = {krug.PresmetajPlostina()}");
            Console.WriteLine($"Dali Perimetarot i Plostinata se ednakvi? {krug.IsSame()}");
        }
    }
}
