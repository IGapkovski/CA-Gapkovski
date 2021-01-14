using System;
using System.Collections.Generic;
using System.Text;

namespace SportskiEkipi
{
    class FudbalskaEkipa : Ekipa
    {
        public FudbalskaEkipa(string ime, int porazi, int pobedi, int crveni, int zolti, int nereseni) : base(ime, porazi, pobedi)
        {
            CrveniKartoni = crveni; ZoltiKartoni = zolti; Nereseni = nereseni; poeni = Pobedi * 3 + Nereseni;
        }
        public int CrveniKartoni { get; set; }
        public int ZoltiKartoni { get; set; }
        public int Nereseni { get; set; }
        
        int poeni;
        public int Poeni
        {
            get { return poeni; }
            set { poeni = Pobedi*3 + Nereseni; }
        }
        public override void Pecati()
        {
            base.Pecati();
            Console.WriteLine($"Nereseni: {Nereseni}, Poeni: {Poeni}");
        }
    }
}
