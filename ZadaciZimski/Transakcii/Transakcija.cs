using System;
using System.Collections.Generic;
using System.Text;

namespace Transakcii
{
    abstract class Transakcija
    {
        public Transakcija(int den, int mesec, int godina, decimal sredstva)
        {
            Den = den; Mesec = mesec; Godina = godina; Sredstva = sredstva;
        }
        public int Den { get; set; }
        public int Mesec { get; set; }
        public int Godina { get; set; }
        public decimal Sredstva { get; set; }
        public static decimal EUR { get; set; } = 61M;
        public static decimal USD { get; set; } = 50M;

        public abstract decimal VoDenari();
        public abstract decimal VoEvra();
        public abstract decimal VoDolarii();
        public abstract void Pecati();


    }
}
