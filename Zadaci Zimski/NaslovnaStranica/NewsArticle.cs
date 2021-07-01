using System;
using System.Collections.Generic;
using System.Text;

namespace NaslovnaStranica
{
    class NewsArticle
    {
        public Category Kategorija { get; set; }
        public string Naslov { get; set; } = "Untitled";
        public NewsArticle()
        {
            Kategorija = new Category();
        }
        public NewsArticle(Category kategorija, string naslov)
        {
            Kategorija = kategorija; Naslov = naslov;
        }
        public void Print()
        {
            Console.WriteLine($"Naslov: {Naslov}");
            Kategorija.Print();
        }
    }
}
