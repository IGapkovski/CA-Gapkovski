using System;
using System.Collections.Generic;
using System.Text;

namespace Igroteka
{
    class Kocka : Igracka
    {
        public Kocka(string boja, int gustina, int visina, int sirina, int dlabocina)
        {
            Boja = boja; Gustina = gustina; Visina = visina; Sirina = sirina; Dlabocina = dlabocina;
        }
        public int Visina { get; set; }
        public int Sirina { get; set; }
        public int Dlabocina { get; set; }
        public override float GetPlostina()
        {
            return 2*(Visina*Sirina + Sirina*Dlabocina + Dlabocina*Visina);
        }
        public float GetVolumen()
        {
            return Visina * Sirina * Dlabocina;
        }
        public float GetMasa()
        {
            return Gustina * GetVolumen();
        }
    }
}
