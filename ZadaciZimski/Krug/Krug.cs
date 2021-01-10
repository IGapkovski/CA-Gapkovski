using System;
using System.Collections.Generic;
using System.Text;

namespace Krug
{
    class Krug
    {
        public float Radius { get; set; }
        public const float PI = 3.14f;
        
        public Krug()
        {
            Radius = 10;
        }
        public Krug(float radius)
        {
            Radius = radius;
        }
        public float PresmetajPlostina()
        {
            return PI * Radius * Radius;
        }
        public float PresmetajPerimetar()
        {
            return 2 * Radius * PI;
        }
        public bool IsSame()
        {
            return PresmetajPlostina() == PresmetajPerimetar();
        }
    }
}
