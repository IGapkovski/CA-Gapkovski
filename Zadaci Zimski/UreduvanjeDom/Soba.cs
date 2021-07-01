using System;
using System.Collections.Generic;
using System.Text;

namespace UreduvanjeDom
{
    class Soba
    {
        public Masa MasaSoba { get; set; }
        public int Dolzina { get; set; }
        public int Sirina { get; set; }
        public Soba()
        {
            MasaSoba = new Masa(); Dolzina = 20; Sirina = 10;
        }
        public Soba(Masa masa, int dolzina, int sirina)
        {
            MasaSoba = masa; Dolzina = dolzina; Sirina = sirina;
        }
        public void Pecati()
        {
            Console.Write($"Sirina na sobata: {Sirina}, Dolzina na sobata: {Dolzina}, Masa: ");
            MasaSoba.Pecati();
        }
    }
}
