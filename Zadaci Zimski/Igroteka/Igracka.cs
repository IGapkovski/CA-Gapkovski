using System;
using System.Collections.Generic;
using System.Text;

namespace Igroteka
{
    abstract class Igracka : Forma
    {
        public virtual string Boja { get; set; }
        public virtual int Gustina { get; set; }
        public abstract float GetPlostina();
    }
}
