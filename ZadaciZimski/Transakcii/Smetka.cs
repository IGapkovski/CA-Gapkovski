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

        public void IzvestajVoDenari()
        {
            Console.WriteLine($"Korisnik so smetka: {BrSmetka} ima momentalno saldo od: {Saldo} MKD");
        }
        public void IzvestajVoDolari()
        {
            Console.WriteLine($"Korisnik so smetka: {BrSmetka} ima momentalno saldo od: {Saldo*Transakcija.USD} USD");
        }
        public void IzvestajVoEvra()
        {
            Console.WriteLine($"Korisnik so smetka: {BrSmetka} ima momentalno saldo od: {Saldo*Transakcija.EUR} EUR");
        }

        public void PecatiTransakcii()
        {
            foreach(var transakcija in Transakcii)
            {
                transakcija.Pecati();
            }
        }
    }
}
