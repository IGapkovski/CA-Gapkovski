using System;
using System.Collections.Generic;
using System.Text;

namespace Nedviznina
{
    class Vila : Nedviznina
    {
        public Vila(string adresa, int kvadratura, int cena, int danokLuksuz) : base( adresa, kvadratura, cena)
        {
            DanokNaLuksuz = danokLuksuz;
        }
        public int DanokNaLuksuz { get; set; } = 10;

        public override void Print()
        {
            Console.WriteLine($"{Adresa}, Kvadratura: {Kvadratura}, Cena po Kvadrat: {CenaKvadrat}, Danok na luksuz :{DanokNaLuksuz}");
            Console.WriteLine($"Danok za {Adresa} e {DanokNaImot()}");
        }
        public override int DanokNaImot()
        {
            return base.DanokNaImot() + DanokNaLuksuz * Cena()/100;
        }
    }
}
