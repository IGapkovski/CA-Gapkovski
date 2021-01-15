using System;
using System.Collections.Generic;
using System.Text;

namespace Vraboten
{
    abstract class Employee
    {
        public string Ime { get; set; }
        public int Godini { get; set; }
        public int GodIskustvo { get; set; }
        public abstract decimal GetPlata();
        public abstract decimal GetBonus();
    }
}
