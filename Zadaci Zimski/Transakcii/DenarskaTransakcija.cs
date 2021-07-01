using System;
using System.Collections.Generic;
using System.Text;

namespace Transakcii
{
    class DenarskaTransakcija : Transakcija
    {
        public DenarskaTransakcija(int den, int mesec, int godina, decimal sredstva) : base(den,  mesec,  godina, sredstva)
        {
        }
        public override void Pecati()
        {
            Console.WriteLine($"{Den}/{Mesec}/{Godina} {Sredstva} MKD");
        }

        public override decimal VoDenari()
        {
            return Sredstva;
        }

        public override decimal VoDolarii()
        {
            return Sredstva / USD;
        }

        public override decimal VoEvra()
        {
            return Sredstva / EUR;
        }
    }
}
