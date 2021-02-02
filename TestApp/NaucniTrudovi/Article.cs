using System;
using System.Collections.Generic;
using System.Text;

namespace NaucniTrudovi
{
    class Article
    {
        public string Naslov { get; set; }
        public VidTrud Trud { get; set; }
        public int GodinaIzdavanje { get; set; }
        public Article (string naslov, VidTrud trud, int godina)
        {
            Naslov = naslov; Trud = trud; GodinaIzdavanje = godina;
        }
    }
}
