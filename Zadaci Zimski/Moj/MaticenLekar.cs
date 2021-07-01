﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MojTermin
{
    class MaticenLekar : Lekar
    {
        public int Pacienti { get; set; }
        public List<decimal> Kotizacija { get; set; }
        public MaticenLekar(string ime, string prezime, int faksimil, decimal pplata, int pacienti, List<decimal> kotizacija):base(ime, prezime, faksimil, pplata)
        {
            Pacienti = pacienti; Kotizacija = kotizacija;
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($"Osnovnata plata na gorenavedeniot lekar e: {base.Plata():c}");
            Console.WriteLine($"Vkupnata plata so kotizacija e: {Plata():c}");
        }
        public override decimal Plata()
        {
            decimal kotizacii = 0;
            foreach(var kotizacija in Kotizacija)
            {
                kotizacii += kotizacija;
            }

            return base.Plata() + (kotizacii/Kotizacija.Count)*(30M/100M);
        }
    }
}
