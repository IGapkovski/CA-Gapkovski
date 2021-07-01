using System;
using System.Collections.Generic;
using System.Text;

namespace Vraboten
{
    class Freelancer : Employee
    {
        public Freelancer(string ime, int godini, int iskustvo, int proekti, List<decimal> sumi)
        {
            Ime = ime; Godini = godini; GodIskustvo = iskustvo; Proekti = proekti; Sumi = sumi;
        }
        public int Proekti { get; set; }
        public List<decimal> Sumi { get; set; }

        public override decimal GetBonus()
        {
            return Proekti > 5 ? (Proekti - 5) * 1000M : 0M;
        }

        public override decimal GetPlata()
        {
            decimal plata = 0M;
            foreach(var suma in Sumi)
            {
                plata += suma;
            }
            return plata + GetBonus();
        }
    }
}
