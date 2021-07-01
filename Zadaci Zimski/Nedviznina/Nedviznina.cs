using System;
using System.Collections.Generic;
using System.Text;

namespace Nedviznina
{
    class Nedviznina
    {
        public string Adresa { get; set; }
        public int Kvadratura { get; set; }
        public int CenaKvadrat { get; set; }
        public Nedviznina(string adresa, int kvadratura, int cena)
        {
            Adresa = adresa; Kvadratura = kvadratura; CenaKvadrat = cena;
        }

        public int Cena()
        {
            return Kvadratura * CenaKvadrat;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{Adresa}, Kvadratura: {Kvadratura}, Cena po Kvadrat: {CenaKvadrat}");
            Console.WriteLine($"Danok za {Adresa} e {DanokNaImot()}");
        }

        public virtual int DanokNaImot()
        {
            return Cena() * 5 / 100;
        }
    }
}
