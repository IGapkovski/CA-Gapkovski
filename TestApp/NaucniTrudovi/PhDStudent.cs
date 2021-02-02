using System;
using System.Collections.Generic;
using System.Text;

namespace NaucniTrudovi
{
    class PhDStudent : Student
    {
        public List<Article> Articles { get; set; }
        public PhDStudent(string ime, string index, int godina, List<Subject> lista, List<Article> articles) : base(ime, index, godina, lista)
        {
            Ime = ime; Index = index; GodinaUpis = godina; ListaOceni = lista; Articles = articles;
        }

        public override double Rang()
        {
            int vkupno = 0;
            foreach (var article in Articles)
            {
                if (article.Trud == VidTrud.Conference) vkupno += 1;
                else vkupno += 3;

            }
            return base.Rang() + vkupno;
        }

        public void AddArticle(Article article)
        {
            if (article.GodinaIzdavanje < this.GodinaUpis) throw new InvalidPublishDateException("Cannot add article");
            else Articles.Add(article);
        }

        public void Count(Article article)
        {
            int brConf = 0; int brJournal = 0;
            foreach(var a in Articles)
            {
                if (a.Trud == VidTrud.Conference) brConf++;
                else brJournal++;
            }
            Console.WriteLine($"Conference aricles count: {brConf} Journal articles count: {brJournal}");
        }
    }
}
