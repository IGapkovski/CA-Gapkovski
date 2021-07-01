using System;
using System.Collections.Generic;
using System.Text;

namespace Vraboten
{
    class SalaryEmployee : Employee
    {
        public decimal OsnovnaPlata { get; set; }
        public SalaryEmployee(string ime, int godini, int iskustvo, decimal plata)
        {
            Ime = ime; Godini = godini; GodIskustvo = iskustvo; OsnovnaPlata = plata;
        }
        public override decimal GetBonus()
        {
            return OsnovnaPlata*GodIskustvo/100M;
        }

        public override decimal GetPlata()
        {
            return GetBonus() + OsnovnaPlata;
        }
    }
}
