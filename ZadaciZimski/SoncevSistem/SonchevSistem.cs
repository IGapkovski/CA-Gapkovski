using System;
using System.Collections.Generic;
using System.Text;

namespace SoncevSistem
{
    class SonchevSistem
    {
        public List<Planeta> Planeti { get; set; }

        public Planeta NajbliskaPlaneta 
        {
            get 
            {
                var tekovna = Planeti[0];
                for (int i = 1; i < Planeti.Count; i++)
                {
                    if (Planeti[i].Oddalecenost < tekovna.Oddalecenost)
                        tekovna = Planeti[i];
                }
                return tekovna;
            }
        }

        
        public SonchevSistem(List<Planeta> planeti)
        {
            Planeti = planeti;
        }
        public void Print()
        {
            Console.WriteLine("Site Planeti:");
            foreach (var planeta in Planeti)
            {
                planeta.Print();
            }
            Console.WriteLine($"Najbliska planeta e {NajbliskaPlaneta.Ime} so dijametar {NajbliskaPlaneta.Dijametar}km.\n");
            Console.WriteLine();
        }
        public void PecatiSoMasa(float masa)
        {
            Console.WriteLine();
            Console.WriteLine($"Planeti so masa pogolema od {masa}kg:");
            foreach (var planeta in Planeti)
            {
                if (planeta.Masa > masa)
                    planeta.Print();
            }
        }
    }
}
