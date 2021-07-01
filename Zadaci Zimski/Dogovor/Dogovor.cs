using System;
using System.Collections.Generic;
using System.Text;

namespace Dogovor
{
    class Dogovor
    {
        public int BrDogovor { get; set; }
        public string Kategorija { get; set; }
        public Potpisuvac[] PP = new Potpisuvac[3];
        public Dogovor()
        {
            BrDogovor = 1; Kategorija = "Osiguruvanje";
            PP[0] = new Potpisuvac("Alek", "Aleksov", "0101988450001");
            PP[1] = new Potpisuvac("Alek", "Aleksov", "0101988450001");
            PP[2] = new Potpisuvac("Marko", "Markov", "0202987440022");
        }
        public bool IsSamePP()
        {
            if (PP[0].EMBG == PP[1].EMBG || PP[0].EMBG == PP[2].EMBG || PP[2].EMBG == PP[1].EMBG)
                return true;
            else
                return false;
        }
    }
}
