using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrika
{
    class Rabotnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Plata { get; set; }
        public Rabotnik()
        {
            Ime = "Nepoznat"; Prezime = "Nekoj"; Plata = 0;
        }
        public Rabotnik(string ime, string prezime, int plata)
        {
            Ime = ime; Prezime = prezime; Plata = plata;
        }
        int GetPlata()
        {
            return Plata;
        }
        public void Peacati()
        {
            Console.WriteLine($"Rabotnik: {Ime} {Prezime} {Plata}");
        }
    }
}
