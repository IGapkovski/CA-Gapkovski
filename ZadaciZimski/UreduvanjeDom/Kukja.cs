using System;
using System.Collections.Generic;
using System.Text;

namespace UreduvanjeDom
{
    class Kukja
    {
        public Soba SobaKukja { get; set; }
        public string Adresa { get; set; }
    public Kukja()
        {
            SobaKukja = new Soba(); Adresa = "Partizanska 20"; 
        }
        public Kukja(Soba soba, string adresa)
        {
            SobaKukja = soba; Adresa = adresa;
        }
        public void Pecati()
        {
            Console.Write($"Adresa: {Adresa}, Soba: ");
            SobaKukja.Pecati();
        }
    }
}
