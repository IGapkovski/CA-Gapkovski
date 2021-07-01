using System;
using System.Collections.Generic;
using System.Text;

namespace Dogovor
{
    class Potpisuvac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EMBG
        {
            get => _embg;
            set 
            {
                if (value.Length == 13)
                {
                    _embg = value;
                }
                else
                {
                    EMBG = "0000000000000";
                    Console.WriteLine("Nevaliden EMBG");
                }
            }
        }
        private string _embg;
        public Potpisuvac()
        {
            Ime = "Nepoznat"; Prezime = "Nekoj"; EMBG = "0000000000000";
        }
        public Potpisuvac(string ime, string prezime, string embg)
        {
            Ime = ime; Prezime = prezime; EMBG = embg;
        }
    }
}
