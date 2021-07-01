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
        private int den, mesec;

        public int Den
        {
            get
            { return den; }
            set
            {
                if (value >= 1 && value <= 31)
                    den = value;
                else throw new InvalidDateException();
            }
        }
        public int Mesec
        {
            get
            { return mesec; }
            set
            {
                if (value >= 1 && value <= 12)
                    mesec = value;
                else throw new InvalidDateException();
            }
        }
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
