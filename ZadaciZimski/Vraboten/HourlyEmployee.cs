using System;
using System.Collections.Generic;
using System.Text;

namespace Vraboten
{
    class HourlyEmployee : Employee
    {
        public HourlyEmployee(string ime, int godini, int iskustvo, int casovi, decimal plata)
        {
            Ime = ime; Godini = godini; GodIskustvo = iskustvo; Casovi = casovi; PlataCas = plata;
        }
        public int Casovi { get; set; }
        public decimal PlataCas { get; set; }
        public override decimal GetBonus()
        {
            return Casovi>320?(Casovi-320)*(PlataCas/2M):0M;
        }

        public override decimal GetPlata()
        {
            return Casovi*PlataCas + GetBonus();
        }
    }
}
