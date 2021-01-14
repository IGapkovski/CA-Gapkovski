using System;

namespace SportskiEkipi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sportski Ekipi");
            Console.Write("Vnesi Ime: ");
            string ime = Console.ReadLine();
            Console.Write("Vnesi pobedi: ");
            int pobedi = int.Parse(Console.ReadLine());
            Console.Write("Vnesi porazi: ");
            int porazi = int.Parse(Console.ReadLine());
            Console.Write("Vnesi crveni kartoni: ");
            int crveni = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zolti kartoni: ");
            int zolti = int.Parse(Console.ReadLine());
            Console.Write("Vnesi nereseni: ");
            int nereseni = int.Parse(Console.ReadLine());
            var fudbaleri = new FudbalskaEkipa(ime, porazi, pobedi, crveni, zolti, nereseni);
            fudbaleri.Pecati();
        }
    }
}
