using System;
using System.Collections.Generic;
using System.Text;

namespace NaslovnaStranica
{
    class FrontPage
    {
        public NewsArticle Article { get; set; }
        public float Price { get; set; } = 0.0F;
        public int EditionNumber { get; set; } = 0;
        public FrontPage()
        {
            Article = new NewsArticle();
        }
        public FrontPage(NewsArticle article, float price, int number)
        {
            Article = article; Price = price; EditionNumber = number;
        }
        public void Print()
        {
            Console.WriteLine($"Price: {Price}, Edition number: {EditionNumber}");
            Article.Print();
        }
    }
}
