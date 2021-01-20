using System;
using System.Collections.Generic;
using System.Text;

namespace SoncevSistem
{
    class Planeta
    {
        public string Ime { get; set; }
        public int Dijametar { get; set; }
        public int Oddalecenost { get; set; }
        public float Masa { get; set; }
        public Planeta()
        {
        }
        public Planeta(string ime, int dijametar, int o, float masa)
        {
            Ime = ime; Dijametar = dijametar; Oddalecenost = o; Masa = masa;
        }
        public void Print()
        {
            Console.WriteLine($"{Ime} so dijametar {Dijametar}km.\n");
        }
    }
}
