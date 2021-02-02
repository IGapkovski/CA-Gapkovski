using System;
using System.Collections.Generic;
using System.Text;

namespace NaucniTrudovi
{
    class Student
    {
        public string Ime { get; set; }
        public string Index { get; set; }
        public int GodinaUpis { get; set; }
        public List<Subject> ListaOceni { get; set; }
       
        public Student(string ime, string index, int godina, List<Subject> lista)
        {
            Ime = ime; Index = index; GodinaUpis = godina; ListaOceni = lista;
        }

        public void AddSubject(Subject subject)
        {
            if (subject.Ocena > 10) throw new InvalidGradeException("Cannot add subject");
            else ListaOceni.Add(subject);
        }

        public virtual double Rang()
        {
            double prosek = 0;
            foreach(var oceni in ListaOceni)
            {
                prosek += oceni.Ocena;
            }
            return prosek / ListaOceni.Count;
        }

        public void Print()
        {
            Console.WriteLine($"{Index} {Ime} {GodinaUpis} {Rang()}");
        }
    }
}
