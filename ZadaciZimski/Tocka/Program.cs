using System;

namespace Tocka
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Tocka3D();
            var t2 = new Tocka3D();
            var t3 = new Tocka3D();

            Console.WriteLine("Zadaca Tocka");
            Console.WriteLine("Vnesi koordinati za tocka 1:");
            Console.Write("x: ");
            t1.X = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            t1.Y = int.Parse(Console.ReadLine());
            Console.Write("z: ");
            t1.Z = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi koordinati za tocka 2:");
            Console.Write("x: ");
            t2.X = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            t2.Y = int.Parse(Console.ReadLine());
            Console.Write("z: ");
            t2.Z = int.Parse(Console.ReadLine());
            Console.WriteLine("Presmetka na 3D rastojanie ili ista prava (1 ili 2)?");
            if (Console.ReadLine() == "1")
                Presmetaj3DRastojanie(t1, t2);
            else
            {
                Console.WriteLine("Vnesi koordinati za tocka 3:");
                Console.Write("x: ");
                t3.X = int.Parse(Console.ReadLine());
                Console.Write("y: ");
                t3.Y = int.Parse(Console.ReadLine());
                Console.Write("z: ");
                t3.Z = int.Parse(Console.ReadLine());
                NaIstaPrava(t1, t2, t3);
            }
                
        }

        private static void NaIstaPrava(Tocka3D t1, Tocka3D t2, Tocka3D t3)
        {
            if ((t2.Y - t1.Y) / (t2.X - t1.X) == (t3.Y - t2.Y) / (t3.X - t2.X))
                Console.WriteLine("Tockite lezat na ista prava");
            else
                Console.WriteLine("Tockite ne lezat na ista prava");
        }

        private static void Presmetaj3DRastojanie(Tocka3D t1, Tocka3D t2)
        {
            Console.WriteLine(Math.Sqrt((t1.X - t2.X) * (t1.X - t2.X) + (t1.Y - t2.Y) * (t1.Y - t2.Y) + (t1.Z - t2.Z) * (t1.Z - t2.Z)));
        }
    }
}
