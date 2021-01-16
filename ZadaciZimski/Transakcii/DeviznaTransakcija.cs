using System;
using System.Collections.Generic;
using System.Text;

namespace Transakcii
{
    class DeviznaTransakcija : Transakcija
    {
        public DeviznaTransakcija(int den, int mesec, int godina, decimal sredstva, string valuta) : base(den, mesec, godina, sredstva)
        {
            Valuta = valuta;
        }
        public string Valuta { get; set; }
        public override void Pecati()
        {
            if (Valuta =="EUR")
                Console.WriteLine($"{Den}/{Mesec}/{Godina} {Sredstva} EUR");
            else
                Console.WriteLine($"{Den}/{Mesec}/{Godina} {Sredstva} USD");
        }

        public override decimal VoDenari()
        {
            if (Valuta == "EUR")
                return Sredstva * EUR;
            else
                return Sredstva * USD;
        }

        public override decimal VoDolarii()
        {
            if (Valuta == "EUR")
                return Sredstva * EUR / USD;
            else
                return Sredstva;
        }

        public override decimal VoEvra()
        {
            if (Valuta == "EUR")
                return Sredstva;
            else
                return Sredstva * USD / EUR;
        }
    }
}
