using System;
using System.Collections.Generic;
using System.Text;

namespace Transakcii
{
    class Smetka
    {
        public List<Transakcija> Transakcii { get; set; }
        public int BrTransakcii { get; set; }
        public decimal Saldo { get; set; } = 0M;
        public string BrSmetka { get; set; } = "300047024112789";
        public Smetka(List<Transakcija> transakcii, int brTransakcii)
        {
            Transakcii = transakcii; BrTransakcii = brTransakcii;
        }
    }
}
