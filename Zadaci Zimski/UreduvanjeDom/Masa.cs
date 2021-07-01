using System;
using System.Collections.Generic;
using System.Text;

namespace UreduvanjeDom
{
    class Masa
    {
        public int Dolzina { get; set; }
        public int Sirina { get; set; }
        public Masa()
        {
            Dolzina = 2;
            Sirina = 1;
        }
        public Masa(int dolzina, int sirina)
        {
            Dolzina = dolzina; Sirina = sirina;
        }
        public void Pecati()
        {
            Console.WriteLine($"Sirina na masata: {Sirina}, Dolzina na masata: {Dolzina}");
        }
    }
}
