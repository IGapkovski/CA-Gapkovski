using System;
using System.Collections.Generic;
using System.Text;

namespace MojTermin
{
    class Lekar
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Faksimil { get; set; }
        public decimal PocetnaPlata { get; set; }
        public Lekar(string ime, string prezime, int faksimil, decimal plata)
        {
            Ime = ime; Prezime = prezime; Faksimil = faksimil; PocetnaPlata = plata;
        }
        public virtual void Pecati()
        {
            Console.WriteLine($"{Faksimil}: {Ime} {Prezime}");
        }
        public virtual decimal Plata()
        {
            return PocetnaPlata;
        }
    }
}
