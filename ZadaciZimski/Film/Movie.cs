using System;
using System.Collections.Generic;
using System.Text;

namespace Film
{
    class Movie
    {
        string _name, _reziser, _zanr;
        public int Godina { get; set; }
        public Movie()
        {
            _name = "Lincoln";
            _reziser = "Steven_Spielberg";
            _zanr = "History";
            Godina = 2012;
        }
        public Movie(string name, string reziser, string zanr, int godina)
        {
            _name = name; _reziser = reziser; _zanr = zanr; Godina = godina; 
        }
        public void PecatiInfo()
        {
            Console.WriteLine($"Ime: {_name}\nReziser: {_reziser}\nZanr: {_zanr}\nGodina: {Godina}");
        }
        
    }
}
