using System;
using System.Collections.Generic;
using System.Text;

namespace NaucniTrudovi
{
    class Subject
    {
        public string Ime { get; set; }
        public int Ocena { get; set; }
        public Subject(string ime, int ocena)
        {
            Ime = ime; Ocena = ocena;
        }
    }
}
