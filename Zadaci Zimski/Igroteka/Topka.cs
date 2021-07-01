using System;
using System.Collections.Generic;
using System.Text;

namespace Igroteka
{
    class Topka : Igracka
    {
        const float PI = 3.14F;
        public Topka(string boja, int gustina, int radius)
        {
            Boja = boja; Gustina = gustina; Radius = radius;
        }
        public int Radius { get; set; }

        public override float GetPlostina()
        {
            return (float)(4 / 3 * Math.Pow(Radius, 3.0) * PI);
        }
        public float GetVolumen()
        {
            return 4 * Radius * Radius * PI;
        }
        public float GetMasa()
        {
            return Gustina * GetVolumen();
        }
    }
}
