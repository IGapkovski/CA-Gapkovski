using System;
using System.Collections.Generic;
using System.Text;

namespace Agol
{
    class Agol
    {
        public Agol(int stepeni, int minuti, int sekundi)
        {
            Stepeni = stepeni;
            Minuti = minuti;
            Sekundi = sekundi;
        }

        public int Stepeni { get; set; }
        public int Minuti { get; set; }
        public int Sekundi { get; set; }
        
        public int AgolVoSekundi()
        {
            return this.Stepeni * 360 + this.Minuti * 60 + this.Sekundi;
        }
        public bool IsValid()
        {
            return (this.Stepeni >= 0 && this.Stepeni <= 360) && (this.Minuti >= 0 && this.Minuti <= 60) && (this.Sekundi >= 0 && this.Sekundi < 60);
        }
    }
}
