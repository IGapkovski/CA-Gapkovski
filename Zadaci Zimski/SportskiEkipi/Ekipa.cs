using System;
using System.Collections.Generic;
using System.Text;

namespace SportskiEkipi
{
    class Ekipa
    {
        public String Ime { get; set; }
        public int Porazi { get; set; }
        public int Pobedi { get; set; }
        public Ekipa(string ime, int porazi, int pobedi)
        {
            Ime = ime; Porazi = porazi; Pobedi = pobedi;
        }
        public virtual void Pecati()
        {
            Console.WriteLine($"Ime: {Ime}, Pobedi: {Pobedi}, Porazi: {Porazi}");
        }
    }
}
